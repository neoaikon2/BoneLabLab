using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TunnelTipper_Chunker : MonoBehaviour
	{
		public SceneChunk mainRoomChunk;

		public float delay;

		[ContextMenu("ForceUnloadStartChunk")]
		public void ForceUnloadStartChunk()
		{
		}

		private UniTaskVoid ForceUnloadStartChunk_async()
		{
			return default(UniTaskVoid);
		}

		private void UnloadChunk()
		{
		}

		public TunnelTipper_Chunker()
			: base()
		{
		}
	}
}
