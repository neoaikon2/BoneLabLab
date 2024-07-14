using System;
using System.Collections.Generic;

public readonly struct OVRAnchorContainer : IOVRAnchorComponent<OVRAnchorContainer>, IEquatable<OVRAnchorContainer>
{
	public static readonly OVRAnchorContainer Null;

	private OVRPlugin.SpaceComponentType IOVRAnchorComponent_003COVRAnchorContainer_003E_002EType => default(OVRPlugin.SpaceComponentType);

	private ulong IOVRAnchorComponent_003COVRAnchorContainer_003E_002EHandle => 0uL;

	public bool IsNull => false;

	public bool IsEnabled => false;

	internal OVRPlugin.SpaceComponentType Type => default(OVRPlugin.SpaceComponentType);

	internal ulong Handle { get; }

	public Guid[] Uuids => null;

	bool IOVRAnchorComponent<OVRAnchorContainer>.IsNull => throw new NotImplementedException();

	bool IOVRAnchorComponent<OVRAnchorContainer>.IsEnabled => throw new NotImplementedException();

	OVRPlugin.SpaceComponentType IOVRAnchorComponent<OVRAnchorContainer>.Type => throw new NotImplementedException();

	ulong IOVRAnchorComponent<OVRAnchorContainer>.Handle => throw new NotImplementedException();

	private OVRAnchorContainer IOVRAnchorComponent_003COVRAnchorContainer_003E_002EFromAnchor(OVRAnchor anchor)
	{
		return default(OVRAnchorContainer);
	}

	private OVRTask<bool> IOVRAnchorComponent_003COVRAnchorContainer_003E_002ESetEnabledAsync(bool enabled, double timeout)
	{
		return default(OVRTask<bool>);
	}

	public bool Equals(OVRAnchorContainer other)
	{
		return false;
	}

	public static bool operator ==(OVRAnchorContainer lhs, OVRAnchorContainer rhs)
	{
		return false;
	}

	public static bool operator !=(OVRAnchorContainer lhs, OVRAnchorContainer rhs)
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

	private OVRAnchorContainer(OVRAnchor anchor)
	{
		Handle = 0uL;
	}

	public OVRTask<bool> FetchChildrenAsync(List<OVRAnchor> anchors)
	{
		return default(OVRTask<bool>);
	}

	public OVRTask<bool> SetEnabledAsync(bool enable, double timeout = 0)
	{
		throw new NotImplementedException();
	}

	OVRTask<bool> IOVRAnchorComponent<OVRAnchorContainer>.SetEnabledAsync(bool enable, double timeout)
	{
		throw new NotImplementedException();
	}

	OVRAnchorContainer IOVRAnchorComponent<OVRAnchorContainer>.FromAnchor(OVRAnchor anchor)
	{
		throw new NotImplementedException();
	}
}
