using SLZ.Marrow.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(Zone))]
	public class ZoneEventDebugger : MonoBehaviour
	{
		[SerializeField]
		private Zone _zone;

		public EntityAggregator aggregator;

		public UnityEvent<MarrowBody> OnBodyTriggerEnter;

		public UnityEvent<MarrowBody> OnBodyTriggerExit;

		public UnityEvent<MarrowEntity> OnEntityTriggerEnter;

		public UnityEvent<MarrowEntity> OnEntityTriggerExit;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void _OnBodyTriggerEnter(MarrowBody body)
		{
		}

		private void _OnBodyTriggerExit(MarrowBody body)
		{
		}

		private void _OnEntityTriggerEnter(MarrowEntity entity)
		{
		}

		private void _OnEntityTriggerExit(MarrowEntity entity)
		{
		}
	}
}
