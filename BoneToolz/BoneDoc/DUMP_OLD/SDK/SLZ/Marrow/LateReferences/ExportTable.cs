using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	public abstract class ExportTable : MonoBehaviour
	{
		[SerializeField]
		private ExportDictionary _exports;

		public IReadOnlyDictionary<string, Object> Exports
		{
			get
			{
				return null;
			}
		}

		private protected abstract void Awake();

		private protected abstract void OnDestroy();

		public ExportTable()
			: base()
		{
		}
	}
}
