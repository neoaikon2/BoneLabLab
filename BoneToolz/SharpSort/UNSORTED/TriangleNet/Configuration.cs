using System;

namespace TriangleNet
{
	public class Configuration
	{
		public Func<IPredicates> Predicates { get; set; }

		public Func<TrianglePool> TrianglePool { get; set; }

		public Configuration()
		{
		}

		public Configuration(Func<IPredicates> predicates)
		{
		}

		public Configuration(Func<IPredicates> predicates, Func<TrianglePool> trianglePool)
		{
		}
	}
}
