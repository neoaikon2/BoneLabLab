using System;
using UnityEngine;

namespace TMPro
{
	internal static class SetPropertyUtility
	{
		public static bool SetColor(Color currentValue, Color newValue)
		{
			return default(bool);
		}

		public static bool SetEquatableStruct<T>(T currentValue, T newValue) where T : IEquatable<T>
		{
			return default(bool);
		}

		public static bool SetStruct<T>(T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		public static bool SetClass<T>(T currentValue, T newValue) where T : class
		{
			return default(bool);
		}
	}
}
