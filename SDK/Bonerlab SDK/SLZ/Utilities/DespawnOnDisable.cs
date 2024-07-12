using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Utilities
{
	[RequireComponent(typeof(Poolee))]
	public class DespawnOnDisable : MonoBehaviour
	{
		[ReadOnly(false)]
		public Poolee poolee;

		private void OnDisable()
		{
		}

		private UniTaskVoid DelayedDespawn()
		{
			return default(UniTaskVoid);
		}

		private void Reset()
		{
		}

		public DespawnOnDisable()
			: base()
		{
		}
	}
}
