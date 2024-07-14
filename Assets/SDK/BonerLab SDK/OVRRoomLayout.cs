using System;
using System.Collections.Generic;

public readonly struct OVRRoomLayout : IOVRAnchorComponent<OVRRoomLayout>, IEquatable<OVRRoomLayout>
{
	public static readonly OVRRoomLayout Null;

	private OVRPlugin.SpaceComponentType IOVRAnchorComponent_003COVRRoomLayout_003E_002EType => default(OVRPlugin.SpaceComponentType);

	private ulong IOVRAnchorComponent_003COVRRoomLayout_003E_002EHandle => 0uL;

	public bool IsNull => false;

	public bool IsEnabled => false;

	internal OVRPlugin.SpaceComponentType Type => default(OVRPlugin.SpaceComponentType);

	internal ulong Handle { get; }

	bool IOVRAnchorComponent<OVRRoomLayout>.IsNull => throw new NotImplementedException();

	bool IOVRAnchorComponent<OVRRoomLayout>.IsEnabled => throw new NotImplementedException();

	OVRPlugin.SpaceComponentType IOVRAnchorComponent<OVRRoomLayout>.Type => throw new NotImplementedException();

	ulong IOVRAnchorComponent<OVRRoomLayout>.Handle => throw new NotImplementedException();

	private OVRRoomLayout IOVRAnchorComponent_003COVRRoomLayout_003E_002EFromAnchor(OVRAnchor anchor)
	{
		return default(OVRRoomLayout);
	}

	private OVRTask<bool> IOVRAnchorComponent_003COVRRoomLayout_003E_002ESetEnabledAsync(bool enabled, double timeout)
	{
		return default(OVRTask<bool>);
	}

	public bool Equals(OVRRoomLayout other)
	{
		return false;
	}

	public static bool operator ==(OVRRoomLayout lhs, OVRRoomLayout rhs)
	{
		return false;
	}

	public static bool operator !=(OVRRoomLayout lhs, OVRRoomLayout rhs)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	private OVRRoomLayout(OVRAnchor anchor)
	{
		Handle = 0uL;
	}

	public OVRTask<bool> FetchLayoutAnchorsAsync(List<OVRAnchor> anchors)
	{
		return default(OVRTask<bool>);
	}

	public bool TryGetRoomLayout(out Guid ceiling, out Guid floor, out Guid[] walls)
	{
		ceiling = default(Guid);
		floor = default(Guid);
		walls = null;
		return false;
	}

	public OVRTask<bool> SetEnabledAsync(bool enable, double timeout = 0)
	{
		throw new NotImplementedException();
	}

	OVRTask<bool> IOVRAnchorComponent<OVRRoomLayout>.SetEnabledAsync(bool enable, double timeout)
	{
		throw new NotImplementedException();
	}

	OVRRoomLayout IOVRAnchorComponent<OVRRoomLayout>.FromAnchor(OVRAnchor anchor)
	{
		throw new NotImplementedException();
	}
}
