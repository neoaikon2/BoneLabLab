using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Zones
{
	internal class DisableManager
	{
		private readonly Dictionary<IDisableCallbackHandler, DisableCount> _disableCounts;

		private readonly List<IDisableCallbackHandler> _dirtyDisableStates;

		private readonly Queue<ValueTuple<IDisableCallbackHandler, bool>> _queuedDisables;
		
		private List<ValueTuple<bool, IDisableCallbackHandler, DisableTypes>> _eventBufferA;
		
		private List<ValueTuple<bool, IDisableCallbackHandler, DisableTypes>> _eventBufferB;

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

		private void ProcessDisabled(ValueTuple<bool, IDisableCallbackHandler, DisableTypes> info)
		{
		}

		private void LastPostLateUpdate()
		{
		}

		public DisableManager()
			: base()
		{
		}
	}
}
