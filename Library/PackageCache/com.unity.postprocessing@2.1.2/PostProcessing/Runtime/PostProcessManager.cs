         m_SampleWeightTable[ 7] = 8 * m_SampleThickness[ 7];    // L-shaped
            m_SampleWeightTable[ 8] = 4 * m_SampleThickness[ 8];    // Diagonal
            m_SampleWeightTable[ 9] = 8 * m_SampleThickness[ 9];    // L-shaped
            m_SampleWeightTable[10] = 8 * m_SampleThickness[10];    // L-shaped
            m_SampleWeightTable[11] = 4 * m_SampleThickness[11];    // Diagonal

            // Zero out the unused samples.
            // FIXME: should we support SAMPLE_EXHAUSTIVELY mode?
            m_SampleWeightTable[0] = 0;
            m_SampleWeightTable[2] = 0;
            m_SampleWeightTable[5] = 0;
            m_SampleWeightTable[7] = 0;
            m_SampleWeightTable[9] = 0;

            // Normalize the weights by dividing by the sum of all weights
            var totalWeight = 0f;

            foreach (float w in m_SampleWeightTable)
                totalWeight += w;

            for (int i = 0; i < m_SampleWeightTable.Length; i++)
                m_SampleWeightTable[i] /= totalWeight;

            // Set the arguments for the render kernel.
            var cs = m_Resources.computeShaders.multiScaleAORender;
            int kernel = isMSAA ? cs.FindKernel("MultiScaleVORender_MSAA_interleaved") : cs.FindKernel("MultiScaleVORender_interleaved");

            cmd.SetComputeFloatParams(cs, "gInvThicknessTable", m_InvThicknessTable);
            cmd.SetComputeFloatParams(cs, "gSampleWeightTable", m_SampleWeightTable);
            cmd.SetComputeVectorParam(cs, "gInvSliceDimension", new Vector2(1f / sourceSize.x, 1f / sourceSize.y));
            cmd.SetComputeVectorParam(cs, "AdditionalParams", new Vector2(-1f / m_Settings.thicknessModifier.value, m_Settings.intensity.value));
            cmd.SetComputeTextureParam(cs, kernel, "DepthTex", source);
            cmd.SetComputeTextureParam(cs, kernel, "Occlusion", destination);

            // Calculate the thread group count and add a dispatch command with them.
            uint xsize, ysize, zsize;
            cs.GetKernelThreadGroupSizes(kernel, out xsize, out ysize, out zsize);

            cmd.DispatchCompute(
                cs, kernel,
                ((int)sourceSize.x + (int)xsize - 1) / (int)xsize,
                ((int)sourceSize.y + (int)ysize - 1) / (int)ysize,
                ((int)sourceSize.z + (int)zsize - 1) / (int)zsize
            );
        }

        void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, int? highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false)
        {
            var cs = m_Resources.computeShaders.multiScaleAOUpsample;
            int kernel = 0;
            if (!isMSAA)
            {
                kernel = cs.FindKernel(highResAO == null ? invert
                    ? "MultiScaleVOUpSample_invert"
                    : "MultiScaleVOUpSample"
                    : "MultiScaleVOUpSample_blendout");
            }
            else
            {
                kernel = cs.FindKernel(highResAO == null ? invert
                ? "MultiScaleVOUpSample_MSAA_invert"
                : "MultiScaleVOUpSample_MSAA"
                : "MultiScaleVOUpSample_MSAA_blendout");
            }


            float stepSize = 1920f / lowResDepthSize.x;
            float bTolerance = 1f - Mathf.Pow(10f, m_Settings.blurTolerance.value) * stepSize;
            bTolerance *= bTolerance;
            float uTolerance = Mathf.Pow(10f, m_Settings.upsampleTolerance.value);
            float noiseFilterWeight = 1f / (Mathf.Pow(10f, m_Settings.noiseFilterTolerance.value) + uTolerance);

            cmd.SetComputeVectorParam(cs, "InvLowResolution", new Vector2(1f / lowResDepthSize.x, 1f / lowResDepthSize.y));
            cmd.SetComputeVectorParam(cs, "InvHighResolution", new Vector2(1f / highResDepthSize.x, 1f / highResDepthSize.y));
            cmd.SetComputeVectorParam(cs, "AdditionalParams", new Vector4(noiseFilterWeight, stepSize, bTolerance, uTolerance));

            cmd.SetComputeTextureParam(cs, kernel, "LoResDB", lowResDepth);
            cmd.SetComputeTextureParam(cs, kernel, "HiResDB", highResDepth);
            cmd.SetComputeTextureParam(cs, kernel, "LoResAO1", interleavedAO);

            if (highResAO != null)
                cmd.SetComputeTextureParam(cs, kernel, "HiResAO", highResAO.Value);

            cmd.SetComputeTextureParam(cs, kernel, "AoResult", dest);

            int xcount = ((int)highResDepthSize.x + 17) / 16;
            int ycount = ((int)highResDepthSize.y + 17) / 16;
            cmd.DispatchCompute(cs, kernel, xcount, ycount, 1);
        }

        void PushReleaseCommands(CommandBuffer cmd)
        {
            Release(cmd, ShaderIDs.LinearDepth);

            Release(cmd, ShaderIDs.LowDepth1);
            Release(cmd, ShaderIDs.LowDepth2);
            Release(cmd, ShaderIDs.LowDepth3);
            Release(cmd, ShaderIDs.LowDepth4);

            Release(cmd, ShaderIDs.TiledDepth1);
            Release(cmd, ShaderIDs.TiledDepth2);
            Release(cmd, ShaderIDs.TiledDepth3);
            Release(cmd, ShaderIDs.TiledDepth4);

            Release(cmd, ShaderIDs.Occlusion1);
            Release(cmd, ShaderIDs.Occlusion2);
            Release(cmd, ShaderIDs.Occlusion3);
            Release(cmd, ShaderIDs.Occlusion4);

            Release(cmd, ShaderIDs.Combined1);
            Release(cmd, ShaderIDs.Combined2);
            Release(cmd, ShaderIDs.Combined3);
        }

        void PreparePropertySheet(PostProcessRenderContext context)
        {
            var sheet = context.propertySheets.Get(m_Resources.shaders.multiScaleAO);
            sheet.ClearKeywords();
            sheet.properties.SetVector(ShaderIDs.AOColor, Color.white - m_Settings.color.value);
            m_PropertySheet = sheet;
        }

        void CheckAOTexture(PostProcessRenderContext context)
        {
            if (m_AmbientOnlyAO == null || !m_AmbientOnlyAO.IsCreated() || m_AmbientOnlyAO.width != context.width || m_AmbientOnlyAO.height != context.height)
            {
                RuntimeUtilities.Destroy(m_AmbientOnlyAO);

                m_AmbientOnlyAO = new RenderTexture(context.width, context.height, 0, RenderTextureFormat.R8, RenderTextureReadWrite.Linear)
                {
                    hideFlags = HideFlags.DontSave,
                    filterMode = FilterMode.Point,
                    enableRandomWrite = true
                };
                m_AmbientOnlyAO.Create();
            }
        }

        void PushDebug(PostProcessRenderContext context)
        {
            if (context.IsDebugOverlayEnabled(DebugOverlay.AmbientOcclusion))
                context.PushDebugOverlay(context.command, m_AmbientOnlyAO, m_PropertySheet, (int)Pass.DebugOverlay);
        }

        public void RenderAfterOpaque(PostProcessRenderContext context)
        {
            var cmd = context.command;
            cmd.BeginSample("Ambient Occlusion");
            SetResources(context.resources);
            PreparePropertySheet(context);
            CheckAOTexture(context);

            // In Forward mode, fog is applied at the object level in the grometry pass so we need
            // to apply it to AO as well or it'll drawn on top of the fog effect.
            if (context.camera.actualRenderingPath == RenderingPath.Forward && RenderSettings.fog)
            {
                m_PropertySheet.EnableKeyword("APPLY_FORWARD_FOG");
                m_PropertySheet.properties.SetVector(
                    ShaderIDs.FogParams,
                    new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance)
                );
            }

            GenerateAOMap(cmd, context.camera, m_AmbientOnlyAO, null, false, false);
            PushDebug(context);
            cmd.SetGlobalTexture(ShaderIDs.MSVOcclusionTexture, m_AmbientOnlyAO);
            cmd.BlitFullscreenTriangle(BuiltinRenderTextureType.None, BuiltinRenderTextureType.CameraTarget, m_PropertySheet, (int)Pass.CompositionForward, RenderBufferLoadAction.Load);
            cmd.EndSample("Ambient Occlusion");
        }

        public void RenderAmbientOnly(PostProcessRenderContext context)
        {
            var cmd = context.command;
            cmd.BeginSample("Ambient Occlusion Render");
            SetResources(context.resources);
            PreparePropertySheet(context);
            CheckAOTexture(context);
            GenerateAOMap(cmd, context.camera, m_AmbientOnlyAO, null, false, false);
            PushDebug(context);
            cmd.EndSample("Ambient Occlusion Render");
        }

        public void CompositeAmbientOnly(PostProcessRenderContext context)
        {
            var cmd = context.command;
            cmd.BeginSample("Ambient Occlusion Composite");
            cmd.SetGlobalTexture(ShaderIDs.MSVOcclusionTexture, m_AmbientOnlyAO);
            cmd.BlitFullscreenTriangle(BuiltinRenderTextureType.None, m_MRT, BuiltinRenderTextureType.CameraTarget, m_PropertySheet, (int)Pass.CompositionDeferred);
            cmd.EndSample("Ambient Occlusion Composite");
        }

        public void Release()
        {
            RuntimeUtilities.Destroy(m_AmbientOnlyAO);
            m_AmbientOnlyAO = null;
        }
    }
#else
    [Serializable]
    public sealed class MultiScaleVO : IAmbientOcclusionMethod
    {
        public MultiScaleVO(AmbientOcclusion settings)
        {
        }

        public void SetResources(PostProcessResources resources)
        {
        }

        public DepthTextureMode GetCameraFlags()
        {
            return DepthTextureMode.None;
        }

        public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA)
        {
        }

        public void RenderAfterOpaque(PostProcessRenderContext context)
        {
        }

        public void RenderAmbientOnly(PostProcessRenderContext context)
        {
        }

        public void CompositeAmbientOnly(PostProcessRenderContext context)
        {
        }

        public void Release()
        {
        }
    }
#endif
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               �PNG

   IHDR  �   �   \�R  KiTXtXML:com.adobe.xmp     <?xpacket begin="﻿" id="W5M0MpCehiHzreSzNTczkc9d"?>
<x:xmpmeta xmlns:x="adobe:ns:meta/" x:xmptk="Adobe XMP Core 5.6-c140 79.160451, 2017/05/06-01:08:21        ">
 <rdf:RDF xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#">
  <rdf:Description rdf:about=""/>
 </rdf:RDF>
</x:xmpmeta>
<?xpacket end="r"?>-CD�    IDATx��wx���?�����PD@�t4�����lQl(Eī\Q)�^,@��	(�����i���`����v�n�g7�͞���9s�;g�;���J�������:pg�,�V��j�F����	D�$w&//���H�V����+�$��3^&((ȝ���p�#���$	d��qY�B/)77��G�RZZj5���@T*�ry~އ,ˢg-���/�|�r���x���F�ӱa� y����,�u�#�0vB����G�Ҵ}o� #�Zt7����:ޘ5������W�2f��f�M�j<E�j?�Nw"��2Ν;�ٳgm�B�e���/~��'z�!~��g$I��fÆt�֍�V�ǥ�H����>!��$	��G��\[ZZJXl#�*MYx$T�		��^�������D�=\�u�8q����ԭ[ס�l�L�y�ZM~~>���DEEY}��.�������F����2���������h��QdY�~ 33����pl���@Y/i�ȑ�Ѿ}���͵�P||<:t���J�b˖-�nݚ��*���B��O�n��錮;w�V/y�޽{ӨQ#������5��u�]L�>���[�Vhw8Y�y��ǹ���y��'�J�^


X�|9�w�F��!�2,Z��v�ڹ4-=���<����tՃ�7��ȟi��nW!�2����s111L�6��|�A233��?�	���$I2��5���ή]��:I�����+����p��e���[ڴiC׮]���G¸g$�$���_!~�Z��K7�W����SQ*����7o\�Z�B��2d7n䫯��s��t���(��7C�M�2d-[���_4k.��͛	�`Y�+8���4�Cy�Z-�<��Νc�ܹ�}��H�����?bcc��ŞtdYF�����g�\����t������9XJ�\:��'�{r�ދ$I���fυ��SPP`3�NǺu�N�G�U�V ����a��|�I�v��ȑ#���
�(""���_UH�A�DDD~�Pzz:������p�wҸq��b�/[\�m�R�CF����~Ԋ���G�_��_�$6h������ލfQ�V-RSS�뮻عs�Q�?��#k֬!''��u�2~�x�w���ի���#33��cǲj�*�O�ΩS��j��mۖ�n�:�pk׮����{�a�����ѣ���ѣ�.]"33�;３7�x��C޿?YYY<�������p�y��V�b+}E���O)..&**�/���B�׮]ː!C���9}�4:���K�V��	6����_�u��}�t>�������ޓ�&�nZ�hQ���'$$�F�Y���t�t:Ëg`` ��� �2�9�˰��VM�6�0�@ӦM+$|��ABCC�ӧÆ3\�

"44��_PP��J�Ұc��lZ��%�Gr57���������g�!K��*���/C�ڬY3:v���ӧY�`�Z�b���iӆ���2b����h߾=˖-��ϏI�&�����ŋ��_سgO�pP�������Fvv�!�m�h߾=��s��~�P�S�N!I��JQ�t�_�Κ5k�޽;;v�୷��X���ڴièQ���D��S���?q��t��e�&M��֭[ILL��W_e�V�:t�!�|����9v�~�!�$��K/1d�È�~Ŭ#


�I�&Fǚ4iRa�J��p��iڶmKhh��#���^���J��E�^$4hLι?y�G�ϪW�$���>GLb**����YYY|��g���p�B�3ݷo:���Ā�j����/�Dtt4ԪU��7���_PTTT!�)��6JCO�^�<x0]�v����B<����l:aaaԯ_�o���%K��T�>}�0z�hڵkg�&�0��-�	�A�ev��Eaa!�w��F��͹���BFFP��Y�r%����'���NNN�'Of�ĉL�4�3gΘwD )))�����0RRR�fV?�c�F�a����t:�
�Ti����٫�S?�܋gP����^��:�R�R��x}�^�X�|9�����曆�����"���СC�7���b��s�O0��������TdY�����黴Τ��իy�G���7n'N�����]pGmbO9�g��w������Y����v�J��?>P�,X��:ХK�ׯo��ر#��������a(�iӦf=�$I���SXXh6�˗/s��	��R�Z�#(,�QϮ">)��z����LTjݍ�@ݺuy��Gٳg[�n�m۶H�ď?��,�dff"Im۶���˗��t:tY�y�����G�$
E�p��J�^ڷoO�F�غu+[�n����Z�ɓ'�Og�)))����Q�F1g��j5�N��Y.��M�V:��zЯ�{���Y�v-gΜ!44���PN�>m8g�F����N���i߾=aaa<��ä�� I�{�6����g�;���$�]�FRR������p��A����V�:t�ƍ۵�:44��<�Ф�Ug!�<�仔�\G#�Uj@�@�%���S~Hpذa|��w���;�mۖ�M�2m�4V�^��_�R�dڴi� >� k֬������|��<��C��ٓ��$֬Y�=��c.==�(�[o��b��׬�X�d	�-b�ҥ,[�I�e޼yt��ɩt�]�����	�����m�ҳgO$I�Z.���۬M���_!���M����˸@�\	�me2]5���§�~
���6m���:�x���

B�����b�0+>>��;W���2�o˲LII	۶m#,,��m�EAA������f�ػ�Ohh(�Z�">>����t:


����������tԪU�R�J��V�Zh�Z����]�v�p���(������N�:u�n�3��t:���	

"22�蜭rY��#�JG x[�l!##�{ｗ{�������l��|;�V��h4��-����<x�S�N&�SSS���;�rB�@P𶞐���\�����*���$�F�1d8  ��8@Ps����6��\�K���$	��%��Cga�E������?�rD�~TS��
\�=;��)���s��#�j��ݻ�'NX��Q �A����ܹs���<	|KρSsD�v�"!!�A�m����.��5\�z�-[�p������eY��ϓ�'��8�#�e�'N0i�$"##+lh**�}�����Ӎ@@<O�!**���3mڴ�9"(��)<<\<4�DDDPRRR�x��Dxxx�����
Z��CsC@�lBM��F���E�N�Xϋ��m^k#_zeY�/�1ys�Xn�����:>LX�2"�x�+ﻋ�TFW���[�l�j�����X�K�:�WY;ZOς}�ت,om,���W9ú�9�J�c�y�c�����=r�i4ƻ`Wh4��Teø��p*����3t�P�����h���ӒiѲ;w�tJ�[�e#Y�JaR��65����#fӵ�,��Z�qY9*����?~ܠ�P*�z�*��3INN�/������gC��[~���|�-Gg�m0g7�0��H��q��W��TeZ�ĵ-}����_����~���NA����R�K׮���#7i��$���_�Z��X!M��3����Ҹ�f�3e�e#W��]q��m6wM�j�{�n�7��o�:�7�v�ʼ8�Wka�5��ݙ���<e
ԫ�t����,��r�����xlO#_�N��k�y��O���Zo_=p��tD�xT�Ʋ.��1dYfݺu���˼��|����s�=�󙙙,Z��B���[�l�w��̙3�7�=z����3f�X��}^{�5�B׮]�e��k���aØ>}:��'���L�0��#G�l�2��^x�~��g�,YBII	���?3fL5Z�f`�G$�'�����Ν;�����5W�eYfРA<��C�X��%K�p��w�g�^�u�J%u����_�~��V��hmc�9b@����)���C^�B���q�0йs���?�ӻǎc�������ܼ\Ǝ˲e��׷�?�M�ƺu�X��J7n�F�!++�B�-�`���t���N���ϧ�>E��2�i$''����y��G��L{�8��9�y�������gϞ�K��qC:��š@�f�s���0z�leũ�T���5�f�zG����eΜ9���+��ĢQk�z���z�X7�?��������Khh(9�r�4i�}���r�1�?�8_~�e���*�kH��M��phN����\e�A����