using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

[DisallowMultipleComponent]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_spatial_anchor")]
public class OVRSpatialAnchor : MonoBehaviour
{
	private struct MultiAnchorDelegatePair
	{
		public List<OVRSpatialAnchor> Anchors;

		public Action<ICollection<OVRSpatialAnchor>, OperationResult> Delegate;
	}

	public struct LoadOptions
	{
		public const int MaxSupported = 1024;

		private IReadOnlyList<Guid> _uuids;

		public OVRSpace.StorageLocation StorageLocation { get; set; }

		[Obsolete("This property is no longer required. MaxAnchorCount will be automatically set to the number of uuids to load.")]
		public int MaxAnchorCount { get; set; }

		public double Timeout { get; set; }

		public IReadOnlyList<Guid> Uuids
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal OVRSpaceQuery.Options ToQueryOptions()
		{
			return default(OVRSpaceQuery.Options);
		}
	}

	public readonly struct UnboundAnchor
	{
		internal readonly OVRSpace _space;

		public Guid Uuid { get; }

		public bool Localized => false;

		public bool Localizing => false;

		public Pose Pose => default(Pose);

		public void Localize(Action<UnboundAnchor, bool> onComplete = null, double timeout = 0.0)
		{
		}

		private void ValidateLocalization()
		{
		}

		public OVRTask<bool> LocalizeAsync(double timeout = 0.0)
		{
			return default(OVRTask<bool>);
		}

		private void AddStorableAndShareableComponents()
		{
		}

		public void BindTo(OVRSpatialAnchor spatialAnchor)
		{
		}

		internal UnboundAnchor(OVRSpace space, Guid uuid)
		{
			_space = default(OVRSpace);
			Uuid = default(Guid);
		}
	}

	private enum MultiAnchorActionType
	{
		Save = 0,
		Share = 1
	}

	private static class Development
	{
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void Log(string message)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void LogWarning(string message)
		{
		}

		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogError(string message)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogRequest(ulong requestId, string message)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogRequestResult(ulong requestId, bool result, string successMessage, string failureMessage)
		{
		}
	}

	public struct SaveOptions
	{
		public OVRSpace.StorageLocation Storage;
	}

	public struct EraseOptions
	{
		public OVRSpace.StorageLocation Storage;
	}

	public enum OperationResult
	{
		Success = 0,
		Failure = -1000,
		Failure_SpaceCloudStorageDisabled = -2000,
		Failure_SpaceMappingInsufficient = -2001,
		Failure_SpaceLocalizationFailed = -2002,
		Failure_SpaceNetworkTimeout = -2003,
		Failure_SpaceNetworkRequestFailed = -2004
	}

	private readonly struct InvertedCapture<TResult, TCapture>
	{
		private static readonly Action<TResult, InvertedCapture<TResult, TCapture>> Delegate;

		private readonly TCapture _capture;

		private readonly Action<TCapture, TResult> _callback;

		private InvertedCapture(Action<TCapture, TResult> callback, TCapture capture)
		{
			_capture = default(TCapture);
			_callback = null;
		}

		private static void Invoke(TResult result, InvertedCapture<TResult, TCapture> invertedCapture)
		{
		}

		public static void ContinueTaskWith(OVRTask<TResult> task, Action<TCapture, TResult> onCompleted, TCapture state)
		{
		}
	}

	private bool _startCalled;

	private ulong _requestId;

	private readonly SaveOptions _defaultSaveOptions;

	private readonly EraseOptions _defaultEraseOptions;

	internal static readonly Dictionary<Guid, OVRSpatialAnchor> SpatialAnchors;

	private static readonly Dictionary<ulong, OVRSpatialAnchor> CreationRequests;

	private static readonly Dictionary<OVRSpace.StorageLocation, List<OVRSpatialAnchor>> SaveRequests;

	private static readonly Dictionary<OVRSpatialAnchor, Guid> AsyncRequestTaskIds;

	private static readonly List<(List<OVRSpaceUser>, List<OVRSpatialAnchor>)> ShareRequests;

	private static readonly Dictionary<ulong, MultiAnchorDelegatePair> MultiAnchorCompletionDelegates;

	private static readonly List<UnboundAnchor> UnboundAnchorBuffer;

	private static readonly OVRPlugin.SpaceComponentType[] ComponentTypeBuffer;

	public OVRSpace Space { get; private set; }

	public Guid Uuid { get; private set; }

	public bool Created => false;

	public bool PendingCreation => false;

	public bool Localized => false;

	public event Action<OperationResult> OnLocalize
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void InitializeFromExisting(OVRSpace space, Guid uuid)
	{
	}

	public void Save(Action<OVRSpatialAnchor, bool> onComplete = null)
	{
	}

	private static NativeArray<ulong> ToNativeArray(ICollection<OVRSpatialAnchor> anchors)
	{
		return default(NativeArray<ulong>);
	}

	public void Save(SaveOptions saveOptions, Action<OVRSpatialAnchor, bool> onComplete = null)
	{
	}

	public OVRTask<bool> SaveAsync()
	{
		return default(OVRTask<bool>);
	}

	public OVRTask<bool> SaveAsync(SaveOptions saveOptions)
	{
		return default(OVRTask<bool>);
	}

	public static void Save(ICollection<OVRSpatialAnchor> anchors, SaveOptions saveOptions, Action<ICollection<OVRSpatialAnchor>, OperationResult> onComplete = null)
	{
	}

	private static List<OVRSpatialAnchor> CopyAnchorListIntoListFromPool(IEnumerable<OVRSpatialAnchor> anchorList)
	{
		return null;
	}

	public void Share(OVRSpaceUser user, Action<OperationResult> onComplete = null)
	{
	}

	public OVRTask<OperationResult> ShareAsync(OVRSpaceUser user)
	{
		return default(OVRTask<OperationResult>);
	}

	public void Share(OVRSpaceUser user1, OVRSpaceUser user2, Action<OperationResult> onComplete = null)
	{
	}

	public OVRTask<OperationResult> ShareAsync(OVRSpaceUser user1, OVRSpaceUser user2)
	{
		return default(OVRTask<OperationResult>);
	}

	public void Share(OVRSpaceUser user1, OVRSpaceUser user2, OVRSpaceUser user3, Action<OperationResult> onComplete = null)
	{
	}

	public OVRTask<OperationResult> ShareAsync(OVRSpaceUser user1, OVRSpaceUser user2, OVRSpaceUser user3)
	{
		return default(OVRTask<OperationResult>);
	}

	public void Share(OVRSpaceUser user1, OVRSpaceUser user2, OVRSpaceUser user3, OVRSpaceUser user4, Action<OperationResult> onComplete = null)
	{
	}

	public OVRTask<OperationResult> ShareAsync(OVRSpaceUser user1, OVRSpaceUser user2, OVRSpaceUser user3, OVRSpaceUser user4)
	{
		return default(OVRTask<OperationResult>);
	}

	public void Share(IEnumerable<OVRSpaceUser> users, Action<OperationResult> onComplete = null)
	{
	}

	public OVRTask<OperationResult> ShareAsync(IEnumerable<OVRSpaceUser> users)
	{
		return default(OVRTask<OperationResult>);
	}

	public static void Share(ICollection<OVRSpatialAnchor> anchors, ICollection<OVRSpaceUser> users, Action<ICollection<OVRSpatialAnchor>, OperationResult> onComplete = null)
	{
	}

	private OVRTask<OperationResult> ShareAsyncInternal(List<OVRSpaceUser> users)
	{
		return default(OVRTask<OperationResult>);
	}

	private List<OVRSpatialAnchor> GetListToStoreTheShareRequest(List<OVRSpaceUser> users)
	{
		return null;
	}

	private static bool AreSortedUserListsEqual(IReadOnlyList<OVRSpaceUser> sortedList1, IReadOnlyList<OVRSpaceUser> sortedList2)
	{
		return false;
	}

	public void Erase(Action<OVRSpatialAnchor, bool> onComplete = null)
	{
	}

	public void Erase(EraseOptions eraseOptions, Action<OVRSpatialAnchor, bool> onComplete = null)
	{
	}

	public OVRTask<bool> EraseAsync()
	{
		return default(OVRTask<bool>);
	}

	public OVRTask<bool> EraseAsync(EraseOptions eraseOptions)
	{
		return default(OVRTask<bool>);
	}

	private static void ThrowIfBound(Guid uuid)
	{
	}

	private void InitializeUnchecked(OVRSpace space, Guid uuid)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private static void SaveBatchAnchors()
	{
	}

	private static void ShareBatchAnchors()
	{
	}

	private void OnDestroy()
	{
	}

	private OVRPose GetTrackingSpacePose()
	{
		return default(OVRPose);
	}

	private void CreateSpatialAnchor()
	{
	}

	internal static bool TryGetPose(OVRSpace space, out OVRPose pose)
	{
		pose = default(OVRPose);
		return false;
	}

	private void UpdateTransform()
	{
	}

	private static bool TryExtractValue<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key, out TValue value)
	{
		value = default(TValue);
		return false;
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void InitializeOnLoad()
	{
	}

	static OVRSpatialAnchor()
	{
	}

	private static void InvokeMultiAnchorDelegate(ulong requestId, OperationResult result, MultiAnchorActionType actionType)
	{
	}

	private static void OnSpatialAnchorCreateComplete(ulong requestId, bool success, OVRSpace space, Guid uuid)
	{
	}

	private static void OnSpaceSaveComplete(ulong requestId, OVRSpace space, bool result, Guid uuid)
	{
	}

	private static void OnSpaceEraseComplete(ulong requestId, bool result, Guid uuid, OVRPlugin.SpaceStorageLocation location)
	{
	}

	public static bool LoadUnboundAnchors(LoadOptions options, Action<UnboundAnchor[]> onComplete)
	{
		return false;
	}

	public static OVRTask<UnboundAnchor[]> LoadUnboundAnchorsAsync(LoadOptions options)
	{
		return default(OVRTask<UnboundAnchor[]>);
	}

	public static bool FromOVRAnchor(OVRAnchor anchor, out UnboundAnchor unboundAnchor)
	{
		unboundAnchor = default(UnboundAnchor);
		return false;
	}

	private static void OnSpaceQueryComplete(ulong requestId, bool queryResult)
	{
	}

	private static void PopulateUnbound(Guid uuid, ulong space)
	{
	}

	private static void OnSpaceSetComponentStatusComplete(ulong requestId, bool result, OVRSpace space, Guid uuid, OVRPlugin.SpaceComponentType componentType, bool enabled)
	{
	}

	private static void OnSpaceListSaveComplete(ulong requestId, OperationResult result)
	{
	}

	private static void OnShareSpacesComplete(ulong requestId, OperationResult result)
	{
	}
}
