using System;
using UnityEngine;

namespace SLZ.Graphics2.VRS
{
	public class ShadingRateResource : IDisposable
	{
		public struct Settings
		{
			public float outerMinorRadius;

			public float outerMajorRadius;

			public float innerMinorRadius;

			public float innerMajorRadius;
		}

		public RenderTexture shadingRateTexture;

		public IntPtr shadingRateTexturePtr;

		public IntPtr SRRViewPtr;

		public IntPtr SRRTablePtr;

		public int[] SRRTable;

		public int maxShadingRate;

		public ComputeBuffer shadingRateLUT;

		public Settings settings;

		private bool disposed;

		public float[] LUTTable;

		private int msaaLevel;

		public static int[] table;

		public static float[] BufferTableConst;

		public static int[] shadingRateClamped;

		public ShadingRateResource(RenderTextureDescriptor desc, Settings settings, string name = "")
			: base()
		{
		}

		public bool UpdateResource(RenderTextureDescriptor desc, Settings newSettings, string name = "")
		{
			return default(bool);
		}

		~ShadingRateResource()
		{
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}

		private void clearTexture()
		{
		}

		private void clearSRRTable()
		{
		}

		private void clearSRLUT()
		{
		}

		public void clearResource(bool manual)
		{
		}

		private void DestroyObject(UnityEngine.Object o)
		{
		}
	}
}
