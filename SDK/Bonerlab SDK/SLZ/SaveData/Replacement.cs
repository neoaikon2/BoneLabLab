using System;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.SaveData
{
	[Serializable]
	public struct Replacement
	{
		[field: SerializeField]
		public SpawnableCrateReference From { get; private set; }

		[field: SerializeField]
		public SpawnableCrateReference To { get; private set; }
	}
}
