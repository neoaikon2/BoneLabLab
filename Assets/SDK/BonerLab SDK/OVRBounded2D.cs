using System;
using Unity.Collections;
using UnityEngine;

public readonly struct OVRBounded2D : IOVRAnchorComponent<OVRBounded2D>, IEquatable<OVRBounded2D>
{
	public static readonly OVRBounded2D Null;

	private OVRPlugin.SpaceComponentType IOVRAnchorComponent_003COVRBounded2D_003E_002EType => default(OVRPlugin.SpaceComponentType);

	private ulong IOVRAnchorComponent_003COVRBounded2D_003E_002EHandle => 0uL;

	public bool IsNull => false;

	public bool IsEnabled => false;

	internal OVRPlugin.SpaceComponentType Type => default(OVRPlugin.SpaceComponentType);

	internal ulong Handle { get; }

	public Rect BoundingBox => default(Rect);

	bool IOVRAnchorComponent<OVRBounded2D>.IsNull => throw new NotImplementedException();

	bool IOVRAnchorComponent<OVRBounded2D>.IsEnabled => throw new NotImplementedException();

	OVRPlugin.SpaceComponentType IOVRAnchorComponent<OVRBounded2D>.Type => throw new NotImplementedException();

	ulong IOVRAnchorComponent<OVRBounded2D>.Handle => throw new NotImplementedException();

	private OVRBounded2D IOVRAnchorComponent_003COVRBounded2D_003E_002EFromAnchor(OVRAnchor anchor)
	{
		return default(OVRBounded2D);
	}

	private OVRTask<bool> IOVRAnchorComponent_003COVRBounded2D_003E_002ESetEnabledAsync(bool enabled, double timeout)
	{
		return default(OVRTask<bool>);
	}

	public bool Equals(OVRBounded2D other)
	{
		return false;
	}

	public static bool operator ==(OVRBounded2D lhs, OVRBounded2D rhs)
	{
		return false;
	}

	public static bool operator !=(OVRBounded2D lhs, OVRBounded2D rhs)
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

	private OVRBounded2D(OVRAnchor anchor)
	{
		Handle = 0uL;
	}

	private Rect ConvertRect(OVRPlugin.Rectf openXrRect)
	{
		return default(Rect);
	}

	public bool TryGetBoundaryPointsCount(out int count)
	{
		count = default(int);
		return false;
	}

	public bool TryGetBoundaryPoints(NativeArray<Vector2> positions)
	{
		return false;
	}

	public OVRTask<bool> SetEnabledAsync(bool enable, double timeout = 0)
	{
		throw new NotImplementedException();
	}

	OVRTask<bool> IOVRAnchorComponent<OVRBounded2D>.SetEnabledAsync(bool enable, double timeout)
	{
		throw new NotImplementedException();
	}

	OVRBounded2D IOVRAnchorComponent<OVRBounded2D>.FromAnchor(OVRAnchor anchor)
	{
		throw new NotImplementedException();
	}
}
