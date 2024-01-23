using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Props
{
	public class ReclamationBin : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoDelayDespawn_003Ed__12
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AssetPoolee poolee;

			public bool hasHost;

			public InteractableHost host;

			public ReclamationBin _003C_003E4__this;

			public Rigidbody rb;

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
			public _003CCoDelayDespawn_003Ed__12(int _003C_003E1__state)
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

		private HashSet<Rigidbody> claimedRBs;

		private Color m_despawnColor;

		[SerializeField]
		private Spawnable sandboxModuleSpawnable;

		[SerializeField]
		private Spawnable redactedModuleSpawnable;

		[SerializeField]
		private Spawnable handgunModuleSpawnable;

		[SerializeField]
		private Spawnable tuscanyModuleSpawnable;

		[SerializeField]
		private Spawnable hoverJunkersModuleSpawnable;

		[SerializeField]
		private Spawnable boardGun;

		[SerializeField]
		private Spawnable junkShip;

		private void Awake()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		private void ACHIEVEMENTUNLOCKS()
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelayDespawn_003Ed__12))]
		private IEnumerator CoDelayDespawn(AssetPoolee poolee, Rigidbody rb, bool hasHost, InteractableHost host)
		{
			return null;
		}
	}
}
