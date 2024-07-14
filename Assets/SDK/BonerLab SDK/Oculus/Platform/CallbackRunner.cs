using System.Runtime.InteropServices;
using UnityEngine;

namespace Oculus.Platform
{
	public class CallbackRunner : MonoBehaviour
	{
		public bool IsPersistantBetweenSceneLoads;

		[PreserveSig]
		private static extern void ovr_UnityResetTestPlatform();

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
