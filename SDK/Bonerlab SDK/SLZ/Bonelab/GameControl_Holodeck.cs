using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Data;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class GameControl_Holodeck : BonelabGameControl
	{
		[CompilerGenerated]
		private sealed class _003CCycleMatOverTime_003Ed__31
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Holodeck _003C_003E4__this;

			private Material[] _003Cmat2_003E5__2;

			private Material[] _003Cmat4_003E5__3;

			private int _003Ci_003E5__4;

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
			public _003CCycleMatOverTime_003Ed__31(int _003C_003E1__state)
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

		public MusicAmbience2dSFX headSfx;

		public GameObject UI;

		public Renderer[] wallPanels;

		public GameObject doorHide;

		public Renderer doorHideRenderer;

		public Image doorCheckImage;

		public Material[] wallMaterials;

		public GameObject[] lights;

		public float maxPanelTicTime;

		public ReflectionProbe probe1;

		public ReflectionProbe probe2;

		public AudioReverbData hugeRoomReverb;

		public AudioReverbData outsideReverb;

		public AudioReverbData voidReverb;

		public AudioClip shipAmbience;

		public AudioClip spaceAmbience;

		public AudioClip desertAmbience;

		public AudioClip beachAmbience;

		public AudioClip cityAmbience;

		public AudioClip stadiumAmbience;

		public AudioClip meadowAmbience;

		public AudioClip voidAmbience;

		public ZoneAmbience zoneAmbience0;

		public ZoneAmbience zoneAmbience1;

		private int materialIndex;

		private IEnumerator matCycle;

		public override void Awake()
		{
		}

		private new void Start()
		{
		}

		public void CYCLEMATERIAL()
		{
		}

		public void SELECTMATERIAL(int i)
		{
		}

		public void TOGGLEDOOR()
		{
		}

		[IteratorStateMachine(typeof(_003CCycleMatOverTime_003Ed__31))]
		private IEnumerator CycleMatOverTime()
		{
			return null;
		}

		private void CueAmbience(AudioClip clipMain)
		{
		}
	}
}
