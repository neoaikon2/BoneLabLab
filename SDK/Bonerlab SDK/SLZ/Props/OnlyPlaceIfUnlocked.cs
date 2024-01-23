using SLZ.Marrow.Warehouse;
using SLZ.SaveData;
using UnityEngine;

namespace SLZ.Props
{
	[RequireComponent(typeof(SpawnableCratePlacer))]
	public class OnlyPlaceIfUnlocked : MonoBehaviour
	{
		public SpawnableCratePlacer cratePlacer;

		private static PlayerUnlocks u => null;

		private void Awake()
		{
		}

		private bool ShouldPlace()
		{
			return false;
		}
	}
}
