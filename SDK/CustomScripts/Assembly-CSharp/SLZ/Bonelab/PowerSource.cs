using UnityEngine;

namespace SLZ.Bonelab
{
	public class PowerSource : MonoBehaviour
	{
		[SerializeField]
		private bool m_InfinitePower;

		[Tooltip("The Capcity of the PowerSource in Watts-min")]
		[SerializeField]
		[Header("VOLTAGE")]
		[Space(5f)]
		private float m_Capacity;

		[Tooltip("Only for reading, functions for charging/drawing should be the mutator")]
		public float BatteryCharge;

		public bool InfinitePower
		{
			get
			{
				return default(bool);
			}
		}

		public float Capacity
		{
			get
			{
				return default(float);
			}
		}

		public bool CanCharge
		{
			get
			{
				return default(bool);
			}
		}

		public void LOADCURRENTCHARGE(float savedCharge)
		{
		}

		public PowerSource()
			: base()
		{
		}
	}
}
