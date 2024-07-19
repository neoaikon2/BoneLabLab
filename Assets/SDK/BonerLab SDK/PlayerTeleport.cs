using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

public class PlayerTeleport : ZoneLinkItem
{
	public Transform destination;

	public bool useRotation;

	protected override void OnEnter(MarrowEntity activatorEntity)
	{
	}

	private void TeleportPlayer(MarrowEntity activatorEntity)
	{
	}
}
