using SLZ.Marrow.Warehouse;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Search;
using UnityEngine;

public static class ScannableQueryEngine
{
    public static int scanQuerySearchErrorCount = 0;
    public static QueryEngine<Scannable> SetupQueryEngine()
    {
        var queryEngine = new QueryEngine<Scannable>();
        queryEngine.SetSearchDataCallback(GetSearchData, s => s.ToLowerInvariant(), System.StringComparison.Ordinal);
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
            if (scannable is Crate crate && crate.GetType() == typeof(AvatarCrate))
                return crate.Title;
            return string.Empty;
        });
        queryEngine.AddFilter("l", scannable =>
        {
            if (scannable is Crate crate && crate.GetType() == typeof(LevelCrate))
                return crate.Title;
            return string.Empty;
        });
        queryEngine.AddFilter("s", scannable =>
        {
            if (scannable is Crate crate && crate.GetType() == typeof(SpawnableCrate))
                return crate.Title;
            return string.Empty;
        });
        queryEngine.AddFilter("d", scannable =>
        {
            if (scannable is DataCard dataCard && dataCard.GetType() == typeof(BoneTag))
                return dataCard.Title;
            return string.Empty;
        });
        queryEngine.AddFilter("b", scannable => scannable.Barcode.ToString());
        return queryEngine;
    }

    static IEnumerable<string> GetSearchData(Scannable scannable)
    {
        if (scannable == null)
        {
            yield break;
        }

        yield return scannable.Title.ToLowerInvariant();
    }

    public static IEnumerable<Scannable> FilterScannableData(string inputQuery, QueryEngine<Scannable> queryEngine, IEnumerable<Scannable> inputData)
    {
        Query<Scannable> query = queryEngine.Parse(inputQuery);
        query.returnPayloadIfEmpty = true;
        if (!query.valid)
        {
            foreach (var queryError in query.errors)
            {
                if (scanQuerySearchErrorCount == 0)
                {
                    if (inputQuery.Substring(inputQuery.Length - 1) != " " && (queryError.reason.Contains("incomplete") || queryError.reason.Contains("right-hand operand")))
                    {
                        Debug.LogFormat(LogType.Warning, LogOption.NoStacktrace, null, $"Scannables Search Query Error at {queryError.index}: {queryError.reason}");
                    }
                }
                else
                {
                    if (!queryError.reason.Contains("incomplete") && !queryError.reason.Contains("right-hand operand"))
                    {
                        Debug.LogFormat(LogType.Error, LogOption.NoStacktrace, null, $"Scannables Search Query Error at {queryError.index}: {queryError.reason}");
                    }
                }

                scanQuerySearchErrorCount++;
            }

            return new List<Scannable>();
        }

        var filteredData = query.Apply(inputData);
        return filteredData;
    }

    public static void ValidateData(IEnumerable<Scannable> filteredData, IEnumerable<Scannable> expectedData)
    {
        var filteredDataArray = filteredData.ToArray();
        var expectedDataArray = expectedData.ToArray();
        Debug.Assert(filteredDataArray.Length == expectedDataArray.Length, $"FilteredScannables data should have {expectedDataArray.Length} elements.");
        if (filteredDataArray.Length != expectedDataArray.Length)
            return;
        for (var i = 0; i < expectedDataArray.Length; i++)
        {
            Debug.Assert(filteredDataArray[i] == expectedDataArray[i], $"{filteredDataArray[i]} should be equal to {expectedDataArray[i]}");
        }
    }
}