using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Rigidbody))]
	public class GetVelocity : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody rigidbody;

		private static ComponentCache<GetVelocity> _cache;

		public static ComponentCache<GetVelocity> Cache => null;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		public void SetVelocity(Vector3 Velocity)
		{
		}

		private void OnDisable()
		{
		}
	}
}
