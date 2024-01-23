using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SplineShieldController : MonoBehaviour
	{
		[SerializeField]
		private global::SLZ.Marrow.Interaction.SplineJoint[] sJoints;

		[SerializeField]
		private float innerForce;

		[ContextMenu("SetShieldVelocities")]
		public void SetShieldVels()
		{
		}

		[ContextMenu("StopShields")]
		public void StopShields()
		{
		}

		public void DestroyShieldJoints()
		{
		}
	}
}
