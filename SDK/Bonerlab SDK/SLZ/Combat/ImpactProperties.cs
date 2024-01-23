using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public class ImpactProperties : ImpactPropertiesVariables, IAttackReceiver, IEventSystemHandler
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRecieveAttackAsync_003Ed__13
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ImpactProperties _003C_003E4__this;

			public Attack attack;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ComponentCache<ImpactProperties> _cache;

		[Header("References")]
		public Collider[] colliders;

		[HideInInspector]
		[SerializeField]
		public bool hasManager;

		[SerializeField]
		[HideInInspector]
		public bool ShowControls;

		[HideInInspector]
		[SerializeField]
		public ImpactPropertiesManager Manager;

		private bool setup;

		public static ComponentCache<ImpactProperties> Cache => null;

		private void Awake()
		{
		}

		private void StaticFix()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateMaterial()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		[AsyncStateMachine(typeof(_003CRecieveAttackAsync_003Ed__13))]
		public UniTaskVoid RecieveAttackAsync(Attack attack)
		{
			return default(UniTaskVoid);
		}

		public void SpawnImpactVFX(Attack attack)
		{
		}

		public void FindColliders(bool childColliders = false)
		{
		}

		public void FindRenderer()
		{
		}

		private void SetRenderer(Renderer renderer)
		{
		}

		public float GetMegaPascals()
		{
			return 0f;
		}
	}
}
