using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Audio;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Obsolete("This interface is not yet considered stable. Use at your own risk!")]
	[AddComponentMenu("VoidLogic/Bonelab/Sinks/VoidLogic One-shot Sound Player")]
	[Support(SupportFlags.CowboySupported, "It's unclear how exactly we want to properly support playing sound. This component is allowed without endorsement until we have an answer for that.")]
	public class OneShotSoundPlayer : MonoBehaviour, IVoidLogicSink, IVoidLogicNode
	{
		[SerializeField]
		[Tooltip("Previous node(s) in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		protected internal MonoBehaviour[] _previous;

		private float _volumeMultiplier;

		private float _pitchMultiplier;

		private List<AudioPlayerAndClipPair> _audioPlayers;

		private Queue<ValueTuple<EdgeType, ClipPair>> _queuedPlays;

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph { get; set; }

		public ClipChooser ClipChooser { get; set; }

		public Transform AudioPlacementOverride { get; set; }

		public float SourceRadius { get; set; }

		public float Volume { get; set; }

		public float SpacialBlend { get; set; }

		public int MaximumQueueDepth { get; set; }

		private EdgeDetector StartEdgeDetector { get; set; }

		private EdgeDetector ResetEdgeDetector { get; set; }

		public int InputCount
		{
			get
			{
				return default(int);
			}
		}

		PortMetadata IVoidLogicNode.PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private UniTaskVoid DoAStart(EdgeType edgeType)
		{
			return default(UniTaskVoid);
		}

		private UniTask SpawnAndPlayAudio(EdgeType edgeType, ClipPair chosenClipPair)
		{
			return default(UniTask);
		}

		private UniTask<GameObject> SpawnAudioPlayerAsync(Vector3 position = default(Vector3))
		{
			return default(UniTask<GameObject>);
		}

		private void OnAudioSourceDespawned(GameObject go)
		{
		}

		public bool TryGetInputAtIndex(uint idx, [Out] IVoidLogicSource input)
		{
			return default(bool);
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return default(bool);
		}

		public OneShotSoundPlayer()
			: base()
		{
		}
	}
}
