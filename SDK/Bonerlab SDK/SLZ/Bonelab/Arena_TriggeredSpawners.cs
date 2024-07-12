using UnityEngine;

namespace SLZ.Bonelab
{
	public class Arena_TriggeredSpawners : MonoBehaviour
	{
		public ProfileSpawner[] spawners;

		private void OnDrawGizmosSelected()
		{
		}

		public Arena_TriggeredSpawners()
			: base()
		{
		}
	}
}
