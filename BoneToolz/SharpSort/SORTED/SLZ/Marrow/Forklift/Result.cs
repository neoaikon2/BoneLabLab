using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Forklift
{
	public readonly struct Result<TOk, TErr>
	{
		public TOk Ok { get; }

		public bool IsOk { get; }

		public TErr Err { get; }

		public bool IsErr => false;

		public Result(TOk ok)
		{
			Ok = default(TOk);
			IsOk = false;
			Err = default(TErr);
		}

		public Result(TErr err)
		{
			Ok = default(TOk);
			IsOk = false;
			Err = default(TErr);
		}
	}
}
