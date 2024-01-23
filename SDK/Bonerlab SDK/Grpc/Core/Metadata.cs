using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Grpc.Core
{
	public sealed class Metadata : IList<Metadata.Entry>, ICollection<Metadata.Entry>, IEnumerable<Metadata.Entry>, IEnumerable
	{
		public class Entry
		{
			private static readonly Regex ValidKeyRegex;

			private readonly string key;

			private readonly string value;

			private readonly byte[] valueBytes;

			public string Key
			{
				get
				{
					return null;
				}
			}

			public bool IsBinary
			{
				get
				{
					return default(bool);
				}
			}

			private Entry(string key, string value, byte[] valueBytes)
				: base()
			{
			}

			public override string ToString()
			{
				return null;
			}

			internal byte[] GetSerializedValueUnsafe()
			{
				return null;
			}

			internal static Entry CreateUnsafe(string key, byte[] valueBytes)
			{
				return null;
			}

			private static bool HasBinaryHeaderSuffix(string key)
			{
				return default(bool);
			}
		}

		public static readonly Metadata Empty;

		private readonly List<Entry> entries;

		private bool readOnly;

		public Entry this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		internal Metadata Freeze()
		{
			return null;
		}

		public int IndexOf(Entry item)
		{
			return default(int);
		}

		public void Insert(int index, Entry item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Add(Entry item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(Entry item)
		{
			return default(bool);
		}

		public void CopyTo(Entry[] array, int arrayIndex)
		{
		}

		public bool Remove(Entry item)
		{
			return default(bool);
		}

		public IEnumerator<Entry> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private void CheckWriteable()
		{
		}

		public Metadata()
			: base()
		{
		}
	}
}
