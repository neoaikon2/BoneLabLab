using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;
using YieldAwaitable = Cysharp.Threading.Tasks.YieldAwaitable;

namespace SLZ
{
	public class GachaSpawnProjectile : SpawnEvents
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAsyncSpawnProcedure_003Ed__14
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GachaSpawnProjectile _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private float _003CcurTime_003E5__3;

			private Vector3 _003CtargetVelocity_003E5__4;

			private Vector3 _003CtargetAngVelocity_003E5__5;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

			private UniTask<AssetPoolee>.Awaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ComponentCache<GachaSpawnProjectile> _cache;

		public Rigidbody rb;

		public Spawnable spawnable;

		public MeshFilter previewMeshFilter;

		public Transform previewMeshTransform;

		public float startScale;

		public CurveData growAnim;

		public static ComponentCache<GachaSpawnProjectile> Cache => null;

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		protected override void OnPostSpawn(GameObject go)
		{
		}

		[AsyncStateMachine(typeof(_003CAsyncSpawnProcedure_003Ed__14))]
		private UniTaskVoid AsyncSpawnProcedure()
		{
			return default(UniTaskVoid);
		}
	}
}
