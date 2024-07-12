using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	public struct GraphUpdate : IEquatable<GraphUpdate>
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
			this.OtherMbOrEntity = default(object);
			this.NodeMb = default(MonoBehaviour);
			this.Index = default(uint);
			this.Operation = default(OperationType);
		}

		internal GraphUpdate(OperationType operation, MonoBehaviour nodeMb, uint index, object otherMbOrEntity)
		{
			this.OtherMbOrEntity = default(object);
			this.NodeMb = default(MonoBehaviour);
			this.Index = default(uint);
			this.Operation = default(OperationType);
		}

		public bool Equals(GraphUpdate other)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
