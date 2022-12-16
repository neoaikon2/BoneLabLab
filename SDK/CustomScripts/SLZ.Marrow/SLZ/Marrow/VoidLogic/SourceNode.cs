using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/SourceNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Source")]
	public class SourceNode : BaseNode
	{
		[Tooltip("Basic additive power (added to sum of previous inputs or 0)")]
		[SerializeField]
		private float _baseValue;

		[Tooltip("Whether to remap the sum of inputs according to the remap curve")]
		[SerializeField]
		private bool _enableRemap;

		[Tooltip("Output response curve (applied to the sum of previous inputs or 0)")]
		[SerializeField]
		private AnimationCurve _remapCurve;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		public float BaseValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		protected override float CalculateValue()
		{
			return default(float);
		}

		public override IReadOnlyList<InputDescription> DescribeInputs()
		{
			return null;
		}

		public SourceNode()
			: base()
		{
		}
	}
}
