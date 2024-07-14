using System;
using System.Collections.Generic;

internal static class OVRSpaceQuery
{
	public struct Options
	{
		public const int MaxUuidCount = 1024;

		private static readonly Guid[] Ids;

		private static readonly OVRPlugin.SpaceComponentType[] ComponentTypes;

		private OVRPlugin.SpaceComponentType _componentType;

		private IEnumerable<Guid> _uuidFilter;

		public int MaxResults { get; set; }

		public double Timeout { get; set; }

		public OVRSpace.StorageLocation Location { get; set; }

		public OVRPlugin.SpaceQueryType QueryType { get; set; }

		public OVRPlugin.SpaceQueryActionType ActionType { get; set; }

		public OVRPlugin.SpaceComponentType ComponentFilter
		{
			get
			{
				return default(OVRPlugin.SpaceComponentType);
			}
			set
			{
			}
		}

		public IEnumerable<Guid> UuidFilter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Options(Options other)
		{
			MaxResults = 0;
			Timeout = 0.0;
			Location = default(OVRSpace.StorageLocation);
			QueryType = default(OVRPlugin.SpaceQueryType);
			ActionType = default(OVRPlugin.SpaceQueryActionType);
			_componentType = default(OVRPlugin.SpaceComponentType);
			_uuidFilter = null;
		}

		public OVRPlugin.SpaceQueryInfo ToQueryInfo()
		{
			return default(OVRPlugin.SpaceQueryInfo);
		}

		public bool TryQuerySpaces(out ulong requestId)
		{
			requestId = default(ulong);
			return false;
		}

		private static void ValidateSingleFilter(IEnumerable<Guid> uuidFilter, OVRPlugin.SpaceComponentType componentFilter)
		{
		}
	}
}
