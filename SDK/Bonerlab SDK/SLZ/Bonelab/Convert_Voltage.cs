using UnityEngine;

namespace SLZ.Bonelab
{
	public class Convert_Voltage : OnOffSwitch
	{
		[Tooltip("Lever can be an OnOff Switch or -1,0,1 float")]
		[Header("SETTINGS")]
		[Space(5f)]
		public bool operation_Float;

		[Tooltip("Will return Lever to center position on letgo")]
		public bool operation_Momentary;

		private float voltage;

		public void INCOMINGVOLTAGE(float volts)
		{
		}

		private void CIRCUIT()
		{
		}
	}
}
