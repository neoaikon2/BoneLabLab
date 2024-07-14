using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine.XR.Management;
using UnityEngine.XR.OpenXR.Features;

namespace SLZ.Marrow.Input
{
	public class XRApi
	{
		private readonly CancellationTokenSource _cts;

		private InputActions _inputActions;

		public XRManagerSettings Settings => null;

		public XRHMD HMD { get; private set; }

		public XRController LeftController { get; private set; }

		public XRController RightController { get; private set; }

		public XRHand LeftHand { get; private set; }

		public XRHand RightHand { get; private set; }

		public XRBody Body { get; private set; }

		public GamepadActionMap Gamepad { get; private set; }

		public ViveTrackerActionMap Trackers { get; private set; }

		public DisplaySubsystemManager Display { get; private set; }

		public InputSubsystemManager Input { get; private set; }

		public MeshSubsystemManager Mesh { get; private set; }

		public bool HasPalmPoseFeature { get; private set; }

		private static bool IsFeatureSupported<TFeature>() where TFeature : OpenXRFeature
		{
			return false;
		}
		public UniTask Initialize()
		{
			return default(UniTask);
		}

		public void Deinitialize()
		{
		}

		public void Refresh()
		{
		}

		private void OnStartFrame()
		{
		}

		private void OnPreNewInputUpdate()
		{
		}

		private void OnPostNewInputUpdate()
		{
		}
		private UniTask InitializeXRLoader()
		{
			return default(UniTask);
		}
		private UniTaskVoid WatchXRChanges()
		{
			return default(UniTaskVoid);
		}
	}
}
