<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 50
	m_flConstantRadius = 1.0
	m_ConstantColor = [ 255, 201, 97, 255 ]
	m_nConstantSequenceNumber = 3
	m_Renderers = 
	[
		{
			_class = "C_OP_RenderTrails"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_flOverbrightFactor = 2.0
			m_hTexture = resource:"materials/particle/sparks/meteorite.vtex"
			m_flLengthFadeInTime = 0.025
			m_bIgnoreDT = true
			m_flRadiusScale = 0.5
			m_flFinalTextureScaleV = -1.0
			m_vEndTrailTintFactor = [ 1.0, 1.0, 1.0, 0.0 ]
			m_flMaxLength = 500.0
			m_bAdditive = true
		},
	]
	m_Operators = 
	[
		{
			_class = "C_OP_FadeOutSimple"
			m_flFadeOutTime = 1.0
		},
		{
			_class = "C_OP_Decay"
		},
		{
			_class = "C_OP_LerpScalar"
			m_flOutput = 0.0
			m_nFieldOutput = 10
			m_flStartTime = 0.2
		},
		{
			_class = "C_OP_Int