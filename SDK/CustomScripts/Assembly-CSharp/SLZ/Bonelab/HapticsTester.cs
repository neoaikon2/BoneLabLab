using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class HapticsTester : MonoBehaviour
	{
		public Grip grip;

		public InteractableHost host;

		public int index;

		[Range(0f, 1f)]
		[SerializeField]
		private float amplitudeMin;

		[Range(0f, 1f)]
		[SerializeField]
		private float amplitudeMax;

		[Range(0f, 2000f)]
		[SerializeField]
		private float frequencyMin;

		[Range(0f, 2000f)]
		[SerializeField]
		private float frequencyMax;

		[Range(0f, 1f)]
		[SerializeField]
		private float duration;

		private float frequency;

		private float amplitude;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnGripUpdate(Hand hand)
		{
		}

		private void OnGripAttached(Hand hand)
		{
		}

		private void OnGripDetached(Hand hand)
		{
		}

		public HapticsTester()
			: base()
		{
		}
	}
}
