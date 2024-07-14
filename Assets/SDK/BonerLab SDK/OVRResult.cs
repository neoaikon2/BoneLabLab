using System;
using System.Runtime.CompilerServices;

internal static class OVRResult
{
	public static OVRResult<TStatus> From<TStatus>(TStatus status) where TStatus : struct, Enum, IConvertible
	{
		return default(OVRResult<TStatus>);
	}

	public static OVRResult<TResult, TStatus> From<TResult, TStatus>(TResult result, TStatus status) where TStatus : struct, Enum, IConvertible
	{
		return default(OVRResult<TResult, TStatus>);
	}
}
public struct OVRResult<TStatus> : IEquatable<OVRResult<TStatus>> where TStatus : struct, Enum, IConvertible
{
	private readonly bool _initialized;

	private readonly int _statusCode;

	private readonly TStatus _status;

	public bool Success => false;

	public TStatus Status => default(TStatus);

	private OVRResult(TStatus status)
	{
		_initialized = false;
		_statusCode = 0;
		_status = default(TStatus);
	}

	public static OVRResult<TStatus> From(TStatus status)
	{
		return default(OVRResult<TStatus>);
	}

	public static OVRResult<TStatus> FromSuccess(TStatus status)
	{
		return default(OVRResult<TStatus>);
	}

	public static OVRResult<TStatus> FromFailure(TStatus status)
	{
		return default(OVRResult<TStatus>);
	}

	public bool Equals(OVRResult<TStatus> other)
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
public struct OVRResult<TValue, TStatus> : IEquatable<OVRResult<TValue, TStatus>> where TStatus : struct, Enum, IConvertible
{
	private readonly bool _initialized;

	private readonly TValue _value;

	private readonly int _statusCode;

	private readonly TStatus _status;

	public bool Success => false;

	public TStatus Status => default(TStatus);

	public bool HasValue => false;

	public TValue Value => default(TValue);

	public bool TryGetValue(out TValue value)
	{
		value = default(TValue);
		return false;
	}

	private OVRResult(TValue value, TStatus status)
	{
		_initialized = false;
		_value = default(TValue);
		_statusCode = 0;
		_status = default(TStatus);
	}

	public static OVRResult<TValue, TStatus> From(TValue value, TStatus status)
	{
		return default(OVRResult<TValue, TStatus>);
	}

	public static OVRResult<TValue, TStatus> FromSuccess(TValue value, TStatus status)
	{
		return default(OVRResult<TValue, TStatus>);
	}

	public static OVRResult<TValue, TStatus> FromFailure(TStatus status)
	{
		return default(OVRResult<TValue, TStatus>);
	}

	public bool Equals(OVRResult<TValue, TStatus> other)
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
