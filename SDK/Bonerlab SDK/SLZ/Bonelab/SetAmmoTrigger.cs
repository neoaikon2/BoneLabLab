using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class SetAmmoTrigger : MonoBehaviour
	{
		public LayerMask layerMask;

		public UnityEvent oneTimeFire;

		private bool used;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
