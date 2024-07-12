using System.Collections.Generic;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	internal class OpenXRAnchorStore
	{
		internal static readonly NativeLibToken nativeLibToken;

		private List<string> m_persistedAnchorNamesCache;

		private bool m_persistedAnchorNamesCacheDirty;

		private readonly object m_persistedAnchorNamesCacheLock;

		public IReadOnlyList<string> PersistedAnchorNames
		{
			get
			{
				return null;
			}
		}

		private void UpdatePersistedAnchorNames()
		{
		}

		public TrackableId LoadAnchor(string name)
		{
			return default(TrackableId);
		}

		public bool TryPersistAnchor(string name, TrackableId trackableId)
		{
			return default(bool);
		}

		public void UnpersistAnchor(string name)
		{
		}

		public void Clear()
		{
		}

		public OpenXRAnchorStore()
			: base()
		{
		}
	}
}
