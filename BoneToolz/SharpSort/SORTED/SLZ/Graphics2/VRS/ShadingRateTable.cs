using System.Runtime.InteropServices;

namespace SLZ.Graphics2.VRS
{
	[StructLayout(0, Size = 64)]
	internal struct ShadingRateTable
	{
		public int[] table;
	}
}
