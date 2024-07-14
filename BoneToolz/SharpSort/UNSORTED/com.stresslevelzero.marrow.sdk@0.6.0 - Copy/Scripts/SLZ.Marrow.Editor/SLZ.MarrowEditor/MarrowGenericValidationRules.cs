 
 
using System.Collections.Generic;
using System.IO;
using System.Reflection;
 
 
 
 
using UnityEditor;
using UnityEditor.AddressableAssets;
 
 
 
using UnityEngine;
using UnityEngine.Rendering;

 

namespace SLZ.MarrowEditor
{
    [InitializeOnLoad]
    public static class MarrowGenericValidationRules
    {
        private static MethodInfo getDefaultTextureCompressionFormatMethod = null;
        private static MethodInfo setDefaultTextureCompressionFormatMethod = null;
        private static MethodInfo getLightMapEncodingQualityMethod = null;
        private static MethodInfo setLightMapEncodingQualityMethod = null;
        private enum LightmapEncodingQualityReflected
        {
            Low = 0,
            Normal = 1,
            High = 2
        }

        static MarrowGenericValidationRules()
        {
            MarrowProjectValidation.ValidationRules.AddRange(new List<MarrowProjectValidation.MarrowValidationRule>() { new MarrowProjectValidation.MarrowValidationRule { order = 0, message = "Addressables must be initialized", Validate = () =>
            {
                return AddressablesManager.Settings != null && File.Exists($"{AddressableAssetSettingsDefaultObject.kDefaultConfigFolder}/{AddressablesManager.MarrowAASettingsFileName}.asset");
            }, FixRule = () =>
            {
                AddressablesManager.CreateAASettings(true);
                AddressablesManager.ApplyPresetAASettings();
            }, fixMessage = "Initialize Addressables" }, new MarrowProjectValidation.MarrowValidationRule { message = "Color space must be Linear", Validate = () =>
            {
                return PlayerSettings.colorSpace == ColorSpace.Linear;
            }, FixRule = () =>
            {
                PlayerSettings.colorSpace = ColorSpace.Linear;
            }, fixMessage = "Set Player Settings Color Space to Linear" }, new MarrowProjectValidation.MarrowValidationRule { message = "Normal Map Encoding must be XYZ", Validate = () =>
            {
                return PlayerSettings.GetNormalMapEncoding(BuildTargetGroup.Android) == NormalMapEncoding.XYZ;
            }, FixRule = () =>
            {
                PlayerSettings.SetNormalMapEncoding(BuildTargetGroup.Android, NormalMapEncoding.XYZ);
            }, fixMessage = "Set Normal Map Encoding to XYZ" }, new MarrowProjectValidation.MarrowValidationRule { message = "Lightmap Encoding Quality must be set to High", Validate = () =>
            {
                SetReflectionMethods();
                return (int)LightmapEncodingQualityReflected.High == (int)(LightmapEncodingQualityReflected)getLightMapEncodingQualityMethod.Invoke(null, new object[] { BuildTargetGroup.Standalone }) && (int)LightmapEncodingQualityReflected.High == (int)(LightmapEncodingQualityReflected)getLightMapEncodingQualityMethod.Invoke(null, new object[] { BuildTargetGroup.Android });
            }, FixRule = () =>
            {
                SetReflectionMethods();
                setLightMapEncodingQualityMethod.Invoke(null, new object[] { BuildTargetGroup.Standalone, (int)LightmapEncodingQualityReflected.High });
                setLightMapEncodingQualityMethod.Invoke(null, new object[] { BuildTargetGroup.Android, (int)LightmapEncodingQualityReflected.High });
            }, fixMessage = "Set Lightmap Encoding Quality to High" }, new MarrowProjectValidation.MarrowValidationRule { message = "Scripting Backend must be IL2CPP", Validate = () =>
            {
                return PlayerSettings.GetScriptingBackend(EditorUserBuildSettings.selectedBuildTargetGroup) == ScriptingImplementation.IL2CPP;
            }, FixRule = () =>
            {
                PlayerSettings.SetScriptingBackend(EditorUserBuildSettings.selectedBuildTargetGroup, ScriptingImplementation.IL2CPP);
            }, fixMessage = "Set Player Settings Scripting Backend to IL2CPP" }, new MarrowProjectValidation.MarrowValidationRule { message = "API Compatibility Level must be NET 4.6", Validate = () =>
            {
                return PlayerSettings.GetApiCompatibilityLevel(BuildTargetGroup.Standalone) == ApiCompatibilityLevel.NET_4_6 && PlayerSettings.GetApiCompatibilityLevel(BuildTargetGroup.Android) == ApiCompatibilityLevel.NET_4_6;
            }, FixRule = () =>
            {
                PlayerSettings.SetApiCompatibilityLevel(BuildTargetGroup.Standalone, ApiCompatibilityLevel.NET_4_6);
                PlayerSettings.SetApiCompatibilityLevel(BuildTargetGroup.Android, ApiCompatibilityLevel.NET_4_6);
            }, fixMessage = "Set Player Settings Scripting Backend to IL2CPP" }, new MarrowProjectValidation.MarrowValidationRule { message = "Android Texture Compression Format must be ASTC", Validate = () =>
            {
                return 3 == (int)getDefaultTextureCompressionFormatMethod.Invoke(null, new object[] { BuildTargetGroup.Android })!;
            }, FixRule = () =>
            {
                getDefaultTextureCompressionFormatMethod.Invoke(null, new object[] { BuildTargetGroup.Android, 3 });
            }, fixMessage = "Set Android Texture Compression Format to ASTC" }, new() { message = "Graphics API must be DX11 for Windows, Vulkan for Android", Validate = () =>
            {
                return (!PlayerSettings.GetUseDefaultGraphicsAPIs(BuildTarget.Android) && PlayerSettings.GetGraphicsAPIs(BuildTarget.Android).Length == 1 && PlayerSettings.GetGraphicsAPIs(BuildTarget.Android)[0] == GraphicsDeviceType.Vulkan) && (!PlayerSettings.GetUseDefaultGraphicsAPIs(BuildTarget.StandaloneWindows64) && PlayerSettings.GetGraphicsAPIs(BuildTarget.StandaloneWindows64).Length == 1 && PlayerSettings.GetGraphicsAPIs(BuildTarget.StandaloneWindows64)[0] == GraphicsDeviceType.Direct3D11);
            }, FixRule = () =>
            {
                PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.Android, false);
                PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.StandaloneWindows64, false);
                PlayerSettings.SetGraphicsAPIs(BuildTarget.Android, new GraphicsDeviceType[] { GraphicsDeviceType.Vulkan });
                PlayerSettings.SetGraphicsAPIs(BuildTarget.StandaloneWindows64, new GraphicsDeviceType[] { GraphicsDeviceType.Direct3D11 });
            }, fixMessage = "Switch to the required Graphics APIs" }, });
        }

        private static void SetReflectionMethods()
        {
            if (getDefaultTextureCompressionFormatMethod == null)
            {
                getDefaultTextureCompressionFormatMethod = typeof(PlayerSettings).GetMethod("GetDefaultTextureCompressionFormat", BindingFlags.NonPublic | BindingFlags.Static);
            }

            if (setDefaultTextureCompressionFormatMethod == null)
            {
                setDefaultTextureCompressionFormatMethod = typeof(PlayerSettings).GetMethod("SetDefaultTextureCompressionFormat", BindingFlags.NonPublic | BindingFlags.Static);
            }

            if (getLightMapEncodingQualityMethod == null)
            {
                getLightMapEncodingQualityMethod = typeof(PlayerSettings).GetMethod("GetLightmapEncodingQualityForPlatformGroup", BindingFlags.NonPublic | BindingFlags.Static);
            }

            if (setLightMapEncodingQualityMethod == null)
            {
                setLightMapEncodingQualityMethod = typeof(PlayerSettings).GetMethod("SetLightmapEncodingQualityForPlatformGroup", BindingFlags.NonPublic | BindingFlags.Static);
            }
        }
    }
}