namespace Microsoft.MixedReality.OpenXR
{
	internal class GestureSubsystem : Disposable
	{
		private static readonly NativeLibToken nativeLibToken;

		private readonly ulong m_gestureRecognizerHandle;

		private GestureSettings m_gestureSettings;

		private bool m_running;

		private readonly object m_runningLock;

		internal GestureSettings GestureSettings
		{
			get
			{
				return default(GestureSettings);
			}
			set
			{
			}
		}

		internal static GestureSubsystem TryCreateGestureSubsystem(GestureSettings settings)
		{
			return null;
		}

		private GestureSubsystem(GestureSettings settings, ulong handle)
			: base()
		{
		}

		internal bool TryGetNextEvent(GestureEventData eventData)
		{
			return default(bool);
		}

		internal void CancelPendingGestures()
		{
		}

		protected override void DisposeNativeResources()
		{
		}

		internal void Start()
		{
		}

		internal void Stop()
		{
		}
	}
}
