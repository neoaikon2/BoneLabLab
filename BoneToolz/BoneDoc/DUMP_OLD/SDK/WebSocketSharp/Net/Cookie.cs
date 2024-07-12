using System;
using System.Runtime.InteropServices;

namespace WebSocketSharp.Net
{
	[Serializable]
	public sealed class Cookie
	{
		private string _comment;

		private Uri _commentUri;

		private bool _discard;

		private string _domain;

		private static readonly int[] _emptyPorts;

		private DateTime _expires;

		private bool _httpOnly;

		private string _name;

		private string _path;

		private string _port;

		private int[] _ports;

		private static readonly char[] _reservedCharsForValue;

		private string _sameSite;

		private bool _secure;

		private DateTime _timeStamp;

		private string _value;

		private int _version;

		internal int MaxAge
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		internal string SameSite
		{
			set
			{
			}
		}

		internal string Comment
		{
			set
			{
			}
		}

		internal Uri CommentUri
		{
			set
			{
			}
		}

		internal bool Discard
		{
			set
			{
			}
		}

		public string Domain
		{
			set
			{
			}
		}

		public DateTime Expires
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public bool HttpOnly
		{
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string Path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string Port
		{
			set
			{
			}
		}

		public bool Secure
		{
			set
			{
			}
		}

		public int Version
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		static Cookie()
		{
		}

		internal Cookie()
			: base()
		{
		}

		public Cookie(string name, string value)
			: this()
		{
		}

		public Cookie(string name, string value, string path, string domain)
			: this()
		{
		}

		private static int hash(int i, int j, int k, int l, int m)
		{
			return default(int);
		}

		private void init(string name, string value, string path, string domain)
		{
		}

		private string toResponseStringVersion0()
		{
			return null;
		}

		private string toResponseStringVersion1()
		{
			return null;
		}

		private static bool tryCreatePorts(string value, [Out] int[] result)
		{
			return default(bool);
		}

		internal bool EqualsWithoutValue(Cookie cookie)
		{
			return default(bool);
		}

		internal string ToRequestString(Uri uri)
		{
			return null;
		}

		internal string ToResponseString()
		{
			return null;
		}

		internal static bool TryCreate(string name, string value, [Out] Cookie result)
		{
			return default(bool);
		}

		public override bool Equals(object comparand)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
