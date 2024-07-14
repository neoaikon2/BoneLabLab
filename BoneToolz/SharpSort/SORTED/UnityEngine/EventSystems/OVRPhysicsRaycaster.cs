using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_physics_raycaster")]
	public class OVRPhysicsRaycaster : BaseRaycaster
	{
		protected const int kNoEventMaskSet = -1;

		[SerializeField]
		protected LayerMask m_EventMask;

		public int sortOrder;

		public override Camera eventCamera => null;

		public virtual int depth => 0;

		public override int sortOrderPriority => 0;

		public int finalEventMask => 0;

		public LayerMask eventMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		protected OVRPhysicsRaycaster()
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		public void Spherecast(PointerEventData eventData, List<RaycastResult> resultAppendList, float radius)
		{
		}

		public Vector2 GetScreenPos(Vector3 worldPosition)
		{
			return default(Vector2);
		}
	}
}
