using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu(null)]
	[Obsolete("Use Button + Toggle instead", true)]
	[Support(SupportFlags.Unsupported, null)]
	[Support(SupportFlags.Deprecated, "Use Button + Toggle instead")]
	public class ToggleButtonNode : ButtonNode
	{
		private float _multiplier;

		private static readonly PortMetadata _portMetadata;

		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		public override void Calculate(NodeState nodeState)
		{
		}

		public ToggleButtonNode()
			: base()
		{
		}
	}
}
