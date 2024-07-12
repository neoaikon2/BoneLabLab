using System;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Serializable]
	public struct ClipPair
	{
		[field: SerializeField]
		public AudioClip NormalClip { get; private set; }

		[field: SerializeField]
		public AudioClip SlowClip { get; private set; }
	}
}
