using UnityEngine;

namespace SLZ.VRMK
{
	public class AvatarExtension : MonoBehaviour
	{
		protected Avatar _avatar;

		protected virtual void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public virtual void OnWriteTransforms()
		{
		}

		public virtual void OnRefreshBodyMeasurements()
		{
		}
	}
}
