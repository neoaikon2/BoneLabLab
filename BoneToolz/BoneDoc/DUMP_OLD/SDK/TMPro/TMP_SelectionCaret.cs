using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	[RequireComponent(typeof(CanvasRenderer))]
	public class TMP_SelectionCaret : MaskableGraphic
	{
		public override void Cull(Rect clipRect, bool validRect)
		{
		}

		protected override void UpdateGeometry()
		{
		}

		public TMP_SelectionCaret()
			: base()
		{
		}
	}
}
