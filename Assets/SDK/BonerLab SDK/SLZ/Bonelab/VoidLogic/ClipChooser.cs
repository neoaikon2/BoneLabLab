using System;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Serializable]
	public class ClipChooser
	{
		private System.Random _random;

		[field: SerializeField]
		public ClipSelectBehavior SelectBehavior { get; set; }

		[field: SerializeField]
		public ClipDispatchBehavior DispatchBehavior { get; set; }

		[field: SerializeField]
		public ClipPair[] AudioClips { get; private set; }

		[field: SerializeField]
		public int ClipIndex { get; set; }

		[field: SerializeField]
		[field: HideInInspector]
		public int RandomSeed { get; set; }

		public bool TryChooseClip(EdgeType edgeType, out ClipPair clipPair)
		{
			clipPair = default(ClipPair);
			return false;
		}

		public virtual bool TryChooseClip(EdgeType edgeType, float selectedIndex, out ClipPair clipPair)
		{
			clipPair = default(ClipPair);
			return false;
		}
	}
}
