using UnityEngine;

namespace SLZ.Bonelab
{
	public class DoorLockTrigger : MonoBehaviour
	{
		private bool m_locked;

		public GameObject thisKey;

		private DoorControl doorControl;

		public bool locked => false;

		private void Start()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void M_DoorControlUnlock(bool hasKey = true)
		{
		}
	}
}
