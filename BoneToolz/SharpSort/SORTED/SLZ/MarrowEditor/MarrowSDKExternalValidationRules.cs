using System;
 
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEditor.Presets;

namespace SLZ.MarrowEditor
{
    [InitializeOnLoad]
    public static class MarrowSDKExternalValidationRules
    {
        private static FieldInfo pcPresetPathFieldInfo = null;
        private static FieldInfo questPresetPathFieldInfo = null;
        private static MethodInfo extractShadersMethodInfo = null;
        private static string _pcPresetPathCached = String.Empty;
        private static string PcPresetPathCached
        {
            get
            {
                SetReflectionMethods();
                if (string.IsNullOrEmpty(_pcPresetPathCached))
                {
                    _pcPresetPathCached = pcPresetPathFieldInfo.GetValue(null) as string;
                }

                return _pcPresetPathCached;
            }
        }

        private static string _questPresetPathCached = String.Empty;
        private static string QuestPresetPathCached
        {
            get
            {
                SetReflectionMethods();
                if (string.IsNullOrEmpty(_questPresetPathCached))
                {
                    _questPresetPathCached = questPresetPathFieldInfo.GetValue(null) as string;
                }

                return _questPresetPathCached;
            }
        }

        static MarrowSDKExternalValidationRules()
        {
#if true
            MarrowProjectValidation.ValidationRules.AddRange(new List<MarrowProjectValidation.MarrowValidationRule>() { new() { message = "Quality Settings incorrect", Validate = () =>
            {
                var qualitySettings = QualitySettings.GetQualitySettings();
                if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.StandaloneWindows64)
                {
                    var preset = AssetDatabase.LoadAssetAtPath<Preset>(PcPresetPathCached);
                    return preset.DataEquals(qualitySettings);
                }

                if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.Android)
                {
                    var preset = AssetDatabase.LoadAssetAtPath<Preset>(QuestPresetPathCached);
                    return preset.DataEquals(qualitySettings);
                }

                return false;
            }, FixRule = () =>
            {
                if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.StandaloneWindows64)
                {
                    SLZ.URPModResources.PlatformQualitySetter.OverrideQualitySettings(BuildTarget.StandaloneWindows64);
                }
                else if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.Android)
                {
                    SLZ.URPModResources.PlatformQualitySetter.OverrideQualitySettings(BuildTarget.Android);
                }
            }, fixMessage = "Setup URP based Quality Settings" }, new() { message = "SLZ Shaders Not Found", Validate = () =>
            {
                return Directory.Exists(Path.Combine("Assets", "SLZShaders"));
            }, FixRule = () =>
            {
                extractShadersMethodInfo.Invoke(null, new object[] { true });
            }, fixMessage = "Install SLZ Shaders" }, });
#endif
        }

        private static void SetReflectionMethods()
        {
#if true
            if (pcPresetPathFieldInfo == null)
            {
                pcPresetPathFieldInfo = typeof(SLZ.URPModResources.PlatformQualitySetter).GetField("PcPresetPath", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            }

            if (questPresetPathFieldInfo == null)
            {
                questPresetPathFieldInfo = typeof(SLZ.URPModResources.PlatformQualitySetter).GetField("QuestPresetPath", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            }

            if (extractShadersMethodInfo == null)
            {
                extractShadersMethodInfo = typeof(SLZ.URPModResources.ExtractAssets).GetMethod("ExtractShaders", BindingFlags.NonPublic | BindingFlags.Static, null, new Type[] { typeof(bool) }, null);
            }
#endif
        }
    }
}