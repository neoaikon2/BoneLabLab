using System.Runtime.CompilerServices;

namespace SLZ.ModIO.ApiModels
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	public interface IEventObject
	{
		long Id { get; }

		long ModId { get; }

		long UserId { get; }

		long DateAdded { get; }

		string EventType { get; }
	}
}
