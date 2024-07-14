using System;
using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	public class Tracker : MonoBehaviour
	{
		private static ComponentCache<Tracker> _cache;

		[SerializeField]
		private MarrowEntity _entity;

		[SerializeField]
		private MarrowBody _body;

		[SerializeField]
		private Collider _collider;

		private List<Action<Collider>> _onDisableActions;

		public static ComponentCache<Tracker> Cache => null;

		public bool HasBody { get; private set; }

		public MarrowEntity Entity => null;

		public MarrowBody Body => null;

		public Collider Collider => null;

		private bool CanUpdateValues(Vector3 orignal, Vector3 updated)
		{
			return false;
		}

		private bool CanUpdateValues(float original, float updated)
		{
			return false;
		}

		internal void Validate(TrackerSettings settings, MarrowBody body, MarrowEntity entity)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		internal void OnDeactivate()
		{
		}

		public void AddDisableCallback(Action<Collider> callback)
		{
		}

		public void RemoveDisableCallback(Action<Collider> callback)
		{
		}
	}
}
