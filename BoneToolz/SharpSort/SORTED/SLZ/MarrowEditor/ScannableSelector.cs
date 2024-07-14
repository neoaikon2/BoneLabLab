#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;
using SLZ.Marrow.Warehouse;
using UnityEditor;
using UnityEditor.Search;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor
{
    class ScannableSelector : EditorWindow
    {
        public static void Create()
        {
            var window = Create(typeof(SpawnableCrate), null);
            window.CollectScannables();
        }

        public static ScannableSelector Create(Type scannableType, Action<string> onCrateSelected)
        {
            ScannableSelector window = EditorWindow.CreateInstance<ScannableSelector>();
            window.scannableType = scannableType;
            if (onCrateSelected != null)
                window.onCrateSelected = onCrateSelected;
            window.titleContent = new GUIContent($"Select {scannableType.Name}");
            window.CollectScannables();
            window.ShowAuxWindow();
            return window;
        }

        public Type scannableType = typeof(Scannable);
        public Action<string> onCrateSelected;
        private ListView listView;
        private ToolbarSearchField scannableSearch;
        private List<Scannable> allScannables = new List<Scannable>();
        private List<Scannable> filteredScannables = new List<Scannable>();
        private QueryEngine<Scannable> queryEngine;
        private string filterText = string.Empty;
        private CratePreview scannablePreview;
        public void CollectScannables()
        {
            allScannables?.Clear();
            if (typeof(Pallet).IsAssignableFrom(scannableType))
                allScannables.AddRange(AssetWarehouse.Instance.GetPallets());
            if (typeof(Crate).IsAssignableFrom(scannableType))
                allScannables.AddRange(AssetWarehouse.Instance.GetCrates());
            if (typeof(DataCard).IsAssignableFrom(scannableType))
                allScannables.AddRange(AssetWarehouse.Instance.GetDataCards());
            allScannables = allScannables.Where(scannable => scannableType.IsAssignableFrom(scannable.GetType())).OrderBy(scannable => scannable.Title).ToList();
            allScannables.Insert(0, null);
            FilterItems(string.Empty);
            listView.itemsSource = filteredScannables;
        }

        void FilterItems(string filterText)
        {
            filteredScannables.Clear();
            var query = queryEngine.Parse(filterText);
            query.returnPayloadIfEmpty = true;
            filteredScannables.Add(null);
            foreach (var scannable in query.Apply(allScannables))
            {
                if (scannable != null)
                    filteredScannables.Add(scannable);
            }

            listView?.Rebuild();
        }

        public void OnEnable()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("f94f27c4cba77794f9d55b98754b188c");
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            tree.StretchToParentSize();
            rootVisualElement.Add(tree);
            listView = tree.Q<ListView>("ListView");
            Func<VisualElement> makeItem = () =>
            {
                VisualElement element = new VisualElement();
                element.style.flexDirection = FlexDirection.Row;
                element.style.paddingLeft = EditorGUIUtility.singleLineHeight;
                VisualElement imageVerticalElement = new VisualElement();
                imageVerticalElement.style.flexDirection = FlexDirection.Column;
                imageVerticalElement.style.justifyContent = Justify.Center;
                Image image = new Image();
                image.name = "RowScannableImage";
                image.style.width = 16f;
                image.style.height = 16f;
                imageVerticalElement.Add(image);
                Label label = new Label();
                label.name = "RowScannableName";
                label.style.marginLeft = 2f;
                label.style.unityTextAlign = TextAnchor.MiddleLeft;
                var space = new VisualElement();
                space.style.flexGrow = 1;
                var palletGroup = new VisualElement();
                palletGroup.style.flexDirection = FlexDirection.Row;
                palletGroup.style.paddingRight = EditorGUIUtility.singleLineHeight;
                Label palletLabel = new Label();
                palletLabel.name = "RowPalletName";
                palletLabel.style.marginLeft = 2f;
                palletLabel.style.unityTextAlign = TextAnchor.MiddleRight;
                palletLabel.style.color = new Color(0.50390625f, 0.50390625f, 0.50390625f);
                palletGroup.Add(palletLabel);
                element.Add(imageVerticalElement);
                element.Add(label);
                element.Add(space);
                element.Add(palletGroup);
                return element;
            };
            Action<VisualElement, int> bindItem = (e, i) =>
            {
                var image = e.Q<Image>("RowScannableImage");
                var label = e.Q<Label>("RowScannableName");
                var palletLabel = e.Q<Label>("RowPalletName");
                var scannable = filteredScannables[i];
                if (scannable != null)
                {
                    label.text = scannable.Title;
                    label.tooltip = scannable.Description;
                    image.image = EditorGUIUtility.GetIconForObject(scannable);
                }
                else
                {
                    label.text = "None";
                }

                if (scannable is Crate || scannable is DataCard)
                {
                    Pallet pallet = null;
                    if (scannable is Crate crate)
                        pallet = crate.Pallet;
                    if (scannable is DataCard dataCard)
                        pallet = dataCard.Pallet;
                    if (pallet != null)
                    {
                        palletLabel.text = pallet.Title;
                    }
                }
            };
            listView.bindItem = bindItem;
            listView.makeItem = makeItem;
            listView.fixedItemHeight = EditorGUIUtility.singleLineHeight;
            listView.selectionType = SelectionType.Single;
            listView.showAlternatingRowBackgrounds = AlternatingRowBackground.ContentOnly;
            listView.onItemsChosen += objects =>
            {
                Close();
            };
            listView.onSelectionChange += objects =>
            {
                if (objects.Any())
                {
                    Scannable scannable = objects.First() as Scannable;
                    onCrateSelected?.Invoke((scannable == null ? Barcode.EmptyBarcode() : scannable.Barcode));
                    SetPreview(scannable);
                }
                else
                {
                    onCrateSelected?.Invoke(Barcode.EmptyBarcode());
                    SetPreview(null);
                }
            };
            listView.style.flexGrow = 1.0f;
            scannableSearch = tree.Q<ToolbarSearchField>("ScannableSearch");
            scannableSearch.RegisterValueChangedCallback(filterEvent =>
            {
                if (filterText != filterEvent.newValue)
                {
                    filterText = filterEvent.newValue;
                    FilterItems(filterText);
                }
            });
            queryEngine = new QueryEngine<Scannable>();
            queryEngine.SetSearchDataCallback(GetSearchData, s => s.ToLowerInvariant(), StringComparison.Ordinal);
            queryEngine.AddFilter("p", scannable =>
            {
                Pallet pallet = null;
                if (scannable is Crate crate)
                    pallet = crate.Pallet;
                if (scannable is DataCard dataCard)
                    pallet = dataCard.Pallet;
                if (pallet != null)
                {
                    return pallet.Title;
                }

                return string.Empty;
            });
            queryEngine.AddFilter("a", scannable =>
            {
                Pallet pallet = null;
                if (scannable is Crate crate)
                    pallet = crate.Pallet;
                if (scannable is DataCard dataCard)
                    pallet = dataCard.Pallet;
                if (pallet != null)
                {
                    return pallet.Author;
                }

                return string.Empty;
            });
            queryEngine.AddFilter("b", scannable => scannable.Barcode.ToString());
        }

        private void OnDisable()
        {
            scannablePreview?.Cleanup();
        }

        private void SetPreview(Scannable scannable)
        {
            if (EditorPrefs.GetBool("UnlockEditingScannables", false))
            {
                if (scannablePreview == null)
                {
                    scannablePreview = new CratePreview();
                }

                if (scannable != null && scannable is Crate crate)
                {
                    var replaceMeLabel = rootVisualElement.Q<Label>("replaceMeLabel");
                    replaceMeLabel.text = crate.Title;
                    scannablePreview.Initialize(new UnityEngine.Object[] { crate });
                    var previewIMGUIContainer = rootVisualElement.Q<IMGUIContainer>("scannablePreviewIMGUI");
                    var bgGUIStyle = new GUIStyle();
                    previewIMGUIContainer.onGUIHandler = () => scannablePreview.OnInteractivePreviewGUI(previewIMGUIContainer.contentRect, bgGUIStyle);
                }
                else
                {
                    var replaceMeLabel = rootVisualElement.Q<Label>("replaceMeLabel");
                    replaceMeLabel.text = scannable == null ? "None" : $"??{scannable.Title}??";
                    var previewIMGUIContainer = rootVisualElement.Q<IMGUIContainer>("scannablePreviewIMGUI");
                    previewIMGUIContainer.onGUIHandler = () =>
                    {
                    };
                }
            }
        }

        static IEnumerable<string> GetSearchData(Scannable scannable)
        {
            if (scannable == null)
                yield break;
            yield return scannable.Title.ToLowerInvariant();
        }
    }
}
#endif
