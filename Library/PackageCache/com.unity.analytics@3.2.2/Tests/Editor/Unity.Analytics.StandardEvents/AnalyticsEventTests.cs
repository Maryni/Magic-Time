<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:vpcf1:version{d47d07e6-072c-49cb-9718-5bfd8d6c3d21} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 0
	m_flConstantRadius = 300.0
	m_ConstantColor = [ 0, 0, 0, 255 ]
	m_controlPointConfigurations = 
	[
		{
			m_name = "absorigin"
			m_drivers = 
			[
				{
					m_entityName = "parent"
					m_iAttachType = "PATTACH_POINT_FOLLOW"
					m_vecOffset = [ 0.0, 0.0, 0.0 ]
					m_angOffset = [ 0.0, 0.0, 0.0 ]
					m_attachmentName = "attach_attack2"
				},
				{
					m_iControlPoint = 1
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 0.0, 0.0, 0.0 ]
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
					m_iControlPoint = 5
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 1.0, 1.0, 1.0 ]
					m_angOffset = [ 0.0, 0.0, 0.0 ]
					m_entityName = "self"
				},
			]
			m_previewState = 
			{
				m_previewModel = "models/heroes/grimstroke/grimstroke.vmdl"
				m_sequenceName = "da_cast1_masters_hand"
				m_hitboxSetName = "default"
				m_bAnimationNonLooping = true
			}
		},
	]
	m_Children = 
	[
		{
			m_ChildRef = resource:"particles/units/heroes/hero_grimstroke/grimstroke_cast2_ground_rope_splatter.vpcf"
		},
		{
			m_ChildRef = resource:"particles/units/heroes/hero_grimstroke/grimstroke_cast2_ground_dark_spray.vpcf"
		},
		{
			m_ChildRef = resource:"particles/units/heroes/hero_grimstroke/grimstroke_cast2_ground_spray.vpcf"
		},
		{
			m_ChildRef = resource:"particles/units/heroes/hero_grimstroke/grimstroke_cast2_ground_rope.vpcf"
		},
		{
			m_ChildRef = resource:"particles/units/heroes/hero_grimstroke/grimstroke_cast2_ground_pause.vpcf"
			m_flDelay = 0.45
		},
		{
			m_ChildRef = resource:"particles/units/heroes/hero_grimstroke/grimstroke_cast2_ground_ember.vpcf"
		},
	]
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               