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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ‰PNG

   IHDR  ¢   ç   \éR  KiTXtXML:com.adobe.xmp     <?xpacket begin="ï»¿" id="W5M0MpCehiHzreSzNTczkc9d"?>
<x:xmpmeta xmlns:x="adobe:ns:meta/" x:xmptk="Adobe XMP Core 5.6-c140 79.160451, 2017/05/06-01:08:21        ">
 <rdf:RDF xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#">
  <rdf:Description rdf:about=""/>
 </rdf:RDF>
</x:xmpmeta>
<?xpacket end="r"?>-CD·    IDATxœìwxÕúÇ?“Ş©„„PD@Št4ôâ•¢¥lQl(EÄ«\Q)Š^,@‚å‚	(½ˆü®‰i„„`ÊöùıvÉn¶g7ÙÍÏóğ9sÊ;gÎ;§ÌùJ‡’‹ŠŠ :pgä²,£V«ÑjµFÇııı	D’$w&//À­H­VÑóÍç+—$‰3^&((ÈÉÀp«#Ò÷„$	dùæqY¦B/)77—£GRZZj5ÎÀÀ@T*ƒry~Ş‡,Ë¢g-¸™‹/²|ùr‚‚‚xùå—íºF§Ó±aÃ yäüüü,†u«#0vB–šŒ£GÒ´}o¢ #ãZt7®“ĞÉ:Ş˜5Ÿ¿ÿ†«W¯2fÌ÷fŞMØj<Eãj?ÂNw"Å2Î;ÇÙ³gmÚB–eşúë/~úé'zè!~şùg$Iâá‡fÃ†tëÖ†VˆÇ¥H«Õ¼>!½’$	ù†G’Í\[ZZJXl#”*MYx$T²		™²^Õ÷Ÿòó÷ßD=\™u§8qâ±±±Ô­[×¡ëlİLıyµZM~~>DEEY}£¨.œµÀóñôFØùóô2»“ï¾ûÎìñèèh»§QdYæ‡~ 33“ŸşÙplòäÉ@Y/iäÈ‘¶Ñ¾}ûÈÍÍµ˜P||<:t¨¸J¥bË–-´nİš””*„±…B¥ÁO’nŒåéŒ®;wúV/y€Ş½{Ó¨Q#£¸ûõë”5âÜu×]LŸ>İîÆ[­Vhw8Y–yüñÇ¹ÿşûyòÉ'íJÃ^


X¾|9»wïF§Ó!Ë2,Z´ˆvíÚ¹4-=ö–¿<ÎØÀ™tÕƒ§7ÈîÈŸiœnW!Ë2ï¿ÿ¾Ùs111L›6Íî¸|ğA233øç?ÿ	ÀÇŒ$I2Äì5Ñí·ßÎ®]»Ì:I’¸ıöÛ+ ¸¸˜pùòe¾ıö[Ú´iC×®]ñ÷÷GÂ¸g$²$ãïï_!~•ZåÂK7şW”–ğæ‹SQ*ÜÕ÷š7o\áZ…BÁ€2d7nä«¯¾¢sçÎtêÔÉ(¯ú7CM–2d-[¶äÅ_4î¹•k.ÜæÍ›	«`Y–+8Àòö4ÍCy´Z-Ï<óçÎcîÜ¹Ü}÷İH’Äÿş÷?bcc­–ÅtdYF§Óáççg±\åãĞétøûû›µ‰9XJß\:Š'¿{rŞŞ‹$I¼ğÂfÏ…‡‡SPP`3NÇºuëNè‘G¡U«V øùù±aÃ|òIºvíÊÈ‘#ÚÈ
(""‚ğ×_UH¨AƒDDD~ëPzz:¡¡¡ÄÄÄpçwÒ¸q™£bç“/[\¾mŠR©CFÇŸĞî®~ÔŠŠÌGË_àâ_Ù$6hÌğÇæñ×ŞfQ«V-RSS¹ë®»Ø¹s§Qº?şø#kÖ¬!''‡ºuë2~üxºwïÎêÕ«ÉËË#33“±cÇ²jÕ*¦OŸÎ©S§Ğjµ´mÛ–°nİ:£pk×®åñÇç{îaüøñÓèÑ£‡¡îÑ£—.]"33“;ï¼“7Şx£‚CŞ¿?YYY<üğÃôìÙÓp¼yóæVËb+}EøôÓO)..&**Š/¿ü²Bù×®]Ë!C¸ûî»9}ú4:¥K—V°ÉÂ…	6²¥ô_ıuŞÿ}£t>øà³÷Ğğä†Ş“ó&ğnZ´hQá˜şÅ'$$„FYÍĞétèt:Ã‹g`` ááá †2ı9ıË°³ãVM›6­0´@Ó¦M+$|ğàABCCéÓ§Ã†3\«

"44Ôè_PPÙJ¡Ò°cËÇlZ¹%³Gr57—Ÿ¾İÌŞï·ÊØg—!K–Ç*ÿúë/CãÚ¬Y3:vìÀéÓ§Y°`­Zµbûöí´iÓ†…òçŸ2bÄÂÂÂhß¾=Ë–-ÃÏÏI“&‘‘‘ÁâÅ‹ùå—_Ø³gO…pP¶Òïï¿ÿ¶šFvv¶!ì¶mÛhß¾=÷Üsà·ß~«P†S§N!I’ÙJQ™t®_¿Îš5kèŞ½;;vìà­·Ş°X®ŒŒÚ´iÃ¨Q£ÌÚDÿÖSŞ–Ò?qâ„Ùtç²eË&MšÄÖ­[ILLäÕW_eáÂ…V¯:t¨!Ì|ÀñãÇ9vì~ø!’$ñÒK/1dÈÃˆ~Å¬#


¢I“&FÇš4iRaÂJ£ÑpúôiÚ¶mKhh¨á#ÕòÃ^å³…J££EÇ^$4hLÎ¹?yó¹GùÏªW$‰ûÇ>GLb**µÆâõYYY|öÙgäåå±páBƒ3İ·o:Ä€ĞjµüòË/Dtt4ÔªU‹7òõ×_PTTT!œ)åÓ6JCO¯^½<x0]»v ¸¸¸B<å‡ÀÌál:aaaÔ¯_Ÿo¾ù†%K–â·T®>}ú0zôhÚµkgÑ&–0—¾-û	ÏA–evíÚEaa!»wïÊF²¬Í¹ûùùBFFPÖûY¹r%ï½÷¡'”NNN“'OfâÄ‰Lš4‰3gÎ˜wD )))†±ÿ°°0RRRÌfV?ÌcîœF£aÿşıèt:»
¯Tiğ©ÍØÙ«¨S?•Ü‹gP«´¹û^îè:…RƒR¥µx}¯^½X¾|9şşş¼ùæ›†ãúôõó"úî¥¹ÆşĞ¡CŒ7ââb‹½s”O0›†ş˜µá•ÔÔTdYæğáÃÎé»´Î¤ÈêÕ«yä‘GøùçŸ7n'Nœ°˜ò]pGmbO9gñİwßş”†ÎYÂÏÏºvíJ‡˜?>PÖ,X°€:Ğ¥Kê×¯o­êØ±#‰‰‰–‘ŸŸŸa(®iÓ¦f=¡$I„‡‡SXXh6Ë—/sâÄ	û‘R‹Z­#(,šQÏ®">)•øz©ôÿçLTjİ–@İºuyôÑGÙ³g[·n mÛ¶H’Ä?şˆ,Ëdff"ImÛ¶ÊíåË—Ñét:tY–yğÁ‰G’$
E…p¦ØJÃ^Ú·oO£FØºu+[·n¥¤¤µZÍÉ“'½OgÒ)))¡°°Q£F1gÎÔj5§N²Y.ÀªMÁV: zĞ¯š{ÿı÷Y»v-gÎœ!44€ĞĞPNŸ>m8g‹FñğÃNûöíiß¾=aaa<üğÃ¤¤¤ I½{÷6üïççgı;¢¤¤$®]»FRR’Ùó¤¤¤pğàAâââÊV±:tˆÆÛµ„:44¹è<ÊĞ¤²Ug!‘<ôä»””\G# Uj@‚@Å%ƒÊS~HpØ°a|÷İw¼óÎ;´mÛ–¦M›2mÚ4V¯^Í×_R©dÚ´i† >ø kÖ¬¡ÿş¼ùæ›|ñÅ<ôĞCôìÙ“¤¤$Ö¬YÃ=÷Üc.==İ(Í[o½Õb¦«×¬õX²d	‹-béÒ¥,[¶I’eŞ¼ytêÔÉ©t®]»Æøñã	¦¨¨ˆ¶mÛÒ³gO$I²Z.€»ï¾Û¬Mú÷ï_!¬¥ôMÓÉÈÈË¸@Í\	ème2]5—’’Â§Ÿ~
”½Ä6mÚÔâª:Óx‚‚‚

B«ÕòğÃb´0+>>;W¶ºº2»oË²LII	Û¶m#,,Œ¶mÛEAA‡¦´´”fó¦Ø»ÅOhh(­Zµ">>Şáüêt:


ˆ®à‹‹‹ÑétÔªU¥R‰J¥¢V­ZhµZŠŠŠ¨]»v…p¦á(………äææN:uŒn¤3éèt:òóó	

"22Òèœ­rY³‰#ØJG x[¶l!##ƒ{ï½—{ï½×áëõ«è l„­|;¥V«Ñh4”­-¨¬„Ş<xS§N&¦SSS¹óÎ;írB@Pğ¶½¸º\å‡çıüü*ïˆàæ$ºF£1d8  À°8@Ps©©À6âŞ\…Köš“$	³»%ÔÄCgaßEÜûª£¦·?•rDö~TSğµò
\‹=;–¨)õÃÜsà”#Òjµìİ»—'NXı°Q ”AóæÍéÜ¹s…‘ñ<	|KÏSsD»ví"!!AƒmÄé‹Ôô.³À5\½z•-[¶påÊÒÒÒÇeYæçŸÏ“À'°ô8Ü#’e™'N0iÒ$"##+lh**Å}÷İÇôéÓ@@<OŸ!**ŠÁƒ3mÚ´Ê9"(ûÀ)<<\<4DDDPRRRá¸x¾Dxxx…çÀéÅ
ZÉCsC@¨lBM¢ÊF«ôÂE–NËXÏ‹•ëm^k#_zeY»/¹1ysÓXnü¾§õ²:>LX©2"á¦x”+ï»‹âµTFW”İ›[›lÖj´®·Ÿ“X³Kù:©WY;ZOÏ‚}ÍØª,om,ËàçW9Ãºä9Jİc«yğºc›õ¥â=rÚi4Æ»`Wh4íÌTeÃ¸šêªp*•ŠöÚ3tèPŸû¼åh¹œÓ’iÑ²;wìtJ¶[–e#YöJaRöò65²¯ê¨#fÓµ£,Ö‘Z­qY9*óòåí?~Ü  P*¸zõ*™»3INN¶/’ª¨—©µgCÿ¼[~±ªÜ|µ-Gg³m0g7å0¥Híì¥qôşW¦¾TeZöÄµ-}¥¥¥¬_¿§Ÿ~šÀ†NA¹›§ßR½K×®¬ûè#7i‚Ÿ$ñÍ×_…Z­²X!MãÑ3«ìåÒ¸‡f”3e°e#WØĞ]q¸³m6wMÑjí{nŒ7 ó·–oç:”7ãv”Ê¼8’Wkaš5»İ™»ö<e
Ô«—tãåù¦,©r±ş¹²¤xlO#_™N¼¥kìyæìO×øşZo_=pæÛtDxTµÆ².À1dYfİºu¼üòË¼øâ‹|ıõ×ÜsÏ=†ó™™™,Z´…BŸŸ[¶láwŞáÌ™3Œ7=zğüóÏ3fìXŞÿ}^{í5†B×®]‘e™µk×Á°aÃ˜>}:şù'………L˜0‘#G²lÙ2£¸^xá~şùg–,YBII	ÿüç?3fL5Z¨f`µG$'—“ÎÎ;ùşûïö5W¯eYfĞ A<ôĞC¬X±‚%K–p÷İw³gÏ^ıu”J%uëÖåå—_¦~ıúVÓ«hmcÓ9b@ºŠ)ãĞëC^ÖBÜî²q×0Ğ¹sçøã?èÓ»ÇcÃúôéİ€Ü¼\ÆË²eËè×·?¦MÆºuëXùîJ7nŒF­!++¥BÉ-ï`ıúõtìĞNÇûï¿Ï§›>E«Ñ2í‰i$''óûÉßyôÑGñÏL{Â8®Ë9—yú©§ğ½ûô¦gÏÔK¬çqC:æî‰Å¡@·f›s•ÖŞ0zleÅ©·TûçÜ5çfëzGâÏÍÍeÎœ9¼òò+ÄÆÄ¢Qk¸zõªÙzX7‰?şøƒƒòßïşKhh(9—r˜4iŸ}ú·Ürò1?ö8_~ùe¥òå*ªkHÚöM¹¸phN­®ÄĞ\eÇAôå°ãá¨