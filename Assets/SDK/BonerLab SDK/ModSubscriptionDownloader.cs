using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Forklift;
using SLZ.Marrow.Forklift.Model;
using SLZ.Marrow.Warehouse;
using SLZ.ModIO;
using SLZ.ModIO.ApiModels;

public class ModSubscriptionDownloader
{
	private class ModDownloadProgressInfo
	{
		public ModObject modObject;

		public ModListing modListing;

		public ModIOModTarget modioModTarget;

		public FileDownloadProgress progress;

		public bool update;

		public ModDownloadProgressInfo(ModObject modObject, ModListing modListing, ModIOModTarget modioModTarget, bool update)
		{
		}

		public float GetPercent()
		{
			return 0f;
		}
	}
	private bool _isDownloading;

	private readonly ModIOManager _modIOManager;

	public int maxConcurrentDownloads;

	private string downloadedMods;

	private List<ModListing> downloadedModsList;

	private int downloadModsCount;

	private List<ModListing> updatedModsList;

	private string downloadedFailedMods;

	private List<ModListing> downloadedFailedModsList;

	private int downloadFailedModsCount;

	private int currentDownloadCount;

	private int totalDownloads;

	private string modTargetPlatformName;

	private string modIOPlatformName;

	private Stopwatch totalStopwatch;

	private CancellationTokenSource downloadCancelToken;

	private Dictionary<long, ModDownloadProgressInfo> modDownloadProgressInfos;

	private Dictionary<long, long> invalidModFiles;

	private Dictionary<long, PalletManifest> installedModIOPallets;

	private Action<string> outputTextAction;

	public Action downloadComplete;

	private string outputText;

	private List<PalletCollisionException> palletCollisions;

	public bool IsDownloading
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public ModSubscriptionDownloader(ModIOManager modIOManager, Action<string> outputTextLog)
	{
	}

	private void ApplicationQuitting()
	{
	}

	public void StopDownloading(bool doNotDispose = false)
	{
	}
	public UniTaskVoid DownloadAllSubscribedMods()
	{
		return default(UniTaskVoid);
	}

	public static string ModObjectToString(ModObject modObject)
	{
		return null;
	}

	private void DeleteUnsubscribedMods(List<ModObject> subscriptions)
	{
	}

	private bool TryGetModObjectPlatform(ModObject modObject, out ModPlatformsObject modObjectPlatform)
	{
		modObjectPlatform = default(ModPlatformsObject);
		return false;
	}

	private List<ModObject> FilterSubscriptions(List<ModObject> subscriptions, out List<ModObject> addSubs, out List<ModObject> updateSubs)
	{
		addSubs = null;
		updateSubs = null;
		return null;
	}
	public UniTaskVoid PrintDownloadCount()
	{
		return default(UniTaskVoid);
	}
	public UniTaskVoid OutputDebugText()
	{
		return default(UniTaskVoid);
	}
	private UniTask DownloadMod(ModListing modListing, ModIOModTarget modTarget, ModObject modObject, bool updatePallet, CancellationToken cancellationToken)
	{
		return default(UniTask);
	}

	private string BytesToReadable(long bytes)
	{
		return null;
	}
	private UniTask<Result<List<ModObject>>> TryGetAllModIOSubscriptions_BE_CAREFUL(CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(UniTask<Result<List<ModObject>>>);
	}
	public static UniTask<T[]> WhenAllWithProgress<T>(IReadOnlyCollection<UniTask<T>> tasks, IProgress<float> progress, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(UniTask<T[]>);
	}
}
