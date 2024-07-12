using System.Runtime.CompilerServices;

namespace Microsoft.MixedReality.OpenXR
{
	public class HandTracker
	{
		private readonly NativeLibToken m_token;

		private readonly Handedness m_handedness;

		public const int JointCount = 26;

		public static HandTracker Left { get; }

		public static HandTracker Right { get; }

		public HandJointsMotionRange MotionRange
		{
			get
			{
				return default(HandJointsMotionRange);
			}
			set
			{
			}
		}

		internal HandTracker(Handedness trackerHandedness)
			: base()
		{
		}

		public bool TryLocateHandJoints(FrameTime frameTime, HandJointLocation[] handJointLocations)
		{
			return default(bool);
		}
	}
}
