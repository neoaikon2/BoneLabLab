using SLZ.Bonelab;
using UnityEngine;

namespace SLZ.Props
{
	public class HoverPlate : MonoBehaviour
	{
		[Header("PUCK")]
		public float hoverDistance;

		public float hoverForce;

		private float currentHeight;

		private float hoverForceMultiplier;

		private Vector3 hoverForceApplied;

		public Rigidbody rb_this;

		public float stability;

		public float stabilitySpeed;

		[Header("HANDLEPUCK")]
		public GameObject Handle;

		public PowerSocket powerSocket;

		public float draw_Power;

		public bool energized;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
