using System;
using UnityEngine;

namespace SLZ.AI
{
	public class AITrigger : MonoBehaviour
	{
		public TriggerManager.TriggerTypes type;

		public float radius;

		public float fov;

		public Action<AITarget> onTriggerEnter;

		public Action<AITarget> onTriggerExit;

		public void SetTrigger(float? radius = null, float? fov = null, TriggerManager.TriggerTypes? type = null)
		{
		}

		public bool TryGetTargetResult(AITarget target, out TriggerManager.TriggerCompareResult result)
		{
			result = default(TriggerManager.TriggerCompareResult);
			return false;
		}

		public virtual void OnAITriggerEnter(AITarget target)
		{
		}

		public virtual void OnAITriggerExit(AITarget target)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
