<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:vpcf13:version{10b35a8e-b1ee-4f14-87a6-a7b6aae37699} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 16
	m_ConstantColor = [ 186, 120, 216, 255 ]
	m_nConstantSequenceNumber = 6
	m_bShouldSort = false
	m_Renderers = 
	[
		{
			_class = "C_OP_RenderTrails"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_flOverbrightFactor = 6.0
			m_flAddSelfAmount = 2.0
			m_bSaturateColorPreAlphaBlend = false
			m_hTexture = resource:"materials/particle/sparks/sparks.vtex"
			m_flMaxLength = 64.0
			m_flLengthFadeInTime = 0.1
			m_flRadiusScale = 0.5
			m_flFinalTextureScaleV = -1.0
			m_flFinalTextureOffsetV = 1.0
			m_nHSVShiftControlPoint = 62
		},
		{
			_class = "C_OP_RenderDeferredLight"
			m_flRadiusScale = 4.0
			m_flAlphaScale = 8.0
			m_flStartFalloff = 0.1
			m_hTexture = resource:"materials/particle/sparks/sparks.vtex"
			m_ColorScale = [ 255, 255, 255 ]
		},
	]
	m_Operators = 
	[
		{
			_class = "C_OP_BasicMovement"
		},
		{
			_class = "C_OP_MaxVelocity"
			m_flMaxVelocity = 600.0
			m_nOverrideCP = 2
		},
		{
			_class = "C_OP_Decay"
			m_nOpEndCapState = 1
		},
		{
			_class = "C_OP_SetChildControlPoints"
			m_bSetOrientation = true
			m_nFirstControlPoint = 3
			m_nFirstSourcePoint = "0"
		},
	]
	m_Initializers = 
	[
		{
			_class = "C_INIT_CreateWithinSphere"
		},
		{
			_class = "C_INIT_RandomRadius"
			m_flRadiusMax = 48.0
			m_flRadiusMin = 48.0
		},
		{
			_class = "C_INIT_RandomLifeTime"
		},
	]
	m_Emitters = 
	[
		{
			_class = "C_OP_InstantaneousEmitter"
			m_nParticlesToEmit = 1
		},
	]
	m_ForceGenerators = 
	[
		{
			_class = "C_OP_AttractToControlPoint"
			m_nControlPointNumber = 1
			m_fFalloffPower = 0.0
			m_fForceAmount = 
			{
				m_nType = "PF_TYPE_LITERAL"
				m_flLiteralValue = 1000000.0
			}
			m_fForceAmountMin = null
		},
	]
	m_Children = 
	[
		{
			m_ChildRef = resource:"particles/units/heroes/hero_witchdoctor/witchdoctor_ward_attack_trail.vpcf"
		},
		{
			m_ChildRef = resource:"particles/units/heroes/hero_witchdoctor/witchdoctor_ward_attack_trail_b.vpcf"
		},
		{
			m_ChildRef = resource:"particles/units/heroes/hero_witchdoctor/witchdoctor_ward_attack_launch.vpcf"
		},
		{
			m_bEndCap = true
			m_ChildRef = resource:"particles/units/heroes/hero_witchdoctor/witchdoctor_ward_attack_explosion.vpcf"
		},
		{
			m_ChildRef = resource:"particles/units/heroes/hero_witchdoctor/witchdoctor_ward_attack_glow.vpcf"
		},
		{
			m_ChildRef = resource:"particles/units/heroes/hero_witchdoctor/witchdoctor_ward_attack_trail_c.vpcf"
		},
	]
	m_PreEmissionOperators = 
	[
		{
			_class = "C_OP_HSVShiftToCP"
			m_DefaultHSVColor = [ 255, 129, 230, 255 ]
		},
	]
	m_nBehaviorVersion = 5
	m_controlPointConfigurations = 
	[
		{
			m_name = "preview"
			m_drivers = 
			[
				{
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 0.0, 0.0, 0.0 ]
					m_angOffset = [ 0.0, 0.0, 0.0 ]
					m_entityName = "self"
				},
				{
					m_iControlPoint = 1
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 0.0, 0.0, 0.0 ]
					m_angOffset = [ 0.0, 0.0, 0.0 ]
					m_entityName = "self"
				},
				{
					m_iControlPoint = 2
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 1.0, 0.0, 0.0 ]
					m_angOffset = [ 0.0, 0.0, 0.0 ]
					m_entityName = "self"
				},
				{
					m_iControlPoint = 3
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 0.0, 0.0, 0.0 ]
					m_angOffset = [ 0.0, 0.0, 0.0 ]
					m_entityName = "self"
				},
				{
					m_iControlPoint = 60
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 143.0, 247.0, 229.0 ]
					m_angOffset = [ 0.0, 0.0, 0.0 ]
					m_entityName = "self"
				},
				{
					m_iControlPoint = 61
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 0.0, 0.0, 0.0 ]
					m_angOffset = [ 0.0, 0.0, 0.0 ]
					m_entityName = "self"
				},
				{
					m_iControlPoint = 62
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 0.0, 0.0, 0.0 ]
					m_angOffset = [ 0.0, 0.0, 0.0 ]
					m_entityName = "self"
				},
			]
		},
	]
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               