using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection
{
	[NullableContext(1)]
	[Nullable(0)]
	public class ServiceCollection : IServiceCollection, IList<ServiceDescriptor>, ICollection<ServiceDescriptor>, IEnumerable<ServiceDescriptor>, IEnumerable
	{
		private readonly List<ServiceDescriptor> _descriptors;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		public ServiceDescriptor this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Clear()
		{
		}

		public bool Contains(ServiceDescriptor item)
		{
			return default(bool);
		}

		public void CopyTo(ServiceDescriptor[] array, int arrayIndex)
		{
		}

		public bool Remove(ServiceDescriptor item)
		{
			return default(bool);
		}

		public IEnumerator<ServiceDescriptor> GetEnumerator()
		{
			return null;
		}

		void ICollection<ServiceDescriptor>.Add(ServiceDescriptor item)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public int IndexOf(ServiceDescriptor item)
		{
			return default(int);
		}

		public void Insert(int index, ServiceDescriptor item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public ServiceCollection()
			: base()
		{
		}
	}
}
