<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 1
	m_flConstantRadius = 80.000000
	m_nConstantSequenceNumber = 6
	m_bShouldSort = false
	m_Renderers =
	[
		{
			_class = "C_OP_RenderSprites"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_bMod2X = true
			m_hTexture = resource:"materials/particle/particle_modulate_04.vtex"
		},
	]
	m_Operators =
	[
		{
			_class = "C_OP_BasicMovement"
		},
		{
			_class = "C_OP_MaxVelocity"
			m_nOverrideCP = 2
			m_flMaxVelocity = 600.000000
		},
		{
			_class = "C_OP_Decay"
			m_nOpEndCapState = 1
		},
		{
			_class = "C_OP_SetChildControlPoints"
			m_nFirstControlPoint = 3
			m_bSetOrientation = true
		},
	]
	m_Initializers =
	[
		{
			_class = "C_INIT_CreateWithinSphere"
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
			m_fForceAmount = 1000000.000000
			m_fFalloffPower = 0.000000
			m_nControlPointNumber = 1
		},
	]
	m_Children =
	[
		{
			m_ChildRef = resource:"particles/units/heroes/hero_leshrac/leshrac_base_attack_b.vpcf"
		},
		{