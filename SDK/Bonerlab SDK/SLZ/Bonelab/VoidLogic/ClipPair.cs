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
			get;
			private set; }

		public AudioClip SlowClip
		{			
			get;
			private set; }
	}
}
