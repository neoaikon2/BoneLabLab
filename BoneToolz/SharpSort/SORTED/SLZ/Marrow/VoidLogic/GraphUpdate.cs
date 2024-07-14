using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	public readonly struct GraphUpdate : IEquatable<GraphUpdate>
	{
		public enum OperationType
		{
			Add = 0,
			Remove = 1,
			UpdateInput = 2,
			Enable = 3,
			Disable = 4
		}

		public readonly OperationType Operation;

		public readonly uint Index;

		public readonly MonoBehaviour NodeMb;

		public readonly object OtherMbOrEntity;

		internal GraphUpdate(OperationType operation, MonoBehaviour nodeMb)
		{
			Operation = default(OperationType);
			Index = 0u;
			NodeMb = null;
			OtherMbOrEntity = null;
		}

		internal GraphUpdate(OperationType operation, MonoBehaviour nodeMb, uint index, object otherMbOrEntity)
		{
			Operation = default(OperationType);
			Index = 0u;
			NodeMb = null;
			OtherMbOrEntity = null;
		}

		public bool Equals(GraphUpdate other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
