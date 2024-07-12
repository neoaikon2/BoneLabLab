using System;

namespace Microsoft.MixedReality.OpenXR
{
	internal delegate void OpenXRContextEvent(IOpenXRContext sender, EventArgs args);
	internal delegate void OpenXRContextEvent<TEventArgs>(IOpenXRContext sender, TEventArgs args) where TEventArgs : EventArgs;
}
