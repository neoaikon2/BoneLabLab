using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Extensions.Logging
{
	[Nullable(0)]
	[NullableContext(2)]
	public struct EventId
	{
		public int Id { get; }

		public string Name { get; }

		public EventId(int id, string name = default(string))
		{
			this.Name = default(string);
			this.Id = default(int);
		}

		[NullableContext(1)]
		public override string ToString()
		{
			return null;
		}

		public bool Equals(EventId other)
		{
			return default(bool);
		}

		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
