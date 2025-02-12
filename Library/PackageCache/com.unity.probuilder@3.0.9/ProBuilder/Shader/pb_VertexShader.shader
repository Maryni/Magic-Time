<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 240
	m_Renderers =
	[
		{
			_class = "C_OP_RenderSprites"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_flStartFadeSize = 0.675000
			m_flEndFadeSize = 0.750000
			m_flMaxSize = 0.850000
			m_flOverbrightFactor = 1.500000
			m_flAddSelfAmount = 2.000000
			m_bBlendFramesSeq0 = false
			m_bSaturateColorPreAlphaBlend = false
			m_hTexture = resource:"materials/particle/spray1/spray1.vtex"
			m_flAnimationRate = 3.000000
		},
	]
	m_Operators =
	[
		{
			_class = "C_OP_Decay"
		},
		{
			_class = "C_OP_InterpolateRadius"
			m_flBias = 0.750000
			m_flEndScale = 2.000000
		},
		{
			_class = "C_OP_FadeInSimple"
		},
		{
			_class = "C_OP_FadeOutSimple"
			m_flFadeOutTime = 0.750000
		},
	]
	m_Initializers =
	[
		{
			_class = "C_INIT_RandomRotation"
		},
		{
			_class = "C_INIT_RandomLifeTime"
			m_fLifetimeMin = 0.300000
			m_fLifetimeMax = 0.500000
		},
		{
			_class = "C_INIT_RandomColor"
			m_ColorMax =
			[
				234,
				243,
				247,
				255,
			]
		},
		{
			_class = "C_INIT_RandomAlpha"
			m_nAlphaMin = 32
			m_nAlphaMax = 33
		},
		{
			_class = "C_INIT_RandomRadius"
			m_flRadiusMin = 2.000000
			m_flRadiusMax = 9.000000
		},
		{
			_class = "C_INIT_RandomColor"
