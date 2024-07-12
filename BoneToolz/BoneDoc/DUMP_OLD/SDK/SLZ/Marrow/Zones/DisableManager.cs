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

		[TupleElementNames(new string[] { "isMarked", "disableable", "type" })]
		private List<ValueTuple<bool, IDisableCallbackHandler, DisableTypes>> _eventBufferA;

		[TupleElementNames(new string[] { "isMarked", "disableable", "type" })]
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

		private void ProcessDisabled([TupleElementNames(new string[] { "isMarked", "disableable", "type" })] ValueTuple<bool, IDisableCallbackHandler, DisableTypes> info)
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
