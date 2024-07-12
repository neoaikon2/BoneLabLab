using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using SLZ.Rig;
using UnityEngine;

public class PlayerTeleport : ZoneLinkItem
{
	public Transform destination;

	public bool useRotation;

	private RigManager _rigManager;

	protected override void OnEnter(MarrowEntity activatorEntity)
	{
	}

	private void TeleportPlayer(MarrowEntity activatorEntity)
	{
	}
}
