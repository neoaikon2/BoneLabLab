using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Props
{
	public class VoidSaber : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CExtendBlade_003Ed__28
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VoidSaber _003C_003E4__this;

			private float _003CbladeScale_003E5__2;

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
			public _003CExtendBlade_003Ed__28(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CRetractBlade_003Ed__29
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VoidSaber _003C_003E4__this;

			private float _003CbladeScale_003E5__2;

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
			public _003CRetractBlade_003Ed__29(int _003C_003E1__state)
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

		public Grip triggerGrip;

		public GameObject bladeRoot;

		public Transform bladeTop;

		public Transform bladeBottom;

		public Transform com;

		public Transform onOffSwitch;

		public Transform dialGuage;

		public int bladeSegments;

		public float extendRate;

		public float extendRateModifier;

		public float retractRate;

		private bool isExtened;

		private bool isPrimaryButtonHeld;

		private IEnumerator bladeAnim;

		private List<lineSegment> previousPoints;

		private MaterialPropertyBlock LaserMaterialPropertyBlock;

		private Mesh laserTrailMesh;

		private MeshFilter LineTrailMesher;

		private Vector3[] vertices;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void InitializeMesh()
		{
		}

		private void MeshUpdate(Vector3 hitpoint, Vector3 lasthit)
		{
		}

		private void OnHandAttachedUpdate(Hand hand)
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}

		[IteratorStateMachine(typeof(_003CExtendBlade_003Ed__28))]
		private IEnumerator ExtendBlade()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRetractBlade_003Ed__29))]
		private IEnumerator RetractBlade()
		{
			return null;
		}
	}
}
