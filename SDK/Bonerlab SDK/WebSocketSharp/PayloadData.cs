using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WebSocketSharp
{
	internal class PayloadData : IEnumerable<byte>, IEnumerable
	{
		private byte[] _data;

		private long _extDataLength;

		private long _length;

		public static readonly PayloadData Empty;

		public static readonly ulong MaxLength;

		internal ushort Code
		{
			get
			{
				return default(ushort);
			}
		}

		internal bool HasReservedCode
		{
			get
			{
				return default(bool);
			}
		}

		public byte[] ApplicationData
		{
			get
			{
				return null;
			}
		}

		public ulong Length
		{
			get
			{
				return default(ulong);
			}
		}

		static PayloadData()
		{
		}

		internal PayloadData(byte[] data)
			: base()
		{
		}

		internal PayloadData(byte[] data, long length)
			: base()
		{
		}

		internal PayloadData(ushort code, string reason)
			: base()
		{
		}

		internal void Mask(byte[] key)
		{
		}

		public IEnumerator<byte> GetEnumerator()
		{
			return null;
		}

		public byte[] ToArray()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
