<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 100
	m_flConstantRadius = 0.900000
	m_ConstantColor =
	[
		195,
		223,
		255,
		255,
	]
	m_Renderers =
	[
		{
			_class = "C_OP_RenderTrails"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_flOverbrightFactor = 6.000000
			m_flAddSelfAmount = 2.000000
			m_bSaturateColorPreAlphaBlend = false
			m_hTexture = resource:"materials/particle/sparks/sparks.vtex"
			m_flMaxLength = 100.000000
			m_flRadiusScale = 0.500000
			m_flFinalTextureScaleV = -1.000000
			m_flFinalTextureOffsetV = 1.000000
		},
	]
	m_Operators =
	[
		{
			_class = "C_OP_RampScalarLinearSimple"
			m_nOpEndCapState = 1
			m_Rate = -2.000000
			m_flEndTim