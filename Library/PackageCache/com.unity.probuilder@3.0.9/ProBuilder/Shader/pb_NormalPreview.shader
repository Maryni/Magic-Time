<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 10
	m_flConstantRadius = 1.000000
	m_ConstantColor =
	[
		255,
		0,
		0,
		255,
	]
	m_Renderers =
	[
		{
			_class = "C_OP_RenderRopes"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_flOverbrightFactor = 4.000000
			m_flAddSelfAmount = 1.000000
			m_bSaturateColorPreAlphaBlend = false
			m_hTexture = resource:"materials/particle/beam_plasma_05.vtex"
			m_flRadiusScale = 0.500000
			m_flFinalTextureScaleU = -1.000000
			m_flFinalTextureOffsetU = 1.000000
			m_flTextureVWorldSize = 268.456390
			m_nMaxTesselation = 3
			m_nMinTesselation = 3
		},
	]
	m_Operators =
	[
		{
			_class = "C_OP_MovementPlaceOnGround"
			m_flOpStartFadeOutTime = 0.100000
			m_flOpEndFadeOutTime = 0.100000
			m_flOffset = 12.000000
			m_