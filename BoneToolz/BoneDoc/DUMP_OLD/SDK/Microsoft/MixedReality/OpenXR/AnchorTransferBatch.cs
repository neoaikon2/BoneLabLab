using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	internal class AnchorTransferBatch
	{
		public IReadOnlyList<string> AnchorNames
		{
			get
			{
				return null;
			}
		}

		public bool AddAnchor(TrackableId trackableId, string name)
		{
			return default(bool);
		}

		public void RemoveAnchor(string name)
		{
		}

		public void Clear()
		{
		}

		public TrackableId LoadAnchor(string name)
		{
			return default(TrackableId);
		}

		public TrackableId LoadAndReplaceAnchor(string name, TrackableId trackableId)
		{
			return default(TrackableId);
		}

		public Task<SerializationCompletionReason> ExportAsync(Stream output)
		{
			return null;
		}

		public Task<SerializationCompletionReason> ImportAsync(Stream input)
		{
			return null;
		}

		public AnchorTransferBatch()
			: base()
		{
		}
	}
}
