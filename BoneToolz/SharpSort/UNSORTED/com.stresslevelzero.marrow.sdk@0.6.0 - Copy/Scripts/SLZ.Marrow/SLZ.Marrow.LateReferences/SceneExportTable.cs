using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	[ExecuteAlways]
	[RequireComponent(typeof(LinkLateReferenceSubscriptions))]
	public class SceneExportTable : ExportTable
	{
		private protected override void Awake()
		{
		}

		private void Reset()
		{
		}

		private protected override void OnDestroy()
		{
		}
	}
}
