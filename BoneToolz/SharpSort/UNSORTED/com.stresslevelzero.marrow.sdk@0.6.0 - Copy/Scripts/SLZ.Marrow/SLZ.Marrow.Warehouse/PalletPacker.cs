using System.IO;
using Cysharp.Threading.Tasks;
using UnityEngine;
using SLZ.Serialize;
using Newtonsoft.Json.Linq;
 
using UnityEngine.Networking;

namespace SLZ.Marrow.Warehouse
{
    public class PalletPacker
    {
        public static bool ValidatePallet(Pallet pallet)
        {
            bool valid = true;
            if (pallet == null)
            {
                valid = false;
                Debug.LogWarning("PalletPacker Validate: Failed, pallet is null");
            }

            if (pallet.Barcode == null)
            {
                valid = false;
                Debug.LogWarning("PalletPacker Validate: Failed, pallet barcode is null");
            }

            if (string.IsNullOrEmpty(pallet.Title))
            {
                valid = false;
                Debug.LogWarning("PalletPacker Validate: Failed, pallet title is empty");
            }

            if (string.IsNullOrEmpty(pallet.Author))
            {
                valid = false;
                Debug.LogWarning("PalletPacker Validate: Failed, pallet author is empty");
            }

            if (pallet.Barcode == Barcode.EMPTY)
            {
                valid = false;
                Debug.LogWarning("PalletPacker Validate: Failed, pallet barcode is empty, generate now");
            }

            return valid;
        }

        public static void PackAndSaveToJson(Pallet pallet, string savePath)
        {
            string json = PackIntoJson(pallet);
            string path = savePath;
#if UNITY_EDITOR
            if (string.IsNullOrEmpty(path))
            {
                path = Path.Combine(Directory.GetParent(Application.dataPath).ToString(), MarrowSDK.BUILT_PALLETS_NAME, pallet.Title + ".json");
            }

#endif
            if (!Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.WriteAllText(path, json);
        }

        public static string PackIntoJson(Pallet pallet)
        {
            string json = "";
            if (ValidatePallet(pallet))
            {
                var store = ObjectStore.Builder.WithMarrowDefaults().Build();
                store.TryPack(pallet, out JObject obj);
                json = obj.ToString();
            }

            return json;
        }

        public static Pallet UnpackJsonFromFile(string path)
        {
            Pallet pallet = null;
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                pallet = UnpackJson(json);
            }
            else
            {
                Debug.LogError("PalletPacker UnpackJsonFromFile: Could not find file " + path);
            }

            return pallet;
        }

        public static async UniTask<Pallet> UnpackJsonFromFileAndroid(string path)
        {
            Pallet pallet = null;
            if (path.StartsWith("jar"))
            {
                try
                {
                    using var webRequest = UnityWebRequest.Get(path);
                    var download = await webRequest.SendWebRequest();
                    var json = download.downloadHandler.text;
                    pallet = UnpackJson(json);
                }
                catch (System.Exception e)
                {
                    Debug.Log($"PalletPacker UnpackJsonFromFileAndroid: Failed to load pallet json from path: {path}: Exception: {e.Message}");
                    Debug.LogException(e);
                }
            }
            else
            {
                pallet = UnpackJsonFromFile(path);
            }

            return pallet;
        }

        public static Pallet UnpackJson(string palletJson)
        {
            Pallet pallet = null;
            JObject obj = JObject.Parse(palletJson);
            var store = ObjectStore.Builder.WithMarrowDefaults().WithJsonDocument(obj).Build();
            store.LoadTypes(obj["types"] as JObject);
            pallet = ScriptableObject.CreateInstance<Pallet>();
            try
            {
                pallet.Unpack(store, obj["root"]["ref"].ToObject<string>());
            }
            catch (System.Exception)
            {
                UnityEngine.Object.DestroyImmediate(pallet);
                return null;
            }

            return pallet;
        }

        public static bool TryUnpackManifestJsonFromFile(string path, out PalletManifest palletManifest, out string palletManifestJson)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                palletManifest = UnpackManifestJson(json);
                palletManifestJson = json;
                return true;
            }
            else
            {
                palletManifest = null;
                palletManifestJson = null;
                return false;
            }
        }

        public static PalletManifest UnpackManifestJson(string palletManifestJson)
        {
            PalletManifest palletManifest = null;
            JObject obj = JObject.Parse(palletManifestJson);
            var store = ObjectStore.Builder.WithMarrowDefaults().WithJsonDocument(obj).Build();
            store.LoadTypes(obj["types"] as JObject);
            var root = obj["root"];
            store.TryCreateFromReference(root, out palletManifest, PalletManifest.CreateManifest);
            return palletManifest;
        }

        public static bool TryPackManifestAndSaveToJson(PalletManifest palletManifest, string savePath, string palletManifestJson = null)
        {
            bool success = true;
            string json = palletManifestJson;
            if (string.IsNullOrEmpty(json))
                json = PackManifestIntoJson(palletManifest);
            string manifestPath = savePath;
            if (string.IsNullOrEmpty(manifestPath))
            {
                manifestPath = PalletManifest.GetManifestPath(palletManifest.Pallet);
            }

            try
            {
                File.WriteAllText(manifestPath, json);
            }
            catch (System.Exception e)
            {
                success = false;
                Debug.LogError($"PalletPacker TryPackManifestAndSaveToJson: Could not save file to {manifestPath}");
                Debug.LogException(e);
            }

            return success;
        }

        public static string PackManifestIntoJson(PalletManifest palletManifest)
        {
            string json = "";
            var store = ObjectStore.Builder.WithMarrowDefaults().Build();
            store.TryPack(palletManifest, out JObject obj);
            json = obj.ToString();
            return json;
        }

        public static bool TryUnpackMarrowGameJsonFromFile(string path, out MarrowSettings marrowGame, out string marrowGameJson)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                marrowGame = UnpackMarrowGameJson(json);
                marrowGameJson = json;
                return true;
            }
            else
            {
                marrowGame = null;
                marrowGameJson = null;
                return false;
            }
        }

        public static MarrowSettings UnpackMarrowGameJson(string marrowGameJson)
        {
            MarrowSettings marrowGame = null;
            JObject obj = JObject.Parse(marrowGameJson);
            var store = ObjectStore.Builder.WithMarrowDefaults().WithJsonDocument(obj).Build();
            store.LoadTypes(obj["types"] as JObject);
            var root = obj["root"];
            store.TryCreateFromReference(root, out marrowGame, type => ScriptableObject.CreateInstance<MarrowSettings>());
            return marrowGame;
        }
    }
}