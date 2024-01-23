using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace WebSocketSharp.Net
{
	[Serializable]
	[DefaultMember("Item")]
	public class CookieCollection : ICollection<Cookie>, IEnumerable<Cookie>, IEnumerable
	{
		private List<Cookie> _list;

		private bool _readOnly;

		private object _sync;

		internal IEnumerable<Cookie> Sorted
		{
			get
			{
				return null;
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

		private void add(Cookie cookie)
		{
		}

		private static int compareForSorted(Cookie x, Cookie y)
		{
			return default(int);
		}

		private static CookieCollection parseRequest(string value)
		{
			return null;
		}

		private static CookieCollection parseResponse(string value)
		{
			return null;
		}

		private int search(Cookie cookie)
		{
			return default(int);
		}

		private static string urlDecode(string s, Encoding encoding)
		{
			return null;
		}

		internal static CookieCollection Parse(string value, bool response)
		{
			return null;
		}

		public void Add(Cookie cookie)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(Cookie cookie)
		{
			return default(bool);
		}

		public void CopyTo(Cookie[] array, int index)
		{
		}

		public IEnumerator<Cookie> GetEnumerator()
		{
			return null;
		}

		public bool Remove(Cookie cookie)
		{
			return default(bool);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public CookieCollection()
			: base()
		{
		}
	}
}
