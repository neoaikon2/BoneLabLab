using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using WebSocketSharp.Net;

namespace WebSocketSharp
{
	public static class Ext
	{
		private static readonly byte[] _last;

		private static readonly int _retry;

		private static byte[] compress(this byte[] data)
		{
			return null;
		}

		private static MemoryStream compress(this Stream stream)
		{
			return null;
		}

		private static byte[] compressToArray(this Stream stream)
		{
			return null;
		}

		private static byte[] decompress(this byte[] data)
		{
			return null;
		}

		private static MemoryStream decompress(this Stream stream)
		{
			return null;
		}

		private static byte[] decompressToArray(this Stream stream)
		{
			return null;
		}

		private static bool isHttpMethod(this string value)
		{
			return default(bool);
		}

		private static bool isHttpMethod10(this string value)
		{
			return default(bool);
		}

		internal static byte[] Append(this ushort code, string reason)
		{
			return null;
		}

		internal static byte[] Compress(this byte[] data, CompressionMethod method)
		{
			return null;
		}

		internal static Stream Compress(this Stream stream, CompressionMethod method)
		{
			return null;
		}

		internal static bool Contains(this string value, params char[] anyOf)
		{
			anyOf = default(char[]);
			return default(bool);
		}

		internal static bool Contains(this NameValueCollection collection, string name, string value, StringComparison comparisonTypeForValue)
		{
			return default(bool);
		}

		internal static bool Contains<T>(this IEnumerable<T> source, Func<T, bool> condition)
		{
			return default(bool);
		}

		internal static void CopyToAsync(this Stream source, Stream destination, int bufferLength, Action completed, Action<Exception> error)
		{
		}

		internal static byte[] Decompress(this byte[] data, CompressionMethod method)
		{
			return null;
		}

		internal static byte[] DecompressToArray(this Stream stream, CompressionMethod method)
		{
			return null;
		}

		internal static void Emit(this EventHandler eventHandler, object sender, EventArgs e)
		{
		}

		internal static void Emit<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e) where TEventArgs : EventArgs
		{
		}

		internal static string GetAbsolutePath(this Uri uri)
		{
			return null;
		}

		internal static WebSocketSharp.Net.CookieCollection GetCookies(this NameValueCollection headers, bool response)
		{
			return null;
		}

		internal static string GetMessage(this CloseStatusCode code)
		{
			return null;
		}

		internal static byte[] GetUTF8EncodedBytes(this string s)
		{
			return null;
		}

		internal static string GetValue(this string nameAndValue, char separator, bool unquote)
		{
			return null;
		}

		internal static byte[] InternalToByteArray(this ushort value, ByteOrder order)
		{
			return null;
		}

		internal static byte[] InternalToByteArray(this ulong value, ByteOrder order)
		{
			return null;
		}

		internal static bool IsCompressionExtension(this string value, CompressionMethod method)
		{
			return default(bool);
		}

		internal static bool IsControl(this byte opcode)
		{
			return default(bool);
		}

		internal static bool IsData(this byte opcode)
		{
			return default(bool);
		}

		internal static bool IsData(this Opcode opcode)
		{
			return default(bool);
		}

		internal static bool IsHttpMethod(this string value, Version version)
		{
			return default(bool);
		}

		internal static bool IsPortNumber(this int value)
		{
			return default(bool);
		}

		internal static bool IsReserved(this ushort code)
		{
			return default(bool);
		}

		internal static bool IsSupported(this byte opcode)
		{
			return default(bool);
		}

		internal static bool IsText(this string value)
		{
			return default(bool);
		}

		internal static bool IsToken(this string value)
		{
			return default(bool);
		}

		internal static bool KeepsAlive(this NameValueCollection headers, Version version)
		{
			return default(bool);
		}

		internal static string Quote(this string value)
		{
			return null;
		}

		internal static void ReadBytesAsync(this Stream stream, int length, Action<byte[]> completed, Action<Exception> error)
		{
		}

		internal static void ReadBytesAsync(this Stream stream, long length, int bufferLength, Action<byte[]> completed, Action<Exception> error)
		{
		}

		internal static T[] Reverse<T>(this T[] array)
		{
			return null;
		}

		internal static IEnumerable<string> SplitHeaderValue(this string value, params char[] separators)
		{
			separators = default(char[]);
			return null;
		}

		internal static byte[] ToByteArray(this Stream stream)
		{
			return null;
		}

		internal static string ToExtensionString(this CompressionMethod method, params string[] parameters)
		{
			parameters = default(string[]);
			return null;
		}

		internal static IPAddress ToIPAddress(this string value)
		{
			return null;
		}

		internal static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		internal static string ToString(this IPAddress address, bool bracketIPv6)
		{
			return null;
		}

		internal static ushort ToUInt16(this byte[] source, ByteOrder sourceOrder)
		{
			return default(ushort);
		}

		internal static ulong ToUInt64(this byte[] source, ByteOrder sourceOrder)
		{
			return default(ulong);
		}

		internal static string TrimSlashFromEnd(this string value)
		{
			return null;
		}

		internal static string TrimSlashOrBackslashFromEnd(this string value)
		{
			return null;
		}

		internal static bool TryCreateVersion(this string versionString, [Out] Version result)
		{
			return default(bool);
		}

		internal static bool TryGetUTF8DecodedString(this byte[] bytes, [Out] string s)
		{
			return default(bool);
		}

		internal static bool TryGetUTF8EncodedBytes(this string s, [Out] byte[] bytes)
		{
			return default(bool);
		}

		internal static string Unquote(this string value)
		{
			return null;
		}

		internal static bool Upgrades(this NameValueCollection headers, string protocol)
		{
			return default(bool);
		}

		internal static void WriteBytes(this Stream stream, byte[] bytes, int bufferLength)
		{
		}

		internal static void WriteBytesAsync(this Stream stream, byte[] bytes, int bufferLength, Action completed, Action<Exception> error)
		{
		}

		public static string GetDescription(this WebSocketSharp.Net.HttpStatusCode code)
		{
			return null;
		}

		public static string GetStatusDescription(this int code)
		{
			return null;
		}

		public static bool IsEnclosedIn(this string value, char c)
		{
			return default(bool);
		}

		public static bool IsHostOrder(this ByteOrder order)
		{
			return default(bool);
		}

		public static bool IsLocal(this IPAddress address)
		{
			return default(bool);
		}

		public static bool IsNullOrEmpty(this string value)
		{
			return default(bool);
		}

		public static bool IsPredefinedScheme(this string value)
		{
			return default(bool);
		}

		public static bool MaybeUri(this string value)
		{
			return default(bool);
		}

		public static T[] SubArray<T>(this T[] array, int startIndex, int length)
		{
			return null;
		}

		public static T[] SubArray<T>(this T[] array, long startIndex, long length)
		{
			return null;
		}

		public static byte[] ToHostOrder(this byte[] source, ByteOrder sourceOrder)
		{
			return null;
		}

		public static string ToString<T>(this T[] array, string separator)
		{
			return null;
		}

		public static Uri ToUri(this string value)
		{
			return null;
		}
	}
}
