using UnityEngine;

namespace RootMotion
{
	public static class LayerMaskExtensions
	{
		public static bool Contains(LayerMask mask, int layer)
		{
			return false;
		}

		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
}
