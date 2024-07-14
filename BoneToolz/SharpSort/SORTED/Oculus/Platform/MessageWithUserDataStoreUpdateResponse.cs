using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithUserDataStoreUpdateResponse : Message<UserDataStoreUpdateResponse>
	{
		public MessageWithUserDataStoreUpdateResponse(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override UserDataStoreUpdateResponse GetUserDataStoreUpdateResponse()
		{
			return null;
		}

		protected override UserDataStoreUpdateResponse GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
