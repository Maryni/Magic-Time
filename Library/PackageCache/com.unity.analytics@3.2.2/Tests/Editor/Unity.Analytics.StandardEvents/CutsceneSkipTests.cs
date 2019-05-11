<?xml version="1.0"?>
<unit type="dev" slot="1">
  <object file="units/dev_tools/editable_text_long/editable_text_long" />
  <extensions>
    <extension name="unit_data" class="ScriptUnitData" />
    <extension name="editable_gui" class="EditableGui">
      <var name="_gui_object" value="g_editable_text" />
      <var name="_text" value="LONG" />
      <var name="_font" value="fonts/font_medium_shadow_mf" />
    </extension>
  </extensions>
</unit><?xml version="1.0"?>
<dynamic_object>
  <diesel materials="units/dev_tools/editable_text_long/editable_text_long" orientation_object="rp_editable_text" />
  <bodies>
    <body name="static_body" enabled="true" template="editor">
      <object name="c_editable_text" enabled="true" collision_type="box" />
    </body>
  </bodies>
  <graphics>
    <object name="g_editable_text" />
  </graphics>
</dynamic_object><?xml version="1.0"?>
<dynamic_object>
  <diesel materials="units/dev_tools/