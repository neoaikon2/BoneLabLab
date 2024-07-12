using System.Runtime.InteropServices;

namespace SLZ.Graphics2.VRS
{
	[StructLayout(LayoutKind.Sequential, Size = 64)]
	internal struct ShadingRateTable
	{
		public int[] table;
	}
}
