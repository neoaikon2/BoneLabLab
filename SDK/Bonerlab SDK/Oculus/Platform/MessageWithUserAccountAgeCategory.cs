using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithUserAccountAgeCategory : Message<UserAccountAgeCategory>
	{
		public MessageWithUserAccountAgeCategory(IntPtr c_message)
			: base(c_message)
		{
		}

		public override UserAccountAgeCategory GetUserAccountAgeCategory()
		{
			return null;
		}

		protected override UserAccountAgeCategory GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
