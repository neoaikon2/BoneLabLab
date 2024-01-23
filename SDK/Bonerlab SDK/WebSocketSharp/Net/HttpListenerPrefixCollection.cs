using System.Collections;
using System.Collections.Generic;

namespace WebSocketSharp.Net
{
	public class HttpListenerPrefixCollection : ICollection<string>, IEnumerable<string>, IEnumerable
	{
		private HttpListener _listener;

		private List<string> _prefixes;

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

		internal HttpListenerPrefixCollection(HttpListener listener)
			: base()
		{
		}

		public void Add(string uriPrefix)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(string uriPrefix)
		{
			return default(bool);
		}

		public void CopyTo(string[] array, int offset)
		{
		}

		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		public bool Remove(string uriPrefix)
		{
			return default(bool);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
