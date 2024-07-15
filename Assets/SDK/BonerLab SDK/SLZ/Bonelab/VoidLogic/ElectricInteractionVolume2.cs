using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	public class ElectricInteractionVolume2 : InteractionVolume
	{
		[SerializeField]
		private MarrowBody _marrowBody;

		public Transform targetPos;

		public Collider[] recieverColliders;

		public AudioClip[] insertClips;

		public AudioClip[] removeClips;

		private bool _isBatteryInserted;

		public PassthroughNode _powerPassthrough;

		private IVoidLogicSource _powerIn;

		private CylinderElectronicGrip2 _batteryHandleGrip;

		private CylinderElectronicGrip2 _batteryBodyGrip;

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
		private UniTaskVoid ElectricInteractionCooldown(IGrippable host)
		{
			return default(UniTaskVoid);
		}
	}
}
