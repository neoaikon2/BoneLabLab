using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.VoidLogic
{
	public class ElectricInteractionVolume2 : InteractionVolume
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CElectricInteractionCooldown_003Ed__18
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ElectricInteractionVolume2 _003C_003E4__this;

			public IGrippable host;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static readonly HashSet<IGrippable> _claimedHosts;

		public Transform targetPos;

		public Collider[] recieverColliders;

		public AudioClip[] insertClips;

		public AudioClip[] removeClips;

		public AudioMixerGroup mixerGroup;

		private bool _isBatteryInserted;

		public PassthroughNode _powerPassthrough;

		private BaseNode _powerIn;

		private CylinderElectronicGrip2 _batteryHandleGrip;

		private CylinderElectronicGrip2 _batteryBodyGrip;

		public static HashSet<IGrippable> ClaimedHosts => null;

		protected override void OnHoverStart(InteractableHost host)
		{
		}

		protected override void OnHoverEnd(InteractableHost host)
		{
		}

		protected override void OnHoverUpdate(InteractableHost host)
		{
		}

		private void HandAttached(IGrippable host, CylinderElectronicGrip2 grip)
		{
		}

		private void RemoveElectronic(IGrippable host, CylinderElectronicGrip2 grip)
		{
		}

		[AsyncStateMachine(typeof(_003CElectricInteractionCooldown_003Ed__18))]
		private UniTaskVoid ElectricInteractionCooldown(IGrippable host)
		{
			return default(UniTaskVoid);
		}
	}
}
