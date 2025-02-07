﻿#if !UNITY_2018_3_OR_NEWER
using UnityEditor;

namespace TMPro
{

    public static class TMP_ProjectTextSettings
    {
        // Open Project Text Settings
        [MenuItem("Edit/Project Settings/TextMeshPro Settings", false, 309)]
        public static void SelectProjectTextSettings()
        {
            TMP_Settings textSettings = TMP_Settings.instance;

            if (textSettings)
            {
                Selection.activeObject = textSettings;

                // TODO: Do we want to ping the Project Text Settings asset in the Project Inspector
                EditorUtility.FocusProjectWindow();
                EditorGUIUtility.PingObject(textSettings);
            }
            else
              