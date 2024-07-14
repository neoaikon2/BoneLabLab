using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAchievementProgressList : Message<AchievementProgressList>
	{
		public MessageWithAchievementProgressList(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override AchievementProgressList GetAchievementProgressList()
		{
			return null;
		}

		protected override AchievementProgressList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
