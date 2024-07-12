using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Serializable]
	public struct ClipPair
	{
		public AudioClip NormalClip
		{
			[IsReadOnly]
			get;
			private set; }

		public AudioClip SlowClip
		{
			[IsReadOnly]
			get;
			private set; }
	}
}
