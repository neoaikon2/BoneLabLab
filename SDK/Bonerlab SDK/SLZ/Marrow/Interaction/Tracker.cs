using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

		public static ComponentCache<Tracker> Cache
		{
			get
			{
				return null;
			}
		}

		public bool HasBody { get; private set; }

		public MarrowEntity Entity
		{
			get
			{
				return null;
			}
		}

		public MarrowBody Body
		{
			get
			{
				return null;
			}
		}

		public Collider Collider
		{
			get
			{
				return null;
			}
		}

		private bool CanUpdateValues(Vector3 orignal, Vector3 updated)
		{
			return default(bool);
		}

		private bool CanUpdateValues(float original, float updated)
		{
			return default(bool);
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

		public Tracker()
			: base()
		{
		}
	}
}
