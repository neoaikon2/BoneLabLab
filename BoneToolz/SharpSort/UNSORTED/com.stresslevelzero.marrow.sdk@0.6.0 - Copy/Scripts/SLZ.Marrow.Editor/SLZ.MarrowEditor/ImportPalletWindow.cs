 
 
using System.IO;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;

namespace SLZ.MarrowEditor
{
    public class ImportPalletWindow : EditorWindow
    {
        private static readonly string PALLET_DEPENDENCIES_DIRNAME = "Pallet Dependencies";
        private static string lastPath = "";
        public static async UniTask<Pallet> LoadPalletFromFolder()
        {
            string openAtPath = lastPath;
            if (string.IsNullOrEmpty(openAtPath))
            {
                openAtPath = MarrowSDK.RuntimeModsPath;
            }

            string path = EditorUtility.OpenFilePanel("Select " + Pallet.PALLET_JSON_FILENAME, openAtPath, "json");
            Pallet loadedPallet = null;
            if (!string.IsNullOrEmpty(path))
            {
                lastPath = Path.GetDirectoryName(path);
                Pallet pallet = PalletPacker.UnpackJsonFromFile(path);
                if (pallet != null)
                {
                    Barcode palletBarcode = new Barcode(pallet.Barcode);
                    DestroyImmediate(pallet);
                    await AssetWarehouse.Instance.LoadPalletFromFolderAsync(path);
                    AssetWarehouse.Instance.TryGetPallet(palletBarcode, out loadedPallet);
                }
                else
                {
                    EditorUtility.DisplayDialog("Import Pallet", "Pallet could not be read from the file: " + path, "Ok");
                }
            }

            return loadedPallet;
        }
    }
}