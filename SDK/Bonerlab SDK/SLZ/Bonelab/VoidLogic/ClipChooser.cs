using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.VoidLogic;

namespace SLZ.Bonelab.VoidLogic
{
	[Serializable]
	public class ClipChooser
	{
		private Random _random;

		public ClipSelectBehavior SelectBehavior { get; set; }

		public ClipDispatchBehavior DispatchBehavior { get; set; }

		public ClipPair[] AudioClips { get; private set; }

		public int ClipIndex { get; set; }

		public int RandomSeed { get; set; }

		public bool TryChooseClip(EdgeType edgeType, [Out] ClipPair clipPair)
		{
			return default(bool);
		}

		public virtual bool TryChooseClip(EdgeType edgeType, float selectedIndex, [Out] ClipPair clipPair)
		{
			return default(bool);
		}

		public ClipChooser()
			: base()
		{
		}
	}
}
