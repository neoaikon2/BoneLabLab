using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Audio;
using SLZ.Marrow.VoidLogic;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	public class LogicGun : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CShowNodeInfo_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public RaycastHit hitInfo;

			public LogicGun _003C_003E4__this;

			private UniTask<IVoidLogicNode>.Awaiter _003C_003Eu__1;

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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CShowSubgraph_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public RaycastHit hitInfo;

			public LogicGun _003C_003E4__this;

			private UniTask<IVoidLogicNode>.Awaiter _003C_003Eu__1;

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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CHideSubgraph_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public RaycastHit hitInfo;

			public LogicGun _003C_003E4__this;

			private UniTask<IVoidLogicNode>.Awaiter _003C_003Eu__1;

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

		public TargetGrip triggerGrip;

		public Transform firePoint;

		public float range;

		public TextMeshPro mainUIPanel;

		public GameObject laserPointer;

		public AudioClip[] chargeSFX;

		public AudioClip[] modeSFX;

		public VoidLogicToolSettings toolSettings;

		private ManagedAudioPlayer _mapCharge;

		private ManagedAudioPlayer _mapMode;

		private LogicGunMode _gunMode;

		private GameObject _probeRoot;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnHandAttached(Hand hand)
		{
		}

		private void OnHandDetached(Hand hand)
		{
		}

		private void OnHandAttachedUpdate(Hand hand)
		{
		}

		[AsyncStateMachine(typeof(_003CShowNodeInfo_003Ed__18))]
		private UniTask ShowNodeInfo(RaycastHit hitInfo)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CShowSubgraph_003Ed__19))]
		private UniTask ShowSubgraph(RaycastHit hitInfo)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CHideSubgraph_003Ed__20))]
		private UniTask HideSubgraph(RaycastHit hitInfo)
		{
			return default(UniTask);
		}

		private bool _cycleSelectModes()
		{
			return false;
		}

		[ContextMenu("Show All Subgraphs")]
		private void ShowAllSubgraphs()
		{
		}

		[ContextMenu("Hide All Subgraphs")]
		private void HideAllSubgraphs(bool force = false)
		{
		}
	}
}
