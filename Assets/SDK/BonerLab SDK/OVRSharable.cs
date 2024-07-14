using System;

public readonly struct OVRSharable : IOVRAnchorComponent<OVRSharable>, IEquatable<OVRSharable>
{
	public static readonly OVRSharable Null;

	private OVRPlugin.SpaceComponentType IOVRAnchorComponent_003COVRSharable_003E_002EType => default(OVRPlugin.SpaceComponentType);

	private ulong IOVRAnchorComponent_003COVRSharable_003E_002EHandle => 0uL;

	public bool IsNull => false;

	public bool IsEnabled => false;

	internal OVRPlugin.SpaceComponentType Type => default(OVRPlugin.SpaceComponentType);

	internal ulong Handle { get; }

	bool IOVRAnchorComponent<OVRSharable>.IsNull => throw new NotImplementedException();

	bool IOVRAnchorComponent<OVRSharable>.IsEnabled => throw new NotImplementedException();

	OVRPlugin.SpaceComponentType IOVRAnchorComponent<OVRSharable>.Type => throw new NotImplementedException();

	ulong IOVRAnchorComponent<OVRSharable>.Handle => throw new NotImplementedException();

	private OVRSharable IOVRAnchorComponent_003COVRSharable_003E_002EFromAnchor(OVRAnchor anchor)
	{
		return default(OVRSharable);
	}

	public OVRTask<bool> SetEnabledAsync(bool enabled, double timeout = 0.0)
	{
		return default(OVRTask<bool>);
	}

	public bool Equals(OVRSharable other)
	{
		return false;
	}

	public static bool operator ==(OVRSharable lhs, OVRSharable rhs)
	{
		return false;
	}

	public static bool operator !=(OVRSharable lhs, OVRSharable rhs)
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

	OVRTask<bool> IOVRAnchorComponent<OVRSharable>.SetEnabledAsync(bool enable, double timeout)
	{
		throw new NotImplementedException();
	}

	OVRSharable IOVRAnchorComponent<OVRSharable>.FromAnchor(OVRAnchor anchor)
	{
		throw new NotImplementedException();
	}

	private OVRSharable(OVRAnchor anchor)
	{
		Handle = 0uL;
	}
}
