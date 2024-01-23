using System.Collections.Generic;
using Unity.Profiling;

namespace TMPro
{
	public class TMP_UpdateManager
	{
		private static TMP_UpdateManager s_Instance;

		private readonly HashSet<int> m_LayoutQueueLookup;

		private readonly List<TMP_Text> m_LayoutRebuildQueue;

		private readonly HashSet<int> m_GraphicQueueLookup;

		private readonly List<TMP_Text> m_GraphicRebuildQueue;

		private readonly HashSet<int> m_InternalUpdateLookup;

		private readonly List<TMP_Text> m_InternalUpdateQueue;

		private readonly HashSet<int> m_CullingUpdateLookup;

		private readonly List<TMP_Text> m_CullingUpdateQueue;

		private static ProfilerMarker k_RegisterTextObjectForUpdateMarker;

		private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker;

		private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker;

		private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker;

		private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker;

		private static TMP_UpdateManager instance
		{
			get
			{
				return null;
			}
		}

		private TMP_UpdateManager()
			: base()
		{
		}

		internal static void RegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}

		private void InternalRegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}

		public static void RegisterTextElementForLayoutRebuild(TMP_Text element)
		{
		}

		private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
		}

		public static void RegisterTextElementForGraphicRebuild(TMP_Text element)
		{
		}

		private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
		}

		public static void RegisterTextElementForCullingUpdate(TMP_Text element)
		{
		}

		private void InternalRegisterTextElementForCullingUpdate(TMP_Text element)
		{
		}

		private void OnCameraPreCull()
		{
		}

		private void DoRebuilds()
		{
		}

		internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}

		public static void UnRegisterTextElementForRebuild(TMP_Text element)
		{
		}

		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
		}

		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
		}

		private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}
	}
}
