using System.Collections.Generic;

namespace SLZ.ModIO.ApiModels
{
	public interface IPaginationObject<out T>
	{
		IReadOnlyList<T> Data { get; }

		long ResultCount { get; }

		long ResultOffset { get; }

		long ResultLimit { get; }

		long ResultTotal { get; }
	}
}
