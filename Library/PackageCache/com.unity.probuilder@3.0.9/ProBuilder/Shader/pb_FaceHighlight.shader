<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 256
	m_flConstantRadius = 32.000000
	m_flConstantLifespan = 2.000000
	m_ConstantColor =
	[
		128,
		166,
		255,
		255,
	]
	m_Renderers =
	[
		{
			_class = "C_OP_RenderSprites"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_bAdditive = true
			m_hTexture = resource:"materials/particle/particle_flares/particle_flare_007b.vtex"
		},
	]
	m_Operators =
	[
		{
			_class = "C_OP_SetSingleControlPointPosition"
			m_vecCP1Pos =
			[
				0.000000,
				0.000000,
				800.000000,
			]
			m_nCP1 = 3
		},
		{
			_class = "C_OP_BasicMovement"
			m_Gravity =
			[
				0.000000,
				0.000000,
				-40.000000,
			]
		},
		{
			_class = "C_OP_OscillateVector"
			m_bOffset = true
			m_RateMin =
			[
				-50.000000,
				-50.000000,
				-50.000000,
			]
			m_RateMax =
			[
				50.000000,
				50.00