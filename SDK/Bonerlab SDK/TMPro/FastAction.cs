using System;
using System.Collections.Generic;

namespace TMPro
{
	public class FastAction
	{
		private LinkedList<Action> delegates;

		private Dictionary<Action, LinkedListNode<Action>> lookup;

		public void Add(Action rhs)
		{
		}

		public void Remove(Action rhs)
		{
		}

		public void Call()
		{
		}

		public FastAction()
			: base()
		{
		}
	}
	public class FastAction<A>
	{
		private LinkedList<Action<A>> delegates;

		private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup;

		public void Add(Action<A> rhs)
		{
		}

		public void Remove(Action<A> rhs)
		{
		}

		public void Call(A a)
		{
		}

		public FastAction()
			: base()
		{
		}
	}
	public class FastAction<A, B>
	{
		private LinkedList<Action<A, B>> delegates;

		private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup;

		public void Add(Action<A, B> rhs)
		{
		}

		public void Remove(Action<A, B> rhs)
		{
		}

		public void Call(A a, B b)
		{
		}

		public FastAction()
			: base()
		{
		}
	}
	public class FastAction<A, B, C>
	{
		private LinkedList<Action<A, B, C>> delegates;

		private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup;

		public void Add(Action<A, B, C> rhs)
		{
		}

		public void Remove(Action<A, B, C> rhs)
		{
		}

		public void Call(A a, B b, C c)
		{
		}

		public FastAction()
			: base()
		{
		}
	}
}
