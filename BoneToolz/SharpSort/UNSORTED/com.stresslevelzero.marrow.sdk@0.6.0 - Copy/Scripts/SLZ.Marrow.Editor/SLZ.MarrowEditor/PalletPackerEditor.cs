using System;
using System.Collections.Generic;
using System.Text;
using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets.Initialization;
using UnityEditor;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;
using SLZ.Marrow;
 
using SLZ.Marrow.Warehouse;
using UnityEditor.AddressableAssets.Build;
using UnityEngine;

 

 

namespace SLZ.MarrowEditor
{
    public class PalletPackerEditor
    {
        public static bool PackPallet(Pallet pallet, bool dedupe = false) => PackPallet(pallet, out _, dedupe);
        public static bool PackPallet(Pallet pallet, out AddressablesPlayerBuildResult result, bool dedupe = false, bool checkValidation = true)
        {
            if (checkValidation && !MarrowProjectValidation.ValidateProject())
            {
                MarrowProjectValidationWindow.ShowWindow();
                result = null;
                return false;
            }

            PreparePallet(pallet, true, dedupe);
            result = new AddressablesPlayerBuildResult();
            PackPalletContent(out result);
            return true;
        }

        public static async UniTask<Tuple<bool, AddressablesPlayerBuildResult>> PackPalletWithValidationAsync(Pallet pallet, bool dedupe = false)
        {
            QueueEditorUpdateLoop.StartEditorUpdateLoop();
            SDKProjectPreferences.LoadFromFile();
            bool currentLoadMarrowGames = SDKProjectPreferences.LoadMarrowGames;
            if (currentLoadMarrowGames)
            {
                SDKProjectPreferences.LoadMarrowGames = false;
                SDKProjectPreferences.SaveToFile();
                await UniTask.Delay(TimeSpan.FromMilliseconds(100));
                await AssetWarehouseWindow.ReloadWarehouse();
                await UniTask.Delay(TimeSpan.FromMilliseconds(100));
            }

            QueueEditorUpdateLoop.StopEditorUpdateLoop();
            if (!MarrowProjectValidation.ValidateProject())
            {
                bool closed = false;
                var window = MarrowProjectValidationWindow.ShowWindow();
                window.OnClose += () =>
                {
                    closed = true;
                };
                await UniTask.WaitUntil(() => closed);
                if (!MarrowProjectValidation.ValidateProject())
                {
                    return null;
                }
            }

            PackPallet(pallet, out var result, dedupe, checkValidation: false);
            if (currentLoadMarrowGames)
            {
                SDKProjectPreferences.LoadFromFile();
                SDKProjectPreferences.LoadMarrowGames = true;
                SDKProjectPreferences.SaveToFile();
                await UniTask.Delay(TimeSpan.FromMilliseconds(100));
                await AssetWarehouseWindow.ReloadWarehouse();
                await UniTask.Delay(TimeSpan.FromMilliseconds(100));
            }

            bool success = result != null && string.IsNullOrEmpty(result.Error);
            return new Tuple<bool, AddressablesPlayerBuildResult>(success, result);
        }

        public static Dictionary<Type, AddressableAssetGroup> PreparePallet(Pallet pallet, bool generatePackedAssets = true, bool dedupe = false, DeduperTool.StripOptions stripOptions = DeduperTool.StripOptions.PartialAnimations)
        {
            var settings = AddressablesManager.SetupAASettingsForPallet(pallet);
            var palletsGroup = settings.FindGroup("Pallets");
            var palletSchema = palletsGroup.GetSchema<PalletGroupSchema>();
            palletSchema.Pallet = pallet;
            EditorUtility.SetDirty(palletsGroup);
            EditorUtility.SetDirty(palletSchema);
            if (generatePackedAssets)
                GeneratePackedAssets(pallet);
            var groups = PreparePalletInternal(settings, pallet);
            if (dedupe)
                DeduperTool.Dedupe(AddressablesManager.EvaluateProfileValueBuildPathForPallet(pallet, AddressablesManager.ProfilePalletID), AddressablesManager.EvaluateProfileValueLoadPathForPallet(pallet, AddressablesManager.ProfilePalletID), stripOptions);
            return groups;
        }

        public static void GeneratePackedAssets(Pallet pallet, bool saveAssets = true)
        {
            if (saveAssets)
                AssetDatabase.StartAssetEditing();
            pallet.ExportPackedAssets();
            pallet.GeneratePackedAssets(false);
            foreach (var crate in pallet.Crates)
            {
                crate.ExportPackedAssets();
                crate.GeneratePackedAssets(false);
            }

            foreach (var dataCard in pallet.DataCards)
            {
                dataCard.ExportPackedAssets();
                dataCard.GeneratePackedAssets(false);
            }

            if (saveAssets)
            {
                AssetDatabase.StopAssetEditing();
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
        }

        public static void GeneratePackedAssets(List<Pallet> pallets)
        {
            AssetDatabase.StartAssetEditing();
            foreach (var pallet in pallets)
            {
                GeneratePackedAssets(pallet, false);
            }

            AssetDatabase.StopAssetEditing();
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private static Dictionary<Type, AddressableAssetGroup> PreparePalletInternal(AddressableAssetSettings settings, Pallet pallet)
        {
            if (pallet.SDKVersion != MarrowSDK.SDK_VERSION)
            {
                pallet.SDKVersion = MarrowSDK.SDK_VERSION;
                EditorUtility.SetDirty(pallet);
                AssetDatabase.SaveAssetIfDirty(pallet);
                AssetDatabase.Refresh();
            }

            foreach (var crate in pallet.Crates)
            {
                if (crate != null && crate is LevelCrate levelCrate)
                {
                    levelCrate.ValidateSceneGUID();
                }
            }

            var palletsGroup = settings.FindGroup("Pallets");
            if (palletsGroup != null)
            {
                var palletEntry = settings.CreateOrMoveEntry(AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(pallet)), palletsGroup);
                palletEntry.address = $"{pallet.Barcode}";
            }

            var scannableTypeToGroup = new Dictionary<Type, AddressableAssetGroup>();
            List<Scannable> palletScannables = new List<Scannable>();
            pallet.GetScannables(ref palletScannables);
            foreach (var scannable in palletScannables)
            {
                AddScannableAssetsToGroup(scannable, settings, pallet, scannableTypeToGroup);
            }

            for (int i = settings.groups.Count - 1; i >= 0; i--)
            {
                var group = settings.groups[i];
                if (group.HasSchema<PalletGroupSchema>() && group.Name.Contains(pallet.Barcode) && group.entries.Count == 0)
                {
                    settings.RemoveGroup(group);
                    foreach (var kvp in scannableTypeToGroup)
                    {
                        if (kvp.Value == group)
                        {
                            scannableTypeToGroup.Remove(kvp.Key);
                            break;
                        }
                    }
                }
            }

            foreach (var group in scannableTypeToGroup.Values)
            {
                EditorUtility.SetDirty(group);
            }

            return scannableTypeToGroup;
        }

        private static AddressableAssetGroup SetupPalletGroup(AddressableAssetSettings settings, Pallet pallet, Type scannableType)
        {
            string groupName = $"{MarrowSDK.SanitizeID(pallet.Title)}_{MarrowSDK.SanitizeName(Crate.GetCrateName(scannableType))}s";
            AddressableAssetGroup group = settings.CreateGroup(groupName, false, false, true, AddressablesManager.PackedPalletGroupTemplate.SchemaObjects);
            if (group.HasSchema<PalletGroupSchema>())
            {
                group.GetSchema<PalletGroupSchema>().Pallet = pallet;
            }

            var bundledGroupSchema = group.GetSchema<BundledAssetGroupSchema>();
            var palletsGroup = settings.FindGroup("Pallets");
            var palletSchema = palletsGroup.GetSchema<PalletGroupSchema>();
            string profileID = palletSchema.MarrowGame != null ? AddressablesManager.ProfileGamePalletID : AddressablesManager.ProfilePalletID;
            string buildPath = AddressablesManager.EvaluateProfileValueBuildPathForPallet(pallet, profileID);
            string loadPath = AddressablesManager.EvaluateProfileValueLoadPathForPallet(pallet, AddressablesManager.ProfilePalletID);
            AddressablesManager.SetCustomBuildPath(bundledGroupSchema, buildPath);
            AddressablesManager.SetCustomLoadPath(bundledGroupSchema, loadPath);
            EditorUtility.SetDirty(group);
            EditorUtility.SetDirty(bundledGroupSchema);
            AssetDatabase.SaveAssetIfDirty(group);
            AssetDatabase.SaveAssetIfDirty(bundledGroupSchema);
            AssetDatabase.Refresh();
            return group;
        }

        private static void AddScannableAssetsToGroup(Scannable scannable, AddressableAssetSettings settings, Pallet pallet, Dictionary<Type, AddressableAssetGroup> scannableTypeToGroup)
        {
            if (scannable != null && scannable is Crate or DataCard)
            {
                Type scannableType = scannable.GetType();
                if (!scannableTypeToGroup.ContainsKey(scannableType))
                {
                    scannableTypeToGroup.Add(scannableType, SetupPalletGroup(settings, pallet, scannableType));
                }

                if (scannableTypeToGroup.TryGetValue(scannableType, out var group))
                {
                    UnityEngine.Object asset = null;
                    string scannableTypeTitle = scannable.GetType().Name;
                    if (scannable is Crate crate)
                    {
                        asset = crate.MainAsset.EditorAsset;
                        scannableTypeTitle = Crate.GetCrateName(crate.GetType());
                    }
                    else if (scannable is DataCard dataCard && dataCard.IsBundledDataCard())
                    {
                        asset = scannable;
                    }

                    AddAssetToGroup(group, asset, scannableTypeTitle, scannable.Title);
                    AddPackedAssetsToGroup(group, scannable, scannable.Title);
                }
            }
        }

        private static void AddPackedAssetsToGroup(AddressableAssetGroup group, IPackedAssets packedAssets, string containerTitle)
        {
            foreach (var packedAsset in packedAssets.ExportPackedAssets())
            {
                if (packedAsset.marrowAsset != null)
                {
                    AddAssetToGroup(group, packedAsset.marrowAsset.EditorAsset, packedAsset.title, containerTitle);
                }

                foreach (var packedSubAsset in packedAsset.subAssets)
                {
                    AddAssetToGroup(group, packedSubAsset.subAsset.EditorAsset, packedAsset.title, containerTitle, packedSubAsset.subTitle);
                }
            }
        }

        private static void AddAssetToGroup(AddressableAssetGroup group, UnityEngine.Object asset, params string[] addressTitles)
        {
            var settings = group.Settings;
            if (asset != null)
            {
                string assetPath = AssetDatabase.GetAssetPath(asset);
                if (!string.IsNullOrEmpty(assetPath))
                {
                    string guid = AssetDatabase.AssetPathToGUID(assetPath);
                    if (!string.IsNullOrEmpty(guid))
                    {
                        AddressableAssetEntry entry = settings.CreateOrMoveEntry(guid, group);
                        var addressStringBuilder = new StringBuilder();
                        foreach (var addressSubtitle in addressTitles)
                        {
                            if (addressStringBuilder.Length != 0)
                                addressStringBuilder.Append("/");
                            addressStringBuilder.Append(MarrowSDK.SanitizeName(addressSubtitle));
                        }

                        entry.address = addressStringBuilder.ToString();
                    }
                }
            }
        }

        public static void PackPalletContent() => PackPalletContent(out _);
        public static void PackPalletContent(out AddressablesPlayerBuildResult result)
        {
            var settings = AddressablesManager.Settings;
            AddressablesRuntimeProperties.ClearCachedPropertyValues();
            var ogBuilderIndex = settings.ActivePlayerDataBuilderIndex;
            var builderIndex = settings.DataBuilders.IndexOf(settings.DataBuilders.Find(s => s.GetType() == typeof(MarrowContentBuildScript)));
            settings.ActivePlayerDataBuilderIndex = builderIndex;
            AddressableAssetSettings.BuildPlayerContent(out result);
            settings.ActivePlayerDataBuilderIndex = ogBuilderIndex;
        }
    }
}