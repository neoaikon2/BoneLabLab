using System;

public struct OVRSpaceUser : IDisposable
{
	internal ulong _handle;

	public bool Valid => false;

	public ulong Id => 0uL;

	public OVRSpaceUser(ulong spaceUserId)
	{
		_handle = 0uL;
	}

	public void Dispose()
	{
	}
}
