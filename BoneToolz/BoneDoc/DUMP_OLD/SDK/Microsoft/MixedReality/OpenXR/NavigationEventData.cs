using System.Runtime.InteropServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 16)]
	public struct NavigationEventData
	{
		public Vector3 NormalizedOffset;

		private NativeDirectionFlags m_directionFlags;

		public bool IsNavigatingX
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsNavigatingY
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsNavigatingZ
		{
			get
			{
				return default(bool);
			}
		}
	}
}
