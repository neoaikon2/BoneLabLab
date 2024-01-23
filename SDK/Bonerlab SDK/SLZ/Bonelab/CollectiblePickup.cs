using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CollectiblePickup : MonoBehaviour
	{
		public enum CollectibleType
		{
			P = 0,
			R = 1,
			O = 2,
			J = 3,
			E = 4,
			C = 5,
			T = 6,
			F = 7
		}

		[CompilerGenerated]
		private sealed class _003CCoCollectAnimation_003Ed__9
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectiblePickup _003C_003E4__this;

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
			public _003CCoCollectAnimation_003Ed__9(int _003C_003E1__state)
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

		public CollectibleType collectibleType;

		public GameObject[] pickupMeshes;

		private bool _isCollected;

		public Action<CollectiblePickup> pickupEvent;

		public AudioClip collectedClip;

		public bool GetCollectionState()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		[IteratorStateMachine(typeof(_003CCoCollectAnimation_003Ed__9))]
		private IEnumerator CoCollectAnimation()
		{
			return null;
		}
	}
}
