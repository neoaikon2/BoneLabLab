using System;

public readonly struct OVRStorable : IOVRAnchorComponent<OVRStorable>, IEquatable<OVRStorable>
{
	public static readonly OVRStorable Null;

	private OVRPlugin.SpaceComponentType IOVRAnchorComponent_003COVRStorable_003E_002EType => default(OVRPlugin.SpaceComponentType);

	private ulong IOVRAnchorComponent_003COVRStorable_003E_002EHandle => 0uL;

	public bool IsNull => false;

	public bool IsEnabled => false;

	internal OVRPlugin.SpaceComponentType Type => default(OVRPlugin.SpaceComponentType);

	internal ulong Handle { get; }

	bool IOVRAnchorComponent<OVRStorable>.IsNull => throw new NotImplementedException();

	bool IOVRAnchorComponent<OVRStorable>.IsEnabled => throw new NotImplementedException();

	OVRPlugin.SpaceComponentType IOVRAnchorComponent<OVRStorable>.Type => throw new NotImplementedException();

	ulong IOVRAnchorComponent<OVRStorable>.Handle => throw new NotImplementedException();

	private OVRStorable IOVRAnchorComponent_003COVRStorable_003E_002EFromAnchor(OVRAnchor anchor)
	{
		return default(OVRStorable);
	}

	public OVRTask<bool> SetEnabledAsync(bool enabled, double timeout = 0.0)
	{
		return default(OVRTask<bool>);
	}

	public bool Equals(OVRStorable other)
	{
		return false;
	}

	public static bool operator ==(OVRStorable lhs, OVRStorable rhs)
	{
		return false;
	}

	public static bool operator !=(OVRStorable lhs, OVRStorable rhs)
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

	OVRTask<bool> IOVRAnchorComponent<OVRStorable>.SetEnabledAsync(bool enable, double timeout)
	{
		throw new NotImplementedException();
	}

	OVRStorable IOVRAnchorComponent<OVRStorable>.FromAnchor(OVRAnchor anchor)
	{
		throw new NotImplementedException();
	}

	private OVRStorable(OVRAnchor anchor)
	{
		Handle = 0uL;
	}
}
