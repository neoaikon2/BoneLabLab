using System;

namespace Microsoft.MixedReality.OpenXR
{
	public class GestureRecognizer
	{
		private GestureSubsystem m_gestureSubsystem;

		private GestureSettings m_requestedSettings;

		public GestureSettings GestureSettings
		{
			get
			{
				return default(GestureSettings);
			}
			set
			{
			}
		}

		public GestureRecognizer(GestureSettings settings)
			: base()
		{
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		public bool TryGetNextEvent(GestureEventData eventData)
		{
			return default(bool);
		}

		public void CancelPendingGestures()
		{
		}

		public void Destroy()
		{
		}

		[Obsolete("Obsolete and will be removed in future releases.  Use the Destroy() function at appropriated place instead.")]
		public void Dispose()
		{
		}
	}
}
