<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 5
	m_flConstantLifespan = 2.0
	m_Renderers = 
	[
		{
			_class = "C_OP_RenderSprites"
			m_hTexture = resource:"materials/lights/white.vtex"
			m_bDisableOperator = true
		},
	]
	m_Operators = 
	[
		{
			_class = "C_OP_Decay"
		},
		{
			_class = "C_OP_SetPerChildControlPoint"
			m_bNumBasedOnParticleCount = true
		},
		{
			_class = "C_OP_EnableChildrenFromParentParticleCount"
			m_nNumChildrenToEnable = 5
		},
	]
	m_Initializers = 
	[
		{
			_class = "C_INIT_CreateWithinSphere"
			m_fRadiusMax = 0.8
			m_vecDistanceBias = [ 1.0, 1.0, 0.0 ]
		