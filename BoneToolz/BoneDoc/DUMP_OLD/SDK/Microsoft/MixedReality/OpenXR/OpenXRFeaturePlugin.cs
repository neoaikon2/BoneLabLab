using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.XR.OpenXR.Features;

namespace Microsoft.MixedReality.OpenXR
{
	internal abstract class OpenXRFeaturePlugin<TPlugin> : OpenXRFeature, IOpenXRContext, ISubsystemPlugin where TPlugin : OpenXRFeaturePlugin<TPlugin>
	{
		internal static readonly NativeLibToken nativeLibToken;

		private List<SubsystemController> m_subsystemControllers;

		public ulong Instance { get; private set; }

		public ulong SystemId { get; private set; }

		public ulong Session { get; private set; }

		public bool IsSessionRunning { get; private set; }

		public XrSessionState SessionState { get; private set; }

		public ulong SceneOriginSpace { get; private set; }

		public IntPtr PFN_xrGetInstanceProcAddr
		{
			get
			{
				return default(IntPtr);
			}
		}

		internal NativeLibToken NativeLibToken
		{
			get
			{
				return default(NativeLibToken);
			}
		}

		static OpenXRFeaturePlugin()
		{
		}

		protected override void OnEnable()
		{
		}

		protected void AddSubsystemController(SubsystemController subsystemController)
		{
		}

		private bool IsExtensionEnabled(string extensionName, uint minimumRevision = 1u)
		{
			return default(bool);
		}

		protected override void OnSubsystemCreate()
		{
		}

		protected override void OnSubsystemStart()
		{
		}

		protected override void OnSubsystemStop()
		{
		}

		protected override void OnSubsystemDestroy()
		{
		}

		protected override bool OnInstanceCreate(ulong instance)
		{
			return default(bool);
		}

		protected override void OnInstanceDestroy(ulong instance)
		{
		}

		protected override void OnSystemChange(ulong systemId)
		{
		}

		protected override void OnSessionCreate(ulong session)
		{
		}

		protected override void OnSessionBegin(ulong session)
		{
		}

		protected override void OnSessionStateChange(int oldState, int newState)
		{
		}

		protected override void OnSessionEnd(ulong session)
		{
		}

		protected override void OnSessionDestroy(ulong session)
		{
		}

		protected override void OnAppSpaceChange(ulong sceneOriginSpace)
		{
		}

		void ISubsystemPlugin.CreateSubsystem<TDescriptor, TSubsystem>(List<TDescriptor> descriptors, string id)
		{
		}

		void ISubsystemPlugin.StartSubsystem<T>()
		{
		}

		void ISubsystemPlugin.StopSubsystem<T>()
		{
		}

		void ISubsystemPlugin.DestroySubsystem<T>()
		{
		}

		public OpenXRFeaturePlugin()
			: base()
		{
		}

		public event OpenXRContextEvent InstanceCreated;

		public event OpenXRContextEvent InstanceDestroying;

		public event OpenXRContextEvent SessionCreated;

		public event OpenXRContextEvent SessionDestroying;

		public event OpenXRContextEvent SessionBegun;

		public event OpenXRContextEvent SessionEnding;
	}
}
