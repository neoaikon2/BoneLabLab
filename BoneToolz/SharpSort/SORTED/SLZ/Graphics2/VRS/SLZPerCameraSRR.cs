using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Graphics2.VRS
{
	public class SLZPerCameraSRR : IDisposable
	{
		public Dictionary<Camera, ShadingRateResource> perCameraResourceHandle;

		private bool disposed;

		private int purgeCounter;

		private int purgeMax;

		~SLZPerCameraSRR()
		{
		}

		public void RemoveCamera(Camera cam)
		{
		}

		public bool GetResource(ref ShadingRateResource res, Camera cam, RenderTextureDescriptor desc, ShadingRateResource.Settings settings)
		{
			return false;
		}

		public ShadingRateResource GetResourceNoRegen(Camera cam)
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}

		public void RemoveAllNull()
		{
		}

		private bool TrueVRSEnabled()
		{
			return false;
		}
	}
}
