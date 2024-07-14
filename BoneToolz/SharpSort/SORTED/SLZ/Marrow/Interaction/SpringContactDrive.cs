using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[Serializable]
	public struct SpringContactDrive
	{
		[SerializeField]
		public float positionSpring;

		[SerializeField]
		public float positionDamper;

		[SerializeField]
		public float maximumForce;

		public SpringContactDrive(float positionSpring, float positionDamper, float maximumForce)
		{
			this.positionSpring = 0f;
			this.positionDamper = 0f;
			this.maximumForce = 0f;
		}
	}
}
