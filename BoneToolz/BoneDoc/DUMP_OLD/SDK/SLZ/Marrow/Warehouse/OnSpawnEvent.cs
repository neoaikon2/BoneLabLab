using System;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class OnSpawnEvent : UltEvent<CrateSpawner, GameObject>
	{
		public OnSpawnEvent()
			: base()
		{
		}
	}
}
