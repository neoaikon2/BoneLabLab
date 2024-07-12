using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public class ZoneEnabler : ZoneLinkItem
	{
		[SerializeField]
		private GameObject[] _gameObjects;

		private void Start()
		{
		}

		protected override void OnEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnExit(MarrowEntity activatorEntity)
		{
		}

		protected override void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnPrimaryExit(MarrowEntity activatorEntity)
		{
		}

		protected override void OnSecondaryEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnSecondaryExit(MarrowEntity activatorEntity)
		{
		}

		private void SetActive(bool isActive)
		{
		}

		public ZoneEnabler()
			: base()
		{
		}
	}
}
