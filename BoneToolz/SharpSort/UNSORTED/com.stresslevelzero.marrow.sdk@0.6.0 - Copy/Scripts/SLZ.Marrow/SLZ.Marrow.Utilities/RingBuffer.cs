namespace SLZ.Marrow.Utilities
{
	public class RingBuffer<TStruct> where TStruct : struct
	{
		private TStruct[] _buffer;

		private int _size;

		private int _cursor;

		public int Length { get; private set; }

		public RingBuffer(int size)
		{
		}

		public void Add(in TStruct tStruct)
		{
		}

		/*
		public unsafe ref TStruct GetReadOnly(int index)
		{
			return ref *(TStruct*)null;
		}

		public unsafe ref TStruct Get(int index)
		{
			return ref *(TStruct*)null;
		}
		*/

		public void Clear()
		{
		}

		private int Mod(int x, int m)
		{
			return 0;
		}
	}
}
