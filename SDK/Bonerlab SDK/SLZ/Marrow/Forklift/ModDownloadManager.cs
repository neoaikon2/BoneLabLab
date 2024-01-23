using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JetBrains.Annotations;
using SLZ.Marrow.Forklift.Model;
using SLZ.Marrow.Warehouse;
using UnityEngine.Networking;

namespace SLZ.Marrow.Forklift
{
	[UsedImplicitly]
	public sealed class ModDownloadManager : IDisposable
	{
		public enum ModDownloadState
		{
			Started = 0,
			Progress = 1,
			Ended = 2
		}

		public delegate void OnModDownloadDelegate(ModDownloadManager modDownloadManager, FileDownloader.TaskItem taskItem, ModDownloadState state, float progress);

		public readonly FileDownloader FileDownloader;

		private bool _verboseLogging;

		private readonly bool INSTALL_COWARDICE;

		private const bool SPAMMY_UPDATES = false;

		private List<string> _targetPreferenceOrder;

		private static string badCharsRegex;

		public bool VerboseLogging
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool TryParseRepository(UnityWebRequest uwr, [Out] ModRepository repo)
		{
			return default(bool);
		}

		public UniTask<List<ModRepository>> FetchRepositoriesAsync(string parent)
		{
			return default(UniTask<List<ModRepository>>);
		}

		public static UniTask<List<ValueTuple<int, Uri>>> ReadValidUrlsAsync(string repositoriesList)
		{
			return default(UniTask<List<ValueTuple<int, Uri>>>);
		}

		public void SetModTargetPreferenceOrder(params string[] targetNames)
		{
			targetNames = default(string[]);
		}

		public bool TrySelectModTarget<TModTarget>(ModListing mod, [Out] TModTarget modTarget) where TModTarget : ModTarget
		{
			return default(bool);
		}

		private static string hashUrl(Uri uri)
		{
			return null;
		}

		public void DownloadMod(ModListing mod, ModTarget target)
		{
		}

		private void ModDownloadManager_OnDownloadStarted(FileDownloader FileDownloader, UnityWebRequest uwr, FileDownloader.TaskItem taskItem)
		{
		}

		private void ModDownloadManager_OnDownloadProgressed(FileDownloader FileDownloader, FileDownloader.TaskItem taskItem, float progress)
		{
		}

		private void ModDownloadManager_OnDownloadFinished(FileDownloader FileDownloader, UnityWebRequest uwr, FileDownloader.TaskItem taskItem)
		{
		}

		public void Dispose()
		{
		}

		public ModDownloadManager()
			: base()
		{
		}

		public event OnModDownloadDelegate OnModDownload;
	}
}
