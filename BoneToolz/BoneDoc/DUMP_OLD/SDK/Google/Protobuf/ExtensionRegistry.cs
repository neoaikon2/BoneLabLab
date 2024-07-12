using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf
{
	public sealed class ExtensionRegistry : ICollection<Extension>, IEnumerable<Extension>, IEnumerable, IDeepCloneable<ExtensionRegistry>
	{
		private IDictionary<ObjectIntPair<Type>, Extension> extensions;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		bool ICollection<Extension>.IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		public ExtensionRegistry()
			: base()
		{
		}

		private ExtensionRegistry(IDictionary<ObjectIntPair<Type>, Extension> collection)
			: this()
		{
		}

		internal bool ContainsInputField(CodedInputStream stream, Type target, [Out] Extension extension)
		{
			return default(bool);
		}

		public void Add(Extension extension)
		{
		}

		public void AddRange(IEnumerable<Extension> extensions)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(Extension item)
		{
			return default(bool);
		}

		void ICollection<Extension>.CopyTo(Extension[] array, int arrayIndex)
		{
		}

		public IEnumerator<Extension> GetEnumerator()
		{
			return null;
		}

		public bool Remove(Extension item)
		{
			return default(bool);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public ExtensionRegistry Clone()
		{
			return null;
		}
	}
}
