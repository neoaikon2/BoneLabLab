 
 
 
using System.IO;
using System.Linq;
using Cysharp.Threading.Tasks;
using SLZ.Marrow;
using UnityEditor;
using SLZ.Marrow.Warehouse;

namespace SLZ.MarrowEditor
{
    public class PalletWizard : ScriptableWizard
    {
        public string palletTitle = "My Pallet";
        public string palletAuthor = "Author";
        public static readonly string palletFolderName = "_Pallets";
        public static void CreateWizard()
        {
            var wizard = ScriptableWizard.DisplayWizard<PalletWizard>("Create Pallet", "Create");
            wizard.helpString = "";
            wizard.errorString = "";
            wizard.OnWizardUpdate();
        }

        void OnWizardCreate()
        {
            Pallet pallet = Pallet.CreatePallet(palletTitle, palletAuthor);
            if (!Directory.Exists(MarrowSDK.GetMarrowAssetsPath(palletFolderName, pallet.Barcode)))
            {
                Directory.CreateDirectory(MarrowSDK.GetMarrowAssetsPath(palletFolderName, pallet.Barcode));
            }

            string palletAssetFileName = pallet.GetAssetFilename();
            string crateAssetPath = MarrowSDK.GetMarrowAssetsPath(palletFolderName, pallet.Barcode, palletAssetFileName);
            AssetDatabase.CreateAsset(pallet, crateAssetPath);
            EditorUtility.SetDirty(pallet);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            ReloadWarehouseAsync().Forget();
        }

        private async UniTaskVoid ReloadWarehouseAsync()
        {
            await AssetWarehouseWindow.ReloadWarehouse();
            if (AssetWarehouse.Instance.WorkingPallets.Count > 0)
            {
                Selection.activeObject = AssetWarehouse.Instance.WorkingPallets.First().Value;
            }
        }

        void OnWizardUpdate()
        {
            helpString = "A Pallet is the structure contains your Crates of various types.\n\nPallets can refer to the contents of other Pallets through dependencies.\n\nWarning! This Title and Author cannot be changed later, make sure it is what you want!";
            errorString = "";
            if (string.IsNullOrEmpty(palletTitle))
            {
                errorString += "Missing Title!";
            }

            if (string.IsNullOrEmpty(palletAuthor))
            {
                if (!string.IsNullOrEmpty(errorString))
                    errorString += "\n";
                errorString += "Missing Author!";
            }

            isValid = string.IsNullOrEmpty(errorString);
        }
    }
}