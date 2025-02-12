<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 24
	m_Renderers =
	[
		{
			_class = "C_OP_RenderSprites"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_bBlendFramesSeq0 = false
			m_hTexture = resource:"materials/particle/smoke1/smoke1.vtex"
		},
	]
	m_Operators =
	[
		{
			_class = "C_OP_BasicMovement"
			m_Gravity =
			[
				0.000000,
				0.000000,
				400.000000,
			]
			m_fDrag = 0.200000
		},
		{
			_class = "C_OP_InterpolateRadius"
			m_flBias = 0.350000
			m_flEndScale = 3.000000
		},
		{
			_class = "C_OP_Decay"
		},
		{
			_class = "C_OP_FadeOutSimple"
			m_flFadeOutTime = 1.000000
		},
		{
			_class = "C_OP_ControlpointLight"
			m_bUseHLambert = false
			m_LightZeroDist1 = 2600.000000
			m_LightFiftyDist1 = 1200.000000
			m_LightColor1 =
			[
				213,
				230,
				230,
				255,
			]
			m_vecCPOffset1 =
			[
				400.000000,
				200.000000,
				1200.000000,
			]
		},
	]
	m_Initializers =
	[
		{
			_class = "C_INIT_RandomColor"
			m_ColorMin =
			[
				213,
				230,
				230,
				255,
			]
			m_ColorMax =
			[
				213,
				230,
				230,
				255,
			]
		},
		{
			_class = "C_INIT_RandomLifeTime"
			m_fLifetimeMin = 0.400000
			m_fLifetimeMax = 0.400000
		},
		{
			_class = "C_INIT_RandomRotation"
		},
		{
			_class = "C_INIT_RandomRadius"
			m_flRadiusMin = 32.000000
			m_flRadiusMax = 48.000000
		},
		{
			_class = "C_INIT_RandomAlpha"
			m_nAlphaMin = 32
			m_nAlphaMax = 32
		},
		{
			_class = "C_INIT_RandomSequence"
			m_nSequenceMax = 5
		},
		{
			_class = "C_INIT_RingWave"
			m_flInitialRadius = 32.000000
			m_flInitialSpeedMin = 1320.000000
			m_flInitialSpeedMax = 1320.000000
			m_bEvenDistribution = true
		},
		{
			_class = "C_INIT_PositionOffset"
			m_OffsetMin =
			[
				0.000000,
				0.000000,
				12.000000,
			]
			m_OffsetMax =
			[
				0.000000,
				0.000000,
				12.000000,
			]
		},
	]
	m_Emitters =
	[
		{
			_class = "C_OP_InstantaneousEmitter"
			m_nParticlesToEmit = 24
		},
	]
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            