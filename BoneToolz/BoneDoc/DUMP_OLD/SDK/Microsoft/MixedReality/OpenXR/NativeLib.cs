using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.MixedReality.OpenXR.Remoting;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	internal class NativeLib
	{
		internal const string DllName = "MicrosoftOpenXRPlugin";

		private const short UnmanagedUTF8Type = 48;

		internal static extern void InitializePlugin();

		internal static extern void SetPluginEnvironment(PluginEnvironment pluginEnvironment, string pluginInfo);

		internal static extern void OnSubsystemsStarting(NativeLibToken token);

		internal static extern void OnSubsystemsStopped(NativeLibToken token);

		internal static extern IntPtr HookGetInstanceProcAddr(NativeLibToken token, IntPtr func);

		internal static extern void OnInstanceCreated(NativeLibToken token, ulong instance, IntPtr xrGetInstanceProcAddr, string[] enabledExtensionNames, int enabledExtensionNamesCount);

		internal static extern void OnInstanceDestroyed(NativeLibToken token);

		internal static extern void SetXrSystemId(NativeLibToken token, ulong systemId);

		internal static extern void SetXrSession(NativeLibToken token, ulong session);

		internal static extern void SetXrSessionRunning(NativeLibToken token, bool running);

		internal static extern void SetSessionState(NativeLibToken token, uint sessionState);

		internal static extern NativeSpaceLocationFlags GetViewTrackingFlags(NativeLibToken token, ViewConfigurationType viewConfigurationType);

		internal static extern void SetPluginOptions(NativeLibToken token, PluginOptions pluginOptions);

		internal static extern void SetSceneOriginSpace(NativeLibToken token, ulong sceneOriginSpace);

		internal static extern bool IsSelectKeywordFiltered();

		internal static extern uint GetEnabledViewConfigurationTypesCount(NativeLibToken token);

		internal static extern void GetEnabledViewConfigurationTypes(NativeLibToken token, ViewConfigurationType[] viewConfigurationTypes, uint viewConfigurationTypesCapacity);

		internal static extern bool GetViewConfigurationIsActive(NativeLibToken token, ViewConfigurationType viewConfigurationType);

		internal static extern uint GetSupportedReprojectionModesCount(NativeLibToken token, ViewConfigurationType viewConfigurationType);

		internal static extern void GetSupportedReprojectionModes(NativeLibToken token, ViewConfigurationType viewConfigurationType, ReprojectionMode[] reprojectionModes, uint reprojectionModesCapacity);

		internal static extern void SetReprojectionSettings(NativeLibToken token, ViewConfigurationType viewConfigurationType, NativeReprojectionSettings nativeReprojectionSettings);

		internal static extern NativeSpaceLocationFlags GetFoundationTrackingStateFlags(NativeLibToken token);

		internal static extern void CreatePlaneProvider(NativeLibToken token);

		internal static extern void StartPlaneSubsystem(NativeLibToken token);

		internal static extern void StopPlaneSubsystem(NativeLibToken token);

		internal static extern void DestroyPlaneSubsystem(NativeLibToken token);

		internal static extern void SetPlaneDetectionMode(NativeLibToken token, PlaneDetectionMode planeDetectionMode);

		internal static extern void GetNumPlaneChanges(NativeLibToken token, FrameTime frameTime, uint numAddedPlanes, uint numUpdatedPlanes, uint numRemovedPlanes);

		internal unsafe static extern void GetPlaneChanges(NativeLibToken token, uint addedPlanesSize, void* addedPlanes, uint updatedPlanesSize, void* updatedPlanes, uint removedPlanesSize, void* removedPlanes);

		internal static extern bool TryCreateAnchorProvider(NativeLibToken token);

		internal static extern void StartAnchorSubsystem(NativeLibToken token);

		internal static extern void StopAnchorSubsystem(NativeLibToken token);

		internal static extern void DestroyAnchorSubsystemPending(NativeLibToken token);

		internal static extern void DestroyAnchorSubsystem(NativeLibToken token);

		internal static extern void RemoveAllAnchors(NativeLibToken token);

		internal unsafe static extern bool TryAddAnchor(NativeLibToken token, FrameTime frameTime, Quaternion rotation, Vector3 position, void* anchorPtr);

		internal static extern bool TryRemoveAnchor(NativeLibToken token, Guid anchorId);

		internal static extern void GetNumAnchorChanges(NativeLibToken token, FrameTime frameTime, uint numAddedAnchors, uint numUpdatedAnchors, uint numRemovedAnchors);

		internal unsafe static extern void GetAnchorChanges(NativeLibToken token, uint addedAnchorsSize, void* addedAnchors, uint updatedAnchorsSize, void* updatedAnchors, uint removedAnchorsSize, void* removedAnchors);

		internal static extern bool LoadAnchorStore(NativeLibToken token);

		internal static extern uint GetNumPersistedAnchorNames(NativeLibToken token);

		internal static extern void GetPersistedAnchorName(NativeLibToken token, uint idx, StringBuilder nameOut, uint capacity);

		internal static extern Guid LoadPersistedAnchor(NativeLibToken token, string name);

		internal static extern bool TryPersistAnchor(NativeLibToken token, string name, Guid anchorId);

		internal static extern void UnpersistAnchor(NativeLibToken token, string name);

		internal static extern void ClearPersistedAnchors(NativeLibToken token);

		internal static extern HandJointsMotionRange GetHandJointsMotionRange(NativeLibToken token, Handedness handedness);

		internal static extern void SetHandJointsMotionRange(NativeLibToken token, Handedness handedness, HandJointsMotionRange handTrackingOptions);

		internal static extern bool TryGetHandJointData(NativeLibToken token, Handedness handedness, FrameTime frameTime, HandJointLocation[] handJoints);

		internal static extern bool TryLocateHandMesh(NativeLibToken token, Handedness handedness, FrameTime frameTime, HandPoseType handPoseType, [Out] Pose pose);

		internal static extern bool TryGetHandMesh(NativeLibToken token, Handedness handedness, FrameTime frameTime, HandPoseType handPoseType, ulong vertexBufferKey, [Out] uint vertexCount, Vector3[] vertexPositions, Vector3[] vertexNormals, uint indexBufferKey, [Out] uint indexCount, int[] indices);

		internal static extern bool TryGetHandMeshBufferSizes(NativeLibToken token, [Out] uint maxVertexCount, [Out] uint maxIndexCount);

		internal static extern bool IsControllerModelSupported(NativeLibToken token);

		internal static extern bool TryGetControllerModelKey(NativeLibToken token, Handedness handedness, [Out] ulong modelKey);

		internal static extern bool TryGetControllerModel(NativeLibToken token, ulong modelKey, uint bufferInputCapacity, [Out] uint bufferOutputCount, byte[] modelBuffer = default(byte[]));

		internal static extern bool TryGetControllerModelProperties(NativeLibToken token, ulong key, uint nodeCapacityInput, [Out] uint nodeCountOutput, [Out] ControllerModel.ControllerModelNodeProperties[] properties = default(ControllerModel.ControllerModelNodeProperties[]));

		internal static extern bool TryGetControllerModelState(NativeLibToken token, ulong key, uint nodeCapacityInput, [Out] uint nodeCountOutput, Pose[] poses = default(Pose[]));

		internal static extern bool IsHighIntegrityLevel(NativeLibToken token);

		internal static extern bool TryEnableRemotingOverride(NativeLibToken token);

		internal static extern void ResetRemotingOverride(NativeLibToken token);

		internal static extern void ConnectRemoting(NativeLibToken token, RemotingConfiguration configuration);

		internal static extern void ListenRemoting(NativeLibToken token, RemotingListenConfiguration listenConfiguration, bool secureListen, string certificateStorePath, string subjectName, string keyPassPhrase, string authenticationRealm, string secureToken);

		internal static extern void DisconnectRemoting(NativeLibToken token);

		internal static extern bool TryGetRemotingConnectionState(NativeLibToken token, [Out] ConnectionState connectionState, [Out] DisconnectReason disconnectReason);

		internal static extern bool SetRemoteSpeechCulture(NativeLibToken token, string cultureName);

		internal static extern bool TryLocateUserReferenceSpace(NativeLibToken token, FrameTime frameTime, [Out] Pose pose);

		internal static extern bool TryCreateSpaceFromStaticNodeId(NativeLibToken token, Guid id, [Out] ulong spaceId);

		internal static extern bool TryCreateSpaceFromDynamicNodeId(NativeLibToken token, Guid id, [Out] ulong spaceId);

		internal static extern bool TryLocateSpatialGraphNodeSpace(NativeLibToken token, ulong spaceId, FrameTime frameTime, [Out] Pose pose);

		internal static extern bool TryLocateSpatialGraphNodeSpace(NativeLibToken token, ulong spaceId, long qpcTime, [Out] Pose pose);

		internal static extern bool TryLocateViewSpace(NativeLibToken nativeLibToken, FrameTime frameTime, [Out] Pose pose, [Out] long time);

		internal static extern IntPtr TryAcquireSceneCoordinateSystem(NativeLibToken token, Pose poseInScene);

		internal static extern IntPtr TryAcquirePerceptionSpatialAnchor(NativeLibToken token, ulong anchorHandle);

		internal static extern IntPtr TryAcquirePerceptionSpatialAnchor(NativeLibToken token, Guid trackableId);

		internal static extern Guid TryCreateARAnchorFromOpenXRHandle(NativeLibToken token, ulong openxrAnchor);

		internal static extern Guid TryCreateARAnchorFromPerceptionAnchor(NativeLibToken token, object perceptionAnchor);

		internal static extern Guid TryAcquireAndReplaceXrSpatialAnchor(NativeLibToken token, object perceptionAnchor, Guid id);

		internal static extern IntPtr TryGetPerceptionDeviceFactory(NativeLibToken nativeLibToken, IntPtr pfnGetInstanceProcAddr);

		internal static extern bool SetMeshComputeSettings(NativeLibToken token, MeshComputeSettings settings);

		internal static extern ulong TryCreateGestureRecognizer(NativeLibToken nativeLibToken, GestureSettings settings);

		internal static extern void DestroyGestureRecognizer(NativeLibToken nativeLibToken, ulong gestureRecognizer);

		internal static extern bool TrySetGestureSettings(NativeLibToken nativeLibToken, ulong gestureRecognizer, GestureSettings settings);

		internal static extern void CancelPendingGesture(NativeLibToken nativeLibToken, ulong gestureRecognizer);

		internal static extern bool TryGetNextEventData(NativeLibToken nativeLibToken, ulong gestureRecognizer, GestureEventData eventData);

		internal static extern void StartGestureRecognizer(NativeLibToken nativeLibToken, ulong gestureRecognizer);

		internal static extern void StopGestureRecognizer(NativeLibToken nativeLibToken, ulong gestureRecognizer);

		public NativeLib()
			: base()
		{
		}
	}
}
