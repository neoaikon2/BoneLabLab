using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LightControlPowerable : Powerable
	{
		[CompilerGenerated]
		private sealed class _003CFlickerLight_003Ed__24
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightControlPowerable _003C_003E4__this;

			private float _003CblinkRange_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CFlickerLight_003Ed__24(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Header("VOLTAGE")]
		public bool isBinary;

		public bool Flicker;

		[Space(5f)]
		public float min_InputVoltage;

		public float max_InputVoltage;

		[Range(-1f, 1f)]
		public float cur_InputVoltage;

		[Space(5f)]
		public float min_LightVoltage;

		public float max_LightVoltage;

		private float att_LightVoltage;

		[Space(5f)]
		public float min_EmissiveVoltage;

		public float max_EmissiveVoltage;

		private float att_EmissiveVoltage;

		[Space(5f)]
		[Header("LIGHT MESH SOURCES")]
		public Renderer mat_Renderer;

		public Renderer mat_haloRenderer;

		[Range(0f, 1f)]
		public float per_Blink;

		[ColorUsage(true, true)]
		public Color hdr_OnColor;

		[ColorUsage(true, true)]
		public Color hdr_OffColor;

		[Header("LIGHT SOURCES")]
		[Tooltip("Only assign a value if you intend to modify a lightsource too")]
		[Space(5f)]
		public Light light_Actual;

		[ColorUsage(true, true)]
		[Tooltip("If there is a lightSource, then modify this color value to modify the Light Component's Color")]
		public Color color_LightOn;

		[ColorUsage(true, true)]
		public Color color_LightOff;

		private void Awake()
		{
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

		public void BeginFlicker()
		{
		}

		[IteratorStateMachine(typeof(_003CFlickerLight_003Ed__24))]
		private IEnumerator FlickerLight()
		{
			return null;
		}

		public void SETLIGHT(float voltage = 1f)
		{
		}

		public void SETLIGHTMESH(float voltage = 1f)
		{
		}

		private Color LerpColor(float voltage, Color a, Color b)
		{
			return default(Color);
		}
	}
}
