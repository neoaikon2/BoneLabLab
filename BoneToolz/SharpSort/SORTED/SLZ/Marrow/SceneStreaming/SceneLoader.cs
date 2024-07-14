using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Zones;

namespace SLZ.Marrow.SceneStreaming
{
	public class SceneLoader
	{
		private bool _isLoading;

		private SceneLoadQueue _sceneQueue;

		private List<SceneChunk> _activeChunks;

		private List<SceneChunk> _chunksToLoad;

		private List<SceneChunk> _chunksToUnload;

		private HashSet<string> _wasLoadedOnce;

		private Queue<ChunkBatch> _chunkQueue;

		private ChunkBatch _nextChunkBatch;

		public void Add(SceneChunk sceneChunk)
		{
		}
		public UniTask LoadAsync()
		{
			return default(UniTask);
		}
		private UniTask LoadChunkBatch(ChunkBatch chunkBatch)
		{
			return default(UniTask);
		}

		private void Solve(ChunkBatch cb)
		{
		}
		private UniTask UnloadScenes(ChunkBatch cb)
		{
			return default(UniTask);
		}
		private UniTask LoadScenes(ChunkBatch cb)
		{
			return default(UniTask);
		}
	}
}
