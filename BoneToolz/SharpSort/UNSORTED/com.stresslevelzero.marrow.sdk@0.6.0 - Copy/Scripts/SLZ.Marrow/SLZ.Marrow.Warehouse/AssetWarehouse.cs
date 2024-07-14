using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
 
using UnityEngine.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Forklift.Model;
using SLZ.Marrow.Utilities;
using UnityEngine.LowLevel;
 
 
 
 
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;
#if UNITY_EDITOR
using SLZ.MarrowEditor;
using UnityEditor;

 

#endif
namespace SLZ.Marrow.Warehouse
{
    public class AssetWarehouse
    {
        public static AssetWarehouse Instance;
        public static bool ready = false;
        private static Action _onReady;
        private bool _initializing = false;
        public bool Initializing { get => _initializing; private set => _initializing = value; }

        private bool initialized = false;
        private readonly Dictionary<Barcode, PalletManifest> palletManifests = new Dictionary<Barcode, PalletManifest>();
        private readonly Dictionary<int, PalletManifest> modioPalletManifestsLookup = new Dictionary<int, PalletManifest>();
        private readonly List<string> loadedCatalogs = new List<string>();
        private HashSet<String> gamePallets = new HashSet<string>();
        private readonly Dictionary<string, MarrowSettings> marrowGames = new Dictionary<string, MarrowSettings>();
        private readonly Dictionary<string, MarrowSettings> palletToMarrowGameLookup = new Dictionary<string, MarrowSettings>();
        private readonly Dictionary<string, string> marrowGameLocations = new Dictionary<string, string>();
        private readonly Dictionary<Barcode, Scannable> _inventoryRegistry = new Dictionary<Barcode, Scannable>();
        private readonly Dictionary<Barcode, Scannable> _oldBarcodeInventoryRegistry = new Dictionary<Barcode, Scannable>();
        private readonly Dictionary<MarrowGuid, Scannable> _slimCodeInventoryRegistry = new Dictionary<MarrowGuid, Scannable>();
        private readonly Dictionary<Barcode, Pallet> _palletRegistry = new Dictionary<Barcode, Pallet>();
        private readonly Dictionary<Barcode, Crate> _crateRegistry = new Dictionary<Barcode, Crate>();
        private readonly Dictionary<Barcode, DataCard> _dataCardRegistry = new Dictionary<Barcode, DataCard>();
        public Dictionary<Barcode, Scannable> InventoryRegistry
        {
            get
            {
                return _inventoryRegistry;
            }
        }

        [ReadOnly]
        [SerializeField]
        private List<string> _allTags = new List<string>();
        public List<string> AllTags
        {
            get
            {
                return _allTags;
            }

            private set
            {
                _allTags = value;
            }
        }

        [SerializeField]
        [ReadOnly]
        private bool _initialLoaded = false;
        public bool InitialLoaded
        {
            get
            {
                return _initialLoaded;
            }

            private set
            {
                _initialLoaded = value;
            }
        }

#if UNITY_EDITOR
        private Dictionary<Object, Crate> _editorObjectCrateLookup = new Dictionary<Object, Crate>();
        public Dictionary<Object, Crate> EditorObjectCrateLookup { get => _editorObjectCrateLookup; private set => _editorObjectCrateLookup = value; }

        private Dictionary<string, Crate> _editorObjectGuidCrateLookup = new Dictionary<string, Crate>();
        public Dictionary<string, Crate> EditorObjectGuidCrateLookup { get => _editorObjectGuidCrateLookup; private set => _editorObjectGuidCrateLookup = value; }

        private readonly Dictionary<Barcode, Pallet> _workingPallets = new Dictionary<Barcode, Pallet>();
        public Dictionary<Barcode, Pallet> WorkingPallets
        {
            get
            {
                return _workingPallets;
            }
        }

        private string _editorGameInstallDirectory = "";
        public string EditorGameInstallDirectory
        {
            get
            {
                if (string.IsNullOrEmpty(_editorGameInstallDirectory))
                {
                    _editorGameInstallDirectory = EditorPrefs.GetString("GameInstallDirectory", "");
                }

                return _editorGameInstallDirectory;
            }

            set => _editorGameInstallDirectory = value;
        }

#endif
        private Stopwatch palletPackStopWatch = new Stopwatch();
        private Stopwatch palletManifestPackStopWatch = new Stopwatch();
        public static void OnReady(Action callbackWhenReady)
        {
            if (ready)
            {
                callbackWhenReady?.Invoke();
                return;
            }

            _onReady += callbackWhenReady;
        }

        public async UniTask InitAsync()
        {
            if (!initialized)
            {
                LogVerbose($"Init {UnityEngine.Random.Range(1, 100)}");
                Instance = this;
                Initializing = true;
                AssetWarehouseMetrics.Reset();
                palletPackStopWatch.Restart();
                palletManifestPackStopWatch.Restart();
                var initStopWatch = new Stopwatch();
                initStopWatch.Start();
#if UNITY_EDITOR
                if (EditorObjectCrateLookup == null)
                    EditorObjectCrateLookup = new Dictionary<Object, Crate>();
                else
                    EditorObjectCrateLookup.Clear();
                if (EditorObjectGuidCrateLookup == null)
                    EditorObjectGuidCrateLookup = new Dictionary<string, Crate>();
                else
                    EditorObjectGuidCrateLookup.Clear();
                AssemblyReloadEvents.beforeAssemblyReload += OnBeforeDomainReload;
                SDKProjectPreferences.LoadFromFile();
                if (!Application.isBatchMode && Directory.Exists("Assets/AddressableAssetsData") && SDKProjectPreferences.LoadMarrowGames)
                {
                    LogVerbose($"Initialize Addressables");
                    var settingsJsonPath = $"{Addressables.BuildPath}/settings.json";
                    if (!string.IsNullOrEmpty(settingsJsonPath) && settingsJsonPath.Contains("com.unity.addressables") && File.Exists(settingsJsonPath))
                    {
                        File.Delete(settingsJsonPath);
                        LogVerbose("Delete Addressables settings.json");
                    }

                    await Addressables.InitializeAsync();
                    LogVerbose($"Addressables Initialized");
                }

#endif
                await LoadInitialPalletsAsync();
                LogVerbose($"Time spent on Pallet Unpacking: {palletPackStopWatch.Elapsed:h\\:mm\\:ss}");
                initStopWatch.Stop();
                LogVerbose($"Finish init, took {initStopWatch.Elapsed:h\\:mm\\:ss}");
                ready = true;
                _onReady?.Invoke();
                _onReady = null;
                initialized = true;
                Initializing = false;
            }
        }

        private void CleanupPalletManifests()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string[] palletManifestJsonPaths = Directory.GetFiles(MarrowSDK.RuntimeModsPath, $"*.{PalletManifest.EXTENSION_NAME}", SearchOption.AllDirectories);
            foreach (var palletManifestJsonPath in palletManifestJsonPaths)
            {
                PalletPacker.TryUnpackManifestJsonFromFile(palletManifestJsonPath, out var palletManifest, out _);
                if (palletManifest == null || !palletManifests.ContainsKey((Barcode)palletManifest.PalletBarcode))
                {
                    LogVerbose($"AssetWarehouse: PURGE MANIFEST: {palletManifest.PalletBarcode} ({palletManifestJsonPath})");
                    File.Delete(palletManifestJsonPath);
                }
            }

            LogVerbose($"AssetWarehouse: Finish CleanupPalletManifests{palletManifestJsonPaths.Count()}, took {stopwatch.Elapsed:h\\:mm\\:ss}");
        }

        private void Init()
        {
            InitAsync().Forget();
        }

        public AssetWarehouse(bool autoInit = true)
        {
            if (autoInit)
                Init();
        }

        ~AssetWarehouse()
        {
        }

        public void Clear()
        {
            LogVerbose("Clear Started");
            UnloadAllPallets();
            _inventoryRegistry.Clear();
            _oldBarcodeInventoryRegistry.Clear();
            _slimCodeInventoryRegistry.Clear();
            _palletRegistry.Clear();
            _crateRegistry.Clear();
            _dataCardRegistry.Clear();
            palletManifests.Clear();
            modioPalletManifestsLookup.Clear();
            gamePallets.Clear();
            marrowGames.Clear();
            palletToMarrowGameLookup.Clear();
            marrowGameLocations.Clear();
            InitialLoaded = false;
            ready = false;
            initialized = false;
            Initializing = false;
            _onReady = null;
            OnChanged = null;
            OnPalletAdded = null;
            OnCrateAdded = null;
            OnDataCardAdded = null;
            AssetWarehouseMetrics.Reset();
#if UNITY_EDITOR
            EditorObjectCrateLookup.Clear();
            EditorObjectGuidCrateLookup.Clear();
            WorkingPallets.Clear();
            OnClearEditor?.Invoke();
#endif
            OnChanged?.Invoke();
            LogVerbose("Clear Finished");
        }

#if UNITY_EDITOR
        [InitializeOnLoadMethod]
        private static void EditorInitialize()
        {
            var loop = PlayerLoop.GetCurrentPlayerLoop();
            Cysharp.Threading.Tasks.PlayerLoopHelper.Initialize(ref loop);
            LogVerbose("InitializeOnLoadMethod");
            LogVerbose("EditorInitialize" + (EditorApplication.isPlayingOrWillChangePlaymode ? " isPlayingOrWillChangePlaymode" : "") + (Application.isPlaying ? " isPlaying" : ""));
            if (Application.isPlaying || EditorApplication.isPlayingOrWillChangePlaymode)
            {
                LogVerbose("EditorInitialize: playing");
            }
            else
            {
                LogVerbose("EditorInitialize: not playing");
                if (AssetWarehouse.Instance == null && !AssetWarehouse.ready)
                {
                    WarehousePathResolver.Setup();
                    var ass = new AssetWarehouse(false);
                    ass.InitAsyncLoadOnProjectOpen().Forget();
                }
            }
        }

        private async UniTask InitAsyncLoadOnProjectOpen()
        {
            QueueEditorUpdateLoop.StartEditorUpdateLoop();
            await UniTask.WaitUntil(() => !EditorApplication.isUpdating);
            await InitAsync();
            QueueEditorUpdateLoop.StopEditorUpdateLoop();
        }

#endif
        private async UniTask LoadInitialPalletsAsync()
        {
            LogVerbose("Load Initial Pallets", true);
#if UNITY_EDITOR
            await LoadInitialPalletsAsync_Editor();
#else
#endif
            InitialLoaded = true;
            LogVerbose("Initial Pallets loaded", true);
        }

        private async UniTask LoadInitialPalletsAsync_Editor()
        {
#if UNITY_EDITOR
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            if (EditorApplication.isPlayingOrWillChangePlaymode)
            {
#if false
#endif
            }
            else
            {
                SDKProjectPreferences.LoadFromFile();
                if (!Application.isBatchMode && Directory.Exists("Assets/AddressableAssetsData") && SDKProjectPreferences.LoadMarrowGames)
                    await EditorLoadBuiltMarrowGames();
                await LoadPalletsFromAssetDatabase();
                if (!Application.isBatchMode && Directory.Exists("Assets/AddressableAssetsData"))
                    await LoadPalletEditorDependencies();
            }
#endif
        }

        public Action OnChanged;
        public Action<string> OnPalletAdded;
        public Action<string> OnCrateAdded;
        public Action<string> OnDataCardAdded;
#if UNITY_EDITOR
        public Action OnClearEditor;
#endif
        public Crate GetCrate(Barcode barcode)
        {
            if (barcode == null)
            {
                return null;
            }
            else
            {
                return GetCrate<Crate>(barcode);
            }
        }

        public T GetCrate<T>(string barcode)
            where T : Crate
        {
            if (TryGetCrate<T>(barcode, out var crate))
            {
                return crate;
            }
            else
            {
                return null;
            }
        }

        public async UniTask<T> GetCrateAsync<T>(string barcode, Action<T> callback = null)
            where T : Crate
        {
            if (!HasCrate<T>(barcode))
            {
                await UniTask.WaitUntil(() => InitialLoaded);
            }

            var completion = new UniTaskCompletionSource<T>();
            if (TryGetCrate<T>(barcode, out var crate))
            {
                completion.TrySetResult(crate);
                callback?.Invoke(crate);
            }
            else
            {
                completion.TrySetResult(null);
            }

            return await completion.Task;
        }

        public async UniTask<Crate> GetCrateAsync(string barcode, Action<Crate> callback = null, CancellationToken cancellationToken = default)
        {
            if (!HasCrate(barcode))
            {
                await UniTask.WaitUntil(() => InitialLoaded);
            }

            var completion = new UniTaskCompletionSource<Crate>();
            if (TryGetCrate(barcode, out var crate))
            {
                completion.TrySetResult(crate);
                callback?.Invoke(crate);
            }
            else
            {
                completion.TrySetResult(null);
            }

            return await completion.Task;
        }

        public bool TryGetPallet(string barcode, out Pallet pallet)
        {
            if (TryGetScannable<Pallet>(barcode, out Pallet foundpallet))
            {
                pallet = foundpallet;
                return true;
            }

            pallet = null;
            return false;
        }

        public bool TryGetPallet(MarrowGuid slimCode, out Pallet pallet)
        {
            if (TryGetScannable<Pallet>(slimCode, out Pallet foundpallet))
            {
                pallet = foundpallet;
                return true;
            }

            pallet = null;
            return false;
        }

        public bool TryGetCrate(string barcode, out Crate crate)
        {
            if (TryGetCrate<Crate>(barcode, out Crate foundCrate))
            {
                crate = foundCrate;
                return true;
            }

            crate = null;
            return false;
        }

        public bool TryGetCrate<T>(string barcode, out T crateT)
            where T : Crate
        {
            if (TryGetScannable<T>(barcode, out T foundCrate))
            {
                crateT = foundCrate;
                return true;
            }

            crateT = null;
            return false;
        }

        public bool TryGetDataCard(string barcode, out DataCard dataCard)
        {
            if (TryGetScannable<DataCard>(barcode, out DataCard foundDataCard))
            {
                dataCard = foundDataCard;
                return true;
            }

            dataCard = null;
            return false;
        }

        public bool TryGetDataCard<T>(string barcode, out T dataCardT)
            where T : DataCard
        {
            if (TryGetScannable<T>(barcode, out T foundDataCard))
            {
                dataCardT = foundDataCard;
                return true;
            }

            dataCardT = null;
            return false;
        }

        public bool TryGetCrate<T>(MarrowGuid slimCode, out T crateT)
            where T : Crate
        {
            if (TryGetScannable<T>(slimCode, out T foundCrate))
            {
                crateT = foundCrate;
                return true;
            }

            crateT = null;
            return false;
        }

        public bool TryGetScannable(string barcode, out Scannable scannable)
        {
            if (TryGetScannable<Scannable>(barcode, out Scannable item))
            {
                scannable = item;
                return true;
            }

            scannable = null;
            return false;
        }

        public bool TryGetScannable<T>(string barcode, out T scannableT)
            where T : Scannable
        {
            scannableT = null;
            bool found = false;
            if (Barcode.IsValid(barcode))
            {
                found = _inventoryRegistry.TryGetValue((Barcode)barcode, out Scannable scannable) && scannable != null && scannable is T;
                if (!found)
                {
                    found = _oldBarcodeInventoryRegistry.TryGetValue((Barcode)barcode, out scannable) && scannable != null && scannable is T;
                }

                if (found)
                {
                    scannableT = (T)scannable;
                }
            }

            return found;
        }

        public bool TryGetScannable<T>(MarrowGuid slimCode, out T scannableT)
            where T : Scannable
        {
            scannableT = null;
            bool found = false;
            if (MarrowGuid.IsValid(slimCode))
            {
                found = _slimCodeInventoryRegistry.TryGetValue(slimCode, out Scannable scannable) && scannable != null && scannable is T;
                if (found)
                {
                    scannableT = (T)scannable;
                }
            }

            return found;
        }

        public bool TryGetSlimCode(string barcode, out MarrowGuid slimCode)
        {
            slimCode = new MarrowGuid();
            if (TryGetScannable(barcode, out var scannable))
            {
                if (scannable.SlimCode.IsValid())
                {
                    slimCode = scannable.SlimCode;
                    return true;
                }
            }

            return false;
        }

        public bool HasScannable<T>(string barcode)
            where T : Scannable
        {
            return TryGetScannable<T>(barcode, out _);
        }

        public bool HasScannable(string barcode)
        {
            return HasScannable<Scannable>(barcode);
        }

        public bool HasCrate<T>(string barcode)
            where T : Crate
        {
            return HasScannable<T>(barcode);
        }

        public bool HasCrate(string barcode)
        {
            return HasCrate<Crate>(barcode);
        }

        public bool HasDataCard<T>(string barcode)
            where T : DataCard
        {
            return HasScannable<T>(barcode);
        }

        public bool HasDataCard(string barcode)
        {
            return HasDataCard<DataCard>(barcode);
        }

        public bool HasPallet(string barcode)
        {
            return HasScannable<Pallet>(barcode);
        }

        public bool UnloadCrateAsset(string barcode, bool forcedUnload = false)
        {
            bool unloaded = false;
            if (TryGetCrate(barcode, out var crate))
            {
                unloaded = UnloadCrateAsset(crate);
            }

            return unloaded;
        }

        public bool UnloadCrateAsset(Crate crate, bool forcedUnload = false)
        {
            foreach (var packedAsset in crate.ExportPackedAssets())
            {
                if (packedAsset.marrowAsset != null)
                {
                    packedAsset.marrowAsset.UnloadAsset(true);
                }

                if (packedAsset.subAssets == null)
                {
                }
                else
                {
                    foreach (var packedSubAsset in packedAsset.subAssets)
                    {
                        packedSubAsset.subAsset.UnloadAsset(true);
                    }
                }
            }

            return crate.MainAsset.UnloadAsset(forcedUnload);
        }

        public bool UnloadDataCardAsset(DataCard dataCard, bool forcedUnload = false)
        {
            foreach (var packedAsset in dataCard.ExportPackedAssets())
            {
                if (packedAsset.marrowAsset != null)
                {
                    packedAsset.marrowAsset.UnloadAsset(true);
                }

                if (packedAsset.subAssets == null)
                {
                }
                else
                {
                    foreach (var packedSubAsset in packedAsset.subAssets)
                    {
                        packedSubAsset.subAsset.UnloadAsset(true);
                    }
                }
            }

            if (dataCard.IsBundledDataCard())
                return dataCard.DataCardAsset.UnloadAsset(forcedUnload);
            else
                return false;
        }

        public int UnloadAllCrateAssets()
        {
            int unloadCount = 0;
            var crates = GetCrates();
            foreach (var crate in crates)
            {
                if (UnloadCrateAsset(crate, true))
                    unloadCount++;
            }

            return unloadCount;
        }

        public int UnloadAllCrateAssets(string excludeBarcode)
        {
            int unloadCount = 0;
            var crates = GetCrates();
            foreach (var crate in crates)
            {
                if (!Barcode.IsValid(excludeBarcode) || crate.Barcode != excludeBarcode)
                {
                    if (UnloadCrateAsset(crate, true))
                        unloadCount++;
                }
            }

            return unloadCount;
        }

        public int UnloadAllCrateAssets(params string[] excludeBarcodes)
        {
            int unloadCount = 0;
            var crates = GetCrates();
            foreach (var crate in crates)
            {
                bool excluded = false;
                foreach (var excludeBarcode in excludeBarcodes)
                {
                    if (!Barcode.IsValid(excludeBarcode) || crate.Barcode != excludeBarcode)
                    {
                        excluded = true;
                        break;
                    }
                }

                if (!excluded)
                {
                    if (UnloadCrateAsset(crate, true))
                        unloadCount++;
                }
            }

            return unloadCount;
        }

        public int UnloadAllDataCardAssets()
        {
            int unloadCount = 0;
            var dataCards = GetDataCards();
            foreach (var dataCard in dataCards)
            {
                if (UnloadDataCardAsset(dataCard, true))
                    unloadCount++;
            }

            return unloadCount;
        }

        public int UnloadAllDataCardAssets(string excludeBarcode)
        {
            int unloadCount = 0;
            var dataCards = GetDataCards();
            foreach (var dataCard in dataCards)
            {
                if (!Barcode.IsValid(excludeBarcode) || dataCard.Barcode != excludeBarcode)
                {
                    if (UnloadDataCardAsset(dataCard, true))
                        unloadCount++;
                }
            }

            return unloadCount;
        }

        public int UnloadAllDataCardAssets(params string[] excludeBarcodes)
        {
            int unloadCount = 0;
            var dataCards = GetDataCards();
            foreach (var dataCard in dataCards)
            {
                bool excluded = false;
                foreach (var excludeBarcode in excludeBarcodes)
                {
                    if (!Barcode.IsValid(excludeBarcode) || dataCard.Barcode != excludeBarcode)
                    {
                        excluded = true;
                        break;
                    }
                }

                if (!excluded)
                {
                    if (UnloadDataCardAsset(dataCard, true))
                        unloadCount++;
                }
            }

            return unloadCount;
        }

        public void UnloadCrate(string barcode)
        {
            if (TryGetCrate(barcode, out var crate))
            {
                UnloadCrate(crate);
            }
        }

        public void UnloadCrate(Crate crate)
        {
            UnloadCrateAsset(crate, true);
            InventoryRegistry.Remove(crate.Barcode);
            if (Barcode.IsValid(crate.BarcodeOld) && InventoryRegistry.ContainsKey(crate.BarcodeOld))
                InventoryRegistry.Remove(crate.BarcodeOld);
            _crateRegistry.Remove(crate.Barcode);
#if UNITY_EDITOR
            Object removeItem = null;
            foreach (var objectCrateKVP in EditorObjectCrateLookup)
            {
                if (objectCrateKVP.Value == crate)
                {
                    removeItem = objectCrateKVP.Key;
                }
            }

            if (removeItem != null)
                EditorObjectCrateLookup.Remove(removeItem);
            string removeItem2 = null;
            foreach (var objectCrateKVP in EditorObjectGuidCrateLookup)
            {
                if (objectCrateKVP.Value == crate)
                {
                    removeItem2 = objectCrateKVP.Key;
                }
            }

            if (removeItem2 != null)
                EditorObjectGuidCrateLookup.Remove(removeItem2);
#endif
            DestroyRuntimeCreatedScannable(crate);
        }

        public void UnloadDataCard(string barcode)
        {
            if (TryGetDataCard(barcode, out var dataCard))
            {
                UnloadDataCard(dataCard);
            }
        }

        public void UnloadDataCard(DataCard dataCard)
        {
            UnloadDataCardAsset(dataCard, true);
            InventoryRegistry.Remove(dataCard.Barcode);
            if (Barcode.IsValid(dataCard.BarcodeOld) && InventoryRegistry.ContainsKey(dataCard.BarcodeOld))
                InventoryRegistry.Remove(dataCard.BarcodeOld);
            _dataCardRegistry.Remove(dataCard.Barcode);
            DestroyRuntimeCreatedScannable(dataCard);
        }

        private void DestroyRuntimeCreatedScannable(Scannable scannable)
        {
#if UNITY_EDITOR
            if (string.IsNullOrEmpty(AssetDatabase.GetAssetPath(scannable)))
            {
                Object.DestroyImmediate(scannable);
            }
#else
#endif
        }

#if UNITY_EDITOR
        private struct EditorCatalogEntry
        {
            public string guid;
            public string address;
            public Object obj;
            public Type assetType;
            public string assetPath;
            public EditorCatalogEntry(string guid, string address, Object obj, Type assetType)
            {
                this.guid = guid;
                this.address = address;
                this.obj = obj;
                this.assetType = assetType;
                assetPath = AssetDatabase.GUIDToAssetPath(this.guid);
                if (this.obj == null)
                {
                    this.obj = AssetDatabase.LoadAssetAtPath(assetPath, this.assetType);
                }
            }
        }

        private async UniTask<Pallet> LoadEditorPallet(Pallet pallet, bool loadPalletJson = true)
        {
            Pallet loadedPallet = pallet;
            if (Application.isPlaying && loadPalletJson)
            {
#if false
#endif
            }
            else
            {
                LoadAndUpdatePalletManifest(pallet, null, string.Empty, string.Empty);
                AddPallet(pallet);
            }

            return loadedPallet;
        }

#endif
        private void AddPallet(Pallet pallet)
        {
            if (pallet == null)
            {
                Debug.LogWarning("AssetWarehouse: Cannot add null pallet");
                return;
            }

            AddScannable(pallet);
            _palletRegistry[pallet.Barcode] = pallet;
            foreach (var crate in pallet.Crates)
            {
                AddCrate(crate);
                if (crate != null && crate.Pallet == null)
                    crate.Pallet = pallet;
            }

            foreach (var dataCard in pallet.DataCards)
            {
                AddDataCard(dataCard);
                if (dataCard != null && dataCard.Pallet == null)
                    dataCard.Pallet = pallet;
            }

            OnChanged?.Invoke();
            OnPalletAdded?.Invoke(pallet.Barcode);
        }

        private void AddCrate(Crate crate)
        {
            if (crate == null)
            {
                Debug.LogWarning("AssetWarehouse: Cannot add null crate");
                return;
            }

            AddScannable(crate);
            AddTags(crate.Tags);
            _crateRegistry[crate.Barcode] = crate;
#if UNITY_EDITOR
            if (crate.MainAsset.EditorAsset != null)
            {
                EditorObjectCrateLookup[crate.MainAsset.EditorAsset] = crate;
            }

            EditorObjectGuidCrateLookup[crate.MainAsset.AssetGUID] = crate;
#endif
            OnCrateAdded?.Invoke(crate.Barcode);
        }

        private void AddDataCard(DataCard dataCard)
        {
            if (dataCard == null)
            {
                Debug.LogWarning("AssetWarehouse: Cannot add null datacard");
                return;
            }

            AddScannable(dataCard);
            _dataCardRegistry[dataCard.Barcode] = dataCard;
            OnDataCardAdded?.Invoke(dataCard.Barcode);
        }

        private bool AddScannable(Scannable item)
        {
            bool added = false;
            if (Barcode.IsValid(item.Barcode))
            {
                _inventoryRegistry[item.Barcode] = item;
                added = true;
                if (Barcode.IsValid(item.BarcodeOld) && item.Barcode != item.BarcodeOld)
                {
                    _oldBarcodeInventoryRegistry[new Barcode(item.BarcodeOld)] = item;
                }

                if (item.SlimCode.IsValid())
                {
                    _slimCodeInventoryRegistry[item.SlimCode] = item;
                }
            }

            if (!added)
            {
                Debug.LogError("AssetWarehouse: Cannot add item " + item.Title + ", invalid barcode");
            }

            return added;
        }

        public void ReloadPallet(string barcode)
        {
            if (TryGetPallet(barcode, out var pallet) && palletManifests.TryGetValue((Barcode)barcode, out var palletManifest))
            {
                string palletPath = Path.GetDirectoryName(palletManifest.CatalogPath);
                UnloadPallet(pallet);
                LoadPalletFromFolderAsync(palletPath, true).Forget();
            }
        }

        public void UnloadPallet(string barcode)
        {
            if (TryGetPallet(barcode, out var pallet))
            {
                UnloadPallet(pallet);
            }
        }

        public void UnloadPallet(Pallet pallet)
        {
            LogVerbose($"UnloadPallet({pallet.Title})");
            foreach (var crate in pallet.Crates)
            {
                UnloadCrate(crate);
            }

            foreach (var dataCard in pallet.DataCards)
            {
                UnloadDataCard(dataCard);
            }

            InventoryRegistry.Remove(pallet.Barcode);
            _palletRegistry.Remove(pallet.Barcode);
            if (Barcode.IsValid(pallet.BarcodeOld) && InventoryRegistry.ContainsKey(pallet.BarcodeOld))
                InventoryRegistry.Remove(pallet.BarcodeOld);
            if (palletManifests.TryGetValue(pallet.Barcode, out var palletManifest))
            {
                palletManifests.Remove(pallet.Barcode);
                if (loadedCatalogs.Contains(palletManifest.CatalogPath))
                {
                    loadedCatalogs.Remove(palletManifest.CatalogPath);
                    Addressables.RemoveResourceLocator(palletManifest.Catalog);
                }
            }

            DestroyRuntimeCreatedScannable(pallet);
        }

        public void UnloadAllPallets()
        {
            foreach (var pallet in GetPallets())
            {
                if (pallet != null)
                {
                    UnloadPallet(pallet);
                }
            }
        }

        public void DeletePallet(string barcode)
        {
            if (TryGetPallet(barcode, out var pallet))
            {
                DeletePallet(pallet);
            }
        }

        public void DeletePallet(Pallet pallet)
        {
            PalletManifest palletManifest;
            palletManifests.TryGetValue(pallet.Barcode, out palletManifest);
            UnloadPallet(pallet);
            if (!string.IsNullOrEmpty(palletManifest?.PalletPath) && PathContainsPath(MarrowSDK.RuntimeModsPath, palletManifest?.PalletPath) && palletManifest.PalletPath.Contains(MarrowSDK.RUNTIME_MODS_DIRECTORY_NAME))
            {
                string palletDirectory = Path.GetDirectoryName(palletManifest.PalletPath);
                Debug.Log("AssetWarehouse: Deleting entire mod directory at \"" + palletDirectory + "\"");
                Directory.Delete(palletDirectory, true);
                File.Delete(palletManifest.ManifestPath);
            }
        }

        private static bool PathContainsPath(string path, string subPath)
        {
            string relativePath = Path.GetRelativePath(path.Replace('\\', '/'), subPath.Replace('\\', '/'));
            return relativePath != "." && relativePath != ".." && !relativePath.StartsWith("../") && !Path.IsPathRooted(relativePath);
        }

        private void AddTags(List<string> newTags)
        {
            bool added = false;
            foreach (var tag in newTags)
            {
                if (!AllTags.Contains(tag))
                {
                    AllTags.Add(tag);
                    added = true;
                }
            }

            if (added)
            {
                AllTags.Sort();
            }
        }

        public int PalletCount()
        {
            return _palletRegistry.Count;
        }

        public List<Pallet> GetPallets()
        {
            List<Pallet> pallets = new List<Pallet>();
            foreach (var palletManifest in palletManifests.Values)
            {
                pallets.Add(palletManifest.Pallet);
            }

            return pallets;
        }

        public void GetPallets(ref List<Pallet> pallets)
        {
            if (pallets == null)
                pallets = new List<Pallet>();
            else
                pallets.Clear();
            foreach (var palletManifest in palletManifests.Values)
            {
                pallets.Add(palletManifest.Pallet);
            }
        }

        public int CrateCount()
        {
            return _crateRegistry.Count;
        }

        public List<Crate> GetCrates()
        {
            List<Crate> crates = new List<Crate>();
            foreach (var scannable in _inventoryRegistry.Values)
            {
                if (scannable is Crate crate && !crates.Contains(scannable))
                {
                    crates.Add(crate);
                }
            }

            return crates;
        }

        public void GetCrates(in List<Crate> crates)
        {
            if (crates.Count > 0)
                crates.Clear();
            foreach (var scannable in _inventoryRegistry.Values)
            {
                if (scannable is Crate crate && !crates.Contains(scannable))
                {
                    crates.Add(crate);
                }
            }
        }

        public int DataCardCount()
        {
            return _dataCardRegistry.Count;
        }

        public List<DataCard> GetDataCards()
        {
            List<DataCard> dataCards = new List<DataCard>();
            foreach (var scannable in _inventoryRegistry.Values)
            {
                if (scannable is DataCard crate && !dataCards.Contains(scannable))
                {
                    dataCards.Add(crate);
                }
            }

            return dataCards;
        }

        public void GetDataCards(in List<DataCard> dataCards)
        {
            if (dataCards.Count > 0)
                dataCards.Clear();
            foreach (var scannable in _inventoryRegistry.Values)
            {
                if (scannable is DataCard dataCard && !dataCards.Contains(scannable))
                {
                    dataCards.Add(dataCard);
                }
            }
        }

        public class HideLevelCrateFilter : ICrateFilter<LevelCrate>
        {
            public bool Filter(LevelCrate crate)
            {
                return !crate.Redacted;
            }
        }

        public List<T> FilterCrates<T>(ref List<T> crateList, ICrateFilter<T> crateFilter)
            where T : Crate
        {
            for (int i = crateList.Count - 1; i >= 0; i--)
            {
                if (crateFilter == null || crateFilter.Filter(crateList[i]))
                {
                    crateList.RemoveAt(i);
                }
            }

            return crateList;
        }

        public List<T> GetCrates<T>(ICrateFilter<T> crateFilter = null)
            where T : Crate
        {
            List<T> crates = new List<T>();
            foreach (var scannable in _inventoryRegistry.Values)
            {
                if (scannable is T crate && (crateFilter == null || crateFilter.Filter(crate)))
                {
                    crates.Add(crate);
                }
            }

            return crates;
        }

        public void TestQueries()
        {
            var pallets = GetPallets();
            var allCrates = GetCrates();
            var allSpawnableCrates = GetCrates<SpawnableCrate>();
            var allSceneCrates = GetCrates<LevelCrate>();
            var testFilterCrates = GetCrates(new HideLevelCrateFilter());
            var testFilterCrates2 = AssetWarehouse.Instance.GetCrates<LevelCrate>().Filter(new HideLevelCrateFilter());
        }

        public static void LogVerbose(string text, bool logInRuntime = false)
        {
            bool logIt = false;
#if UNITY_EDITOR
            if (EditorPrefs.GetBool("VerboseWarehouseLogging", false))
            {
                logIt = true;
            }

#else
#endif
            if (logIt)
            {
                Debug.Log("AssetWarehouse: " + text);
            }
        }

#if UNITY_EDITOR
        private bool loadingFromAssetDatabase = false;
        public async UniTask LoadPalletsFromAssetDatabase(bool clear = false)
        {
            if (!loadingFromAssetDatabase)
            {
                loadingFromAssetDatabase = true;
                LogVerbose("LoadPalletsFromAssetDatabase");
                if (clear)
                {
                    _inventoryRegistry.Clear();
                    _palletRegistry.Clear();
                    palletManifests.Clear();
                }

                List<Pallet> loadedPallets = new List<Pallet>();
                var foundAssets = AssetDatabase.FindAssets("t:Pallet");
                foreach (var guid in foundAssets)
                {
                    string path = AssetDatabase.GUIDToAssetPath(guid);
                    Pallet pallet = AssetDatabase.LoadAssetAtPath<Pallet>(path);
                    string fullPalletPath = Path.GetFullPath(path);
                    bool validSDKPath = fullPalletPath.Contains(MarrowSDK.PackagePath) || fullPalletPath.Contains(Path.Combine("PackageCache", MarrowSDK.PACKAGE_NAME));
                    bool validPathDirectory = fullPalletPath.Contains(Path.GetFullPath(MarrowSDK.GetMarrowAssetsPath("_Pallets")));
                    if (!HasPallet(pallet.Barcode) && (validSDKPath || validPathDirectory))
                    {
                        var loadedPallet = await LoadEditorPallet(pallet);
                        if (loadedPallet != null)
                        {
                            loadedPallets.Add(loadedPallet);
                            if (validPathDirectory)
                            {
                                WorkingPallets.TryAdd(pallet.Barcode, pallet);
                            }

                            LogVerbose($"Loaded Pallet from AssetDatabase: {loadedPallet.Barcode}");
                        }
                    }
                }

                foreach (var loadedPallet in loadedPallets)
                {
                    if (HasPallet(loadedPallet.Barcode))
                    {
                        await LoadPalletDataCards(loadedPallet);
                    }
                }

                loadingFromAssetDatabase = false;
                LogVerbose("LoadPalletsFromAssetDatabase: Done");
            }
            else
            {
                LogVerbose("LoadPalletsFromAssetDatabase: Skipping, already loading");
            }
        }

        private async UniTask LoadPalletEditorDependencies()
        {
            LogVerbose("LoadPalletEditorDependencies");
            string[] palletManifestJsonPaths = Directory.GetFiles(MarrowSDK.RuntimeModsPath, $"*.{PalletManifest.EXTENSION_NAME}", SearchOption.AllDirectories);
            var unloadedPalletManifests = new Dictionary<Barcode, PalletManifest>();
            foreach (var palletManifestJsonPath in palletManifestJsonPaths)
            {
                if (PalletPacker.TryUnpackManifestJsonFromFile(palletManifestJsonPath, out var palletManifest, out _))
                {
                    Barcode palletBarcode = (Barcode)palletManifest.PalletBarcode;
                    if (!_palletRegistry.ContainsKey(palletBarcode) && !palletManifests.ContainsKey(palletBarcode) && !string.IsNullOrEmpty(palletManifest.PalletPath))
                    {
                        unloadedPalletManifests[palletBarcode] = palletManifest;
                    }
                }
            }

            foreach (var pallet in _palletRegistry.Values.ToArray())
            {
                foreach (var palletDependencyRef in pallet.PalletDependencies)
                {
                    var palletRefBarcode = palletDependencyRef.Barcode;
                    if (palletRefBarcode.IsValid() && !palletRefBarcode.ID.Contains("SLZ.BONELAB"))
                    {
                        if (!_palletRegistry.ContainsKey(palletRefBarcode) && unloadedPalletManifests.TryGetValue(palletRefBarcode, out var palletManifest))
                        {
                            var palletPath = palletManifest.PalletPath;
                            LogVerbose($"LoadPalletEditorDependencies: Load pallet dependency {palletRefBarcode} for {pallet.Barcode}");
                            await LoadPalletFromFolderAsync(palletPath);
                        }
                    }
                }
            }

            LogVerbose("LoadPalletEditorDependencies: Done");
        }

#endif
#if UNITY_EDITOR
        public async UniTask EditorLoadBuiltMarrowGames()
        {
            SDKProjectPreferences.LoadFromFile();
            foreach (var marrowGameInstallPath in SDKProjectPreferences.MarrowGameInstallPaths)
            {
                await EditorLoadBuiltMarrowGame(marrowGameInstallPath);
            }
        }

        public async UniTask EditorLoadBuiltMarrowGame(string gamePath)
        {
            MarrowSettings marrowGame;
            if (string.IsNullOrEmpty(gamePath) || !Directory.Exists(gamePath))
            {
                UnityEngine.Debug.LogError($"AssetWarehouse: EditorLoadBuiltMarrowGame: Failed to load \"{gamePath}\"");
            }
            else
            {
                if (!string.IsNullOrEmpty(gamePath) && Directory.Exists(gamePath))
                {
                    string contentDirectory = "";
                    var dirs = Directory.GetDirectories(gamePath, "StandaloneWindows64", SearchOption.AllDirectories);
                    foreach (var dir in dirs)
                    {
                        var parent = Directory.GetParent(dir);
                        var parentParent = parent == null ? null : Directory.GetParent(parent.FullName);
                        if (parent != null && parentParent != null && parent.Name == "aa" && parentParent.Name == "StreamingAssets")
                        {
                            contentDirectory = Path.GetFullPath(dir);
                            break;
                        }
                    }

                    gamePath = contentDirectory;
                    string marrowGamePath = Path.Combine(gamePath, "MarrowGame.json");
                    if (File.Exists(marrowGamePath) && PalletPacker.TryUnpackMarrowGameJsonFromFile(marrowGamePath, out marrowGame, out _))
                    {
                        string palletsString = "[ ";
                        foreach (var gamePallet in marrowGame.GamePallets)
                        {
                            palletToMarrowGameLookup[gamePallet.Barcode] = marrowGame;
                            palletsString += $"{gamePallet.Barcode} ";
                        }

                        palletsString += "]";
                        await LoadMarrowGame(marrowGame, gamePath);
                        await LoadGamePallets(marrowGame, gamePath, false);
                        LogVerbose($"Loaded Built Game for {marrowGame.GameTitle} at \"{gamePath}\" with pallets: {palletsString}");
                    }
                }
            }
        }

#endif
        public async UniTask LoadMarrowGame(MarrowSettings marrowGame, string contentPath)
        {
            if (!marrowGames.ContainsKey(marrowGame.GameTitle))
            {
                marrowGames[marrowGame.GameTitle] = marrowGame;
                if (!string.IsNullOrEmpty(contentPath))
                {
                    marrowGameLocations[marrowGame.GameTitle] = contentPath;
                }
            }
        }

        public async UniTask LoadGamePallets(MarrowSettings marrowGame, string contentPath, bool loadStandalonePallets = true)
        {
            await LoadMarrowGame(marrowGame, contentPath);
            string palletListString = string.Join(", ", marrowGame.GamePallets);
            LogVerbose($"Load Game Pallets: {marrowGame.GameTitle}[{palletListString}]", true);
            if (loadStandalonePallets)
            {
                foreach (var pallet in marrowGame.StandalonePallets)
                {
                    string palletPath = WarehousePathResolver.EnsureValidPath(Path.Combine(contentPath, $"{pallet.Barcode}.pallet.json"));
                    LogVerbose($"Load Standalone Game Pallet {pallet.Barcode}: {palletPath}", true);
                    var loaded = await LoadPalletFromFolderAsync(palletPath);
                    if (loaded)
                    {
                        gamePallets.Add(pallet.Barcode);
                        palletToMarrowGameLookup[pallet.Barcode] = marrowGame;
                    }
                }
            }

            foreach (var pallet in marrowGame.GamePallets)
            {
                string palletPath = WarehousePathResolver.EnsureValidPath(Path.Combine(contentPath, $"{pallet.Barcode}.pallet.json"));
                LogVerbose($"Load Game Pallet {pallet.Barcode}: {palletPath}", true);
                var loaded = await LoadPalletFromFolderAsync(palletPath, customCatalog: marrowGame.GameTitle);
                if (loaded)
                {
                    gamePallets.Add(pallet.Barcode);
                    palletToMarrowGameLookup[pallet.Barcode] = marrowGame;
                }
            }
        }

        public async UniTask<bool> LoadPalletFromMarrowGame(string palletBarcode, string palletPath)
        {
            bool success = false;
            if (palletToMarrowGameLookup.TryGetValue(palletBarcode, out var marrowGame))
            {
                success = await LoadPalletFromFolderAsync(palletPath, customCatalog: marrowGame.GameTitle);
            }

            return success;
        }

        public async UniTask LoadPalletsFromFolderAsync(string path)
        {
            if (Directory.Exists(path))
            {
                string[] palletJsons = Directory.GetFiles(path, $"*{Pallet.PALLET_JSON_FILENAME}", SearchOption.AllDirectories);
                foreach (var palletJsonPath in palletJsons)
                {
                    bool success = await LoadPalletFromFolderAsync(palletJsonPath);
                }
            }
            else
            {
                Debug.LogWarning("AssetWarehouse: Cannot load pallets from folder, missing folder: " + (path == null ? "null" : path));
            }
        }

        public async UniTask<bool> LoadPalletFromFolderAsync(string palletPath, bool updateCatalog = false, string customCatalog = null, ModListing modListing = null)
        {
            palletPackStopWatch.Start();
            Pallet loadedPallet = null;
#if !UNITY_EDITOR && UNITY_ANDROID
#else
            loadedPallet = PalletPacker.UnpackJsonFromFile(palletPath);
#endif
            palletPackStopWatch.Stop();
            if (loadedPallet != null)
            {
                return await LoadPalletAsync(loadedPallet, palletPath, updateCatalog, customCatalog, modListing);
            }
            else
            {
                Debug.LogWarning("AssetWarehouse: Cannot read " + Pallet.PALLET_JSON_FILENAME + " at " + palletPath);
                return false;
            }
        }

        public async UniTask<bool> LoadPalletAsync(Pallet pallet, string palletPath, bool updateCatalog = false, string customCatalog = null, ModListing modListing = null, bool loadDataCards = true)
        {
            bool success = false;
            if (!string.IsNullOrEmpty(palletPath))
            {
                string catalogName = string.IsNullOrEmpty(customCatalog) ? pallet.Barcode : customCatalog;
                string catalogPath = palletPath.Replace($"{pallet.Barcode}.pallet.json", $"catalog_{catalogName}.json");
                catalogPath = catalogPath.Replace($"pallet.json", $"catalog_{catalogName}.json");
                WarehousePathResolver.EnsureValidPath(ref catalogPath);
                bool catalogExists = false;
#if !UNITY_EDITOR && UNITY_ANDROID
#else
                catalogExists = File.Exists(catalogPath);
#endif
                if (catalogExists)
                {
                    LogVerbose($"Found catalog for pallet {pallet.Barcode}: {catalogPath}", true);
                    bool runtimeUpdate = loadedCatalogs.Contains(catalogPath);
                    bool catalogLoaded = false;
                    IResourceLocator catalogLocator = null;
                    if (runtimeUpdate)
                    {
                        var checkForCatalogOp = Addressables.CheckForCatalogUpdates(false);
                        var updatableCatalogs = await checkForCatalogOp;
                        string updateCatalogPath = null;
                        if (updatableCatalogs != null && updatableCatalogs.Count > 0)
                        {
                            foreach (var catalog in updatableCatalogs)
                            {
                                if (Path.GetFullPath(catalogPath) == Path.GetFullPath(catalog))
                                {
                                    updateCatalogPath = catalog;
                                }
                            }

                            if (!string.IsNullOrEmpty(updateCatalogPath))
                            {
                                var catalogs = await Addressables.UpdateCatalogs(false, new[] { updateCatalogPath }, true);
                                catalogLoaded = catalogs != null && catalogs.Count > 0;
                                if (catalogLoaded)
                                {
                                    LogVerbose($"Updated catalog {catalogPath}: {catalogs[0].Keys.Count()} keys", true);
                                }
                                else
                                {
                                    Debug.LogError($"AssetWarehouse: Failed to update catalog for pallet {pallet.Barcode} at {catalogPath}, {updateCatalogPath}");
                                }
                            }
                        }

                        Addressables.Release(checkForCatalogOp);
                    }
                    else
                    {
                        var operationHandle = Addressables.LoadContentCatalogAsync(catalogPath, true);
#if UNITY_EDITOR
                        EditorApplication.QueuePlayerLoopUpdate();
#endif
                        catalogLocator = await operationHandle;
#if UNITY_EDITOR
                        EditorApplication.QueuePlayerLoopUpdate();
#endif
                        catalogLoaded = catalogLocator != null;
                        if (catalogLoaded)
                        {
                            loadedCatalogs.Add(catalogPath);
                            LogVerbose($"Loaded catalog {catalogPath}: {catalogLocator.Keys.Count()} keys", true);
                        }
                        else
                        {
                            Debug.LogError($"AssetWarehouse: Failed to open catalog for pallet {pallet.Barcode} at {catalogPath}");
                        }
                    }

                    if (catalogLoaded || runtimeUpdate)
                    {
                        LoadAndUpdatePalletManifest(pallet, modListing, palletPath, catalogPath, catalogLocator);
                        if (loadDataCards)
                            await LoadPalletDataCards(pallet);
                        AddPallet(pallet);
                        success = true;
                    }
                }
                else
                {
                    Debug.LogError($"AssetWarehouse: Cannot load catalog from path {catalogPath} for pallet {pallet.Barcode}");
                }
            }
            else if (string.IsNullOrEmpty(palletPath))
            {
                Debug.LogError($"AssetWarehouse: Cannot load pallet {pallet.Barcode} with null/empty pallet path");
            }

            return await UniTask.FromResult(success);
        }

        private void LoadAndUpdatePalletManifest(Pallet pallet, ModListing modListing, string palletPath, string catalogPath, IResourceLocator catalogLocator = null)
        {
            var manifestPath = PalletManifest.GetManifestPath(pallet);
            bool updateManifest = TryLoadCachedPalletManifest(out var loadedPalletManifest, manifestPath, out var loadedPalletManifestJson);
            var palletManifest = updateManifest ? new PalletManifest(loadedPalletManifest) : loadedPalletManifest;
            palletManifest.Pallet = pallet;
            palletManifest.PalletBarcode = pallet.Barcode;
            palletManifest.PalletPath = palletPath;
            palletManifest.CatalogPath = catalogPath;
            if (catalogLocator != null)
                palletManifest.Catalog = catalogLocator;
            if (string.IsNullOrEmpty(palletManifest.InstalledDate))
            {
                if (updateManifest)
                {
                    if (!string.IsNullOrEmpty(loadedPalletManifest.InstalledDate))
                    {
                        palletManifest.InstalledDate = loadedPalletManifest.InstalledDate;
                    }
                }
                else
                {
                    palletManifest.SetInstalledDateToNow();
                }
            }

            if (string.IsNullOrEmpty(palletManifest.UpdatedDate))
            {
                if (updateManifest)
                {
                    if (!string.IsNullOrEmpty(loadedPalletManifest.UpdatedDate))
                    {
                        palletManifest.UpdatedDate = loadedPalletManifest.UpdatedDate;
                    }
                }
                else
                {
                    palletManifest.UpdatedDate = palletManifest.InstalledDate;
                }
            }

            if (pallet.Version != palletManifest.Version)
            {
                palletManifest.Version = pallet.Version;
            }

            if (modListing != null)
            {
                if (!Barcode.IsValid(modListing.Barcode))
                    modListing.Barcode = pallet.Barcode;
                palletManifest.ModListing = modListing;
            }
            else
            {
                if (updateManifest && loadedPalletManifest.ModListing != null)
                {
                    palletManifest.ModListing = loadedPalletManifest.ModListing;
                }
            }

            try
            {
                var newJson = PalletPacker.PackManifestIntoJson(palletManifest);
                if (!updateManifest || string.IsNullOrEmpty(loadedPalletManifestJson) || !newJson.Equals(loadedPalletManifestJson, StringComparison.InvariantCulture))
                {
                    UpdatePalletManifest(palletManifest, newJson);
                }

                CachePalletManifest(palletManifest);
            }
            catch (Exception e)
            {
                Debug.LogError($"AssetWarehouse: Failed to update pallet manifest for pallet: {pallet.name}: {pallet.Barcode}");
                Debug.LogException(e);
            }
        }

        private bool TryLoadCachedPalletManifest(out PalletManifest palletManifest, string manifestPath, out string palletManifestJson)
        {
            palletManifestPackStopWatch.Start();
            if (PalletPacker.TryUnpackManifestJsonFromFile(manifestPath, out palletManifest, out palletManifestJson))
            {
                palletManifestPackStopWatch.Stop();
                return true;
            }
            else
            {
                palletManifestPackStopWatch.Stop();
                palletManifest = new PalletManifest();
                return false;
            }
        }

        public bool TryGetPalletManifest(string barcode, out PalletManifest palletManifest)
        {
            return palletManifests.TryGetValue((Barcode)barcode, out palletManifest);
        }

        public bool UpdatePalletManifest(PalletManifest palletManifest, string json = "")
        {
            bool success = PalletPacker.TryPackManifestAndSaveToJson(palletManifest, palletManifest.ManifestPath, json);
            return success;
        }

        private void CachePalletManifest(PalletManifest palletManifest)
        {
            palletManifests[palletManifest.Pallet.Barcode] = palletManifest;
        }

        public List<PalletManifest> GetPalletManifests()
        {
            return palletManifests.Values.ToList();
        }

        public async UniTask LoadPalletDataCards(Pallet pallet)
        {
            bool isPlaying = Application.isPlaying;
#if UNITY_EDITOR
            isPlaying = isPlaying || EditorApplication.isPlayingOrWillChangePlaymode;
#endif
            if (isPlaying)
            {
                List<DataCard> loadedDataCards = new List<DataCard>();
                foreach (var dataCard in pallet.DataCards)
                {
                    DataCard loadedDataCard = dataCard;
                    if (dataCard.IsBundledDataCard())
                    {
                        try
                        {
                            LogVerbose($"Load DataCard<{loadedDataCard.GetType().Name}> {loadedDataCard.Title}");
                            var loadCard = await dataCard.DataCardAsset.LoadAssetAsync();
                            if (loadCard != null)
                            {
                                loadedDataCard = loadCard;
#if UNITY_EDITOR
                                if (isPlaying)
                                {
                                    if (!string.IsNullOrEmpty(AssetDatabase.GetAssetPath(loadCard)))
                                    {
                                        loadedDataCard = Object.Instantiate(loadCard);
                                        loadedDataCard.ExportPackedAssets();
                                    }
                                }

#endif
                                loadedDataCard.DataCardAsset = dataCard.DataCardAsset;
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.LogError($"AssetWarehouse: Failed to load DataCard({dataCard.GetType().Name}) \"{dataCard.Title}\" from Pallet \"{dataCard.Pallet.Title}\"");
                            loadedDataCard = null;
                        }
                    }

                    if (loadedDataCard != null)
                        loadedDataCards.Add(loadedDataCard);
                }

                pallet.DataCards.Clear();
                pallet.DataCards.AddRange(loadedDataCards);
            }
        }

#if UNITY_EDITOR
        public void ClearPallets()
        {
            _inventoryRegistry.Clear();
            _palletRegistry.Clear();
            palletManifests.Clear();
            OnChanged?.Invoke();
        }

        private void OnBeforeDomainReload()
        {
            Clear();
        }
#endif
    }

    public static class AssetWarehouseExtensions
    {
        public static List<T> Filter<T>(this List<T> crateList, ICrateFilter<T> crateFilter)
            where T : Crate
        {
            return AssetWarehouse.Instance.FilterCrates(ref crateList, crateFilter);
        }
    }
}