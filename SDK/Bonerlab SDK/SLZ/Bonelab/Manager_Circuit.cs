using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Manager_Circuit : MonoBehaviour
	{
		[Tooltip("Assign a value if there is an object that functions like a fusebox")]
		[Space(5f)]
		[Header("Surge BOX")]
		public SurgeBox FuseBoxRef;

		[Space(5f)]
		[Tooltip("Used if you don't want a powerSource connected.")]
		[Header("ELECTRONICS")]
		public bool isPowerSource;

		[Tooltip("The minumum voltage required to power this circuit")]
		public float MinimumVoltage;

		public float TotalVoltage;

		[Space(3f)]
		public List<PowerSocket> PowerSockets;

		public List<Powerable> Electronics;

		[Space(10f)]
		[Tooltip("Checked if you want it to only work with a specific Power Source.")]
		[Header("SPECIFIC POWERSOURCE")]
		public bool SpecificPSMode;

		public bool hasPowerSources => false;

		public bool isInfinitePower => false;

		public bool hasReqCharge => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void CurrentOnOff(bool isOn)
		{
		}

		public void DestroyedPowerable(Powerable obj)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
