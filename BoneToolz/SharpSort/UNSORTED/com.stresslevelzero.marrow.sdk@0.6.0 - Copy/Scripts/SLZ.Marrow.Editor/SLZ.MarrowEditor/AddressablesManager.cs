 
 
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
 
 
using SLZ.Marrow.Warehouse;
using UnityEditor.AddressableAssets.Build;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;
 
using UnityEditor.Presets;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.Initialization;

namespace SLZ.MarrowEditor
{
    public class AddressablesManager
    {
        public static AddressableAssetSettings Settings
        {
            get
            {
                return AddressableAssetSettingsDefaultObject.Settings;
            }

            set
            {
                AddressableAssetSettingsDefaultObject.Settings = value;
            }
        }

        public const string ProfilePalletID = "Pallet";
        public const string ProfileGamePalletID = "Game Pallet";
        public const string MarrowAASettingsFileName = "AddressableAssetSettings";
        private static AddressableAssetGroupTemplate _packedPalletGroupTemplate;
        public static AddressableAssetGroupTemplate PackedPalletGroupTemplate
        {
            get
            {
                if (_packedPalletGroupTemplate == null)
                {
                    AddressableAssetGroupTemplate loadedTemplate = null;
                    foreach (var template in Settings.GroupTemplateObjects)
                    {
                        if (template.name.Equals("Packed Pallet Assets") && template is AddressableAssetGroupTemplate aaTemplate)
                            loadedTemplate = aaTemplate;
                    }

                    if (loadedTemplate != null)
                    {
                        _packedPalletGroupTemplate = loadedTemplate;
                    }
                }

                return _packedPalletGroupTemplate;
            }
        }

        private static AddressableAssetGroupTemplate _palletsGroupTemplate;
        public static AddressableAssetGroupTemplate PalletsGroupTemplate
        {
            get
            {
                if (_palletsGroupTemplate == null)
                {
                    AddressableAssetGroupTemplate loadedTemplate = null;
                    foreach (var template in Settings.GroupTemplateObjects)
                    {
                        if (template.name.Equals("Pallets") && template is AddressableAssetGroupTemplate aaTemplate)
                            loadedTemplate = aaTemplate;
                    }

                    if (loadedTemplate != null)
                    {
                        _palletsGroupTemplate = loadedTemplate;
                    }
                }

                return _palletsGroupTemplate;
            }
        }

        public static void ApplyPresetAASettings()
        {
            var settings = Settings;
            string presetPath = AssetDatabase.GUIDToAssetPath("c737533b10b487f4394b3e2e80a6d40c");
            Preset aaSettingsPreset = AssetDatabase.LoadAssetAtPath<Preset>(presetPath);
            aaSettingsPreset.ApplyTo(settings);
            AddressableAssetSettingsDefaultObject.Settings = settings;
            CallAddressablesAwake();
        }

        public static AddressableAssetSettings CreateAASettings(bool force = false)
        {
            if (force)
            {
                if (Directory.Exists(AddressableAssetSettingsDefaultObject.kDefaultConfigFolder))
                {
                    Directory.Delete(AddressableAssetSettingsDefaultObject.kDefaultConfigFolder, true);
                }

                if (File.Exists(AssetDatabase.GetTextMetaFilePathFromAssetPath(AddressableAssetSettingsDefaultObject.kDefaultConfigFolder)))
                    File.Delete(AssetDatabase.GetTextMetaFilePathFromAssetPath(AddressableAssetSettingsDefaultObject.kDefaultConfigFolder));
                AssetDatabase.Refresh();
            }

            var settings = AddressableAssetSettings.Create(AddressableAssetSettingsDefaultObject.kDefaultConfigFolder, MarrowAASettingsFileName, true, true);
            AddressableAssetSettingsDefaultObject.Settings = settings;
            settings.RemoveGroup(settings.DefaultGroup);
            settings.RemoveGroup(settings.FindGroup(AddressableAssetSettings.PlayerDataGroupName));
            if (Directory.Exists(settings.DataBuilderFolder))
                AssetDatabase.DeleteAsset(settings.DataBuilderFolder);
            if (Directory.Exists(settings.GroupFolder))
                AssetDatabase.DeleteAsset(settings.GroupFolder);
            if (Directory.Exists(settings.GroupTemplateFolder))
                AssetDatabase.DeleteAsset(settings.GroupTemplateFolder);
            PlayerPrefs.DeleteKey(Addressables.kAddressablesRuntimeDataPath);
            ApplyPresetAASettings();
            CallAddressablesAwake();
            return settings;
        }

        public static AddressableAssetSettings SetupAASettingsForPallet(Pallet pallet)
        {
            return SetupAASettings(ProfilePalletID, null, pallet);
        }

        private static AddressableAssetSettings SetupAASettings(string profilePath, string customContentName = null, Pallet pallet = null, bool setupPalletGroup = true)
        {
            var settings = AddressableAssetSettingsDefaultObject.Settings;
            if (settings == null)
                settings = CreateAASettings(true);
            UnityEditor.Build.Pipeline.Utilities.ScriptableBuildPipeline.useDetailedBuildLog = true;
            UnityEditor.AddressableAssets.Settings.ProjectConfigData.GenerateBuildLayout = true;
            ClearGroups();
            ApplyPresetAASettings();
            AddressablesRuntimeProperties.ClearCachedPropertyValues();
            string buildPath = EvaluateProfileValueBuildPathForPallet(pallet, profilePath);
            string loadPath = EvaluateProfileValueLoadPathForPallet(pallet, profilePath);
            FixDefaultGroup(buildPath, loadPath);
            AddressablesRuntimeProperties.ClearCachedPropertyValues();
            var contentName = !string.IsNullOrEmpty(customContentName) ? customContentName : pallet.Barcode;
            if (settings.OverridePlayerVersion != contentName)
            {
                settings.OverridePlayerVersion = contentName;
                EditorUtility.SetDirty(settings);
            }

            if (settings.BuildRemoteCatalog == false)
            {
                settings.BuildRemoteCatalog = true;
                EditorUtility.SetDirty(settings);
            }

            if (settings.ShaderBundleNaming != ShaderBundleNaming.Custom)
            {
                settings.ShaderBundleNaming = ShaderBundleNaming.Custom;
                EditorUtility.SetDirty(settings);
            }

            if (settings.ShaderBundleCustomNaming != contentName)
            {
                settings.ShaderBundleCustomNaming = contentName;
                EditorUtility.SetDirty(settings);
            }

            if (settings.MonoScriptBundleNaming != MonoScriptBundleNaming.Custom)
            {
                settings.MonoScriptBundleNaming = MonoScriptBundleNaming.Custom;
                EditorUtility.SetDirty(settings);
            }

            if (settings.MonoScriptBundleCustomNaming != contentName)
            {
                settings.MonoScriptBundleCustomNaming = contentName;
                EditorUtility.SetDirty(settings);
            }

            if (settings.RemoteCatalogBuildPath.Id != buildPath)
            {
                SetRemoteCatalogBuildPath(settings, buildPath);
                EditorUtility.SetDirty(settings);
            }

            if (settings.RemoteCatalogLoadPath.Id != loadPath)
            {
                SetRemoteCatalogLoadPath(settings, loadPath);
                EditorUtility.SetDirty(settings);
            }

            if (setupPalletGroup && !settings.FindGroup("Pallets"))
                settings.CreateGroup("Pallets", false, false, true, AddressablesManager.PalletsGroupTemplate.SchemaObjects);
            AssetDatabase.SaveAssetIfDirty(settings);
            return settings;
        }

        public static void ClearGroups()
        {
            var settings = Settings;
            for (var i = settings.groups.Count - 1; i >= 0; i--)
            {
                var group = settings.groups[i];
                if (group != null)
                {
                    if (group.Default)
                    {
                        foreach (var entry in group.entries.ToList())
                        {
                            group.RemoveAssetEntry(entry);
                        }
                    }
                    else
                    {
                        settings.RemoveGroup(group);
                    }
                }
            }
        }

        private static void FixDefaultGroup(string buildPath, string loadPath)
        {
            var settings = Settings;
            string metaGuid = "e4a20b55993a1fb40b1596966b14c9ae";
            string presetPath = AssetDatabase.GUIDToAssetPath("e473fee2058c3c84ead989aa134b6304");
            Preset bundledSchemaPreset = AssetDatabase.LoadAssetAtPath<Preset>(presetPath);
            var defaultGroup = settings.DefaultGroup;
            var bundledAssetSchema = defaultGroup.GetSchema<BundledAssetGroupSchema>();
            if (bundledAssetSchema != null)
            {
                string path = AssetDatabase.GetAssetPath(bundledAssetSchema);
                string guid = AssetDatabase.GUIDFromAssetPath(path).ToString();
                if (guid != metaGuid || !path.Contains("Assets"))
                {
                    defaultGroup.RemoveSchema<BundledAssetGroupSchema>();
                }

                bundledAssetSchema = null;
            }

            if (bundledAssetSchema == null)
            {
                bundledAssetSchema = defaultGroup.AddSchema<BundledAssetGroupSchema>();
                string assetPath = AssetDatabase.GetAssetPath(bundledAssetSchema);
                string metaPath = AssetDatabase.GetTextMetaFilePathFromAssetPath(assetPath);
                string yamlContent = File.ReadAllText(metaPath);
                string replacedContent = Regex.Replace(yamlContent, @"guid:\s*(\w+)", "guid: " + metaGuid);
                File.WriteAllText(metaPath, replacedContent);
                AssetDatabase.ImportAsset(AssetDatabase.GetAssetPath(bundledAssetSchema));
                defaultGroup.Schemas.RemoveAll(schema => schema is not ContentUpdateGroupSchema);
                bundledAssetSchema = AssetDatabase.LoadAssetAtPath<BundledAssetGroupSchema>(assetPath);
                defaultGroup.Schemas.Add(bundledAssetSchema);
            }

            bundledSchemaPreset.ApplyTo(bundledAssetSchema);
            SetCustomBuildPath(bundledAssetSchema, buildPath);
            SetCustomLoadPath(bundledAssetSchema, loadPath);
        }

        public static string EvaluateProfileValue(string variableName)
        {
            string value;
            if (Settings == null)
            {
                value = "SETTINGS NULL";
            }
            else
            {
                value = Settings.profileSettings.GetValueByName(Settings.activeProfileId, variableName);
                value = Settings.profileSettings.EvaluateString(Settings.activeProfileId, value);
            }

            return value;
        }

        public static string EvaluateProfileValueForPallet(string variableName, Pallet pallet)
        {
            return ProfileValueForPallet(EvaluateProfileValue(variableName), pallet);
        }

        public static string EvaluateProfileValueBuildPathForPallet(Pallet pallet, string profile)
        {
            return EvaluateProfileValueForPallet($"{profile}.BuildPath", pallet);
        }

        public static string EvaluateProfileValueLoadPathForPallet(Pallet pallet, string profile)
        {
            return EvaluateProfileValueForPallet($"{profile}.LoadPath", pallet);
        }

        public static void SetRemoteCatalogBuildPath(AddressableAssetSettings settings, string buildPath)
        {
            typeof(ProfileValueReference).GetProperty("Id").SetValue(settings.RemoteCatalogBuildPath, buildPath);
        }

        private static void SetRemoteCatalogLoadPath(AddressableAssetSettings settings, string loadPath)
        {
            typeof(ProfileValueReference).GetProperty("Id").SetValue(settings.RemoteCatalogLoadPath, loadPath);
        }

        public static void SetCustomBuildPath(BundledAssetGroupSchema schema, string buildPath)
        {
            typeof(ProfileValueReference).GetProperty("Id").SetValue(schema.BuildPath, buildPath);
            typeof(BundledAssetGroupSchema).GetField("m_UseCustomPaths", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(schema, true);
            EditorUtility.SetDirty(schema);
        }

        public static void SetCustomLoadPath(BundledAssetGroupSchema schema, string loadPath)
        {
            typeof(ProfileValueReference).GetProperty("Id").SetValue(schema.LoadPath, loadPath);
            typeof(BundledAssetGroupSchema).GetField("m_UseCustomPaths", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(schema, true);
            EditorUtility.SetDirty(schema);
        }

        public static string ProfileValueForPallet(string profileValue, Pallet pallet)
        {
            if (profileValue.Contains("~PALLETBARCODE~") && pallet != null)
            {
                profileValue = profileValue.Replace("~PALLETBARCODE~", pallet.Barcode);
            }

            return profileValue;
        }

        [InitializeOnLoadMethod]
        public static void CallAddressablesAwake()
        {
            if (AddressableAssetSettingsDefaultObject.Settings != null)
            {
                typeof(AddressableAssetSettings).GetMethod("Awake", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(AddressableAssetSettingsDefaultObject.Settings, null);
            }
        }

        private static void OpenFolder(string folderPath)
        {
            string folderToOpen = folderPath;
            if (Directory.Exists(folderToOpen))
            {
                folderToOpen = Path.GetFullPath(folderPath);
                EditorUtility.RevealInFinder(folderToOpen);
            }
        }

        [MenuItem("Stress Level Zero/Void Tools/Open Built Pallet Folder")]
        public static void OpenBuiltdddModFolder()
        {
            var pallet = Selection.activeObject as Pallet;
            OpenBuiltModFolder(pallet);
        }

        public static string GetBuiltModFolder(Pallet pallet = null)
        {
            return pallet != null ? EvaluateProfileValueBuildPathForPallet(pallet, AddressablesManager.ProfilePalletID) : string.Empty;
        }

        public static void OpenBuiltModFolder(Pallet pallet = null)
        {
            if (pallet != null)
            {
                var buildPath = EvaluateProfileValueBuildPathForPallet(pallet, AddressablesManager.ProfilePalletID);
                OpenFolder(Path.GetFullPath(buildPath));
            }
        }

        public static void OpenContainingBuiltModFolder(Pallet pallet = null)
        {
            if (pallet != null)
            {
                var buildPath = EvaluateProfileValueBuildPathForPallet(pallet, AddressablesManager.ProfilePalletID);
                OpenFolder(Path.GetFullPath(Path.Combine(buildPath, "..")));
            }
        }
    }
}