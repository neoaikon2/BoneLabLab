public interface IOVRAnchorComponent<T>
{
	bool IsNull { get; }

	bool IsEnabled { get; }

	internal OVRPlugin.SpaceComponentType Type { get; }

	internal ulong Handle { get; }

	OVRTask<bool> SetEnabledAsync(bool enable, double timeout = 0.0);

	internal T FromAnchor(OVRAnchor anchor);
}
