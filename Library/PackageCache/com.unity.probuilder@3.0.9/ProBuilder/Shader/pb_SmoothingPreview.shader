<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 4
	m_flConstantRadius = 10.000000
	m_flConstantLifespan = 0.100000
	m_ConstantColor =
	[
		114,
		195,
		237,
		255,
	]
	m_bShouldSort = false
	m_Renderers =
	[
		{
			_class = "C_OP_RenderSprites"
			VisibilityInputs =
			{
				m_flCameraBias = 22.000000
			}
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_bAdditive = true
			m_hTexture = resource:"materials/particle/particle_flares/anam_white.vtex"
			m_flOverbrightFactor = 2.000000
		},
	]
	m_Operators =
	[
		{
			_class = "C_OP_Decay"
		},
		{
			_class = "C_OP_SpinUpdate"
		},
		{
			_class = "C_OP_FadeOutSimple"
			m_flFadeOutTime = 0.150000
		},
		{
			_class = "C_OP_InterpolateRadius"
			m_flEndScale = 0.000000
			m_flStartScale = 2.000000
		},
		{
			_class = "C_OP_PositionLock"
		},
		{
			_class = "C_OP_MovementRotateParticleAroundAx