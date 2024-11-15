using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab/Sinks/VoidLogic Continuous Sound Player")]
	[Obsolete("This interface is not yet considered stable. Use at your own risk!")]
	[Support(SupportFlags.CowboySupported, "It's unclear how exactly we want to properly support playing sound. This component is allowed without endorsement until we have an answer for that.")]
	public class ContinuousSoundPlayer : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, ISerializationCallbackReceiver
	{
		[SerializeField]
		[Obsolete("Replace with `_previousConnections`")]
		[Tooltip("Previous node(s) in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		private MonoBehaviour[] _previous;

		[SerializeField]
		[Tooltip("Previous node(s) in the chain")]
		[NonReorderable]
		private OutputPortReference[] _previousConnections;

		private float _volumeMultiplier;

		private float _pitchMultiplier;

		private float _volumeFaderMultiplier;

		private AudioPlayerAndClipPair _audioPlayer;

		private bool shouldBeAwake;

		private bool cueFadeIn;

		private EdgeType lastStartEdgeType;

		private CancellationTokenSource managedUpdateCancelToken;

		private CancellationTokenSource fadeCancelToken;

		private static readonly PortMetadata _portMetadata;

		[field: ReadOnly(false)]
		[field: SerializeField]
		public VoidLogicSubgraph Subgraph { get; set; }

		[field: SerializeField]
		public ClipChooser ClipChooser { get; set; }

		[field: SerializeField]
		public Transform AudioPlacementOverride { get; set; }

		[field: Range(0.1f, 10f)]
		[field: SerializeField]
		public float SourceRadius { get; set; }

		[field: SerializeField]
		[field: Range(0f, 1f)]
		public float Volume { get; set; }

		[field: Tooltip("Fade time in seconds.")]
		[field: Range(0.1f, 8f)]
		[field: SerializeField]
		public float FadeTime { get; set; }

		[field: SerializeField]
		[field: Range(0f, 1f)]
		public float SpacialBlend { get; set; }

		[field: Range(1f, 5f)]
		[field: SerializeField]
		public int MaximumQueueDepth { get; set; }

		[field: Tooltip("Edge detection configuration for start input")]
		[field: SerializeField]
		private EdgeDetector StartEdgeDetector { get; set; }

		[field: SerializeField]
		[field: Tooltip("Edge detection configuration for reset input")]
		private EdgeDetector ResetEdgeDetector { get; set; }

		public int InputCount => 0;

		private PortMetadata SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicNode_002EPortMetadata => default(PortMetadata);

		public PortMetadata PortMetadata => throw new NotImplementedException();

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
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
		private UniTaskVoid ManagedUpdate(CancellationToken cancellationSource)
		{
			return default(UniTaskVoid);
		}
		private UniTask DoAStart(EdgeType edgeType)
		{
			return default(UniTask);
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
		private UniTaskVoid FadeVolume(float fadeTarget, float fadeTime, CancellationTokenSource cancellationSource)
		{
			return default(UniTaskVoid);
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		private void OnTriggerExit(Collider c)
		{
		}

		public bool TryGetInputConnection(uint inputIndex, out OutputPortReference connectedPort)
		{
			connectedPort = default(OutputPortReference);
			return false;
		}

		public bool TryConnectPortToInput(OutputPortReference output, uint inputIndex)
		{
			return false;
		}

		public void OnBeforeSerialize()
		{
			throw new NotImplementedException();
		}

		public void OnAfterDeserialize()
		{
			throw new NotImplementedException();
		}
	}
}
