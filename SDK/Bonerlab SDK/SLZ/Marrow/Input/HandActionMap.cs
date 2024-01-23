using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	public sealed class HandActionMap : XRHand
	{
		private Dictionary<HandFinger, List<Bone>> _bones;

		private readonly bool _isLeft;

		private bool _hasFeature;

		public static Quaternion LeftAnimSpace;

		public static Quaternion RightAnimSpace;

		private readonly SimpleTransform[] _worldBuffer;

		private readonly List<Bone> _indexFinger;

		private readonly List<Bone> _middleFinger;

		private readonly List<Bone> _pinkyFinger;

		private readonly List<Bone> _ringFinger;

		private readonly List<Bone> _thumbFinger;

		private Hand _hand;

		public HandActionMap(bool left)
			: base()
		{
		}

		private bool TryPickBestHandDevice(bool left)
		{
			return default(bool);
		}

		public override void OnPostNewInputUpdate()
		{
		}

		private bool CopyPoseToBuffer(Bone bone, HandBone handBone)
		{
			return default(bool);
		}

		private void ProcessesHand()
		{
		}

		private void CalcLocalPose(HandBone parentBone, HandBone childBone)
		{
		}
	}
}
