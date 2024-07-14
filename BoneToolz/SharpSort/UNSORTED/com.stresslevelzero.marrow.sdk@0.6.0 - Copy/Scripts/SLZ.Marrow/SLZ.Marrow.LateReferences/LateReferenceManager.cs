using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	public static class LateReferenceManager
	{
		private static ExportTable _exportTableOfLastResort;

		private static readonly Dictionary<string, SceneExportTable> _sceneExportIndex;

		private static readonly Dictionary<string, Object> _sceneObjectsById;

		private static readonly Dictionary<Object, string> _sceneIdsByObject;

		private static readonly Dictionary<string, HashSet<LateReference>> _subscriptions;

		public static bool TryGetIdForObject(Object obj, out ExportTable exportTable, out string uniqueId)
		{
			exportTable = null;
			uniqueId = null;
			return false;
		}

		public static bool TryGetObject<T>(LateReference<T> lateReference, out ExportTable exportTable, out T obj) where T : Object
		{
			exportTable = null;
			obj = null;
			return false;
		}

		public static bool FindSuitableExportTableForObject(Object obj, out ExportTable exportTable)
		{
			exportTable = null;
			return false;
		}

		public static void Register(ExportTable exportTable, LateReference lateReference)
		{
		}

		public static void AddSubscription<T>(LateReference<T> lateReference) where T : Object
		{
		}

		public static void LinkSubscribedLateReferences()
		{
		}

		public static int VacuumLinks()
		{
			return 0;
		}

		public static void LoadTable(SceneExportTable exportTable)
		{
		}

		public static void UnloadTable(SceneExportTable exportTable)
		{
		}
	}
}
