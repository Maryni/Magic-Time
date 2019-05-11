using UnityEditor;
using UnityEngine;
using System.Collections;

namespace TMPro.EditorUtilities
{

    //[InitializeOnLoad]
    class TMP_ResourcesLoader
    {

        /// <summary>
        /// Function to pre-load the TMP Resources
        /// </summary>
        public static void LoadTextMeshProResources()
        {
            //TMP_Settings.LoadDefaultSettings();
            //TMP_StyleSheet.LoadDefaultStyleSheet();
        }


        static TMP_ResourcesLoader()
        {
            //Debug.Log("Loading TMP Resources...");

            // Get current targetted platform


            //string Settings = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone);
            //TMPro.TMP_Settings.LoadDefaultSettings();
            //T