using System.Collections.Generic;

namespace Trees
{
	public class MinHeap
	{
		public class HeapNode
		{
			public uint Key { get; set; }

			public float Value { get; set; }

			public void SetNode(uint key, float value)
			{
			}

			public HeapNode(uint key, float value)
			{
			}

			public void Reset()
			{
			}
		}

		public readonly List<HeapNode> heapData;

		protected HeapNode tempNode;

		protected readonly HeapNode bestNode;

		protected int parentInd;

		public int NbEntries { get; protected set; }

		public MinHeap(int heapSize)
		{
		}

		public virtual void Add(uint key, float val)
		{
		}

		public virtual void Remove(float val)
		{
		}

		public void RemoveAtKey(uint key)
		{
		}

		public virtual bool FindKey(uint key)
		{
			return false;
		}

		public void RemoveAtIndex(int ind)
		{
		}

		public virtual uint Poll()
		{
			return 0u;
		}

		protected virtual void BubbleUp(int checkInd)
		{
		}

		protected virtual void BubbleDown(int checkInd)
		{
		}

		private void HandleBubbling(int atInd)
		{
		}

		private static int GetParentInd(int ind)
		{
			return 0;
		}

		private static int GetLeftChildInd(int parentInd)
		{
			return 0;
		}

		private static int GetRightChildInd(int parentInd)
		{
			return 0;
		}

		public virtual void Clear()
		{
		}
	}
}
