<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:vpcf12:version{cf2e4e5e-e5e0-4da9-930b-a526a91236e2} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 64
	m_bShouldSort = false
	m_Renderers = 
	[
		{
			_class = "C_OP_RenderSprites"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_bAdditive = true
			m_flOverbrightFactor = 2.0
			m_hTexture = resource:"materials/particle/particle_ring_wavy7.vtex"
			m_flAnimationRate = 4.0
			m_nOrientationType = 2
			m_bDisableOperator = true
			m_nHSVShiftControlPoint = 62
		},
	]
	m_Operators = 
	[
		{
			_class = "C_OP_FadeOutSimple"
		},
		{
			_class = "C_OP_FadeInSimple"
			m_flFadeInTime = 1.0
		},
		{
			_class = "C_OP_Decay"
		},
		{
			_class = "C_OP_InterpolateRadius"
			m_flEndScale = 2.0
			m_flStartScale = 0.1
			m_flStartTime = 0.85
		},
		{
			_class = "C_OP_InterpolateRadius"
			m_flBias = 0.85
			m_flEndScale = 2.0
			m_flEndTime = 0.85
			m_flStartTime = 0.1
			m_flStartScale = 0.2
		},
		{
			_class = "C_OP_LerpScalar"
			m_flOutput = 1.570796
			m_nFieldOutput = 12
		},
		{
			_class = "C_OP_OscillateScalar"
			m_nField = 4
			m_RateMin = -11.0
			m_RateMax = 11.0
			m_FrequencyMin = 0.125
			m_FrequencyMax = 0.5
			m_flOscAdd = 0.1
		},
		{
			_class = "C_OP_BasicMovement"
			m_Gravity = [ 0.0, 0.0, 200.0 ]
			m_flOpStartFadeInTime = 0.1
			m_flOpEndFadeInTime = 0.15
		},
		{
			_class = "C_OP_ColorInterpolate"
			m_flFadeEndTime = 0.0
			m_flFadeStartTime = 1.0
			m_ColorFade = [ 49, 80, 27, 255 ]
		},
	]
	m_Initializers = 
	[
		{
			_class = "C_INIT_RandomSequence"
			m_nSequenceMax = 1
		},
		{
			_class = "C_INIT_RandomYaw"
			m_flDegreesMax = 90.0
		},
		{
			_class = "C_INIT_RandomRotation"
		},
		{
			_class = "C_INIT_RandomColor"
			m_ColorMax = [ 19, 232, 8, 255 ]
			m_ColorMin = [ 18, 117, 53, 255 ]
		},
		{
			_class = "C_INIT_RandomLifeTime"
			m_fLifetimeMax = 0.6
			m_fLifetimeMin = 0.15
		},
		{
			_class = "C_INIT_CreateWithinBox"
		},
		{
			_class = "C_INIT_RandomRadius"
