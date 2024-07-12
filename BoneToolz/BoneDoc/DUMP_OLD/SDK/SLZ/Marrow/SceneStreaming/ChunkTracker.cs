using System;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Marrow.SceneStreaming
{
	[Obsolete("Chunk tracker is now obsolete use the new zone/entity system for this functionality")]
	public class ChunkTracker : SpawnEvents
	{
		private int _freezeCount;

		[SerializeField]
		private Rigidbody _rigidbody;

		[SerializeField]
		private ChunkTrackerGroup _parentGroup;

		public bool IsFrozen
		{
			get
			{
				return default(bool);
			}
		}

		protected override void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Freeze()
		{
		}

		public void Unfreeze()
		{
		}

		public ChunkTracker()
			: base()
		{
		}
	}
}
