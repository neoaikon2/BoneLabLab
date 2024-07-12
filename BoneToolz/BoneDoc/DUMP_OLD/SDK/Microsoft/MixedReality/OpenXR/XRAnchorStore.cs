using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	public class XRAnchorStore
	{
		private readonly OpenXRAnchorStore m_openxrAnchorStore;

		public IReadOnlyList<string> PersistedAnchorNames
		{
			get
			{
				return null;
			}
		}

		public TrackableId LoadAnchor(string name)
		{
			return default(TrackableId);
		}

		public bool TryPersistAnchor(TrackableId trackableId, string name)
		{
			return default(bool);
		}

		public void UnpersistAnchor(string name)
		{
		}

		public void Clear()
		{
		}

		[Obsolete("This method is obsolete. Use the LoadAnchorStoreAsync() extension method on an XRAnchorSubsystem or an ARAnchorManager instead.", false)]
		public static Task<XRAnchorStore> LoadAsync(XRAnchorSubsystem anchorSubsystem)
		{
			return null;
		}

		internal static Task<XRAnchorStore> LoadAnchorStoreAsync(XRAnchorSubsystem anchorSubsystem)
		{
			return null;
		}

		internal XRAnchorStore(OpenXRAnchorStore openxrAnchorStore)
			: base()
		{
		}
	}
}
