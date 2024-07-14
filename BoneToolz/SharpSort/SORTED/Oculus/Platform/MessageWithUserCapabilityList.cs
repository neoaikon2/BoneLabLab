using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithUserCapabilityList : Message<UserCapabilityList>
	{
		public MessageWithUserCapabilityList(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override UserCapabilityList GetUserCapabilityList()
		{
			return null;
		}

		protected override UserCapabilityList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
