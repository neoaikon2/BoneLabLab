using UnityEngine;

namespace SLZ.Bonelab.SLZ.Bonelab
{
	public class ElevatorPowerable : Powerable
	{
		[Space(5f)]
		[Header("Elevator REFS")]
		public bool isBinary;

		[Range(0f, 0.2f)]
		[Space(5f)]
		[Header("VOLTAGE OFFSET")]
		public float lowerOffSet = .2f;

		[Range(0f, 0.8f)]
		public float higherOffset = .8f;

		[Space(5f)]
		[Range(-1f, 1f)]
		public float min_InputVoltage = -1;

		[Range(-1f, 1f)]
		public float max_InputVoltage = 1;

		[Space(5f)]
		public float min_TargetVoltage = -1;

		public float max_TargetVoltage = 1;

		[Space(5f)]
		[Header("JOINTS")]
		public ConfigurableJoint m_configJoint;

		public Rigidbody m_rb;

		[Space(3f)]
		public Rigidbody ConnectedRB;

		public float parentScale = 1.0f;

		private Vector3 Anchor = Vector3.zero;

		private Vector3 axis_slide = Vector3.zero;

		private float limit_Linear;

		private float bounce = .15f;

		private float contactDistance = .05f;

		public float springPower = 10000f;

		public float damperPower = 10000f;

		public float motor_forcePower = 2700f;

		[Tooltip("Changing the force to not be able to hold up the platform when there's no power")]
		public float NoPowerForce = 70f;

		[Tooltip("Modifier for the garage door's movement in Time.deltaTime")]
		public float speedMod = .8f;

		[Space(5f)]
		public float tarPos_down;

		public float tarPos_up;

		private Vector3 desiredPosition;

		private float stored_Draw;

		[Header("DEBUG")]
		public bool isDebugging;

		private void Start()
		{
		}

		public void SetUpJoint()
		{
		}

		private void ANCHOR()
		{
		}

		public void LIMITS()
		{
		}

		public void SETDRIVE()
		{
		}

		public override void SwitchPowerOnOff(bool isOn)
		{
		}

		public override void VoltageToObject(float voltage, int id = 0)
		{
		}

		public void CUTPOWER()
		{
		}

		private void UPDOWN_LIFT(float attnVoltage)
		{
		}

		private float SetMoveRate(float Voltage)
		{
			return 0f;
		}

		private void Update()
		{
		}
	}
}
