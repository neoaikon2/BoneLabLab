using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab.Obsolete;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class NavMeshDoor : MonoBehaviour
	{
		public enum DoorType
		{
			DoorA = 0,
			DoorB = 1,
			DoorC = 2,
			DoorD = 3,
			DoorE = 4
		}
		public DoorType doorType;

		[SerializeField]
		private bool isOpen;

		[SerializeField]
		private ObjectDestructible destructable;

		[SerializeField]
		private bool isDestructable;

		[SerializeField]
		private GarageDoor_Phys_Powerable garageDoor;

		[SerializeField]
		private bool forceOpenOnStart;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}
		private IEnumerator CoForceGarage(float delay)
		{
			return null;
		}

		private void ForceGarageDoorsOpen()
		{
		}

		private void OnDestructableBreak(ObjectDestructible dest)
		{
		}

		public void ToggleDoor()
		{
		}

		public void ToggleArea(bool open)
		{
		}
	}
}
