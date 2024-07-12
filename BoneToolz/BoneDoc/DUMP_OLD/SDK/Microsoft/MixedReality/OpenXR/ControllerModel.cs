using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	public class ControllerModel
	{
		[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 128)]
		internal struct ControllerModelNodeProperties
		{
			private const int ControllerModelNodeNameSize = 64;

			public string ParentNodeName { get; }

			public string NodeName { get; }
		}

		private readonly Handedness m_handedness;

		private uint m_lastNodeStateCount;

		private static readonly MotionControllerFeaturePlugin m_feature;

		public static ControllerModel Left { get; }

		public static ControllerModel Right { get; }

		public static bool IsSupported
		{
			get
			{
				return default(bool);
			}
		}

		internal ControllerModel(Handedness trackerHandedness)
			: base()
		{
		}

		public bool TryGetControllerModelKey([Out] ulong modelKey)
		{
			return default(bool);
		}

		public Task<byte[]> TryGetControllerModel(ulong modelKey)
		{
			return null;
		}

		internal bool TryGetControllerModelProperties(ulong modelKey, Transform modelRoot, [Out] Transform[] nodes)
		{
			return default(bool);
		}

		internal bool TryGetControllerModelState(ulong modelKey, Pose[] poses)
		{
			return default(bool);
		}
	}
}
