using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	public class OverlapTrigger : MonoBehaviour
	{
		protected void OnDisable()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public virtual void OnOverlapEnter(GameObject other)
		{
		}

		public virtual void OnOverlapExit(GameObject other)
		{
		}
	}
}
