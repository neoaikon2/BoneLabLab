using UnityEngine;

namespace SLZ.Bonelab
{
	public class PowerSource : MonoBehaviour
	{
		[SerializeField]
		private bool m_InfinitePower;

		[Space(5f)]
		[Header("VOLTAGE")]
		[Tooltip("The Capcity of the PowerSource in Watts-min")]
		[SerializeField]
		private float m_Capacity;

		[Tooltip("Only for reading, functions for charging/drawing should be the mutator")]
		public float BatteryCharge;

		public bool InfinitePower => false;

		public float Capacity => 0f;

		public bool CanCharge => false;

		public void LOADCURRENTCHARGE(float savedCharge)
		{
		}
	}
}
