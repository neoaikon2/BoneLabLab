using System;

public readonly struct OVRSpace : IEquatable<OVRSpace>
{
	public enum StorageLocation
	{
		Local = 0,
		Cloud = 1
	}

	public ulong Handle { get; }

	public bool Valid => false;

	public bool TryGetUuid(out Guid uuid)
	{
		uuid = default(Guid);
		return false;
	}

	public OVRSpace(ulong handle)
	{
		Handle = 0uL;
	}

	public override string ToString()
	{
		return null;
	}

	public bool Equals(OVRSpace other)
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

	public static bool operator ==(OVRSpace lhs, OVRSpace rhs)
	{
		return false;
	}

	public static bool operator !=(OVRSpace lhs, OVRSpace rhs)
	{
		return false;
	}

	public static implicit operator OVRSpace(ulong handle)
	{
		return default(OVRSpace);
	}

	public static implicit operator ulong(OVRSpace space)
	{
		return 0uL;
	}
}
