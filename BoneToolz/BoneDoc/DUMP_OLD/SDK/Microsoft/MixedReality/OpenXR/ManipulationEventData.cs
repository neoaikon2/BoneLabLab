using System.Runtime.InteropServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 12)]
	public struct ManipulationEventData
	{
		public Vector3 CumulativeTranslation;
	}
}
