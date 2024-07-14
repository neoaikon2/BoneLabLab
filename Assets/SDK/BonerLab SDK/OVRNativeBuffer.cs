using System;

public class OVRNativeBuffer : IDisposable
{
	protected bool disposed;

	protected int m_numBytes;

	protected IntPtr m_ptr;

	public OVRNativeBuffer(int numBytes)
	{
	}

	~OVRNativeBuffer()
	{
	}

	public void Reset(int numBytes)
	{
	}

	public int GetCapacity()
	{
		return 0;
	}

	public IntPtr GetPointer(int byteOffset = 0)
	{
		return (IntPtr)0;
	}

	public void Dispose()
	{
	}

	protected void Dispose(bool disposing)
	{
	}

	protected void Reallocate(int numBytes)
	{
	}

	protected void Release()
	{
	}
}
