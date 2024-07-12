using System;

namespace SLZ.Marrow.VoidLogic
{
	public struct NodeState
	{
		internal unsafe fixed byte data[32];

		private byte _enabled;

		private byte _invalid;

		internal WeakReference<object> _entity;

		public bool Enabled
		{
			get
			{
				return default(bool);
			}
			internal set
			{
			}
		}

		public NodeState(bool enabled, bool invalid)
		{
			this._entity = default(WeakReference<object>);
			this._invalid = default(byte);
			this._enabled = default(byte);
		}

		public float GetAtOffsetF(int offset)
		{
			return default(float);
		}

		public void SetAtOffsetF(int offset, float newValue)
		{
		}

		public void CopyValueToPreviousValueF()
		{
		}

		public void CopyValueToPreviousValueAndSetF(float newValue)
		{
		}

		public void SetValueF(float newValue)
		{
		}

		public float GetValueF()
		{
			return default(float);
		}

		public float DistanceFromValueToPreviousValueF()
		{
			return default(float);
		}
	}
}
