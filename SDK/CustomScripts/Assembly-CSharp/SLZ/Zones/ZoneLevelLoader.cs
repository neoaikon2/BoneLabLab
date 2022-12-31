using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Zones
{
	public class ZoneLevelLoader : ZoneItem
	{
		[Header("Dependancies")]
		public LevelCrateReference level;

		public LevelCrateReference loadScreenLevel = new LevelCrateReference("fa534c5a83ee4ec6bd641fec424c4142.Level.DefaultLoad");

		public Spawnable vfxFadeOutSpawnable;

		public UnityEvent OnLoadStart;

		public UnityEvent OnLoadEnd;

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		private void LoadLevel()
		{
		}

		public ZoneLevelLoader()
			: base()
		{
		}
	}
}
