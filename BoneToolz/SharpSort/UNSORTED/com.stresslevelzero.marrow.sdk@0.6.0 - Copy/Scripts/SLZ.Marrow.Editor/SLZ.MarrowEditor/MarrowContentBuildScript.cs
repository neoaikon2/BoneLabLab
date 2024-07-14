using System;
 
using System.Collections.Generic;
using System.IO;
 
 
using SLZ.Marrow;
using UnityEditor.AddressableAssets.Build.DataBuilders;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;
using UnityEngine;
using SLZ.Marrow.Warehouse;
 
 
using UnityEditor.AddressableAssets.Build;
using UnityEngine.AddressableAssets;
 
 
using UnityEngine.Build.Pipeline;

namespace SLZ.MarrowEditor
{
    [CreateAssetMenu(fileName = "MarrowContentBuildScript.asset", menuName = "Addressables/Content Builders/Marrow Content Build Script")]
    public class MarrowContentBuildScript : BuildScriptPackedMode
    {
        public override string Name
        {
            get
            {
                return "Marrow Content Build Script";
            }
        }

        public const string TempDirectory = "MarrowPersistedBuildContent";
        private MarrowSettings marrowGame;
        private Pallet contentPallet;
        private bool? _marrowGameBuild;
        public bool MarrowGameBuild => _marrowGameBuild.Value;

        private string _contentBuildPath;
        public string ContentBuildPath => _contentBuildPath;

        private List<Pallet> pallets;
        private bool InitCachedBuildValues(bool silentFail = false)
        {
            var palletsGroup = AddressablesManager.Settings.FindGroup("Pallets");
            if (palletsGroup == null)
            {
                if (silentFail)
                    return false;
                var ex = new Exception("MarrowContentBuildScript: FAILED, missing Pallets group");
                Debug.LogError(ex.Message);
                Debug.LogException(ex);
            }

            var palletSchema = palletsGroup.GetSchema<PalletGroupSchema>();
            if (palletSchema == null)
            {
                var ex = new Exception("MarrowContentBuildScript: FAILED, missing Pallets group schema");
                Debug.LogError(ex.Message);
                Debug.LogException(ex);
            }

            if (palletSchema.MarrowGame != null)
            {
                _marrowGameBuild = true;
                marrowGame = palletSchema.MarrowGame;
                _contentBuildPath = AddressablesManager.EvaluateProfileValueBuildPathForPallet(null, AddressablesManager.ProfileGamePalletID);
            }
            else if (palletSchema.Pallet != null)
            {
                _marrowGameBuild = false;
                contentPallet = palletSchema.Pallet;
                _contentBuildPath = AddressablesManager.EvaluateProfileValueBuildPathForPallet(palletSchema.Pallet, AddressablesManager.ProfilePalletID);
            }
            else
            {
                Debug.LogError("MarrowContentBuildScript: FAILED, missing PalletGroupSchema MarrowGame or Pallet reference");
                throw new Exception("MarrowContentBuildScript: FAILED, missing PalletGroupSchema MarrowGame or Pallet reference");
            }

            return true;
        }

        protected override string ProcessGroupSchema(AddressableAssetGroupSchema schema, AddressableAssetGroup assetGroup, AddressableAssetsBuildContext aaContext)
        {
            var palletDataSchema = schema as PalletGroupSchema;
            if (palletDataSchema != null && !assetGroup.HasSchema<BundledAssetGroupSchema>() && !assetGroup.HasSchema<ContentUpdateGroupSchema>() && !assetGroup.HasSchema<PlayerDataGroupSchema>())
                return ProcessPalletDataSchema(palletDataSchema, assetGroup, aaContext);
            return base.ProcessGroupSchema(schema, assetGroup, aaContext);
        }

        protected string ProcessPalletDataSchema(PalletGroupSchema schema, AddressableAssetGroup assetGroup, AddressableAssetsBuildContext aaContext)
        {
            try
            {
                string profileID = MarrowGameBuild ? AddressablesManager.ProfileGamePalletID : AddressablesManager.ProfilePalletID;
                foreach (var entry in assetGroup.entries)
                {
                    if (entry.MainAssetType == typeof(Pallet) && entry.MainAsset is Pallet pallet)
                    {
                        string palletPath = Path.Combine(AddressablesManager.EvaluateProfileValueBuildPathForPallet(pallet, profileID), $"{pallet.Barcode}.pallet.json");
                        PalletPacker.PackAndSaveToJson(pallet, palletPath);
                        pallets.Add(pallet);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                return e.ToString();
            }

            return String.Empty;
        }

        protected override string ProcessAllGroups(AddressableAssetsBuildContext aaContext)
        {
            var errorString = base.ProcessAllGroups(aaContext);
            return errorString;
        }

        protected override TResult BuildDataImplementation<TResult>(AddressablesDataBuilderInput builderInput)
        {
            var settings = builderInput.AddressableSettings;
            InitCachedBuildValues();
            ClearCachedData();
            pallets = new List<Pallet>();
            var palletsGroup = settings.FindGroup("Pallets");
            foreach (var entry in palletsGroup.entries)
            {
                if (entry.MainAssetType == typeof(Pallet) && entry.MainAsset is Pallet pallet)
                {
                    pallets.Add(pallet);
                }
            }

            ProjectConfigData.GenerateBuildLayout = true;
            TextureStreamTool.ApplyTextureStreamingToAllTextures();
            var result = base.BuildDataImplementation<TResult>(builderInput);
            return result;
        }

        protected override TResult DoBuild<TResult>(AddressablesDataBuilderInput builderInput, AddressableAssetsBuildContext aaContext)
        {
            Debug.Log("MarrowContentBuildScript: DoBuild");
            var result = base.DoBuild<TResult>(builderInput, aaContext);
#if false
#endif
            File.Delete(Path.Combine(Addressables.BuildPath, "catalog.json"));
            return result;
        }

        private static void ClearTempDirectory()
        {
            var tempFullPath = Path.Combine("Temp", "com.unity.addressables", TempDirectory);
            DirectoryInfo di = new DirectoryInfo(tempFullPath);
            if (di.Exists)
            {
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }

                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
        }

        protected override string ConstructAssetBundleName(AddressableAssetGroup assetGroup, BundledAssetGroupSchema schema, BundleDetails info, string assetBundleName)
        {
            string bundleName = base.ConstructAssetBundleName(assetGroup, schema, info, assetBundleName);
            return bundleName;
        }

        public override void ClearCachedData()
        {
            base.ClearCachedData();
            bool initialized = InitCachedBuildValues(true);
            if (initialized && Directory.Exists(ContentBuildPath))
            {
                try
                {
                    Directory.Delete(ContentBuildPath, true);
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }
            }
        }
    }
}