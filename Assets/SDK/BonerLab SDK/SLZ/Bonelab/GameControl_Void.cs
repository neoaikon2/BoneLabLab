using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_Void : BonelabInternalGameControl
	{
		[CompilerGenerated]
		private sealed class _003CMoveFloorSequence_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Void _003C_003E4__this;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CMoveFloorSequence_003Ed__38(int _003C_003E1__state)
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

			public void Dispose()
			{
				throw new NotImplementedException();
			}

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CAccelerate_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Void _003C_003E4__this;

			public AnimationCurve curve;

			private float _003CstartTime_003E5__2;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CAccelerate_003Ed__39(int _003C_003E1__state)
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

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CDecelerate_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Void _003C_003E4__this;

			public AnimationCurve curve;

			private float _003CendTime_003E5__2;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CDecelerate_003Ed__40(int _003C_003E1__state)
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

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CEnviormentTreadmill_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Void _003C_003E4__this;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CEnviormentTreadmill_003Ed__42(int _003C_003E1__state)
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

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CTreadmillMatchSeams_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Void _003C_003E4__this;

			private float _003ClerpTime_003E5__2;

			private float _003ClerpLength_003E5__3;

			private Vector2[] _003CbaseOffsets_003E5__4;

			private Vector2[] _003CgoalOffsets_003E5__5;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CTreadmillMatchSeams_003Ed__43(int _003C_003E1__state)
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

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		public MarrowEntity TaxiEntity;

		public Rigidbody taxiRb;

		public ConfigurableJoint taxiConfigJoint;

		public ConfigurableJoint rearLeftWheelConfigJoint;

		public ConfigurableJoint rearRightWheelConfigJoint;

		public float maxThrottle;

		public float startLength;

		public float driveLength;

		public float endLength;

		public AnimationCurve taxiStartCurve;

		public AnimationCurve taxiEndCurve;

		public AnimationCurve linearStartCurve;

		public AnimationCurve linearEndCurve;

		public AnimationCurve matLerpCurve;

		public Vector2 directionTile;

		public Renderer[] floorTiles;

		private Material[] floorMats;

		private Vector3 cabStartPos;

		private IEnumerator moveCoroutine;

		private IEnumerator throttleCoroutine;

		private IEnumerator treadmillCoroutine;

		private float topVelocity;

		public LayerMask teleportLayers;

		public GameObject staticLampRoot;

		public GameObject forwardLampRoot;

		public GameObject rearLampRoot;

		public GameObject lampPost;

		public int numberOfLampPosts;

		public float minMaxPost;

		public float interval;

		public List<GameObject> spawnedPosts;

		public List<GameObject> spawnedPostsFront;

		public List<GameObject> spawnedPostsRear;

		private int loopCount;

		public override void Awake()
		{
		}

		public override void Start()
		{
		}

		private void OnLevelLoad()
		{
		}

		[ContextMenu("StartMoveSequence")]
		public void StartMoveSequence()
		{
		}

		[IteratorStateMachine(typeof(_003CMoveFloorSequence_003Ed__38))]
		private IEnumerator MoveFloorSequence()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAccelerate_003Ed__39))]
		private IEnumerator Accelerate(AnimationCurve curve)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDecelerate_003Ed__40))]
		private IEnumerator Decelerate(AnimationCurve curve)
		{
			return null;
		}

		private Vector3 CalcuateStoppingPoint(AnimationCurve curve)
		{
			return default(Vector3);
		}

		[IteratorStateMachine(typeof(_003CEnviormentTreadmill_003Ed__42))]
		private IEnumerator EnviormentTreadmill()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTreadmillMatchSeams_003Ed__43))]
		private IEnumerator TreadmillMatchSeams()
		{
			return null;
		}
	}
}
