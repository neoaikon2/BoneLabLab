using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Forklift.Model;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;

namespace SLZ.Marrow.Warehouse
{
	public class AssetWarehouse
	{
		public class HideLevelCrateFilter : ICrateFilter<LevelCrate>
		{
			public bool Filter(LevelCrate crate)
			{
				return default(bool);
			}

			public HideLevelCrateFilter()
				: base()
			{
			}
		}

		public static AssetWarehouse Instance;

		public static bool ready;

		private static Action _onReady;

		private bool initialized;

		private readonly Dictionary<Barcode, PalletManifest> palletManifests;

		private readonly Dictionary<int, PalletManifest> modioPalletManifestsLookup;

		private readonly List<string> loadedCatalogs;

		private HashSet<string> gamePallets;

		private readonly Dictionary<string, MarrowSettings> marrowGames;

		private readonly Dictionary<string, MarrowSettings> palletToMarrowGameLookup;

		private readonly Dictionary<string, string> marrowGameLocations;

		private readonly Dictionary<Barcode, Scannable> _inventoryRegistry;

		private readonly Dictionary<Barcode, Scannable> _oldBarcodeInventoryRegistry;

		private readonly Dictionary<MarrowGuid, Scannable> _slimCodeInventoryRegistry;

		private readonly Dictionary<Barcode, Pallet> _palletRegistry;

		private bool _simulateBuiltPallets;

		[SerializeField]
		[ReadOnly(false)]
		private List<string> _allTags;

		[ReadOnly(false)]
		[SerializeField]
		private bool _initialLoaded;

		private Stopwatch palletPackStopWatch;

		private Stopwatch palletManifestPackStopWatch;

		public Action OnChanged;

		public Action<string> OnPalletAdded;

		public Action<string> OnCrateAdded;

		public Action<string> OnDataCardAdded;

		public bool SimulateBuiltPallets
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Dictionary<Barcode, Scannable> InventoryRegistry
		{
			get
			{
				return null;
			}
		}

		public List<string> AllTags
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool InitialLoaded
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public static void OnReady(Action callbackWhenReady)
		{
		}

		public UniTask InitAsync()
		{
			return default(UniTask);
		}

		private void CleanupPalletManifests()
		{
		}

		private void Init()
		{
		}

		public AssetWarehouse(bool autoInit = true)
			: base()
		{
		}

		~AssetWarehouse()
		{
		}

		public void Clear()
		{
		}

		private UniTask LoadInitialPalletsAsync()
		{
			return default(UniTask);
		}

		[MarrowInternal]
		private UniTask LoadInitialPalletsAsync_Build()
		{
			return default(UniTask);
		}

		private UniTask LoadInitialPalletsAsync_Editor()
		{
			return default(UniTask);
		}

		public Crate GetCrate(Barcode barcode)
		{
			return null;
		}

		public T GetCrate<T>(string barcode) where T : Crate
		{
			return null;
		}

		public UniTask<T> GetCrateAsync<T>(string barcode, Action<T> callback = default(Action<T>)) where T : Crate
		{
			return default(UniTask<T>);
		}

		public UniTask<Crate> GetCrateAsync(string barcode, Action<Crate> callback = default(Action<Crate>), CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Crate>);
		}

		public bool TryGetPallet(string barcode, [Out] Pallet pallet)
		{
			return default(bool);
		}

		public bool TryGetPallet(MarrowGuid slimCode, [Out] Pallet pallet)
		{
			return default(bool);
		}

		public bool TryGetCrate(string barcode, [Out] Crate crate)
		{
			return default(bool);
		}

		public bool TryGetCrate<T>(string barcode, [Out] T crateT) where T : Crate
		{
			return default(bool);
		}

		public bool TryGetDataCard(string barcode, [Out] DataCard dataCard)
		{
			return default(bool);
		}

		public bool TryGetDataCard<T>(string barcode, [Out] T dataCardT) where T : DataCard
		{
			return default(bool);
		}

		public bool TryGetCrate<T>(MarrowGuid slimCode, [Out] T crateT) where T : Crate
		{
			return default(bool);
		}

		public bool TryGetScannable(string barcode, [Out] Scannable scannable)
		{
			return default(bool);
		}

		public bool TryGetScannable<T>(string barcode, [Out] T scannableT) where T : Scannable
		{
			return default(bool);
		}

		public bool TryGetScannable<T>(MarrowGuid slimCode, [Out] T scannableT) where T : Scannable
		{
			return default(bool);
		}

		public bool TryGetSlimCode(string barcode, [Out] MarrowGuid slimCode)
		{
			return default(bool);
		}

		public bool HasScannable<T>(string barcode) where T : Scannable
		{
			return default(bool);
		}

		public bool HasScannable(string barcode)
		{
			return default(bool);
		}

		public bool HasCrate<T>(string barcode) where T : Crate
		{
			return default(bool);
		}

		public bool HasCrate(string barcode)
		{
			return default(bool);
		}

		public bool HasDataCard<T>(string barcode) where T : DataCard
		{
			return default(bool);
		}

		public bool HasDataCard(string barcode)
		{
			return default(bool);
		}

		public bool HasPallet(string barcode)
		{
			return default(bool);
		}

		public bool UnloadCrateAsset(string barcode, bool forcedUnload = false)
		{
			return default(bool);
		}

		public bool UnloadCrateAsset(Crate crate, bool forcedUnload = false)
		{
			return default(bool);
		}

		public bool UnloadDataCardAsset(DataCard dataCard, bool forcedUnload = false)
		{
			return default(bool);
		}

		public int UnloadAllCrateAssets()
		{
			return default(int);
		}

		public int UnloadAllCrateAssets(string excludeBarcode)
		{
			return default(int);
		}

		public int UnloadAllCrateAssets(params string[] excludeBarcodes)
		{
			excludeBarcodes = default(string[]);
			return default(int);
		}

		public int UnloadAllDataCardAssets()
		{
			return default(int);
		}

		public int UnloadAllDataCardAssets(string excludeBarcode)
		{
			return default(int);
		}

		public int UnloadAllDataCardAssets(params string[] excludeBarcodes)
		{
			excludeBarcodes = default(string[]);
			return default(int);
		}

		public void UnloadCrate(string barcode)
		{
		}

		public void UnloadCrate(Crate crate)
		{
		}

		public void UnloadDataCard(string barcode)
		{
		}

		public void UnloadDataCard(DataCard dataCard)
		{
		}

		private void DestroyRuntimeCreatedScannable(Scannable scannable)
		{
		}

		private void AddPallet(Pallet pallet)
		{
		}

		private void AddCrate(Crate crate)
		{
		}

		private void AddDataCard(DataCard dataCard)
		{
		}

		private bool AddScannable(Scannable item)
		{
			return default(bool);
		}

		public void ReloadPallet(string barcode)
		{
		}

		public void UnloadPallet(string barcode)
		{
		}

		public void UnloadPallet(Pallet pallet)
		{
		}

		public void UnloadAllPallets()
		{
		}

		public void DeletePallet(string barcode)
		{
		}

		public void DeletePallet(Pallet pallet)
		{
		}

		private static bool PathContainsPath(string path, string subPath)
		{
			return default(bool);
		}

		private void AddTags(List<string> newTags)
		{
		}

		public List<Pallet> GetPallets()
		{
			return null;
		}

		public void GetPallets(List<Pallet> pallets)
		{
		}

		public List<Crate> GetCrates()
		{
			return null;
		}

		public void GetCrates([In] List<Crate> crates)
		{
		}

		public List<DataCard> GetDataCards()
		{
			return null;
		}

		public void GetDataCards([In] List<DataCard> dataCards)
		{
		}

		public List<T> FilterCrates<T>(List<T> crateList, ICrateFilter<T> crateFilter) where T : Crate
		{
			return null;
		}

		public List<T> GetCrates<T>(ICrateFilter<T> crateFilter = default(ICrateFilter<T>)) where T : Crate
		{
			return null;
		}

		public void TestQueries()
		{
		}

		public static void LogVerbose(string text, bool logInRuntime = false)
		{
		}

		public void LoadPalletsFromModsFolder()
		{
		}

		public UniTask LoadPalletsFromModsFolderAsync()
		{
			return default(UniTask);
		}

		public UniTask LoadMarrowGame(MarrowSettings marrowGame, string contentPath)
		{
			return default(UniTask);
		}

		[MarrowInternal]
		public UniTask LoadInternalGamePallets()
		{
			return default(UniTask);
		}

		public UniTask LoadGamePallets(MarrowSettings marrowGame, string contentPath)
		{
			return default(UniTask);
		}

		public bool IsPalletInMarrowGame(Pallet pallet)
		{
			return default(bool);
		}

		public bool IsPalletInMarrowGame(Pallet pallet, string marrowGameTitle)
		{
			return default(bool);
		}

		public UniTask<bool> LoadPalletFromMarrowGame(string palletBarcode, string palletPath)
		{
			return default(UniTask<bool>);
		}

		public UniTask LoadPalletsFromFolderAsync(string path)
		{
			return default(UniTask);
		}

		public UniTask<bool> LoadPalletFromFolderAsync(string palletPath, bool updateCatalog = false, string customCatalog = default(string), ModListing modListing = default(ModListing))
		{
			return default(UniTask<bool>);
		}

		public UniTask<bool> LoadPalletAsync(Pallet pallet, string palletPath, bool updateCatalog = false, string customCatalog = default(string), ModListing modListing = default(ModListing), bool loadDataCards = true)
		{
			return default(UniTask<bool>);
		}

		private void LoadAndUpdatePalletManifest(Pallet pallet, ModListing modListing, string palletPath, string catalogPath, IResourceLocator catalogLocator = default(IResourceLocator))
		{
		}

		private bool TryLoadCachedPalletManifest([Out] PalletManifest palletManifest, string manifestPath, [Out] string palletManifestJson)
		{
			return default(bool);
		}

		public bool TryGetPalletManifest(string barcode, [Out] PalletManifest palletManifest)
		{
			return default(bool);
		}

		public bool UpdatePalletManifest(PalletManifest palletManifest, string json = "")
		{
			return default(bool);
		}

		private void CachePalletManifest(PalletManifest palletManifest)
		{
		}

		public List<PalletManifest> GetPalletManifests()
		{
			return null;
		}

		public UniTask LoadPalletDataCards(Pallet pallet)
		{
			return default(UniTask);
		}
	}
}
