using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	public class ControllerModelArticulator : MonoBehaviour
	{
		private ControllerModel m_controllerModel;

		private ulong m_modelKey;

		private Transform[] m_animationNodes;

		private Pose[] m_poses;

		private bool IsArticulating
		{
			get
			{
				return default(bool);
			}
		}

		public bool TryStartArticulating(ControllerModel controllerModel, ulong modelKey)
		{
			return default(bool);
		}

		public void StopArticulating()
		{
		}

		protected void Update()
		{
		}

		public ControllerModelArticulator()
			: base()
		{
		}
	}
}
