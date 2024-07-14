namespace SLZ.ModIO.ApiModels
{
	public interface IEventObject
	{
		long Id { get; }

		long ModId { get; }

		long UserId { get; }

		long DateAdded { get; }

		string EventType { get; }
	}
}
