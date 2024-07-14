using System;
using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.PhysxHelpers
{
	public class PhysxTriggerHelper : MonoBehaviour
	{
		private static ComponentCache<PhysxTriggerHelper> _cache;

		private List<Action<Collider, Rigidbody>> _onDisableActions;

		private Collider _collider;

		private Rigidbody _rigidbody;

		public static ComponentCache<PhysxTriggerHelper> Cache => null;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public static PhysxTriggerHelper GetHelper(Collider col)
		{
			return null;
		}

		public static void AddDisableCallback(Collider col, Action<Collider, Rigidbody> callback)
		{
		}

		public static void RemoveDisableCallback(Collider col, Action<Collider, Rigidbody> callback)
		{
		}
	}
}
