<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->
{
	_class = "CParticleSystemDefinition"
	m_bShouldHitboxesFallbackToRenderBounds = false
	m_nMaxParticles = 1
	m_flConstantRadius = 0.75
	m_bShouldSort = false
	m_Renderers = 
	[
		{
			_class = "C_OP_RenderSprites"
			m_flAddSelfAmount = 1.0
			m_bAdditive = true
			m_flOverbrightFactor = 2.0
			m_hTexture = resource:"materials/particle/particle_flares/aircraft_white_v3.vtex"
		},
	]
	m_Operators = 
	[
		{
			_class = "C_OP_BasicMovement"
			m_nOpEndCapState = 0
		},
		{
			_class = "C_OP_PositionLock"
			m_nControlPointNumber = 3
			m_bLockRot = true
		},
		{
			_class = "C_OP_Decay"
			m_nOpEndCapState = 1
		},
	]
	m_Initializers = 
	[
		{
			_class = "C_INIT_CreateWithinSphere"
			m_nControlPointNumber = 3
		},
		{
			_class = "C_INIT_RandomLifeTime"
			m_fLifetimeMax = 1.0
			m_fLifetimeMin = 1.0
		},
		{
			_class = "C_INIT_RandomRotation"
			m_nFieldOutput = 20
			m_bRandomlyFlipDirection = false
			m_flDegreesMax = 180.0
			m_flDegreesMin = 180.0
		},
		{
			_class = "C_INIT_RandomScalar"
			m_flMin = 0.5
			m_flMax = 1.25
			m_nFieldOutput = 18
		},
		{
			_class = "C_INIT_RandomRadius"
			m_flRadiusMax = 100.0
			m_flRadiusMin = 50.0
		},
		{
			_class = "C_INIT_RandomColor"
			m_ColorMin = [ 40, 200, 222, 255 ]
			m_ColorMax = [ 58, 122, 251, 255 ]
		},
	]
	m_Emitters = 
	[
		{
			_class = "C_OP_InstantaneousEmitter"
			m_nParticlesToEmit = 1
		},
	]
	m_Children = 
	[
		{
			m_bEndCap = true
			m_ChildRef = resource:"particles/units/heroes/hero_dark_willow/dark_willow_shadow_realm_wisp_endcap.vpcf"
		},
	]
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
					m_vecOffset = [ 0.0, 0.0, 0.0 ]
					m_angOffset = [ null, null, null ]
					m_entityName = "self"
				},
				{
					m_iControlPoint = 2
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 1.0, 0.0, 0.0 ]
					m_angOffset = [ null, null, null ]
					m_entityName = "self"
				},
				{
					m_iControlPoint = 3
					m_iAttachType = "PATTACH_WORLDORIGIN"
					m_vecOffset = [ 0.0, 0.0, 0.0 ]
					m_angOffset = [ null, null, null ]
					m_entityName = "self"
				},
			]
		},
	]
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 XNBw�f  �
  �
�N �   7$  {VF����@�W;'�w�ꀕE`H������m>q��d��|��  #  F �`kw���x��p��7i�ܻ��U�V3n�D��o�6Ē�Eh
���+	��     �! V�������  |w��a0�ˠ��v'/���HFt	:����<��������ȝĭ 픺I� 4��&\�a�!��N!E
��AK�
!A [7ޅ�pZD���J\�Ȏ���gƳW-xv���a���k���a+�Z�~M��j:k�l��c�UW��wp�J�<���+<un�;��?՝]t����i�Uܨڔ���w&�KH���l(ľ�kC:�����SZ_h���ʰ}�k)`�k�{�v�R�^1vH�m$�d�A���g���9T�+�3^�.��E�����E�T�*��S˜+8K�����&'>i9�����hA��G�d�����9d�P��M�s!�� f��S>�)��A�HKFlh�s�	�w��o8�-���,�9r߲M�M�Y�'E��E||���c~��Z*�6���$,�3���#��,���"IΖ�%�z�
#[3ЊPơ���R���5���J@#�N�#�/Ll�(�o�9]��/��%����ػT5�8���r�H��ʳ��}&hm�^��)�������O�W|�E�'��  ���Q�$��M�^DF͟P�[�(�oq���6��=���1��_I��KW�o/2%S�TA��� ���Q�$��ӬJL