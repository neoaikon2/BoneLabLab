using System;
using System.Reflection;
using SLZ.Marrow.Warehouse;
 
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
 
using UnityEngine.UIElements;

 

namespace SLZ.MarrowEditor
{
    [CustomPropertyDrawer(typeof(ScannableReference), true)]
    [CustomPropertyDrawer(typeof(ScannableReference<>), true)]
    public class ScannablePropertyDrawerGeneric : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var container = new ScannableReferenceElement(property, fieldInfo);
            container.style.flexDirection = FlexDirection.Row;
            return container;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;
            EditorGUI.PropertyField(position, property.FindPropertyRelative("_barcode").FindPropertyRelative("_id"), GUIContent.none);
            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }

    public class ScannableReferenceElement : VisualElement
    {
        private Label objectFieldTitleLabel;
        private ObjectField scannableObjectField;
        private PropertyField barcodeField;
        private Button switchModeButton;
        private Type scannableObjectType;
        private bool showBarcode = false;
        private Image barcodeImage;
        private Image objectSelectorImage;
        private Button newButton;
        private SerializedProperty barcodeIdProp;
        private static Texture2D nippleIconTexture;
        private static Texture2D plusIconTexture;
        private static Texture2D barcodeIconTexture;
        private static Texture2D objectSelectorIconTexture;
        private static Color buttonColor = new Color(0.2156863f, 0.2156863f, 0.2156863f);
        private static Color buttonHoverColor = new Color(0.2980392f, 0.2980392f, 0.2980392f);
        public virtual void SetObjectType(FieldInfo fieldInfo)
        {
            scannableObjectType = typeof(Scannable);
            Type scannableRefType = null;
            Type fieldType = fieldInfo.FieldType;
            if (typeof(ScannableReference).IsAssignableFrom(fieldType))
            {
                scannableRefType = fieldType;
            }
            else if (fieldType.GetGenericArguments().Length > 0 && typeof(ScannableReference).IsAssignableFrom(fieldType.GetGenericArguments()[0]))
            {
                scannableRefType = fieldType.GetGenericArguments()[0];
            }
            else if (fieldType.IsArray && fieldType.HasElementType)
            {
                scannableRefType = fieldType.GetElementType();
            }

            if (scannableRefType != null)
            {
                var current = scannableRefType;
                while (current != null)
                {
                    if (current.GetGenericArguments().Length > 0 && typeof(Scannable).IsAssignableFrom(current.GetGenericArguments()[0]))
                    {
                        scannableRefType = current;
                        break;
                    }

                    current = current.BaseType;
                }
            }

            if (scannableRefType != null)
            {
                scannableObjectType = scannableRefType.GetGenericArguments()[0];
            }
        }

        public ScannableReferenceElement(SerializedProperty property, FieldInfo fieldInfo)
        {
            SetObjectType(fieldInfo);
            CacheIconTextures();
            barcodeIdProp = property.FindPropertyRelative("_barcode").FindPropertyRelative("_id");
            barcodeField = new PropertyField(property.FindPropertyRelative("_barcode"), property.displayName);
            barcodeField.style.flexGrow = 1;
            barcodeField.RegisterValueChangeCallback(barcodeText =>
            {
                LoadScannableObjectFromBarcode(property);
                AutoModeDetection(property);
                SetMode(showBarcode, property);
            });
            scannableObjectField = new ObjectField(scannableObjectType.Name);
            scannableObjectField.label = property.displayName;
            scannableObjectField.style.flexGrow = 1;
            scannableObjectField.style.marginRight = -2;
            scannableObjectField.objectType = scannableObjectType;
            scannableObjectField.tooltip = GetBarcodeValue();
            objectFieldTitleLabel = scannableObjectField.Q<VisualElement>(className: "unity-object-field-display").Q(className: "unity-object-field__object").Q<Label>(className: "unity-object-field-display__label");
            Button nippleButton = new Button();
            nippleButton.style.backgroundColor = new Color(0.2156863f, 0.2156863f, 0.2156863f);
            nippleButton.style.height = 16;
            nippleButton.style.width = 18;
            nippleButton.style.paddingBottom = 0f;
            nippleButton.style.paddingTop = 0f;
            nippleButton.style.paddingLeft = 0f;
            nippleButton.style.paddingRight = 0f;
            nippleButton.style.marginBottom = 0f;
            nippleButton.style.marginTop = 0f;
            nippleButton.style.marginLeft = 0f;
            nippleButton.style.marginRight = 0f;
            nippleButton.style.borderBottomWidth = 0f;
            nippleButton.style.borderTopWidth = 0f;
            nippleButton.style.borderLeftWidth = 0f;
            nippleButton.style.borderRightWidth = 0f;
            nippleButton.style.borderBottomLeftRadius = 0f;
            nippleButton.style.borderTopLeftRadius = 0f;
            nippleButton.style.alignSelf = Align.Center;
            nippleButton.style.backgroundImage = nippleIconTexture;
            nippleButton.style.backgroundColor = buttonColor;
            nippleButton.style.unitySliceLeft = 1;
            nippleButton.style.unitySliceTop = 1;
            nippleButton.style.unitySliceRight = 1;
            nippleButton.style.unitySliceBottom = 1;
            nippleButton.RegisterCallback<MouseOverEvent>(evt => nippleButton.style.backgroundColor = buttonHoverColor);
            nippleButton.RegisterCallback<MouseLeaveEvent>(evt => nippleButton.style.backgroundColor = buttonColor);
            scannableObjectField.Q(className: "unity-object-field__selector").style.display = DisplayStyle.None;
            scannableObjectField.Q(className: "unity-base-field__input").Add(nippleButton);
            nippleButton.clicked += () =>
            {
                ScannableSelector.Create(scannableObjectType, barcode =>
                {
                    property.serializedObject.Update();
                    SetBarcodeValue(barcode);
                    property.serializedObject.ApplyModifiedProperties();
                    LoadScannableObjectFromBarcode(property);
                    AutoModeDetection(property);
                    SetMode(showBarcode, property);
                });
            };
            scannableObjectField.RegisterValueChangedCallback(obj =>
            {
                if (obj.newValue != null)
                {
                    property.serializedObject.Update();
                    SetBarcodeValue((obj.newValue as Scannable)?.Barcode);
                    property.serializedObject.ApplyModifiedProperties();
                    if (obj.newValue is IScannable scannable)
                    {
                        SetScannableFieldText(scannable);
                    }
                }
                else
                {
                    property.serializedObject.Update();
                    SetBarcodeValue(Barcode.EmptyBarcode());
                    property.serializedObject.ApplyModifiedProperties();
                }

                SetMode(showBarcode, property);
            });
            switchModeButton = new Button(() =>
            {
                showBarcode = !showBarcode;
                LoadScannableObjectFromBarcode(property);
                SetMode(showBarcode, property);
            });
            switchModeButton.style.backgroundImage = barcodeIconTexture;
            switchModeButton.style.height = 18;
            switchModeButton.style.width = 18;
            switchModeButton.style.paddingTop = 0f;
            switchModeButton.style.paddingBottom = 0f;
            switchModeButton.style.paddingLeft = 0f;
            switchModeButton.style.paddingRight = 0f;
            switchModeButton.style.marginTop = 0f;
            switchModeButton.style.marginBottom = 0f;
            switchModeButton.style.marginLeft = 3f;
            switchModeButton.style.marginRight = 1f;
            switchModeButton.style.alignSelf = Align.Center;
            switchModeButton.style.unitySliceLeft = 1;
            switchModeButton.style.unitySliceTop = 1;
            switchModeButton.style.unitySliceRight = 1;
            switchModeButton.style.unitySliceBottom = 1;
            barcodeImage = new Image();
            barcodeImage.image = barcodeIconTexture;
            barcodeImage.style.height = 16;
            barcodeImage.style.width = 16;
            barcodeImage.tooltip = "Switch To Text Barcode";
            objectSelectorImage = new Image();
            objectSelectorImage.image = objectSelectorIconTexture;
            objectSelectorImage.style.height = 16;
            objectSelectorImage.style.width = 16;
            objectSelectorImage.tooltip = "Switch To Pallet Selector";
            Add(barcodeField);
            Add(scannableObjectField);
            Add(switchModeButton);
            LoadScannableObjectFromBarcode(property);
            AutoModeDetection(property);
            SetMode(showBarcode, property);
            AssetWarehouse.OnReady(() =>
            {
                LoadScannableObjectFromBarcode(property);
                AutoModeDetection(property);
                SetMode(showBarcode, property);
            });
        }

        private void CacheIconTextures()
        {
            if (nippleIconTexture == null)
                nippleIconTexture = EditorGUIUtility.IconContent("pick_uielements").image as Texture2D;
            if (plusIconTexture == null)
                plusIconTexture = EditorGUIUtility.IconContent("toolbar plus").image as Texture2D;
            if (barcodeIconTexture == null)
                barcodeIconTexture = EditorGUIUtility.IconContent("InputField Icon").image as Texture2D;
            if (objectSelectorIconTexture == null)
                objectSelectorIconTexture = EditorGUIUtility.IconContent("Selectable Icon").image as Texture2D;
        }

        private void LoadScannableObjectFromBarcode(SerializedProperty property)
        {
            Scannable scannable = null;
            if (AssetWarehouse.ready)
            {
                AssetWarehouse.Instance.TryGetScannable(GetBarcodeValue(), out scannable);
                scannableObjectField.SetValueWithoutNotify(scannable);
                if (scannable != null)
                    SetScannableFieldText(scannable);
            }
        }

        private string GetBarcodeValue()
        {
            return barcodeIdProp.stringValue;
        }

        private void SetBarcodeValue(string newValue)
        {
            barcodeIdProp.stringValue = newValue;
        }

        private void SetScannableFieldText(IScannable scannable)
        {
            Pallet pallet = null;
            if (scannable is Crate crate)
                pallet = crate.Pallet;
            if (scannable is DataCard dataCard)
                pallet = dataCard.Pallet;
            if (pallet != null)
            {
                SetScannableFieldText(scannable.Title, pallet.Title);
            }
            else
            {
                SetScannableFieldText(scannable.Title, scannable.GetType().Name);
            }
        }

        private void SetScannableFieldText(string title, string subText = null)
        {
            objectFieldTitleLabel.text = $"{title} {(string.IsNullOrEmpty(subText) ? "" : $"({subText})")}";
        }

        private void AutoModeDetection(SerializedProperty property)
        {
            showBarcode = scannableObjectField.value == null && Barcode.IsValid(GetBarcodeValue());
        }

        private void SetMode(bool showBarcode, SerializedProperty property)
        {
            barcodeField.style.display = showBarcode ? DisplayStyle.Flex : DisplayStyle.None;
            scannableObjectField.style.display = !showBarcode ? DisplayStyle.Flex : DisplayStyle.None;
            objectSelectorImage.style.display = showBarcode ? DisplayStyle.Flex : DisplayStyle.None;
            barcodeImage.style.display = !showBarcode ? DisplayStyle.Flex : DisplayStyle.None;
            switchModeButton.style.backgroundImage = showBarcode ? objectSelectorIconTexture : barcodeIconTexture;
            switchModeButton.tooltip = showBarcode ? "Switch To Pallet Selector" : "Switch To Text Barcode";
        }
    }
}