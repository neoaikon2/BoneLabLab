using System;
using System.Runtime.CompilerServices;

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

		[MethodImpl(256)]
		internal bool IsActive()
		{
			return false;
		}

		[MethodImpl(256)]
		internal bool IsCulled()
		{
			return false;
		}

		[MethodImpl(256)]
		internal bool IsHidden()
		{
			return false;
		}

		[MethodImpl(256)]
		internal bool IsDespawned()
		{
			return false;
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
	}
}
