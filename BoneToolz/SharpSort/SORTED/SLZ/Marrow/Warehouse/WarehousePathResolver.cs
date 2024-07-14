 
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace SLZ.Marrow.Warehouse
{
    public static class WarehousePathResolver
    {
        private static Dictionary<string, string> cache = new Dictionary<string, string>();
        private static bool enableLogging = false;
        public static void Setup()
        {
            cache.Clear();
            Addressables.InternalIdTransformFunc = ResolvePath;
        }

        private static void Log(string message)
        {
            if (enableLogging)
                Debug.Log($"WarehousePathResolver: {message}");
        }

        private static void LogError(string message)
        {
            if (enableLogging)
                Debug.LogError($"WarehousePathResolver: {message}");
        }

        public static string EnsureValidPath(string path)
        {
            string returnPath = $"{path}";
            EnsureValidPath(ref returnPath);
            return returnPath;
        }

        public static void EnsureValidPath(ref string path)
        {
            if (path.Contains("\\"))
                path = path.Replace("\\", "/");
#if !UNITY_EDITOR && UNITY_ANDROID
#endif
        }

        static string ResolvePath(IResourceLocation location)
        {
            Log($"Initial: Path \"{location.InternalId}\"");
            try
            {
                if (location.ResourceType == typeof(IAssetBundleResource))
                {
                    if (cache.TryGetValue(location.InternalId, out var cachedPath))
                    {
                        Log($"Use Cached value: InternalId[{location.InternalId}], cachedPath[{cachedPath}]");
                        return cachedPath;
                    }

                    string newLocation = location.InternalId;
                    if (!newLocation.Contains("settingsassets"))
                    {
                        if (newLocation.StartsWith(SLZ.Marrow.MarrowSDK.RuntimeModsPath, System.StringComparison.Ordinal))
                        {
                            newLocation = location.InternalId.Replace("\\", "/");
                            var relativePath = Path.GetRelativePath(SLZ.Marrow.MarrowSDK.RuntimeModsPath, newLocation);
                            string palletBarcode = relativePath.Split('/')[0];
                            relativePath = string.Join('/', relativePath.Split('/').Skip(1));
                            if (AssetWarehouse.Instance.TryGetPalletManifest(palletBarcode, out var palletManifest))
                            {
                                var newRoot = Path.GetDirectoryName(palletManifest.CatalogPath);
                                newLocation = $"{newRoot}/{relativePath}";
                            }

                            Log($"Path \"{newLocation}\"  from ({location.InternalId})");
                        }
                        else if (newLocation.StartsWith("PALLET_BARCODE:"))
                        {
                            var arrSplit = newLocation.Split(':');
                            var palletBarcode = arrSplit[1];
                            var relativePath = arrSplit[2];
                            relativePath = relativePath.Substring(1, relativePath.Length - 1);
                            Log($"Pallet[{palletBarcode}] Path: \"{newLocation}\" \"{location.InternalId}\"");
                            if (AssetWarehouse.Instance.TryGetPalletManifest(palletBarcode, out var palletManifest))
                            {
                                newLocation = $"{Path.GetDirectoryName(palletManifest.CatalogPath)}/{relativePath}";
                            }
                            else
                            {
                                LogError($"Failed to find Pallet Manifest for {palletBarcode} for path \"{newLocation}\"");
                                return newLocation;
                            }
                        }
                    }

                    EnsureValidPath(ref newLocation);
                    if (newLocation != location.InternalId)
                        cache[location.InternalId] = newLocation;
                    Log($"Fixed: Path \"{newLocation}\"");
                    return newLocation;
                }
            }
            catch
            {
                return location.InternalId;
            }

            var locationText = location.InternalId;
            EnsureValidPath(ref locationText);
            Log($"Untouched: Path \"{locationText}\"");
            return locationText;
        }
    }
}