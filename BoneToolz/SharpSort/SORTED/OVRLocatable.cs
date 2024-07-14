using System;
using UnityEngine;

public readonly struct OVRLocatable : IOVRAnchorComponent<OVRLocatable>, IEquatable<OVRLocatable>
{
	public readonly struct TrackingSpacePose
	{
		private readonly OVRPlugin.SpaceLocationFlags _flags;

		public Vector3? Position { get; }

		public Quaternion? Rotation { get; }

		public bool IsPositionTracked => false;

		public bool IsRotationTracked => false;

		internal TrackingSpacePose(Vector3 position, Quaternion rotation, OVRPlugin.SpaceLocationFlags flags)
		{
			Position = null;
			Rotation = null;
			_flags = default(OVRPlugin.SpaceLocationFlags);
		}

		public Vector3? ComputeWorldPosition(Camera camera)
		{
			return null;
		}

		public Quaternion? ComputeWorldRotation(Camera camera)
		{
			return null;
		}
	}

	public static readonly OVRLocatable Null;

	private OVRPlugin.SpaceComponentType IOVRAnchorComponent_003COVRLocatable_003E_002EType => default(OVRPlugin.SpaceComponentType);

	private ulong IOVRAnchorComponent_003COVRLocatable_003E_002EHandle => 0uL;

	public bool IsNull => false;

	public bool IsEnabled => false;

	internal OVRPlugin.SpaceComponentType Type => default(OVRPlugin.SpaceComponentType);

	internal ulong Handle { get; }

	bool IOVRAnchorComponent<OVRLocatable>.IsNull => throw new NotImplementedException();

	bool IOVRAnchorComponent<OVRLocatable>.IsEnabled => throw new NotImplementedException();

	OVRPlugin.SpaceComponentType IOVRAnchorComponent<OVRLocatable>.Type => throw new NotImplementedException();

	ulong IOVRAnchorComponent<OVRLocatable>.Handle => throw new NotImplementedException();

	private OVRLocatable IOVRAnchorComponent_003COVRLocatable_003E_002EFromAnchor(OVRAnchor anchor)
	{
		return default(OVRLocatable);
	}

	public OVRTask<bool> SetEnabledAsync(bool enabled, double timeout = 0.0)
	{
		return default(OVRTask<bool>);
	}

	public bool Equals(OVRLocatable other)
	{
		return false;
	}

	public static bool operator ==(OVRLocatable lhs, OVRLocatable rhs)
	{
		return false;
	}

	public static bool operator !=(OVRLocatable lhs, OVRLocatable rhs)
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

	private OVRLocatable(OVRAnchor anchor)
	{
		Handle = 0uL;
	}

	public bool TryGetSceneAnchorPose(out TrackingSpacePose pose)
	{
		pose = default(TrackingSpacePose);
		return false;
	}

	public bool TryGetSpatialAnchorPose(out TrackingSpacePose pose)
	{
		pose = default(TrackingSpacePose);
		return false;
	}

	OVRTask<bool> IOVRAnchorComponent<OVRLocatable>.SetEnabledAsync(bool enable, double timeout)
	{
		throw new NotImplementedException();
	}

	OVRLocatable IOVRAnchorComponent<OVRLocatable>.FromAnchor(OVRAnchor anchor)
	{
		throw new NotImplementedException();
	}
}
