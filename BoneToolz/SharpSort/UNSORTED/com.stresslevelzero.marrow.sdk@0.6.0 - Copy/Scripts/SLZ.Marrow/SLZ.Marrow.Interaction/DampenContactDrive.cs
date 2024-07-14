using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[Serializable]
	public struct DampenContactDrive
	{
		[SerializeField]
		public float positionDamper;

		[SerializeField]
		public float maximumForce;

		public DampenContactDrive(float positionDamper, float maximumForce)
		{
			this.positionDamper = 0f;
			this.maximumForce = 0f;
		}
	}
}
