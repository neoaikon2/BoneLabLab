using System;
 
using System.Collections.Generic;
using System.IO;
using Cysharp.Threading.Tasks;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

 

namespace SLZ.MarrowEditor
{
    public class DataCardCreatorEditor : EditorWindow
    {
        private VisualElement root;
        private VisualTreeAsset windowAsset;
        private DataCard dataCard;
        public Type dataCardType;
        private SerializedObject serializedObject;
        private bool validData = false;
        private bool created = false;
        public static void ShowWindow(Pallet pallet = null)
        {
            var window = GetWindow<DataCardCreatorEditor>("Create DataCard");
            window.Initialize(typeof(DataCard), pallet);
            window.Show();
        }

        public static void ShowWindowBoneTag(Pallet pallet = null)
        {
            var window = GetWindow<DataCardCreatorEditor>("Create DataCard");
            window.Initialize(typeof(BoneTag), pallet);
            window.Show();
        }

        public static void ShowWindowMonoDisc(Pallet pallet = null)
        {
            var window = GetWindow<DataCardCreatorEditor>("Create DataCard");
            window.Initialize(typeof(MonoDisc), pallet);
            window.Show();
        }

        public static void ShowWindow(Type dataCardType, Action<DataCard> onCreate = null)
        {
            if (typeof(DataCard).IsAssignableFrom(dataCardType))
            {
                var window = GetWindow<DataCardCreatorEditor>("Create DataCard");
                window.Initialize(dataCardType);
                if (onCreate != null)
                    window.OnCreate += onCreate;
                window.Show();
            }
        }

        public Action<DataCard> OnCreate;
        public void Initialize(Type dataCardTypeInput = null, Pallet pallet = null)
        {
            dataCardType = dataCardTypeInput;
            if (dataCardType == null)
                dataCardType = typeof(MonoDisc);
            titleContent = new GUIContent($"Create {dataCardType.Name}", AssetWarehouseTreeView.GetIconForMonoScript(dataCardType));
            dataCard = ScriptableObject.CreateInstance(dataCardType) as DataCard;
            if (pallet != null)
                dataCard.Pallet = pallet;
            if (dataCard.Pallet == null)
            {
                var guids = AssetDatabase.FindAssets("t:Pallet", new[] { MarrowSDK.GetMarrowAssetsPath(PalletWizard.palletFolderName) });
                if (guids.Length > 0)
                {
                    pallet = dataCard.Pallet = AssetDatabase.LoadAssetAtPath<Pallet>(AssetDatabase.GUIDToAssetPath(guids[0]));
                }
            }

            serializedObject = new SerializedObject(dataCard);
            root.Q<ObjectField>("pallet").value = dataCard.Pallet;
            root.Q<PropertyField>("barcode").Bind(serializedObject);
            root.Q<PropertyField>("title").Bind(serializedObject);
            root.Q<PropertyField>("description").Bind(serializedObject);
            CreatePropertiesGUI(root.Q("datacardFields"));
        }

        public void OnEnable()
        {
            windowAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(AssetDatabase.GUIDToAssetPath("c23a1f389c3051f41a0b09466904bde6"));
        }

        public void CreateGUI()
        {
            root = rootVisualElement;
            root.Add(windowAsset.Instantiate());
            root.Q<PropertyField>("barcode").SetEnabled(false);
            root.Q<ObjectField>("pallet").objectType = typeof(Pallet);
            root.Q<ObjectField>("pallet").RegisterValueChangedCallback(Validate);
            root.Q<ObjectField>("pallet").RegisterValueChangedCallback(PalletChangedValue);
            root.Q<PropertyField>("title").RegisterValueChangeCallback(Validate);
            root.Q<PropertyField>("title").RegisterValueChangeCallback(TitleChangedValue);
            root.Q<Button>("Create").clickable.clicked += CreateDataCardAsset;
        }

        private void PalletChangedValue(ChangeEvent<Object> evt)
        {
            var pallet = evt.newValue as Pallet;
            dataCard.Pallet = pallet;
            GenerateBarcode();
        }

        private void TitleChangedValue(EventBase arg)
        {
            GenerateBarcode();
        }

        private void Validate(EventBase evt)
        {
            validData = dataCard.Pallet && !string.IsNullOrEmpty(dataCard.Title);
            root.Q<Button>("Create").SetEnabled(validData);
        }

        private void GenerateBarcode()
        {
            if (validData)
            {
                dataCard.GenerateBarcode(true);
            }
        }

        private void CreateDataCardAsset()
        {
            dataCard.Pallet.DataCards.Add(dataCard);
            EditorUtility.SetDirty(dataCard.Pallet);
            string palletPath = AssetDatabase.GetAssetPath(dataCard.Pallet);
            palletPath = System.IO.Path.GetDirectoryName(palletPath);
            string dataCardAssetFilename = dataCard.GetAssetFilename();
            string assetPath = Path.Combine(palletPath, dataCardAssetFilename);
            if (File.Exists(Path.Combine(Application.dataPath, assetPath)))
            {
                assetPath = AssetDatabase.GenerateUniqueAssetPath(assetPath);
            }

            AssetDatabase.CreateAsset(dataCard, assetPath);
            dataCard.GeneratePackedAssets(false);
            AssetDatabase.SaveAssetIfDirty(dataCard);
            AssetDatabase.SaveAssetIfDirty(dataCard.Pallet);
            AssetDatabase.Refresh();
            AssetWarehouseWindow.ReloadWarehouse().Forget();
            created = true;
            OnCreate?.Invoke(dataCard);
            Close();
        }

        private void OnDestroy()
        {
            OnCreate = null;
            if (!created && dataCard != null)
            {
                DestroyImmediate(dataCard);
            }
        }

        public void CreatePropertiesGUI(VisualElement container)
        {
            HashSet<string> ignoreProperties = new HashSet<string>();
            ignoreProperties.Add("m_Script");
            ignoreProperties.Add("_barcode");
            ignoreProperties.Add("_barcodeOld");
            ignoreProperties.Add("_slimCode");
            ignoreProperties.Add("_title");
            ignoreProperties.Add("_description");
            ignoreProperties.Add("_unlockable");
            ignoreProperties.Add("_redacted");
            ignoreProperties.Add("_pallet");
            ignoreProperties.Add("_dataCardAsset");
            if (serializedObject == null)
                return;
            SerializedProperty iterator = serializedObject.GetIterator();
            if (iterator.NextVisible(true))
            {
                do
                {
                    if (!ignoreProperties.Contains(iterator.propertyPath))
                    {
                        PropertyField child = new PropertyField(iterator);
                        child.name = "PropertyField:" + iterator.propertyPath;
                        container.Add((VisualElement)child);
                        child.BindProperty(iterator);
                    }
                }
                while (iterator.NextVisible(false));
            }
        }
    }
}