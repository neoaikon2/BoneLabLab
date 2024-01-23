using SLZ.Marrow.Warehouse;
using SLZ.SaveData;
using UnityEngine;

namespace SLZ.Props
{
	[RequireComponent(typeof(SpawnableCratePlacer))]
	public class GachaPlacer : MonoBehaviour
	{
		[SerializeField]
		private GenericCrateReference unlockCrate;

		public SpawnableCratePlacer cratePlacer;

		public bool onlyPlaceIfBeatGame;

		private static PlayerUnlocks u => null;

		private static PlayerProgression p => null;

		private void Awake()
		{
		}

		private bool ShouldPlace()
		{
			return false;
		}

		public void SetGachaContents(SpawnableCratePlacer scp, GameObject go)
		{
		}
	}
}
