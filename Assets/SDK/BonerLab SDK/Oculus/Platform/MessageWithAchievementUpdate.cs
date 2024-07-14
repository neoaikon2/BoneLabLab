using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAchievementUpdate : Message<AchievementUpdate>
	{
		public MessageWithAchievementUpdate(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override AchievementUpdate GetAchievementUpdate()
		{
			return null;
		}

		protected override AchievementUpdate GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
