using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Forklift.Model;

namespace SLZ.Marrow.Forklift
{
	public static class ModRepositoryWorkflow
	{
		[PublicAPI]
		public static bool TryParseRepository(JObject repositoryJson, out ModRepository repo)
		{
			repo = null;
			return false;
		}
		[PublicAPI]
		public static UniTask<ModRepository[]> FetchRepositoriesAsync(string parent)
		{
			return default(UniTask<ModRepository[]>);
		}
		[PublicAPI]
		public static UniTask<List<(int, Uri)>> ReadValidUrlsAsync(string repositoriesList)
		{
			return default(UniTask<List<(int, Uri)>>);
		}
	}
}
