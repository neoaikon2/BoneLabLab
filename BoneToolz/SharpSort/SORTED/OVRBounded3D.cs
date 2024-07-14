using System;
using UnityEngine;

public readonly struct OVRBounded3D : IOVRAnchorComponent<OVRBounded3D>, IEquatable<OVRBounded3D>
{
	public static readonly OVRBounded3D Null;

	private OVRPlugin.SpaceComponentType IOVRAnchorComponent_003COVRBounded3D_003E_002EType => default(OVRPlugin.SpaceComponentType);

	private ulong IOVRAnchorComponent_003COVRBounded3D_003E_002EHandle => 0uL;

	public bool IsNull => false;

	public bool IsEnabled => false;

	internal OVRPlugin.SpaceComponentType Type => default(OVRPlugin.SpaceComponentType);

	internal ulong Handle { get; }

	public Bounds BoundingBox => default(Bounds);

	bool IOVRAnchorComponent<OVRBounded3D>.IsNull => throw new NotImplementedException();

	bool IOVRAnchorComponent<OVRBounded3D>.IsEnabled => throw new NotImplementedException();

	OVRPlugin.SpaceComponentType IOVRAnchorComponent<OVRBounded3D>.Type => throw new NotImplementedException();

	ulong IOVRAnchorComponent<OVRBounded3D>.Handle => throw new NotImplementedException();

	private OVRBounded3D IOVRAnchorComponent_003COVRBounded3D_003E_002EFromAnchor(OVRAnchor anchor)
	{
		return default(OVRBounded3D);
	}

	private OVRTask<bool> IOVRAnchorComponent_003COVRBounded3D_003E_002ESetEnabledAsync(bool enabled, double timeout)
	{
		return default(OVRTask<bool>);
	}

	public bool Equals(OVRBounded3D other)
	{
		return false;
	}

	public static bool operator ==(OVRBounded3D lhs, OVRBounded3D rhs)
	{
		return false;
	}

	public static bool operator !=(OVRBounded3D lhs, OVRBounded3D rhs)
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

	private OVRBounded3D(OVRAnchor anchor)
	{
		Handle = 0uL;
	}

	private Bounds ConvertBounds(OVRPlugin.Boundsf openXrBounds)
	{
		return default(Bounds);
	}

	public OVRTask<bool> SetEnabledAsync(bool enable, double timeout = 0)
	{
		throw new NotImplementedException();
	}

	OVRTask<bool> IOVRAnchorComponent<OVRBounded3D>.SetEnabledAsync(bool enable, double timeout)
	{
		throw new NotImplementedException();
	}

	OVRBounded3D IOVRAnchorComponent<OVRBounded3D>.FromAnchor(OVRAnchor anchor)
	{
		throw new NotImplementedException();
	}
}
