 
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;

namespace SLZ.MarrowEditor
{
    public class DeduperTool
    {
        private const string GENERATED_DEDUPE_GROUP_NAME = "Duplicate Asset Isolation";
        private const string DEDUPE_GROUP_NAME = "Deduped";
        public enum StripOptions
        {
            None,
            Models,
            PartialAnimations
        }

        public static AddressableAssetGroup Dedupe(string buildPath, string loadPath, StripOptions stripOptions = StripOptions.PartialAnimations)
        {
            AddressableAssetGroup dedupeGroup = null;
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            AddressableAssetSettings settings = AddressablesManager.Settings;
            dedupeGroup = settings.FindGroup(DEDUPE_GROUP_NAME);
            if (dedupeGroup != null)
            {
                settings.RemoveGroup(dedupeGroup);
            }

            dedupeGroup = settings.FindGroup(GENERATED_DEDUPE_GROUP_NAME);
            if (dedupeGroup != null)
            {
                settings.RemoveGroup(dedupeGroup);
            }

            var dedupeRule = new UnityEditor.AddressableAssets.Build.AnalyzeRules.CheckBundleDupeDependencies();
            dedupeRule.FixIssues(settings);
            dedupeGroup = settings.FindGroup(GENERATED_DEDUPE_GROUP_NAME);
            if (dedupeGroup != null)
            {
                EditorUtility.SetDirty(dedupeGroup);
                dedupeGroup.Name = DEDUPE_GROUP_NAME;
                dedupeGroup.name = dedupeGroup.Name;
                List<string> addedAddresses = new List<string>();
                foreach (var entry in dedupeGroup.entries)
                {
                    if (entry.MainAsset != null)
                    {
                        string name = entry.MainAsset.name;
                        if (entry.MainAsset is Shader)
                        {
                            string path = AssetDatabase.GetAssetPath(entry.MainAsset);
                            if (!string.IsNullOrEmpty(path))
                            {
                                name = System.IO.Path.GetFileNameWithoutExtension(path);
                            }
                            else
                            {
                                name = entry.MainAsset.name.Substring(name.LastIndexOf("/") + 1, name.Length - name.LastIndexOf("/") - 1);
                            }
                        }

                        string address = entry.MainAsset.GetType().Name + "/" + name;
                        if (addedAddresses.Contains(address))
                        {
                            address += "--" + entry.guid.Substring(0, 8);
                        }

                        entry.SetAddress(address);
                        addedAddresses.Add(address);
                    }
                    else
                    {
                        Debug.LogError("Deduper: BAD entry in dedupe group! " + entry.address);
                        entry.SetAddress("NULL/DELETEME");
                    }
                }

                BundledAssetGroupSchema schema = dedupeGroup.GetSchema<BundledAssetGroupSchema>();
                schema.BundleMode = BundledAssetGroupSchema.BundlePackingMode.PackSeparately;
                schema.IncludeAddressInCatalog = false;
                AddressablesManager.SetCustomBuildPath(schema, buildPath);
                AddressablesManager.SetCustomLoadPath(schema, loadPath);
                var updateSchema = dedupeGroup.GetSchema<ContentUpdateGroupSchema>();
                updateSchema.StaticContent = false;
                Debug.Log("Deduper: Created Dedupe Group with " + dedupeGroup.entries.Count + " assets: " + string.Format("{0:hh\\:mm\\:ss}", timer.Elapsed));
                if (stripOptions != StripOptions.None)
                {
                    List<AddressableAssetEntry> strippers = new List<AddressableAssetEntry>();
                    foreach (var entry in dedupeGroup.entries)
                    {
                        bool strip = stripOptions.Equals(StripOptions.Models) && (entry.AssetPath.EndsWith(".fbx") || entry.AssetPath.EndsWith(".obj"));
                        if (stripOptions.Equals(StripOptions.PartialAnimations) && entry.AssetPath.Contains("@") && (entry.AssetPath.EndsWith(".fbx") || entry.AssetPath.EndsWith(".obj")))
                        {
                            strip = true;
                        }

                        if (strip)
                        {
                            strippers.Add(entry);
                        }
                    }

                    foreach (var entry in strippers)
                    {
                        dedupeGroup.RemoveAssetEntry(entry);
                    }

                    string strippedAssets = "";
                    foreach (var entry in strippers)
                    {
                        string extension = System.IO.Path.GetExtension(entry.AssetPath);
                        strippedAssets += "[" + entry.MainAssetType.Name + (!string.IsNullOrEmpty(extension) ? "/" + extension.Replace(".", "") : "") + "] " + entry.MainAsset.name + " (" + entry.AssetPath + ") \n";
                    }

                    Debug.Log("Deduper: Stripped " + strippers.Count + " Assets: \n" + strippedAssets);
                    if (strippers.Count > 0)
                        Debug.Log("Deduper: Stripped Dedupe Group now has " + dedupeGroup.entries.Count + " assets");
                }
            }

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            Debug.Log("Deduper: Finished dedupe! Took " + string.Format("{0:hh\\:mm\\:ss}", timer.Elapsed));
            return dedupeGroup;
        }
    }
}