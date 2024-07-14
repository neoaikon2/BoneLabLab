public static class OperationResultExtensions
{
	public static bool IsSuccess(this OVRSpatialAnchor.OperationResult res)
	{
		return false;
	}

	public static bool IsError(this OVRSpatialAnchor.OperationResult res)
	{
		return false;
	}

	public static bool IsWarning(this OVRSpatialAnchor.OperationResult res)
	{
		return false;
	}
}
