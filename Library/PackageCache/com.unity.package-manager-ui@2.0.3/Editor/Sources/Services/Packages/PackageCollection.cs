TextureParams TextureParameter m_SamplerIndex m_MultiSampled m_BufferParams BufferBinding m_ConstantBuffers ConstantBuffer m_StructParams StructParameter m_StructSize m_VectorMembers m_MatrixMembers m_Size m_ConstantBufferBindings m_UAVParams UAVParameter m_OriginalIndex m_Samplers SamplerParameter sampler bindPoint m_ShaderRequirements progFragment progGeometry progHull progDomain m_HasInstancingVariant m_HasProceduralInstancingVariant m_UseName m_TextureName m_CustomEditorName m_FallbackName m_Dependencies SerializedShaderDependency from to m_DisableNoSubshadersMessage platforms offsets compressedLengths decompressedLengths compressedBlob PPtr<Shader> m_NonModifiableTextures m_ShaderIsBaked m_DefaultTextures ShaderCompilationInfo m_CompileInfo m_Snippets ShaderSnippet m_Code m_AssetPath m_PlatformMask m_HardwareTierVariantsMask m_StartLine m_TypesMask Hash128 m_IncludesHash bytes[0] bytes[1] bytes[2] bytes[3] bytes[4] bytes[5] bytes[6] bytes[7] bytes[8] bytes[9] bytes[10] bytes[11] bytes[12] bytes[13] bytes[14] bytes[15] m_CodeHash m_FromOther m_Language m_VariantsUser0 m_VariantsUser1 m_VariantsUser2 m_VariantsUser3 m_VariantsUser4 m_VariantsUser5 m_VariantsBuiltin0 m_VariantsBuiltin1 m_VariantsBuiltin2 m_VariantsBuiltin3 m_VariantsBuiltin4 m_VariantsBuiltin5 m_BaseRequirements m_KeywordTargetInfo KeywordTargetInfo keywordName requirements m_NonStrippedUserKeywords m_BuiltinKeywords m_MeshComponentsFromSnippets m_HasSurfaceShaders m_HasFixedFunctionShaders               d              h   D       >I     °                                	z÷ůD˝-Ă;   Assets/ProCore/ProBuilder/Shader/pb_SmoothingPreview.shader                                                                                                                                              _Opacity   Opacity               ?                                        @	   <noninit>      A	   <noninit>      @	   <noninit>      A	   <noninit>       	   <noninit>       	   <noninit>     pA	   <noninit>     ?	   <noninit>       	   <noninit>     ?	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>     pA	   <noninit>     ?	   <noninit>       	   <noninit>     ?	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>     pA	   <noninit>     ?	   <noninit>       	   <noninit>     ?	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>     pA	   <noninit>     ?	   <noninit>       	   <noninit>     ?	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>     pA	   <noninit>     ?	   <noninit>       	   <noninit>     ?	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>     pA	   <noninit>     ?	   <noninit>       	   <noninit>     ?	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>     pA	   <noninit>     ?	   <noninit>       	   <noninit>     ?	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>     pA	   <noninit>         ?	   <noninit>     @	   <noninit>     ?	   <noninit>      @	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>      A	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>      A	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>      A	   <noninit>     C	   <noninit>     C	   <noninit>       	   <noninit>          unity_FogStart         unity_FogEnd       unity_FogDensity    	   <noninit>       	   <noninit>       	   <noninit>       	   <noninit>      unity_FogColor  ˙˙˙˙ôš        IGNOREPROJECTOR    true
   RenderType     Geometry                                                         IGNOREPROJECTOR    true
   RenderType     Geometry    "   Hidden/ProBuilder/SmoothingPreview                                                         ôš    #line 18 ""
#ifdef DUMMY_PREPROCESSOR_TO_WORK_AROUND_HLSL_COMPILER_LINE_HANDLING
#endif

#include "HLSLSupport.cginc"
#define UNITY_INSTANCED_LOD_FADE
#define UNITY_INSTANCED_SH
#define UNITY_INSTANCED_LIGHTMAPSTS
#include "UnityShaderVariables.cginc"
#include "UnityShaderUtilities.cginc"
#line 18 ""
#ifdef DUMMY_PREPROCESSOR_TO_WORK_AROUND_HLSL_COMPILER_LINE_HANDLING
#endif
/* UNITY: Original start of shader */
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			float _Opacity;
			float _Dither;

			struct appdata
			{
				float4 vertex : POSITION;
				float4 color : COLOR;
			};

			struct v2f
			{
				float4 pos : SV_POSITION;
				float4 color : COLOR;
			};

			v2f vert (appdata v)
			{
				v2f o;

				/// https://www.opengl.org/discussion_boards/showthread.php/166719-Clean-Wireframe-Over-Solid-Mesh
				o.pos = float4(UnityObjectToViewPos(v.vertex.xyz), 1);
				o.pos.xyz *= .98;
				o.pos = mul(UNITY_MATRIX_P, o.pos);
                o.color = v.color;

				return o;
			}

			half4 frag (v2f i) : COLOR
			{
                i.pos.xy = floor(i.pos.xy * 1) * .5;
                float checker = -frac(i.pos.x + i.pos.y);
                clip(lerp(1, checker, _Dither));

                half4 c = half4(i.color.rgb, i.color.a * _Opacity);
				return c;
			}

			     Assets/ProCore/ProBuilder/Shader˙˙˙˙          }OŮ (ůźŁňşÓÉîŇoéBSŮ ŕ(                                                        !   	      SHADOWS_SOFTă      DIRLIGHTMAP_COMBINEDă      DIRLIGHTMAP_SEPARATEă      DYNAMICLIGHTMAP_ON  ă      SHADOWS_SCREEN  ă      INSTANCING_ON         PROCEDURAL_INSTANCING_ON @     STEREO_MULTIVIEW_ON ë     STEREO_INSTANCING_ONë                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                0Ź  d\     0Ŕ    2018.3.0f2 ţ˙˙˙      ˙˙3$řĚuńě˛e+ Í=   ^          7  ˙˙˙˙         Ś ˛            Đ                 Ś                Ś                Ś #               Ś +               H 3   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ      	        Q  j     
        H <   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             Ő I   ˙˙˙˙       1  1  ˙˙˙˙    Ŕ    Ţ               H j  ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j              P             AssetMetaData guid data[0] data[1] data[2] data[3] pathName originalName labels assetStoreRef włë ˙˙W*(ě7ĆípÍ(ŤúćR5            7  ˙˙˙˙         Ś ˛               E            Ţ  %             . .             7   a            Ţ  %             . .              r            Ţ  %      	       . .      
       H Ť ˙˙˙˙     1  1  ˙˙˙˙   @   Ţ             Q  j            ń  L   ˙˙˙˙       1  1  ˙˙˙˙        Ţ                j  ˙˙˙˙        ^     ˙˙˙˙        H t   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             H y   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             H    ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             y 
              Ţ  %      !       . .      "       Ő    ˙˙˙˙#       1  1  ˙˙˙˙$    @    Ţ      %         . j     &         L        '         L  Ž      (    @    H Ő   ˙˙˙˙)      1  1  ˙˙˙˙*   @    Ţ      +        Q  j     ,        H ŕ   ˙˙˙˙-      1  1  ˙˙˙˙.   @    Ţ      /        Q  j     0        H ň   ˙˙˙˙1      1  1  ˙˙˙˙2   @    Ţ      3        Q  j     4      PrefabImporter PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_ExternalObjects SourceAssetIdentifier type assembly name m_AddedObjectFileIDs m_IsPrefabVariant m_UnableToImportOnPreviousDomainReload m_UserData m_AssetBundleName m_AssetBundleVariant jaą; ˙˙HaâŻäŇ§ÜŮOśú   #      Ţ 7               Ś ˛     