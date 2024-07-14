using System;

public readonly struct OVRSemanticLabels : IOVRAnchorComponent<OVRSemanticLabels>, IEquatable<OVRSemanticLabels>
{
	public static readonly OVRSemanticLabels Null;

	private OVRPlugin.SpaceComponentType IOVRAnchorComponent_003COVRSemanticLabels_003E_002EType => default(OVRPlugin.SpaceComponentType);

	private ulong IOVRAnchorComponent_003COVRSemanticLabels_003E_002EHandle => 0uL;

	public bool IsNull => false;

	public bool IsEnabled => false;

	internal OVRPlugin.SpaceComponentType Type => default(OVRPlugin.SpaceComponentType);

	internal ulong Handle { get; }

	public string Labels => null;

	bool IOVRAnchorComponent<OVRSemanticLabels>.IsNull => throw new NotImplementedException();

	bool IOVRAnchorComponent<OVRSemanticLabels>.IsEnabled => throw new NotImplementedException();

	OVRPlugin.SpaceComponentType IOVRAnchorComponent<OVRSemanticLabels>.Type => throw new NotImplementedException();

	ulong IOVRAnchorComponent<OVRSemanticLabels>.Handle => throw new NotImplementedException();

	private OVRSemanticLabels IOVRAnchorComponent_003COVRSemanticLabels_003E_002EFromAnchor(OVRAnchor anchor)
	{
		return default(OVRSemanticLabels);
	}

	private OVRTask<bool> IOVRAnchorComponent_003COVRSemanticLabels_003E_002ESetEnabledAsync(bool enabled, double timeout)
	{
		return default(OVRTask<bool>);
	}

	public bool Equals(OVRSemanticLabels other)
	{
		return false;
	}

	public static bool operator ==(OVRSemanticLabels lhs, OVRSemanticLabels rhs)
	{
		return false;
	}

	public static bool operator !=(OVRSemanticLabels lhs, OVRSemanticLabels rhs)
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

	public OVRTask<bool> SetEnabledAsync(bool enable, double timeout = 0)
	{
		throw new NotImplementedException();
	}

	OVRTask<bool> IOVRAnchorComponent<OVRSemanticLabels>.SetEnabledAsync(bool enable, double timeout)
	{
		throw new NotImplementedException();
	}

	OVRSemanticLabels IOVRAnchorComponent<OVRSemanticLabels>.FromAnchor(OVRAnchor anchor)
	{
		throw new NotImplementedException();
	}

	private OVRSemanticLabels(OVRAnchor anchor)
	{
		Handle = 0uL;
	}
}
