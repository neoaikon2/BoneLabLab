using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.Props;
using SLZ.VFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AvatarPedestal : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDestroyDome_003Ed__8
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AvatarPedestal _003C_003E4__this;

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
			public _003CDestroyDome_003Ed__8(int _003C_003E1__state)
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

		public GenericCrateReference selectedCrate;

		public GachaCapsule gacha;

		public GameObject dome;

		public GameObject lightGlow;

		public Blip domeBlip;

		private bool called;

		public void Awake()
		{
		}

		public void UNLOCKAVATAR()
		{
		}

		[IteratorStateMachine(typeof(_003CDestroyDome_003Ed__8))]
		public IEnumerator DestroyDome()
		{
			return null;
		}
	}
}
