using System.Collections.Generic;

namespace SLZ.Marrow.Zones
{
	internal class DisableManager
	{
		private readonly Dictionary<IDisableCallbackHandler, DisableCount> _disableCounts;

		private readonly List<IDisableCallbackHandler> _dirtyDisableStates;

		private readonly Queue<(IDisableCallbackHandler, bool)> _queuedDisables;

		private List<(bool isMarked, IDisableCallbackHandler disableable, DisableTypes type)> _eventBufferA;

		private List<(bool isMarked, IDisableCallbackHandler disableable, DisableTypes type)> _eventBufferB;

		private int _lastDisableFrame;

		public void Cleanup()
		{
		}

		public void Register(IDisableCallbackHandler entity)
		{
		}

		public void Unregister(IDisableCallbackHandler entity)
		{
		}

		public void MarkDisabled(IDisableCallbackHandler disableable, DisableTypes type)
		{
		}

		public void UnmarkDisabled(IDisableCallbackHandler disableable, DisableTypes type)
		{
		}

		private void ProcessDisabled((bool isMarked, IDisableCallbackHandler disableable, DisableTypes type) info)
		{
		}

		private void LastPostLateUpdate()
		{
		}
	}
}
