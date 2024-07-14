using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;
using SLZ.Marrow.Warehouse;
using UnityEditor.UIElements;
using SLZ.Marrow;
using Cysharp.Threading.Tasks;
using UnityEditor.SceneTemplate;

#if UNITY_EDITOR
namespace SLZ.MarrowEditor
{
    public class CreateLevelCrateEditorWindow : EditorWindow
    {
        public Barcode barcode = Barcode.EmptyBarcode();
        public Pallet pallet;
        public string levelTitle;
        public DropdownField createLevelSceneDropdown;
        public ObjectField customSceneObjectField;
        private bool validationPassed = true;
        private Crate tempCrate;
        public static void ShowCreateLevelCrateWindowEditor()
        {
            string levelImagePath = MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/crate-level16.png");
            Texture2D levelIconImage = EditorGUIUtility.Load(levelImagePath) as Texture2D;
            EditorWindow createLevelCrateWin = GetWindow<CreateLevelCrateEditorWindow>();
            createLevelCrateWin.titleContent = new GUIContent(" Create Level Crate");
            createLevelCrateWin.titleContent.image = levelIconImage;
            createLevelCrateWin.minSize = new Vector2(400, 210);
        }

        public void CreateGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("f633a274391168a43a3f0fbc1c58e59b");
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            tree.StretchToParentSize();
            rootVisualElement.Add(tree);
            TextField barcodeField = tree.Q<TextField>("barcodeField");
            TextField crateTitleTextField = tree.Q<TextField>("crateTitleTextField");
            crateTitleTextField.RegisterValueChangedCallback(evt =>
            {
                crateTitleTextField.value = MarrowSDK.SanitizeName(crateTitleTextField.value);
                levelTitle = crateTitleTextField.value;
                GenerateCrateTitleAndBarcode(barcodeField, crateTitleTextField);
            });
            ObjectField createCratePalletField = tree.Q<ObjectField>("createCratePalletField");
            createCratePalletField.RegisterValueChangedCallback(evt =>
            {
                pallet = (Pallet)createCratePalletField.value;
                if (createCratePalletField.value == null)
                {
                    pallet = null;
                }

                GenerateCrateTitleAndBarcode(barcodeField, crateTitleTextField);
            });
            customSceneObjectField = tree.Q<ObjectField>("customSceneObjectField");
            customSceneObjectField.RegisterValueChangedCallback(evt =>
            {
                crateTitleTextField.value = evt.newValue.name;
            });
            createLevelSceneDropdown = tree.Q<DropdownField>("createLevelSceneDropdown");
            createLevelSceneDropdown.RegisterValueChangedCallback(evt =>
            {
                if (createLevelSceneDropdown.index == 0)
                {
                    customSceneObjectField.style.display = DisplayStyle.None;
                }
                else
                {
                    customSceneObjectField.style.display = DisplayStyle.Flex;
                }
            });
            Button createLevelCrateButton = tree.Q<Button>("createLevelCrateButton");
            createLevelCrateButton.clickable.clicked += () =>
            {
                if (ValidateCreateLevelCrateInput() && validationPassed)
                {
                    string newScenePath = $"{MarrowSDK.GetMarrowAssetsPath("Levels", MarrowSDK.SanitizeName(levelTitle))}.unity";
                    if (createLevelSceneDropdown.index == 0)
                    {
                        newScenePath = $"{MarrowSDK.GetMarrowAssetsPath("Levels", MarrowSDK.SanitizeName(levelTitle))}.unity";
                        SceneTemplateAsset marrowSceneTemplate = AssetDatabase.LoadAssetAtPath<SceneTemplateAsset>(MarrowSDK.GetPackagePath("Editor/Assets/Scene Template/Default Marrow SceneTemplate.scenetemplate"));
                        SceneTemplateService.Instantiate(marrowSceneTemplate, false, newScenePath);
                    }
                    else
                    {
                        string customSceneObjectPath = AssetDatabase.GetAssetPath(customSceneObjectField.value);
                        newScenePath = $"{customSceneObjectPath}";
                    }

                    var sceneGuid = AssetDatabase.GUIDFromAssetPath(newScenePath).ToString();
                    LevelCrate levelCrate = Crate.CreateCrate(typeof(LevelCrate), pallet, levelTitle, new MarrowScene(sceneGuid)) as LevelCrate;
                    string palletPath = AssetDatabase.GetAssetPath(pallet);
                    palletPath = System.IO.Path.GetDirectoryName(palletPath);
                    string crateAssetFilename = levelCrate.GetAssetFilename();
                    string crateAssetPath = System.IO.Path.Combine(palletPath, crateAssetFilename);
                    AssetDatabase.CreateAsset(levelCrate, crateAssetPath);
                    pallet.Crates.Add(levelCrate);
                    EditorUtility.SetDirty(pallet);
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();
                    AssetWarehouseWindow.ReloadWarehouse().Forget();
                    if (createLevelSceneDropdown.index != 0)
                    {
                        var sceneAtPath = AssetDatabase.LoadMainAssetAtPath(newScenePath);
                        AssetDatabase.OpenAsset(sceneAtPath);
                    }

                    this.Close();
                }
            };
            IMGUIContainer imguiValidationContainer = tree.Q<IMGUIContainer>("imguiValidationContainer");
            imguiValidationContainer.onGUIHandler = () =>
            {
                string errorString = "";
                if (string.IsNullOrEmpty(levelTitle))
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Level Crate Title cannot be empty.";
                }

                if (pallet == null)
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Pallet cannot be empty.";
                }

                if (createLevelSceneDropdown.index != 0 && customSceneObjectField.value == null)
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "The Custom Scene cannot be empty.";
                }

                if (!string.IsNullOrEmpty(levelTitle) && pallet != null)
                {
                    if (AssetWarehouse.Instance.HasCrate(pallet.Barcode + ".Level." + MarrowSDK.SanitizeID(levelTitle)))
                    {
                        if (!string.IsNullOrEmpty(errorString))
                            errorString += "\n";
                        errorString += "Level already exists with that Title.";
                    }

                    if (levelTitle == "My Level Crate")
                    {
                        errorString += "Set the level title";
                    }
                }

                if (!string.IsNullOrEmpty(errorString))
                {
                    EditorGUILayout.HelpBox(errorString, MessageType.Error);
                    validationPassed = false;
                    if (createLevelCrateButton.enabledSelf)
                        createLevelCrateButton.SetEnabled(false);
                }
                else
                {
                    validationPassed = true;
                    if (!createLevelCrateButton.enabledSelf)
                        createLevelCrateButton.SetEnabled(true);
                }
            };
            SetDefaults(crateTitleTextField, createCratePalletField);
        }

        private void GenerateCrateTitleAndBarcode(TextField barcodeField, TextField crateTitleTextField)
        {
            if (pallet != null && !string.IsNullOrEmpty(levelTitle))
            {
                if (tempCrate == null)
                {
                    tempCrate = Crate.CreateCrate(typeof(LevelCrate), pallet, levelTitle, null);
                }
                else
                {
                    tempCrate.Pallet = pallet;
                    tempCrate.Title = levelTitle;
                    tempCrate.GenerateBarcode(true);
                }

                barcode = new Barcode(tempCrate.Barcode);
                barcodeField.value = barcode;
            }
            else
            {
                barcode = null;
                if (pallet == null)
                {
                    barcodeField.value = "INVALID - Needs Pallet";
                }

                if (string.IsNullOrEmpty(levelTitle))
                {
                    barcodeField.value = "INVALID - Needs Level Title";
                }
            }
        }

        private bool ValidateCreateLevelCrateInput()
        {
            if (!string.IsNullOrEmpty(levelTitle) && pallet != null)
            {
                if (createLevelSceneDropdown.index == 0)
                {
                    return true;
                }
                else
                {
                    if (customSceneObjectField.value != null)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void SetDefaults(TextField crateTitleTextField, ObjectField createCratePalletField)
        {
            createLevelSceneDropdown.index = 0;
            customSceneObjectField.style.display = DisplayStyle.None;
            if (!string.IsNullOrEmpty(levelTitle))
            {
                crateTitleTextField.value = levelTitle;
            }
            else
            {
                levelTitle = crateTitleTextField.value;
            }

            foreach (var selected in Selection.objects)
            {
                if (selected != null && selected.GetType() == typeof(Pallet))
                {
                    pallet = (Pallet)selected;
                }
            }

            if (pallet == null)
            {
                var palletGuids = AssetDatabase.FindAssets("t:Pallet");
                if (palletGuids.Length > 0)
                {
                    var path = AssetDatabase.GUIDToAssetPath(palletGuids[0]);
                    pallet = AssetDatabase.LoadAssetAtPath<Pallet>(path);
                }
            }

            createCratePalletField.value = pallet;
        }
    }
}
#endif
