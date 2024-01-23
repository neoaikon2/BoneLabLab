using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Rendering;
using YieldAwaitable = Cysharp.Threading.Tasks.YieldAwaitable;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Volume))]
	public class FadeAndDespawnVolume : SpawnEvents
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFadeOverTime_003Ed__15
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public float seconds;

			public FadeAndDespawnVolume _003C_003E4__this;

			private float _003CrecpSeconds_003E5__2;

			private float _003Ctimer_003E5__3;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ComponentCache<FadeAndDespawnVolume> _cache;

		public Volume volume;

		public Action onComplete;

		public float duration;

		private float startValue;

		private float endValue;

		public GameObject fadingQuad;

		private Material mat;

		private Color black;

		private Color clear;

		public static ComponentCache<FadeAndDespawnVolume> Cache => null;

		protected void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		protected override void OnSpawn(GameObject go)
		{
		}

		[AsyncStateMachine(typeof(_003CFadeOverTime_003Ed__15))]
		private UniTaskVoid FadeOverTime(float seconds)
		{
			return default(UniTaskVoid);
		}

		private void SetValues(float lerper)
		{
		}
	}
}
