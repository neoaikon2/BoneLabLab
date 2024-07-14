using System;

internal static class OVRDeserialize
{
	public struct DisplayRefreshRateChangedData
	{
		public float FromRefreshRate;

		public float ToRefreshRate;
	}

	public struct SpaceQueryResultsData
	{
		public ulong RequestId;
	}

	public struct SpaceQueryCompleteData
	{
		public ulong RequestId;

		public int Result;
	}

	public struct SceneCaptureCompleteData
	{
		public ulong RequestId;

		public int Result;
	}

	public struct SpatialAnchorCreateCompleteData
	{
		public ulong RequestId;

		public int Result;

		public ulong Space;

		public Guid Uuid;
	}

	public struct SpaceSetComponentStatusCompleteData
	{
		public ulong RequestId;

		public int Result;

		public ulong Space;

		public Guid Uuid;

		public OVRPlugin.SpaceComponentType ComponentType;

		public int Enabled;
	}

	public struct SpaceSaveCompleteData
	{
		public ulong RequestId;

		public ulong Space;

		public int Result;

		public Guid Uuid;
	}

	public struct SpaceEraseCompleteData
	{
		public ulong RequestId;

		public int Result;

		public Guid Uuid;

		public OVRPlugin.SpaceStorageLocation Location;
	}

	public struct SpaceShareResultData
	{
		public ulong RequestId;

		public int Result;
	}

	public struct SpaceListSaveResultData
	{
		public ulong RequestId;

		public int Result;
	}

	public static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
	{
		return default(T);
	}
}
