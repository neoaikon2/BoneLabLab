using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AlwaysLookAt : ZoneLinkItem
	{
		public Transform local;

		public Transform target;

		public bool isPhysics;

		public ConfigurableJoint jnt_Rotator;

		private Coroutine tickLook;

		private void Start()
		{
		}

		private void SetPlayerTarget(MarrowEntity playerEntity)
		{
		}
		private IEnumerator TickLook()
		{
			return null;
		}

		private void UpdateLookat()
		{
		}

		private new void OnDisable()
		{
		}
	}
}
