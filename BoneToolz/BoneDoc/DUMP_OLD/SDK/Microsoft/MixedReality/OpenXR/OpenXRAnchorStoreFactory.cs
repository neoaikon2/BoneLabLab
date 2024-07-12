using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	internal static class OpenXRAnchorStoreFactory
	{
		private static Task<OpenXRAnchorStore> m_anchorStoreLoadTask;

		private static ulong m_currentOpenxrSession;

		public static Task<OpenXRAnchorStore> LoadAnchorStoreAsync(XRAnchorSubsystem anchorSubsystem)
		{
			return null;
		}
	}
}
