<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:vpcf12:version{cf2e4e5e-e5e0-4da9-930b-a526a91236e2} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 128
	m_flConstantRadius = 150.0
	m_ConstantColor = [ 66, 142, 51, 255 ]
	m_Renderers = 
	[
		{
			_class = "C_OP_RenderSprites"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_bAdditive = true
			m_flOverbrightFactor = 10.0
			m_hTexture = resource:"materials/particle/smoke/steam/steam.vtex"
			m_flAnimationRate = 0.5
			m_nHSVShiftControlPoint = 62
		},
	]
	m_Operators = 
	[
		{
			_class = "C_OP_Decay"
		},
		{
			_class = "C_OP_InterpolateRadius"
			m_flStartScale = 0.0
			m_flEndScale = 2.0
			m_flBias = 0.9
		},
		{
			_class = "C_OP_FadeOutSimple"
			m_flFadeOutTime = 0.5
		},
		{
			_class = "C_OP_RampScalarLinearSimple"
			m_nField = 10
			m_Rate = -0.7
		},
		{
			_class = "C_OP_BasicMovement"
		},
		{
			_class = "C_OP_SpinUpdate"
		},
		{
			_class = "C_OP_VectorNoise"
			m_fl4NoiseScale = 0.65
			m_nFieldOutput = 0
			m_vecOutputMin = [ -5.0, -5.0, -5.0 ]
			m_vecOutputMax = [ 5.0, 5.0, 5.0 ]
			m_bAdditive = true
		},
		{
			_class = "C_OP_ColorInterpolate"
			m_flFadeEndTime = 0.8
			m_ColorFade = [ 79, 123, 98, 255 ]
		},
	]
	m_Initializers = 
	[
		{
			_class = "C_INIT_RandomLifeTime"
			m_fLifetimeMax = 0.9
			m_fLifetimeMin = 0.7
		},
		{
			_class = "C_INIT_CreateWithinSphere"
			m_LocalCoordinateSystemSpeedMin = [ -50.0, -50.0, 50.0 ]
			m_LocalCoordinateSystemSpeedMax = [ 50.0, 50.0, 100.0 ]
		},
		{
			_class = "C_INIT_RandomRotation"
			m_flDegreesMax = 40.0
		},
		{
			_class = "C_INIT_RandomColor"
			m_ColorMin = [ 56, 207, 56, 255 ]
			m_ColorMax = [ 8, 32, 119, 255 ]
		},
		{
			_class = "C_INIT_RandomSequence"
			m_nSequenceMax = 4
		},
		{
			_class = "C_INIT_RandomRotationSpeed"
			m_flDegreesMin = 30.0
			m_flDegreesMax = 60.0
		},
		{
			_class = "C_INIT_RandomAlpha"
			m_nAlphaMin = 150
			m_nAlphaMax = 200
		},
		{
			_class = "C_INIT_RandomRadius"
			m_flRadiusMax = 90.0
			m_flRadiusMin = 50.0
		},
		{
			_class = "C_INIT_PositionOffset"
			m_OffsetMin = [ 0.0, 0.0, 20.0 ]
			m_OffsetMax = [ 0.0, 0.0, 20.0 ]
		},
		{
			_class = "C_INIT_RandomYawFlip"
		},
		{
			_class = "C_INIT_R