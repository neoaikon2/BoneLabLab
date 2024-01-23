using System;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Combat
{
	[Serializable]
	public class UnityEventCollision : UnityEvent<Collider, Vector3, Vector3>
	{
	}
}
