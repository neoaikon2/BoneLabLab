using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	public static class LateReferenceManager
	{
		private static ExportTable _exportTableOfLastResort;

		private static readonly Dictionary<string, SceneExportTable> _sceneExportIndex;

		private static readonly Dictionary<string, UnityEngine.Object> _sceneObjectsById;

		private static readonly Dictionary<UnityEngine.Object, string> _sceneIdsByObject;

		private static readonly Dictionary<string, HashSet<LateReference>> _subscriptions;

		public static bool TryGetIdForObject(UnityEngine.Object obj, [Out] ExportTable exportTable, [Out] string uniqueId)
		{
			return default(bool);
		}

		public static bool TryGetObject<T>(LateReference<T> lateReference, [Out] ExportTable exportTable, [Out] T obj) where T : UnityEngine.Object
		{
			return default(bool);
		}

		public static bool FindSuitableExportTableForObject(UnityEngine.Object obj, [Out] ExportTable exportTable)
		{
			return default(bool);
		}

		public static void Register(ExportTable exportTable, LateReference lateReference)
		{
		}

		public static void AddSubscription<T>(LateReference<T> lateReference) where T : UnityEngine.Object
		{
		}

		public static void LinkSubscribedLateReferences()
		{
		}

		public static int VacuumLinks()
		{
			return default(int);
		}

		public static void LoadTable(SceneExportTable exportTable)
		{
		}

		public static void UnloadTable(SceneExportTable exportTable)
		{
		}
	}
}
