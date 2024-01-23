using System;

namespace Steamworks
{
	internal struct Utf8StringPointer
	{
		internal IntPtr ptr;

		public static implicit operator string(Utf8StringPointer p)
		{
			return null;
		}
	}
}
