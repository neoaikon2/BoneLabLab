using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace WebSocketSharp
{
	internal class WebSocketFrame : IEnumerable<byte>, IEnumerable
	{
		private byte[] _extPayloadLength;

		private Fin _fin;

		private Mask _mask;

		private byte[] _maskingKey;

		private Opcode _opcode;

		private PayloadData _payloadData;

		private byte _payloadLength;

		private Rsv _rsv1;

		private Rsv _rsv2;

		private Rsv _rsv3;

		internal ulong ExactPayloadLength
		{
			get
			{
				return default(ulong);
			}
		}

		internal int ExtendedPayloadLengthWidth
		{
			get
			{
				return default(int);
			}
		}

		public bool IsClose
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsCompressed
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsContinuation
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsData
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsFinal
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsFragment
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsMasked
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsPing
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsPong
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsText
		{
			get
			{
				return default(bool);
			}
		}

		public ulong Length
		{
			get
			{
				return default(ulong);
			}
		}

		public Opcode Opcode
		{
			get
			{
				return default(Opcode);
			}
		}

		public PayloadData PayloadData
		{
			get
			{
				return null;
			}
		}

		public Rsv Rsv2
		{
			get
			{
				return default(Rsv);
			}
		}

		public Rsv Rsv3
		{
			get
			{
				return default(Rsv);
			}
		}

		private WebSocketFrame()
			: base()
		{
		}

		internal WebSocketFrame(Fin fin, Opcode opcode, byte[] data, bool compressed, bool mask)
			: this()
		{
		}

		internal WebSocketFrame(Fin fin, Opcode opcode, PayloadData payloadData, bool compressed, bool mask)
			: this()
		{
		}

		private static byte[] createMaskingKey()
		{
			return null;
		}

		private static string dump(WebSocketFrame frame)
		{
			return null;
		}

		private static string print(WebSocketFrame frame)
		{
			return null;
		}

		private static WebSocketFrame processHeader(byte[] header)
		{
			return null;
		}

		private static void readExtendedPayloadLengthAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
		}

		private static void readHeaderAsync(Stream stream, Action<WebSocketFrame> completed, Action<Exception> error)
		{
		}

		private static void readMaskingKeyAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
		}

		private static void readPayloadDataAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
		}

		private static string utf8Decode(byte[] bytes)
		{
			return null;
		}

		internal static WebSocketFrame CreateCloseFrame(PayloadData payloadData, bool mask)
		{
			return null;
		}

		internal static WebSocketFrame CreatePingFrame(bool mask)
		{
			return null;
		}

		internal static WebSocketFrame CreatePongFrame(PayloadData payloadData, bool mask)
		{
			return null;
		}

		internal static void ReadFrameAsync(Stream stream, bool unmask, Action<WebSocketFrame> completed, Action<Exception> error)
		{
		}

		internal void Unmask()
		{
		}

		public IEnumerator<byte> GetEnumerator()
		{
			return null;
		}

		public string PrintToString(bool dumped)
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
