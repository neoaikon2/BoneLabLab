using UnityEngine;

namespace SLZ.Marrow.AI
{
	public class SlotPosition : MonoBehaviour
	{
		[Header("This is meant to set global shader variable for holographic visor")]
		[SerializeField]
		private MeshRenderer VisorRenderer;

		[SerializeField]
		private GameObject HomeTransform;

		[SerializeField]
		private Vector3 Offset;

		[SerializeField]
		private bool SetOnEnable;

		private int id;

		private void Reset()
		{
		}

		public void OnEnable()
		{
		}

		public void EnableAndSet()
		{
		}

		public void EnableAndSet(Vector3 position)
		{
		}

		public void DisableMesh()
		{
		}

		public void SetEquippedPos()
		{
		}

		public void SetEquippedPos(Vector3 position)
		{
		}
	}
}
