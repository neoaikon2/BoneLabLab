using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	public class SpatialGraphNode
	{
		private ulong m_spaceId;

		private const NativeLibToken token = NativeLibToken.HoloLens;

		public Guid Id { get; private set; }

		public static SpatialGraphNode FromStaticNodeId(Guid id)
		{
			return null;
		}

		public static SpatialGraphNode FromDynamicNodeId(Guid id)
		{
			return null;
		}

		public bool TryLocate(FrameTime frameTime, [Out] Pose pose)
		{
			return default(bool);
		}

		public bool TryLocate(long qpcTime, [Out] Pose pose)
		{
			return default(bool);
		}

		private SpatialGraphNode()
			: base()
		{
		}
	}
}
