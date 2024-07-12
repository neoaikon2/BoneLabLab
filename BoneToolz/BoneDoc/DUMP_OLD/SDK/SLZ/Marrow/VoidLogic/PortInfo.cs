using System.Runtime.CompilerServices;

namespace SLZ.Marrow.VoidLogic
{
	public struct PortInfo
	{
		public readonly string Name;

		public readonly int Offset;

		public readonly int Width;

		public PortInfo(string name, int offset, int width)
		{
			this.Width = default(int);
			this.Offset = default(int);
			this.Name = default(string);
		}
	}
}
