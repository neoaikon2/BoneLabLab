using System.Collections.Generic;
using SLZ.Marrow.Plugins;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[MarrowPlugin("SLZ.Marrow.Plugins", "Overlap Trigger", "0.0.1")]
	public class OverlapTriggerManager : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		private enum EventType
		{
			TriggerEnter = 0,
			TriggerExit = 1
		}

		private static OverlapTriggerManager _manager;

		private readonly Dictionary<GameObject, Dictionary<GameObject, int>> _overlapCounts;

		private readonly Dictionary<GameObject, HashSet<GameObject>> _helperPairLookup;

		private readonly Queue<(EventType type, OverlapTrigger trigger, GameObject gameObject)> _triggerEvents;

		private readonly List<OverlapTrigger> _getComponentsTriggerCache;

		public static OverlapTriggerManager Instance => null;

		~OverlapTriggerManager()
		{
		}

		public void AddOverlapEnterPair(OverlapTrigger trigger, GameObject otherGameObject)
		{
		}

		public void AddOverlapExitPair(OverlapTrigger trigger, GameObject otherGameObject)
		{
		}

		public void DisableOverlap(GameObject overlapObject)
		{
		}

		private void ClearPair(OverlapTrigger trigger, GameObject otherGameObject)
		{
		}

		private void AddHelper(GameObject triggerGameObject, GameObject otherGameObject)
		{
		}

		private void RemoveHelper(GameObject triggerGameObject, GameObject otherGameObject)
		{
		}

		private void OnMarrowUpdate()
		{
		}
	}
}
