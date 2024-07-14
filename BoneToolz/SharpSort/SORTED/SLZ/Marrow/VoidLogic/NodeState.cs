using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.VoidLogic
{
	public struct NodeState
	{
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _003Cdata_003Ee__FixedBuffer
		{
			public byte FixedElementField;
		}

		internal unsafe fixed byte data[32];

		private byte _enabled;

		private byte _invalid;

		internal WeakReference<object> _entity;

		public bool Enabled
		{
			[MethodImpl(256)]
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public NodeState(bool enabled, bool invalid)
		{			
			_enabled = 0;
			_invalid = 0;
			_entity = null;
		}

		[MethodImpl(256)]
		public float GetAtOffsetF(int offset)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public void SetAtOffsetF(int offset, float newValue)
		{
		}

		[MethodImpl(256)]
		public void CopyValueToPreviousValueF()
		{
		}

		[MethodImpl(256)]
		public void CopyValueToPreviousValueAndSetF(float newValue)
		{
		}

		[MethodImpl(256)]
		public void SetValueF(float newValue)
		{
		}

		[MethodImpl(256)]
		public float GetValueF()
		{
			return 0f;
		}

		[MethodImpl(256)]
		public float DistanceFromValueToPreviousValueF()
		{
			return 0f;
		}
	}
}
