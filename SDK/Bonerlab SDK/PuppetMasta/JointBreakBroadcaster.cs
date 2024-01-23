using UnityEngine;

namespace PuppetMasta
{
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[HideInInspector]
		[SerializeField]
		public int muscleIndex;

		private void OnJointBreak()
		{
		}
	}
}
