using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	[AddComponentMenu(null)]
	[Obsolete("Superseded by VoidLogic")]
	public class ElectricInteractionVolume : InteractionVolume
	{
		public Transform targetPos;

		public Collider[] recieverColliders;

		public AudioClip[] insertClips;

		public AudioClip[] removeClips;

		public float volume;

		private bool m_isElectricInserted;

		[Space(10f)]
		[SerializeField]
		[Tooltip("The type of electronic this object takes")]
		private List<PowerSourceType> m_acceptedTypes;

		private PowerSocket m_powerSock;

		private PowerSource m_ps;

		private CylinderElectronicGrip m_cegHandle;

		private CylinderElectronicGrip m_cegBody;

		public static Action<ElectricInteractionVolume, IGrippable> OnVolumeChanged;

		public bool isElectricInserted => false;

		private void Start()
		{
		}

		private bool M_CanInsert(PowerSourceType type)
		{
			return false;
		}

		protected override void OnHoverStart(InteractableHost host)
		{
		}

		protected override void OnHoverEnd(InteractableHost host)
		{
		}

		protected override void OnHoverUpdate(InteractableHost host)
		{
		}

		private void M_InsertElectric(InteractableHost host)
		{
		}

		public void RemoveElectronic(IGrippable host, CylinderElectronicGrip grip)
		{
		}

		private void M_DestroyedPowerSource(InteractableHost host)
		{
		}
		private IEnumerator CoElectricInteractionCooldown(bool isInserted, IGrippable host)
		{
			return null;
		}

		private void DestroyedPSInteractionVolume()
		{
		}

		public void ExitInteractionVolume()
		{
		}
	}
}
