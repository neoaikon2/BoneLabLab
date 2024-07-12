using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class KeyReceiver : InteractionReciever
	{
		[Flags]
		public enum Code
		{
			CODE_A = 1,
			CODE_B = 2,
			CODE_C = 4,
			CODE_D = 8,
			CODE_E = 0x10,
			CODE_F = 0x20,
			CODE_G = 0x40,
			CODE_H = 0x80,
			CODE_I = 0x100,
			CODE_J = 0x200,
			CODE_K = 0x400
		}

		private enum _States
		{
			EMPTY = 0,
			SWITCHING = 1,
			EJECTING = 2,
			HOVERING = 3,
			INSERTED = 4,
			SLIDING = 5
		}

		/*
		[CompilerGenerated]
		private sealed class _003CCoEjectMagazine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KeyReceiver _003C_003E4__this;

			public Action callback;

			private SimpleTransform _003CinsertToHost_003E5__2;

			private SimpleTransform _003ClocalStart_003E5__3;

			private SimpleTransform _003ClocalEnd_003E5__4;

			private Vector3 _003CendToStart_003E5__5;

			private float _003CsqrDistance_003E5__6;

			private float _003Cacceleration_003E5__7;

			private float _003Cspeed_003E5__8;

			private SimpleTransform _003Ctarget_003E5__9;

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
			public _003CCoEjectMagazine_003Ed__34(int _003C_003E1__state)
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
		private sealed class _003CCoWaitLockMagazine_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KeyReceiver _003C_003E4__this;

			private float _003Cspeed_003E5__2;

			private float _003Cacceleration_003E5__3;

			private SimpleTransform _003CinsertToHost_003E5__4;

			private SimpleTransform _003ClocalStart_003E5__5;

			private SimpleTransform _003ClocalEnd_003E5__6;

			private SimpleTransform _003Ctarget_003E5__7;

			private float _003CsqrDistance_003E5__8;

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
			public _003CCoWaitLockMagazine_003Ed__35(int _003C_003E1__state)
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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAltFixedUpdateLoop_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public CancellationTokenSource cancellationSource;

			public KeyReceiver _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}
		*/

		[Header("References")]
		public MarrowEntity marrowEntity;

		public Transform startInsertTarget;

		public Transform endInsertTarget;

		public AudioClip[] insertClips;

		public AudioClip[] ejectClips;

		public Code code;

		[Tooltip("Keep the key in the reciever after it has been inserted")]
		public bool isKeyConsumed;

		public UnityEvent onUnlock;

		public UnityEvent onLock;

		[HideInInspector]
		public Action<Key> OnInserted;

		public Action OnRemoved;

		public Action<Key> OnKeyRemoved;

		private float _sqInsertDistance;

		private _States _State;

		private SphereCollider _sphereCollider;

		private InteractableHost _keyHost;

		private Key _key;

		private bool _isActive;

		private SimpleTransform _InsertTargetToHand;

		private SimpleTransform _HandToInsertTarget;

		private SimpleTransform _HandTargetTransform;

		private CancellationTokenSource cancelToken;

		private bool _WasMagazineGrabbed;

		private float _CartridgeGrabbedTime;

		private bool _IsHoverEject;

		private float _ActivePerc;

		private float _ActivePercVel;

		public bool hasCartridge => false;

		public InteractableHost GetHost()
		{
			return null;
		}

		private void CalculateMagazineRig(Transform insert, InteractableHost host)
		{
		}

		protected override void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void OnAttachedHandDelegate(Hand hand)
		{
		}

		private void OnDetachedHandDelegate(Hand hand)
		{
		}

		private void UpdateMagazineGrab(Hand hand)
		{
		}

		private void CreateJointConfig()
		{
		}

		public void SetHoverEject()
		{
		}

		//[IteratorStateMachine(typeof(_003CCoEjectMagazine_003Ed__34))]
		private IEnumerator CoEjectMagazine(Action callback = null)
		{
			return null;
		}

		//[IteratorStateMachine(typeof(_003CCoWaitLockMagazine_003Ed__35))]
		private IEnumerator CoWaitLockMagazine()
		{
			return null;
		}

		private void OnPreRealtimeRig()
		{
		}

		//[AsyncStateMachine(typeof(_003CAltFixedUpdateLoop_003Ed__38))]
		private UniTaskVoid AltFixedUpdateLoop(CancellationTokenSource cancellationSource)
		{
			return default(UniTaskVoid);
		}

		public override void OnInteractableHostEnter(InteractableHost host)
		{
		}

		public override void OnInteractableHostExit(InteractableHost host)
		{
		}

		public override void OnInteractableHostStay(InteractableHost host)
		{
		}

		private void MoveTowardsStartInsertTarget()
		{
		}

		private void SlideTowardsEndInsertTarget()
		{
		}

		private void MakeStatic()
		{
		}

		private void OnMagazineLocked()
		{
		}

		public void Release(Action callback)
		{
		}

		public void Release()
		{
		}

		private void OnMagazineGrabbed(InteractableHost host, Hand hand)
		{
		}

		private void OnMagazineUnlocked()
		{
		}

		private void MakeDynamic()
		{
		}
	}
}
