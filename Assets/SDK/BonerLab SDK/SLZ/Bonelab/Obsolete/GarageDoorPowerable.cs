using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	public class GarageDoorPowerable : Powerable
	{
		public enum MOVINGSTATE
		{
			UP = 0,
			DOWN = 1,
			STOPPED_UP = 2,
			STOPPED_DOWN = 3
		}
		[Space(5f)]
		[Header("GARAGE REFS")]
		public bool isBinary;

		public GameObject GarageDoorParent;

		public Transform GarageTop;

		public Transform GarageBottom;

		[Range(0.005f, 0.015f)]
		[Tooltip("Used for the non-binary mode")]
		[Header("MOVERATE")]
		[Space(5f)]
		public float MinMoveRate;

		[Range(0.005f, 0.02f)]
		[Tooltip("Used for the non-binary mode")]
		public float MaxMoveRate;

		[Tooltip("Used when in binary mode")]
		[Range(0.01f, 0.015f)]
		public float ConstantMoveRate;

		[Range(75f, 200f)]
		[Tooltip("Speed multiplier to make sure movement rate is noticable")]
		public float Speed;

		[Range(0f, 0.2f)]
		[Header("Voltage Offset")]
		[Space(5f)]
		public float lowerOffSet;

		[Range(0f, 0.8f)]
		public float higherOffset;

		[Space(5f)]
		[Range(-1f, 1f)]
		public float min_InputVoltage;

		[Range(-1f, 1f)]
		public float max_InputVoltage;

		[Space(5f)]
		public float min_TargetVoltage;

		public float max_TargetVoltage;

		private float m_currVoltage;

		[Header("DEBUG")]
		[Space(10f)]
		public bool isDebugging;

		private float stored_Draw;

		private MOVINGSTATE m_moveState;

		private Coroutine MoveUp;

		private Coroutine MoveDown;

		private bool isCoRunning;

		public MOVINGSTATE MoveState
		{
			get
			{
				return default(MOVINGSTATE);
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public override void SwitchPowerOnOff(bool isOn)
		{
		}

		public override void VoltageToObject(float voltage, int id = 0)
		{
		}

		private void SetFloatGarageMove(float voltage)
		{
		}

		private void StopMoving()
		{
		}

		public void StopGarageDoorBttn()
		{
		}

		private void UpGargeDoorBttn()
		{
		}

		private void DownGarageDoorBttn()
		{
		}

		public void ContinueMovement()
		{
		}
		private IEnumerator CoMoveUp()
		{
			return null;
		}
		private IEnumerator CoMoveDown()
		{
			return null;
		}

		private float SetMoveRate(float Voltage, bool up)
		{
			return 0f;
		}
	}
}
