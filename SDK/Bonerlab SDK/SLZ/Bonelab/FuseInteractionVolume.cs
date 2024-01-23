using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class FuseInteractionVolume : InteractionVolume
	{
		[CompilerGenerated]
		private sealed class _003CCoFuseInteractionCooldown_003Ed__15
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FuseInteractionVolume _003C_003E4__this;

			public bool isInserted;

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
			public _003CCoFuseInteractionCooldown_003Ed__15(int _003C_003E1__state)
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

		public Transform targetPos;

		public Collider[] recieverColliders;

		private bool m_isFuseInserted;

		private CylinderFuseGrip m_fuseGrip;

		private Control_SurgeBox m_fuseBox;

		[SerializeField]
		[Tooltip("Assign the maximum wattage cap before the fuse blows")]
		[Space(10f)]
		[Header("FUSE DATA")]
		private float m_FuseBlowoutCap;

		public bool FuseIn => false;

		public bool IsFuseBlown(float WattAmt)
		{
			return false;
		}

		private void Start()
		{
		}

		protected override void OnHoverStart(InteractableHost host)
		{
		}

		protected override void OnHoverEnd(InteractableHost host)
		{
		}

		protected override void OnHoverUpdate(InteractableHost host)
		{
		}

		private void M_InsertFuse(InteractableHost host)
		{
		}

		public void RemoveFuse(IGrippable host)
		{
		}

		[IteratorStateMachine(typeof(_003CCoFuseInteractionCooldown_003Ed__15))]
		private IEnumerator CoFuseInteractionCooldown(bool isInserted)
		{
			return null;
		}
	}
}
