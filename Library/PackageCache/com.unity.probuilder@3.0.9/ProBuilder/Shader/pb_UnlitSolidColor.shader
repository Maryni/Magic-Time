<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 40
	m_flConstantRadius = 15.0
	m_flNoDrawTimeToGoToSleep = 2.0
	m_bShouldSort = false
	m_Renderers = 
	[
		{
			_class = "C_OP_RenderSprites"
			m_nSequenceCombineMode = "SEQUENCE_COMBINE_MODE_USE_SEQUENCE_0"
			m_bBlendFramesSeq0 = false
			m_hTexture = resource:"materials/particle/impact/fleks3.vtex"
			m_flAnimationRate = 1.0
		},
	]
	m_Operators = 
	[
		{
			_class = "C_OP_BasicMovement"
			m_fDrag = 0.05
			m_Gravity = [ 0.0, 0.0, -500.0 ]
		},
		{
			_class = "C_OP_Decay"
		},
		{
			_class = "C_OP_SpinUpdate"
		}