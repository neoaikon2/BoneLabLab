using System;

namespace SLZ.Marrow.Zones
{
	[Serializable]
	public class InactiveStatus
	{
		internal Action<InactiveStatus, bool> OnHideResolve;

		internal Action<InactiveStatus, bool> OnCullResolve;

		internal Action<InactiveStatus, bool> OnDespawnResolve;

		internal Action<InactiveStatus, bool> OnHideApply;

		internal Action<InactiveStatus, bool> OnCullApply;

		internal Action<InactiveStatus, bool> OnDespawnApply;

		internal InactiveStates request;

		internal InactiveStates resolved;

		internal InactiveStates applied;

		internal InactiveStates completed;

		internal bool IsActive()
		{
			return default(bool);
		}

		internal bool IsCulled()
		{
			return default(bool);
		}

		internal bool IsHidden()
		{
			return default(bool);
		}

		internal bool IsDespawned()
		{
			return default(bool);
		}

		internal void Hide(bool isInactive = true)
		{
		}

		internal void Cull(bool isInactive = true)
		{
		}

		internal void Despawn(bool isInactive = true)
		{
		}

		internal void Clear()
		{
		}

		public InactiveStatus()
			: base()
		{
		}
	}
}
