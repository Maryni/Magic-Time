<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:vpcf13:version{10b35a8e-b1ee-4f14-87a6-a7b6aae37699} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 32
	m_flConstantRadius = 50.0
	m_ConstantColor = [ 112, 208, 244, 255 ]
	m_flNoDrawTimeToGoToSleep = 12.0
	m_bShouldSort = false
	m_Renderers = 
	[
		{
			_class = "C_OP_RenderRopes"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_bAdditive = true
			m_nOrientationType = 3
			m_hTexture = resource:"materials/particle/beam_edge_05b.vtex"
			m_flRadiusScale = 0.5
			m_flTextureVWorldSize = 137.931046
			m_flTextureVScrollRate = -3.448276
			m_nMaxTesselation = 3
			m_nMinTesselation = 3
		},
	]
	m_Operators = 
	[
		{
			_class = "C_OP_BasicMovement"
			m_fDrag = 0.1
		},
		{
			_class = "C_OP_FadeInSimple"
			m_flOpEndFadeOutTime = 0.5
			m_flOpStartFadeOutTime = 0.5
			m_flFadeInTime = 0.125
		},
		{
			_class = "C_OP_Decay"
			m_nOpEndCapState = 1
		},
		{
			_class = "C_OP_InterpolateRadius"
			m_flStartScale = 0.0
			m_flEndScale = 8.0
			m_flBias = 0.75
			m_flOpStartFadeOutTime = 0.5
			m_flOpEndFadeOutTime = 0.5
		},
		{
			_class = "C_OP_RemapDirectionToCPToVector"
			m_bNormalize = true
			m_nFieldOutput = "21"
			m_nCP = 10
		},
		{
			_class = "C_OP_OscillateScalar"
			m_nField = "3"
			m_RateMin = -1550.0
			m_RateMax = 1150.0
			m_FrequencyMin = 0.1
			m_bProportional = false
			m_flEndTime_min = 9999999.0
			m_flEndTime_max = 9999999.0
		},
		{
			_class = "C_OP_OscillateScalar"
			m_nField = "16"
			m_RateMin = -2.0
			m_RateMax = 2.0
			m_FrequencyMin = 0.1
			m_bProportional = false
			m_flEndTime_min = 9999999827968.0
			m_flEndTime_max = 9999999827968.0
		},
		{
			_class = "C_OP_ClampScalar"
			m_flOutputMax = 1600.0
		},
		{
			_class = "C_OP_DifferencePreviousParticle"
			m_bSetPreviousParticle = true
			m_bScaleInitialRange = true
			m_flOutputMax = 0.0
			m_flOutputMin = 1.0
			m_nFieldOutput = "7"
			m_flInputMax = 90.0
			m_flInputMin = 89.0
			m_flOpEndFadeOutTime = 0.5
			m_flOpStartFadeOutTime = 0.5
		},
	]
	m_Initializers = 
	[
		{
			_class = "C_INIT_RandomLifeTime"
			m_fLifetimeMin = 0.5
			m_fLifetimeMax = 0.5
		},
		{
			_class = "C_INIT_RandomAlpha"
			m_nAlphaMin = 85
		},
		{
			_class = "C_INIT_RingWave"
			m_flParticlesPerOrbit = 31.0
			m_bEvenDistribution = true
			m_flInitialRadius = 1.0
			m_nOverrideCP = 1
		},
		{
			_class = "C_INIT_RandomRotation"
			m_flDegreesMin = -180.0
			m_flDegreesMax = -180.0
		},
		{
			_class = "C_INIT_RandomRadius"
			m_flRadiusMax = 184.0
			m_flRadiusMin = 60.0
		},
		{
			_class = "C_INIT_RandomColor"
			m_ColorMax = [ 78, 33, 194, 255 ]
			m_ColorMin = [ 76, 11, 208, 255 ]
			m_bDisableOperator = true
		},
		{
			_class = "C_INIT_PositionOffset"
			m_OffsetMin = [ 0.0, 0.0, 256.0 ]
			m_OffsetMax = [ 0.0, 0.0, 256.0 ]
		},
		{
			_class = "C_INIT_PositionPlaceOnGround"
			m_flOffset = 12.0
			m_bIncludeWater = true
			m_flMaxTraceLength = 1024.0
		},
		{
			_class = "C_INIT_RandomColor"
			m_ColorMin = [ 8, 229, 96, 255 ]
			m_ColorMax = [ 70, 250, 139, 255 ]
		},
	]
	m_Emitters = 
	[
		{
			_class = "C_OP_InstantaneousEmitter"
			m_flStartTime = 0.15
			m_nParticlesToEmit = 32
		},
	]
	m_PreEmissionOperators = 
	[
		{
			_class = "C_OP_SetControlPointToCenter"
			m_vecCP1Pos = [ 0.0, 0.0, 500.0 ]
			m_nCP1 = 10
		},
	]
	m_nBehaviorVersion = 5
	m_nFirstMultipleOverride_BackwardCompat = 6
	m_controlPointConfigurations = 
	[
		{
			m_name = "preview"
			m_drivers = 
			[
				{
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 0.0, 0.0, 0.0 ]
					m_angOffset = [ null, null, null ]
					m_entityName = "self"
				},
				{
					m_iControlPoint = 1
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 1.0, 1.0, 1.0 ]
					m_angOffset = [ null, null, null ]
					m_entityName = "self"
				},
				{
					m_iControlPoint = 62
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 0.0, 0.0, 0.0 ]
					m_angOffset = [ null, null, null ]
					m_entityName = "self"
				},
			]
		},
	]
}                                                                                                                                                                                                                                                                                                                                                                          