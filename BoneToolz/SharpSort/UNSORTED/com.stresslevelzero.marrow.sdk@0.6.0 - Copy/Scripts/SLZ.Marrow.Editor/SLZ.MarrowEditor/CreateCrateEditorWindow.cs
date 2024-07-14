using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;
using SLZ.Marrow.Warehouse;
using System.Collections.Generic;
using UnityEditor.UIElements;
using SLZ.Marrow;
using Cysharp.Threading.Tasks;
 
using System.Linq;

#if UNITY_EDITOR
namespace SLZ.MarrowEditor
{
    public class CreateCrateEditorWindow : EditorWindow
    {
        public enum CrateType
        {
            SPAWNABLE_CRATE,
            LEVEL_CRATE,
            AVATAR_CRATE,
            VFX_CRATE
        }

        public Barcode barcode = Barcode.EmptyBarcode();
        public Pallet pallet;
        public CrateType crateType;
        public string crateTitle = "";
        public UnityEngine.Object assetReference;
        private Dictionary<System.Type, System.Type> assetTypeCache;
        private Crate tempCrate;
        public static void ShowCreateCrateWindowEditor()
        {
            EditorWindow createCrateWin = GetWindow<CreateCrateEditorWindow>();
            createCrateWin.titleContent = new GUIContent("Create Crate");
            createCrateWin.minSize = new Vector2(400, 300);
        }

        public void CreateGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("53459f0137ff4f74d89ec29407e6100d");
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            tree.StretchToParentSize();
            rootVisualElement.Add(tree);
            TextField barcodeField = tree.Q<TextField>("barcodeField");
            TextField crateTitleTextField = tree.Q<TextField>("crateTitleTextField");
            crateTitleTextField.RegisterValueChangedCallback(evt =>
            {
                crateTitleTextField.value = MarrowSDK.SanitizeName(crateTitleTextField.value);
                crateTitle = crateTitleTextField.value;
                GenerateCrateTitleAndBarcode(barcodeField, crateTitleTextField);
            });
            ObjectField createCratePalletField = tree.Q<ObjectField>("createCratePalletField");
            createCratePalletField.RegisterValueChangedCallback(evt =>
            {
                pallet = (Pallet)createCratePalletField.value;
                GenerateCrateTitleAndBarcode(barcodeField, crateTitleTextField);
            });
            ObjectField assetReferenceField = tree.Q<ObjectField>("assetReferenceField");
            assetReferenceField.allowSceneObjects = false;
            assetReferenceField.RegisterValueChangedCallback(evt =>
            {
                assetReference = assetReferenceField.value;
                GenerateCrateTitleAndBarcode(barcodeField, crateTitleTextField);
            });
            EnumField crateTypeEnumField = tree.Q<EnumField>("crateTypeEnumField");
            crateTypeEnumField.RegisterValueChangedCallback(evt =>
            {
                crateType = (CrateType)crateTypeEnumField.value;
                if (crateType == CrateType.SPAWNABLE_CRATE)
                {
                    assetReferenceField.objectType = typeof(GameObject);
                }
                else if (crateType == CrateType.LEVEL_CRATE)
                {
                    assetReferenceField.objectType = typeof(SceneAsset);
                }
                else if (crateType == CrateType.AVATAR_CRATE)
                {
                    assetReferenceField.objectType = typeof(GameObject);
                }
                else if (crateType == CrateType.VFX_CRATE)
                {
                    assetReferenceField.objectType = typeof(GameObject);
                }

                GenerateCrateTitleAndBarcode(barcodeField, crateTitleTextField);
            });
            UnityEngine.UIElements.Button createCrateButton = tree.Q<UnityEngine.UIElements.Button>("createCrateButton");
            createCrateButton.clickable.clicked += () =>
            {
                if (ValidateCreateCrateInput())
                {
                    System.Type type = GetCrateType(crateType);
                    if (type != null)
                    {
                        string assetPath = AssetDatabase.GetAssetPath(assetReference);
                        MarrowAsset crateAssetReference = null;
                        if (!string.IsNullOrEmpty(assetPath))
                        {
                            string guid = AssetDatabase.AssetPathToGUID(assetPath);
                            if (!string.IsNullOrEmpty(guid))
                            {
                                crateAssetReference = new MarrowAsset(guid);
                            }
                        }

                        if (crateAssetReference != null)
                        {
                            Crate crate = Crate.CreateCrate(type, pallet, crateTitle, crateAssetReference);
                            string palletPath = AssetDatabase.GetAssetPath(pallet);
                            palletPath = System.IO.Path.GetDirectoryName(palletPath);
                            string crateAssetFilename = crate.GetAssetFilename();
                            string crateAssetPath = System.IO.Path.Combine(palletPath, crateAssetFilename);
                            AssetDatabase.CreateAsset(crate, crateAssetPath);
                            pallet.Crates.Add(crate);
                            EditorUtility.SetDirty(pallet);
                            AssetDatabase.SaveAssets();
                            AssetDatabase.Refresh();
                            ReloadWarehouseAsync().Forget();
                        }
                        else
                        {
                            Debug.LogError("Invalid Asset");
                        }
                    }
                }
            };
            IMGUIContainer imguiValidationContainer = tree.Q<IMGUIContainer>("imguiValidationContainer");
            imguiValidationContainer.onGUIHandler = () =>
            {
                string errorString = "";
                if (string.IsNullOrEmpty(crateTitle))
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Crate Title cannot be empty.";
                }

                if (pallet == null)
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Pallet cannot be empty.";
                }

                if (assetReference == null)
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Asset Reference cannot be empty.";
                }
                else if (!AssetDatabase.Contains(assetReference))
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Invalid Asset Reference.";
                }
                else
                {
                    System.Type assetType = GetCrateAssetType(GetCrateType(crateType));
                    if (assetType != assetReference.GetType())
                    {
                        if (!string.IsNullOrEmpty(errorString))
                            errorString += "\n";
                        errorString += "Asset Reference must be a " + assetType.Name;
                    }
                    else
                    {
                        if ((CrateType)crateTypeEnumField.value == CrateType.AVATAR_CRATE)
                        {
                            if ((assetReference as GameObject).GetComponent<Avatar>() == null)
                            {
                                if (!string.IsNullOrEmpty(errorString))
                                    errorString += "\n";
                                errorString += "Asset Reference must have an Avatar component.";
                            }
                        }
                    }
                }

                if (!Barcode.IsValidSize(barcode))
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Barcode too long! Max length is " + Barcode.MAX_SIZE;
                }

                if (AssetWarehouse.Instance.HasCrate(barcode))
                {
                    if (!string.IsNullOrEmpty(errorString))
                        errorString += "\n";
                    errorString += "Crate already exists with that Barcode!";
                }

                if (!string.IsNullOrEmpty(errorString))
                    EditorGUILayout.HelpBox(errorString, MessageType.Error);
            };
            SetDefaults(barcodeField, crateTitleTextField, crateTypeEnumField, createCratePalletField, assetReferenceField);
            GenerateCrateTitleAndBarcode(barcodeField, crateTitleTextField);
        }

        private void GenerateCrateTitleAndBarcode(TextField barcodeField, TextField crateTitleTextField)
        {
            System.Type assetType = GetCrateAssetType(GetCrateType(crateType));
            if (assetReference != null && assetType == assetReference.GetType())
            {
                if (string.IsNullOrEmpty(crateTitle))
                {
                    crateTitle = ObjectNames.NicifyVariableName(assetReference.name);
                    crateTitleTextField.value = crateTitle;
                }
            }

            if (pallet != null && !string.IsNullOrEmpty(crateTitle) && assetReference != null)
            {
                tempCrate = Crate.CreateCrate(GetCrateType(crateType), pallet, crateTitle, null);
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

                if (string.IsNullOrEmpty(crateTitle))
                {
                    barcodeField.value = "INVALID - Needs Crate Title";
                }

                if (assetReference == null)
                {
                    barcodeField.value = "INVALID - Needs Asset Reference";
                }
            }
        }

        private bool ValidateCreateCrateInput()
        {
            if (!string.IsNullOrEmpty(crateTitle) && assetReference != null && pallet != null)
            {
                if (crateType == CrateType.AVATAR_CRATE && (assetReference as GameObject).GetComponent<Avatar>() == null)
                {
                    return false;
                }

                if (crateType == CrateType.LEVEL_CRATE && assetReference is not SceneAsset)
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        private void SetDefaults(TextField barcodeField, TextField crateTitleTextField, EnumField crateTypeEnumField, ObjectField createCratePalletField, ObjectField assetReferenceField)
        {
            if (!string.IsNullOrEmpty(barcode))
            {
                barcodeField.value = barcode;
            }

            if (!string.IsNullOrEmpty(crateTitle))
            {
                crateTitleTextField.value = crateTitle;
            }
            else
            {
                crateTitle = crateTitleTextField.value;
            }

            if (assetReferenceField.value == null)
            {
                assetReference = null;
            }

            foreach (var selected in Selection.objects)
            {
                if (selected != null && selected.GetType() == typeof(Pallet))
                {
                    pallet = (Pallet)selected;
                }
                else if (selected != null && selected.GetType() != typeof(Pallet))
                {
                    if (selected.GetType() == typeof(SceneAsset))
                    {
                        crateTypeEnumField.value = CrateType.LEVEL_CRATE;
                    }
                    else if (selected.GetType() == typeof(GameObject))
                    {
                        if ((selected as GameObject).GetComponent("SLZ.VRMK.Avatar"))
                        {
                            crateTypeEnumField.value = CrateType.AVATAR_CRATE;
                        }
                        else
                        {
                            crateTypeEnumField.value = CrateType.SPAWNABLE_CRATE;
                        }
                    }

                    if (AssetDatabase.Contains(selected))
                    {
                        assetReference = selected;
                        crateTitle = ObjectNames.NicifyVariableName(selected.name);
                    }
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
            else
            {
                createCratePalletField.value = pallet;
            }

            crateType = (CrateType)crateTypeEnumField.value;
            if (crateType == CrateType.SPAWNABLE_CRATE)
            {
                assetReferenceField.objectType = typeof(GameObject);
            }
            else if (crateType == CrateType.LEVEL_CRATE)
            {
                assetReferenceField.objectType = typeof(SceneAsset);
            }
            else if (crateType == CrateType.AVATAR_CRATE)
            {
                assetReferenceField.objectType = typeof(GameObject);
            }
            else if (crateType == CrateType.VFX_CRATE)
            {
                assetReferenceField.objectType = typeof(GameObject);
            }
        }

        public System.Type GetCrateType(CrateType type)
        {
            switch (type)
            {
                case CrateType.SPAWNABLE_CRATE:
                    return typeof(SpawnableCrate);
                case CrateType.LEVEL_CRATE:
                    return typeof(LevelCrate);
                case CrateType.AVATAR_CRATE:
                    return typeof(AvatarCrate);
                case CrateType.VFX_CRATE:
                    return typeof(VFXCrate);
                default:
                    return null;
            }
        }

        public CrateType GetCrateType(System.Type type)
        {
            if (type == typeof(SpawnableCrate))
            {
                return CrateType.SPAWNABLE_CRATE;
            }
            else if (type == typeof(LevelCrate))
            {
                return CrateType.LEVEL_CRATE;
            }
            else if (type == typeof(AvatarCrate))
            {
                return CrateType.AVATAR_CRATE;
            }
            else if (type == typeof(VFXCrate))
            {
                return CrateType.VFX_CRATE;
            }

            return CrateType.SPAWNABLE_CRATE;
        }

        public System.Type GetCrateAssetType(System.Type type)
        {
            if (assetTypeCache == null)
            {
                assetTypeCache = new Dictionary<System.Type, System.Type>();
                Crate crate = ScriptableObject.CreateInstance<SpawnableCrate>();
                assetTypeCache[typeof(SpawnableCrate)] = crate.AssetType;
                crate = ScriptableObject.CreateInstance<LevelCrate>();
                assetTypeCache[typeof(LevelCrate)] = crate.AssetType;
                crate = ScriptableObject.CreateInstance<AvatarCrate>();
                assetTypeCache[typeof(AvatarCrate)] = crate.AssetType;
                crate = ScriptableObject.CreateInstance<VFXCrate>();
                assetTypeCache[typeof(VFXCrate)] = crate.AssetType;
            }

            if (assetTypeCache.TryGetValue(type, out var assetType))
            {
                return assetType;
            }
            else
            {
                return null;
            }
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
