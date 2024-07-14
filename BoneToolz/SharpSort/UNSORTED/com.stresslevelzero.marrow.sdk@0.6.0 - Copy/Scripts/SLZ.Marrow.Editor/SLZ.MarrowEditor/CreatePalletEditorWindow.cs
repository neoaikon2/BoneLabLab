using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;
using SLZ.Marrow.Warehouse;
using System.IO;
using SLZ.Marrow;
using Cysharp.Threading.Tasks;
 
using System.Linq;

#if UNITY_EDITOR
namespace SLZ.MarrowEditor
{
    public class CreatePalletEditorWindow : EditorWindow
    {
        public string palletTitle = "My Pallet";
        public string palletAuthor = "Author";
        public static readonly string palletFolderName = "_Pallets";
        public static void ShowCreatePalletWindowEditor()
        {
            string palletImagePath = MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/pallet16.png");
            Texture2D palletIconImage = EditorGUIUtility.Load(palletImagePath) as Texture2D;
            EditorWindow createPalletWin = GetWindow<CreatePalletEditorWindow>();
            createPalletWin.titleContent = new GUIContent(" Create Pallet");
            createPalletWin.titleContent.image = palletIconImage;
            createPalletWin.minSize = new Vector2(400, 200);
        }

        public void CreateGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("af1a8ac6a7af0b347ba2dc089f25faf2");
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            tree.StretchToParentSize();
            rootVisualElement.Add(tree);
            IMGUIContainer imguiValidationContainer = tree.Q<IMGUIContainer>("imguiValidationContainer");
            TextField palletTitleTextField = tree.Q<TextField>("palletTitleTextField");
            palletTitleTextField.RegisterValueChangedCallback(evt =>
            {
                palletTitleTextField.value = MarrowSDK.SanitizeName(palletTitleTextField.value);
                palletTitle = palletTitleTextField.value;
            });
            TextField palletAuthorTextField = tree.Q<TextField>("palletAuthorTextField");
            palletAuthorTextField.RegisterValueChangedCallback(evt =>
            {
                palletAuthorTextField.value = MarrowSDK.SanitizeName(palletAuthorTextField.value);
                palletAuthor = palletAuthorTextField.value;
            });
            Button createPalletButton = tree.Q<Button>("createPalletButton");
            imguiValidationContainer.onGUIHandler = () =>
            {
                string errorString = "";
                if (string.IsNullOrEmpty(palletTitle))
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Pallet Title cannot be empty.";
                }

                if (string.IsNullOrEmpty(palletAuthor))
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Pallet Author cannot be empty.";
                }

                if (palletTitle == "My Pallet")
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Set the Pallet Title";
                }

                if (palletAuthor == "Author")
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Set the Pallet Author";
                }

                if (!string.IsNullOrEmpty(errorString))
                {
                    EditorGUILayout.HelpBox(errorString, MessageType.Error);
                    if (createPalletButton.enabledSelf)
                        createPalletButton.SetEnabled(false);
                }
                else
                {
                    if (!createPalletButton.enabledSelf)
                        createPalletButton.SetEnabled(true);
                }
            };
            createPalletButton.clickable.clicked += () =>
            {
                if (ValidateCreatePalletInput())
                {
                    Pallet pallet = Pallet.CreatePallet(palletTitle, palletAuthor);
                    if (AssetWarehouse.Instance.HasPallet(pallet.Barcode))
                    {
                        Debug.LogError("Pallet with this barcode already exists.  Aborting.");
                        return;
                    }

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
                    this.Close();
                }
            };
        }

        private bool ValidateCreatePalletInput()
        {
            if (!string.IsNullOrEmpty(palletTitle) && !string.IsNullOrEmpty(palletAuthor))
            {
                return true;
            }

            return false;
        }

        private async UniTaskVoid ReloadWarehouseAsync()
        {
            await AssetWarehouseWindow.ReloadWarehouse();
            if (AssetWarehouse.Instance.WorkingPallets.Count > 0)
            {
                Selection.activeObject = AssetWarehouse.Instance.WorkingPallets.First().Value;
            }
        }
    }
}
#endif
