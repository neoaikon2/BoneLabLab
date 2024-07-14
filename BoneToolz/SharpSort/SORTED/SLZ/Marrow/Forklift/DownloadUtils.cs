using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Forklift
{
	public static class DownloadUtils
	{
		public static void ParseIntoUrls(List<string> strings, out List<Uri> parsedUrls, out List<FetchError> errors)
		{
			parsedUrls = null;
			errors = null;
		}

		public static void GroupUrlsByHost(List<Uri> urls, out Dictionary<string, List<Uri>> groupedUrls, out List<FetchError> errors)
		{
			groupedUrls = null;
			errors = null;
		}

		public static Queue<TItem> LinearizeRoundRobin<TGroupKey, TItem>(Dictionary<TGroupKey, List<TItem>> groupedRequests)
		{
			return null;
		}

		public static void FillItems<TItem>(ref Queue<TItem> from, List<TItem> into, int limit, List<int> filledIndices, Func<TItem, List<TItem>, bool> shouldAddItemToList)
		{
		}
	}
}
