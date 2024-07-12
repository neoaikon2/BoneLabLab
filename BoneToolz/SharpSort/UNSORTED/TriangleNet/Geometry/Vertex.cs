using TriangleNet.Topology;

namespace TriangleNet.Geometry
{
	public class Vertex : Point
	{
		internal int hash;

		internal VertexType type;

		internal Otri tri;

		public VertexType Type => default(VertexType);

		public double this[int i] => 0.0;

		public Vertex()
		{
		}

		public Vertex(double x, double y)
		{
		}

		public Vertex(double x, double y, int mark)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
