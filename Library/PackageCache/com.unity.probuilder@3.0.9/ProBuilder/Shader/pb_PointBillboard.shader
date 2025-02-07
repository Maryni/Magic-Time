<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 128
	m_ConstantColor =
	[
		234,
		108,
		46,
		255,
	]
	m_Renderers =
	[
		{
			_class = "C_OP_RenderSprites"
			VisibilityInputs =
			{
				m_flInputMax = 0.100000
				m_flProxyRadius = 12.000000
				m_nCPin = 0
			}
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_hTexture = resource:"materials/particle/wisp/particle_swirl.vtex"
			m_flAnimationRate2 = 0.100000
			m_flAnimationRate = 0.780000
		},
	]
	m_Operators =
	[
		{
			_class = "C_OP_BasicMovement"
			m_fDrag = 0.050000
		},
		{
			_class = "C_OP_InterpolateRadius"
			m_flStartScale = 0.250000
			m_flBias = 0.700000
			m_flEndScale = 4.000000
		},
		{
			_class = "C_OP_Decay"
		},
		{
			_class = "C_OP_FadeOutSimple"
			m_flFadeOutTime = 1.000000
		},
		{
			_class = "C_OP_VectorNoise"
			m_bAdditive = true
			m_vecOutputMax =
			[
				20.000000,
				20.000000,
				20.000000,
			]
			m_vecOutputMin =
			[
				-20.000000,
				-20.000000,
				-20.000000,
			]
			m_nFieldOutput = 0
			m_fl4NoiseScale = 0.800000
		},
		{
			_class = "C_OP_PositionLock"
			m_flOpEndFadeOutTime = 0.750000
			m_flOpStartFadeOutTime = 0.400000
		},
	]
	m_Initializers =
	[
		{
			_class = "C_INIT_RandomLifeTime"
			m_fLifetimeMax = 0.700000
			m_fLifetimeMin = 0.500000
		},
		{
			_class = "C_INIT_RandomRadius"
			m_flRadiusMax = 35.000000
			m_flRadiusMin = 20.000000
		},
		{
			_class = "C_INIT_RandomRotation"
		},
		{
			_class = "C_INIT_CreateWithinSphere"
			m_bLocalCoords = true
			m_fRadiusMax = 50.000000
		},
		{
			_class = "C_INIT_RandomColor"
			m_ColorMax =
			[
				13,
				11,
				11,
				255,
			]
			m_ColorMin =
			[
				16,
				14,
				14,
				255,
			]
		},
		{
			_class = "C_INIT_PositionOffset"
			m_OffsetMin =
			[
				-20.000000,
				0.000000,
				-40.000000,
			]
			m_OffsetMax =
			[
				-20.000000,
				0.000000,
				30.000000,
			]
			m_bLocalCoords = true
		},
	]
	m_Emitters =
	[
		{
			_class = "C_OP_ContinuousEmitter"
			m_flEmitRate = 150.000000
			m_flEmissionDuration = 0.250000
		},
	]
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           