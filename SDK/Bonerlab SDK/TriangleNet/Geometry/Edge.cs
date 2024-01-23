namespace TriangleNet.Geometry
{
	public class Edge : IEdge
	{
		public int P0 { get; private set; }

		public int P1 { get; private set; }

		public int Label { get; private set; }

		public Edge(int p0, int p1)
		{
		}

		public Edge(int p0, int p1, int label)
		{
		}
	}
}
