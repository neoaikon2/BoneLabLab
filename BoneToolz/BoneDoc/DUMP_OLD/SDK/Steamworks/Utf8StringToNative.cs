using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal class Utf8StringToNative : ICustomMarshaler
	{
		public IntPtr MarshalManagedToNative(object managedObj)
		{
			return default(IntPtr);
		}

		public object MarshalNativeToManaged(IntPtr pNativeData)
		{
			return null;
		}

		public void CleanUpNativeData(IntPtr pNativeData)
		{
		}

		public void CleanUpManagedData(object managedObj)
		{
		}

		public int GetNativeDataSize()
		{
			return default(int);
		}

		[Preserve]
		public static ICustomMarshaler GetInstance(string cookie)
		{
			return null;
		}

		public Utf8StringToNative()
			: base()
		{
		}
	}
}
