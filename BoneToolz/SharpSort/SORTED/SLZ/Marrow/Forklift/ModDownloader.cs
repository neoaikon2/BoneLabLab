using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Forklift.Model;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Forklift
{
	[PublicAPI]
	public static class ModDownloader
	{
		private const bool SPAMMY_UPDATES = false;

		private const bool STRICT_VERSION_EQUALITY_CHECK = false;

		[CanBeNull]
		private static JObject ModSettingsJSON;

		private static Dictionary<long, long> invalidMods;

		public static bool VerboseLogging => false;

		public static ModIOManager ModIOManager { get; set; }

		private static string ModSettingsPath => null;
		public static UniTask LoadModSettings()
		{
			return default(UniTask);
		}

		public static Dictionary<long, long> GetInvalidMods()
		{
			return null;
		}
		public static UniTask AddInvalidModFile(long modID, long fileID, CancellationToken cancelToken)
		{
			return default(UniTask);
		}
		public static UniTask RemoveInvalidModFile(long modID, CancellationToken cancelToken)
		{
			return default(UniTask);
		}
		public static UniTask WriteModSettings()
		{
			return default(UniTask);
		}
		public static UniTask<Pallet> DownloadMod(ModListing listing, ModTarget target, [CanBeNull] IProgress<FileDownloadProgress> progress, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Pallet>);
		}
	}
}
