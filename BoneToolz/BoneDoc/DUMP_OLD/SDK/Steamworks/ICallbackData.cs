namespace Steamworks
{
	internal interface ICallbackData
	{
		CallbackType CallbackType { get; }

		int DataSize { get; }
	}
}
