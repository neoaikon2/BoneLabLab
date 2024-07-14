using System.Collections.Generic;

namespace SLZ.Marrow.Zones
{
	public class InactiveObjectManager
	{
		private const double ACTIVATE_TIME_THRESHOLD_SECONDS = 0.0005000000237487257;

		private Queue<InactiveStatus> _resolve;

		private Queue<InactiveStatus> _apply;

		private Queue<InactiveStatus> _complete;

		private bool _isAutoSimulate;

		internal int ApplyCount => 0;

		public InactiveObjectManager(bool isAutoSimulate)
		{
		}

		internal void Cleanup()
		{
		}

		public void Hide(InactiveStatus ic, bool isInactive = true)
		{
		}

		public void Cull(InactiveStatus ic, bool isInactive = true)
		{
		}

		public void Despawn(InactiveStatus ic, bool isInactive = true)
		{
		}

		public void Update()
		{
		}

		private void Resolve()
		{
		}

		private void Apply()
		{
		}

		private void Complete()
		{
		}
	}
}
