python early hide:

    class _ObjectNamespace(object):
        def __init__(self, nso, name):
            self.nso = nso
            self.name = name

        def set(self, name, value):
            setattr(self.nso, name, value)

        def set_default(self, name, value):
            raise Exception("The default statement can not be used with the {} namespace.".format(self.name))

    class _PersistentNamespace(object):
        def set(self, name, value):
            if getattr(persistent, name) is None:
                setattr(persistent, name, value)

        def set_default(self, name, value):
            if getattr(persistent, name) is None:
                setattr(persistent, name, value)

    class _PreferencesNamespace(object):

        def set(self, name, value):
            raise Exception("The define statement can not be used with the preferences namespace.")

        def set_default(self, name, value):

            undefined = object()

            if not isinstance(persistent._preference_default, dict):
                persistent._preference_default = { }

            old_default = persistent._preference_default.get(name, undefined)

            if old_default != value:
                setattr(_preferences, name, value)
                persistent._preference_default[name] = value

            default_field = "default_" + name

            # This ensures we don't conflict with the old way of doing
            # things.
            if hasattr(config, default_field):
                setattr(config, default_field, value)

    class _GuiNamespace(object):
        def set(self, name, value):
            setattr(gui, name, value)

        def set_default(self, name, value):
            setattr(gui, name, value)


    config.special_namespaces["store.config"] = _ObjectNamespace(config, "config")
    config.special_namespaces["store.persistent"] = _PersistentNamespace()
    config.special_namespaces["store.preferences"] =  _PreferencesNamespace()
    config.special_namespaces["store.gui"] = _GuiNamespace()

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            "Rr|H "Rr�
  "Rr`  vehicle_type_track_data version_major 3 version_minor 0 version_revision vehicle_track name default vehicle_types vehicle_type supercar brake_lines num_brake_lines 27 brake_line id lineType drift brake_data type normal min_speed 46.0 min_speed_drop 0.6 max_speed 76.7 max_speed_left max_speed_right drift_speed 79.3 distance_modifier 1.00 brake_cruise_ratio 1.10 hold_time 0.00 curve_modifier -1.0000000000 curve_modifier_left curve_modifier_right 10 grip 33.6 56.0 55.5 20 27.6 60.0 30 30.0 50.0 40 46.8 78.0 64.0 50 25.8 43.0 36.6 60 30.5 50.8 59.8 70 36.7 61.1 80 28.8 48.0 90 44.0 100 31.2 52.0 110 25.2 42.0 120 45.0 130 140 150 40.0 160 28.2 47.0 170 53.0 1000 39.0 65.0 1010 1020 49.0 1030 59.0 1040 1050 1060 34.2 57.0 1070 38.4 80.6 1080 34.8 58.0 touring_car 41.3 68.9 70.2 hold_line_id hold_distance_modifier 1.0000000000 61.0 58.5 61.5 1 26.4 2 43.7 72.8 68.0 4 42.6 46.6 5 35.9 40.4 6 33.5 55.9 7 8 9 35.1 44.6 40.6 41.5 43.5 11 12 13 29.4 14 41.0 15 34.3 57.2 16 30.6 51.0 17 62.0 18 19 40.8 21 66.0 22 49.9 83.2 23 35.4 24 25 71.5 26 lightweight 18.6 31.0 22.2 37.0 18.0 19.2 32.0 21.6 36.0 22.8 38.0 17.4 29.0 20.4 34.0 21.0 35.0 24.0 32.4 54.0 31.8 sports_coupe 39.8 66.3 52.5 67.6 41.6 39.5 42.9 55.0 muscle 54.5 27.0 42.1 32.8 54.6 53.3 23.4 40.5 24.6 37.8 63.0 74.1 75.4 euro 45.2 classic_muscle 50.5 28.9 48.1 49.4 50.7 45.5 33.0 63.7 classic_euro 44.5 hot_hatch 37.5 indycar 87.1 56.2 93.6 51.6 50.4 84.0 76.0 91.0 47.4 79.0 84.5 63.2 105.3 100.1 37.2 super_mod 65.5 49.6 37.4 62.4 71.0 49.1 81.9 88.4 gt3 47.6 70.0 63.5 38.2 48.6 81.0 classic_jdm 30.4 roadster 56.5 super_touring 59.5 39.6 52.3 jdm 42.5 gt   "RrD         &   (   6   8   I   W   \   d   r      �   �   �   �   �   �   �   �   �   �   �   �   �   �   �         +  7  <  N  S  f  k  u  z  �  �  �  �  �  �  �  �  �  �  �  �  �  �  �  �  �  �                "  '  *  /  4  7  <  A  D  