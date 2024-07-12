using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	public class XRAnchorTransferBatch
	{
		private readonly AnchorTransferBatch m_anchorTransferBatch;

		public IReadOnlyList<string> AnchorNames
		{
			get
			{
				return null;
			}
		}

		public XRAnchorTransferBatch()
			: base()
		{
		}

		private XRAnchorTransferBatch(AnchorTransferBatch anchorTransferBatch)
			: this()
		{
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

		public static Task<Stream> ExportAsync(XRAnchorTransferBatch anchorTransferBatch)
		{
			return null;
		}

		public static Task<XRAnchorTransferBatch> ImportAsync(Stream inputStream)
		{
			return null;
		}
	}
}
