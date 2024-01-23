using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace WebSocketSharp.Net
{
	[Serializable]
	[ComVisible(true)]
	[DefaultMember("Item")]
	public class WebHeaderCollection : NameValueCollection, ISerializable
	{
		private static readonly Dictionary<string, HttpHeaderInfo> _headers;

		private bool _internallyUsed;

		private HttpHeaderType _state;

		public override string[] AllKeys
		{
			get
			{
				return null;
			}
		}

		public override int Count
		{
			get
			{
				return default(int);
			}
		}

		static WebHeaderCollection()
		{
		}

		internal WebHeaderCollection(HttpHeaderType state, bool internallyUsed)
			: this()
		{
		}

		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this()
		{
		}

		public WebHeaderCollection()
			: base()
		{
		}

		private void add(string name, string value, HttpHeaderType headerType)
		{
		}

		private void checkAllowed(HttpHeaderType headerType)
		{
		}

		private static string checkName(string name, string paramName)
		{
			return null;
		}

		private void checkRestricted(string name, HttpHeaderType headerType)
		{
		}

		private static string checkValue(string value, string paramName)
		{
			return null;
		}

		private static HttpHeaderInfo getHeaderInfo(string name)
		{
			return null;
		}

		private static HttpHeaderType getHeaderType(string name)
		{
			return default(HttpHeaderType);
		}

		private static bool isMultiValue(string name, bool response)
		{
			return default(bool);
		}

		private static bool isRestricted(string name, bool response)
		{
			return default(bool);
		}

		private void set(string name, string value, HttpHeaderType headerType)
		{
		}

		internal void InternalSet(string name, string value, bool response)
		{
		}

		internal string ToStringMultiValue(bool response)
		{
			return null;
		}

		public void Add(string header)
		{
		}

		public override void Add(string name, string value)
		{
		}

		public override string Get(int index)
		{
			return null;
		}

		public override string Get(string name)
		{
			return null;
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		public override string GetKey(int index)
		{
			return null;
		}

		public override string[] GetValues(int index)
		{
			return null;
		}

		public override string[] GetValues(string name)
		{
			return null;
		}

		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public override void OnDeserialization(object sender)
		{
		}

		public override void Remove(string name)
		{
		}

		public override void Set(string name, string value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
