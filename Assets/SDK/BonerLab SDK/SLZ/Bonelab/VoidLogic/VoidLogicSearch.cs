using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.VoidLogic;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;

namespace SLZ.Bonelab.VoidLogic
{
	public static class VoidLogicSearch
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public MonoBehaviour[] candidates;

			public NativeArray<float> minDistanceArray;

			internal (int, float, MonoBehaviour) _003CFindClosest10_003Eb__2(int index)
			{
				return default((int, float, MonoBehaviour));
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFindClosest10_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<IVoidLogicNode[]> _003C_003Et__builder;

			public Vector3 targetPosition;

			private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;

			private TransformAccessArray _003Ctransforms_003E5__2;

			private NativeArray<float3> _003CpositionArray_003E5__3;

			private JobHandle _003Chandle_003E5__4;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				throw new System.NotImplementedException();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw new System.NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public MonoBehaviour[] candidates;

			public NativeArray<float> minDistanceArray;

			internal (int, float, MonoBehaviour) _003CFindClosest_003Eb__2(int index)
			{
				return default((int, float, MonoBehaviour));
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFindClosest_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<IVoidLogicNode> _003C_003Et__builder;

			public Vector3 targetPosition;

			private _003C_003Ec__DisplayClass1_0 _003C_003E8__1;

			private TransformAccessArray _003Ctransforms_003E5__2;

			private NativeArray<float3> _003CpositionArray_003E5__3;

			private JobHandle _003Chandle_003E5__4;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				throw new System.NotImplementedException();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw new System.NotImplementedException();
			}
		}

		[AsyncStateMachine(typeof(_003CFindClosest10_003Ed__0))]
		public static UniTask<IVoidLogicNode[]> FindClosest10(Vector3 targetPosition)
		{
			return default(UniTask<IVoidLogicNode[]>);
		}

		[AsyncStateMachine(typeof(_003CFindClosest_003Ed__1))]
		public static UniTask<IVoidLogicNode> FindClosest(Vector3 targetPosition)
		{
			return default(UniTask<IVoidLogicNode>);
		}
	}
}
