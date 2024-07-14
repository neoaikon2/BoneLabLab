using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Oculus.Platform
{
	public class CAPI
	{
		public struct ovrKeyValuePair
		{
			public string key_;

			private KeyValuePairType valueType_;

			public string stringValue_;

			public int intValue_;

			public double doubleValue_;

			public ovrKeyValuePair(string key, string value)
			{
				key_ = null;
				valueType_ = default(KeyValuePairType);
				stringValue_ = null;
				intValue_ = 0;
				doubleValue_ = 0.0;
			}

			public ovrKeyValuePair(string key, int value)
			{
				key_ = null;
				valueType_ = default(KeyValuePairType);
				stringValue_ = null;
				intValue_ = 0;
				doubleValue_ = 0.0;
			}

			public ovrKeyValuePair(string key, double value)
			{
				key_ = null;
				valueType_ = default(KeyValuePairType);
				stringValue_ = null;
				intValue_ = 0;
				doubleValue_ = 0.0;
			}
		}

		public struct ovrNetSyncVec3
		{
			public float x;

			public float y;

			public float z;
		}

		public struct OculusInitParams
		{
			public int sType;

			public string email;

			public string password;

			public ulong appId;

			public string uriPrefixOverride;
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void FilterCallback([In][Out] short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels);

		public const string DLL_NAME = "LibOVRPlatform64_1";

		private static UTF8Encoding nativeStringEncoding;

		public const int VoipFilterBufferSize = 480;

		public static IntPtr ArrayOfStructsToIntPtr(Array ar)
		{
			return (IntPtr)0;
		}

		public static ovrKeyValuePair[] DictionaryToOVRKeyValuePairs(Dictionary<InitConfigOptions, bool> dict)
		{
			return null;
		}

		public static ovrKeyValuePair[] DictionaryToOVRKeyValuePairs(Dictionary<string, object> dict)
		{
			return null;
		}

		public static byte[] IntPtrToByteArray(IntPtr data, ulong size)
		{
			return null;
		}

		public static Dictionary<string, string> DataStoreFromNative(IntPtr pointer)
		{
			return null;
		}

		public static string StringFromNative(IntPtr pointer)
		{
			return null;
		}

		public static int GetNativeStringLengthNotIncludingNullTerminator(IntPtr pointer)
		{
			return 0;
		}

		public static DateTime DateTimeFromNative(ulong seconds_since_the_one_true_epoch)
		{
			return default(DateTime);
		}

		public static ulong DateTimeToNative(DateTime dt)
		{
			return 0uL;
		}

		public static byte[] BlobFromNative(uint size, IntPtr pointer)
		{
			return null;
		}

		public static byte[] FiledataFromNative(uint size, IntPtr pointer)
		{
			return null;
		}

		public static IntPtr StringToNative(string s)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		public static extern bool ovr_UnityInitWrapper(string appId);

		[PreserveSig]
		public static extern void ovr_UnityInitGlobals(IntPtr loggingCB);

		[PreserveSig]
		public static extern ulong ovr_UnityInitWrapperAsynchronous(string appId);

		[PreserveSig]
		public static extern bool ovr_UnityInitWrapperStandalone(string accessToken, IntPtr loggingCB);

		[PreserveSig]
		public static extern ulong ovr_Platform_InitializeStandaloneOculus(ref OculusInitParams init);

		[PreserveSig]
		public static extern ulong ovr_PlatformInitializeWithAccessToken(ulong appId, string accessToken);

		[PreserveSig]
		public static extern ulong ovr_PlatformInitializeWithAccessTokenAndOptions(ulong appId, string accessToken, ovrKeyValuePair[] configOptions, UIntPtr numOptions);

		[PreserveSig]
		public static extern bool ovr_UnityInitWrapperWindows(string appId, IntPtr loggingCB);

		[PreserveSig]
		public static extern ulong ovr_UnityInitWrapperWindowsAsynchronous(string appId, IntPtr loggingCB);

		[PreserveSig]
		public static extern bool ovr_SetDeveloperAccessToken(string accessToken);

		public static string ovr_GetLoggedInUserLocale()
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_GetLoggedInUserLocale_Native();

		[PreserveSig]
		public static extern IntPtr ovr_PopMessage();

		[PreserveSig]
		public static extern void ovr_FreeMessage(IntPtr message);

		[PreserveSig]
		public static extern IntPtr ovr_Voip_CreateEncoder();

		[PreserveSig]
		public static extern void ovr_Voip_DestroyEncoder(IntPtr encoder);

		[PreserveSig]
		public static extern IntPtr ovr_Voip_CreateDecoder();

		[PreserveSig]
		public static extern void ovr_Voip_DestroyDecoder(IntPtr decoder);

		[PreserveSig]
		public static extern void ovr_VoipDecoder_Decode(IntPtr obj, byte[] compressedData, ulong compressedSize);

		[PreserveSig]
		public static extern IntPtr ovr_Microphone_Create();

		[PreserveSig]
		public static extern void ovr_Microphone_Destroy(IntPtr obj);

		[PreserveSig]
		public static extern void ovr_Voip_SetSystemVoipPassthrough(bool passthrough);

		[PreserveSig]
		public static extern void ovr_Voip_SetSystemVoipMicrophoneMuted(VoipMuteState muted);

		[PreserveSig]
		public static extern void ovr_UnityResetTestPlatform();

		[PreserveSig]
		public static extern ulong ovr_HTTP_GetWithMessageType(string url, int messageType);

		[PreserveSig]
		public static extern void ovr_CrashApplication();

		[PreserveSig]
		public static extern void ovr_Voip_SetMicrophoneFilterCallback(FilterCallback cb);

		[PreserveSig]
		public static extern void ovr_Voip_SetMicrophoneFilterCallbackWithFixedSizeBuffer(FilterCallback cb, UIntPtr bufferSizeElements);

		public static void LogNewUnifiedEvent(LogEventName eventName, Dictionary<string, string> values)
		{
		}

		public static void LogNewEvent(string eventName, Dictionary<string, string> values)
		{
		}

		[PreserveSig]
		public static extern void ovr_Log_NewEvent(IntPtr eventName, IntPtr[] values, UIntPtr length);

		[PreserveSig]
		public static extern IntPtr ovr_ApplicationLifecycle_GetLaunchDetails();

		public static void ovr_ApplicationLifecycle_LogDeeplinkResult(string trackingID, LaunchResult result)
		{
		}

		[PreserveSig]
		private static extern void ovr_ApplicationLifecycle_LogDeeplinkResult_Native(IntPtr trackingID, LaunchResult result);

		public static ulong ovr_HTTP_StartTransfer(string url, ovrKeyValuePair[] headers)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_HTTP_StartTransfer_Native(IntPtr url, ovrKeyValuePair[] headers, UIntPtr numItems);

		[PreserveSig]
		public static extern bool ovr_HTTP_Write(ulong transferId, byte[] bytes, UIntPtr length);

		[PreserveSig]
		public static extern void ovr_HTTP_WriteEOM(ulong transferId);

		public static string ovr_Message_GetStringForJavascript(IntPtr message)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Message_GetStringForJavascript_Native(IntPtr message);

		[PreserveSig]
		public static extern UIntPtr ovr_NetSync_GetAmbisonicFloatPCM(long connection_id, float[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		public static extern UIntPtr ovr_NetSync_GetAmbisonicInt16PCM(long connection_id, short[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		public static extern UIntPtr ovr_NetSync_GetAmbisonicInterleavedFloatPCM(long connection_id, float[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		public static extern UIntPtr ovr_NetSync_GetAmbisonicInterleavedInt16PCM(long connection_id, short[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		public static extern bool ovr_NetSync_GetListenerPosition(long connection_id, ulong sessionId, ref ovrNetSyncVec3 position);

		[PreserveSig]
		public static extern UIntPtr ovr_NetSync_GetMonostreamFloatPCM(long connection_id, ulong sessionId, float[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		public static extern UIntPtr ovr_NetSync_GetMonostreamInt16PCM(long connection_id, ulong session_id, short[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		public static extern UIntPtr ovr_NetSync_GetPcmBufferMaxSamples();

		[PreserveSig]
		public static extern bool ovr_NetSync_GetVoipAmplitude(long connection_id, ulong sessionId, ref float amplitude);

		[PreserveSig]
		public static extern void ovr_NetSync_SetListenerPosition(long connection_id, ref ovrNetSyncVec3 position);

		[PreserveSig]
		public static extern int ovr_Party_PluginGetSharedMemHandle();

		[PreserveSig]
		public static extern VoipMuteState ovr_Party_PluginGetVoipMicrophoneMuted();

		[PreserveSig]
		public static extern bool ovr_Party_PluginGetVoipPassthrough();

		[PreserveSig]
		public static extern SystemVoipStatus ovr_Party_PluginGetVoipStatus();

		[PreserveSig]
		public static extern void ovr_Voip_Accept(ulong userID);

		[PreserveSig]
		public static extern VoipDtxState ovr_Voip_GetIsConnectionUsingDtx(ulong peerID);

		[PreserveSig]
		public static extern VoipBitrate ovr_Voip_GetLocalBitrate(ulong peerID);

		[PreserveSig]
		public static extern UIntPtr ovr_Voip_GetOutputBufferMaxSize();

		[PreserveSig]
		public static extern UIntPtr ovr_Voip_GetPCM(ulong senderID, short[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		public static extern UIntPtr ovr_Voip_GetPCMFloat(ulong senderID, float[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		public static extern UIntPtr ovr_Voip_GetPCMSize(ulong senderID);

		[PreserveSig]
		public static extern UIntPtr ovr_Voip_GetPCMWithTimestamp(ulong senderID, short[] outputBuffer, UIntPtr outputBufferNumElements, uint[] timestamp);

		[PreserveSig]
		public static extern UIntPtr ovr_Voip_GetPCMWithTimestampFloat(ulong senderID, float[] outputBuffer, UIntPtr outputBufferNumElements, uint[] timestamp);

		[PreserveSig]
		public static extern VoipBitrate ovr_Voip_GetRemoteBitrate(ulong peerID);

		[PreserveSig]
		public static extern uint ovr_Voip_GetSyncTimestamp(ulong userID);

		[PreserveSig]
		public static extern long ovr_Voip_GetSyncTimestampDifference(uint lhs, uint rhs);

		[PreserveSig]
		public static extern VoipMuteState ovr_Voip_GetSystemVoipMicrophoneMuted();

		[PreserveSig]
		public static extern SystemVoipStatus ovr_Voip_GetSystemVoipStatus();

		[PreserveSig]
		public static extern void ovr_Voip_SetMicrophoneMuted(VoipMuteState state);

		[PreserveSig]
		public static extern void ovr_Voip_SetNewConnectionOptions(IntPtr voipOptions);

		[PreserveSig]
		public static extern void ovr_Voip_SetOutputSampleRate(VoipSampleRate rate);

		[PreserveSig]
		public static extern void ovr_Voip_Start(ulong userID);

		[PreserveSig]
		public static extern void ovr_Voip_Stop(ulong userID);

		[PreserveSig]
		public static extern ulong ovr_AbuseReport_LaunchAdvancedReportFlow(ulong content_id, IntPtr abuse_report_options);

		[PreserveSig]
		public static extern ulong ovr_AbuseReport_ReportRequestHandled(ReportRequestResponse response);

		public static ulong ovr_Achievements_AddCount(string name, ulong count)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Achievements_AddCount_Native(IntPtr name, ulong count);

		public static ulong ovr_Achievements_AddFields(string name, string fields)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Achievements_AddFields_Native(IntPtr name, IntPtr fields);

		[PreserveSig]
		public static extern ulong ovr_Achievements_GetAllDefinitions();

		[PreserveSig]
		public static extern ulong ovr_Achievements_GetAllProgress();

		[PreserveSig]
		public static extern ulong ovr_Achievements_GetDefinitionsByName(string[] names, int count);

		[PreserveSig]
		public static extern ulong ovr_Achievements_GetProgressByName(string[] names, int count);

		public static ulong ovr_Achievements_Unlock(string name)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Achievements_Unlock_Native(IntPtr name);

		[PreserveSig]
		public static extern ulong ovr_Application_CancelAppDownload();

		[PreserveSig]
		public static extern ulong ovr_Application_CheckAppDownloadProgress();

		[PreserveSig]
		public static extern ulong ovr_Application_GetInstalledApplications();

		[PreserveSig]
		public static extern ulong ovr_Application_GetVersion();

		[PreserveSig]
		public static extern ulong ovr_Application_InstallAppUpdateAndRelaunch(IntPtr deeplink_options);

		[PreserveSig]
		public static extern ulong ovr_Application_LaunchOtherApp(ulong appID, IntPtr deeplink_options);

		[PreserveSig]
		public static extern ulong ovr_Application_StartAppDownload();

		[PreserveSig]
		public static extern ulong ovr_ApplicationLifecycle_GetRegisteredPIDs();

		[PreserveSig]
		public static extern ulong ovr_ApplicationLifecycle_GetSessionKey();

		public static ulong ovr_ApplicationLifecycle_RegisterSessionKey(string sessionKey)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_ApplicationLifecycle_RegisterSessionKey_Native(IntPtr sessionKey);

		[PreserveSig]
		public static extern ulong ovr_AssetFile_Delete(ulong assetFileID);

		[PreserveSig]
		public static extern ulong ovr_AssetFile_DeleteById(ulong assetFileID);

		public static ulong ovr_AssetFile_DeleteByName(string assetFileName)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_AssetFile_DeleteByName_Native(IntPtr assetFileName);

		[PreserveSig]
		public static extern ulong ovr_AssetFile_Download(ulong assetFileID);

		[PreserveSig]
		public static extern ulong ovr_AssetFile_DownloadById(ulong assetFileID);

		public static ulong ovr_AssetFile_DownloadByName(string assetFileName)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_AssetFile_DownloadByName_Native(IntPtr assetFileName);

		[PreserveSig]
		public static extern ulong ovr_AssetFile_DownloadCancel(ulong assetFileID);

		[PreserveSig]
		public static extern ulong ovr_AssetFile_DownloadCancelById(ulong assetFileID);

		public static ulong ovr_AssetFile_DownloadCancelByName(string assetFileName)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_AssetFile_DownloadCancelByName_Native(IntPtr assetFileName);

		[PreserveSig]
		public static extern ulong ovr_AssetFile_GetList();

		[PreserveSig]
		public static extern ulong ovr_AssetFile_Status(ulong assetFileID);

		[PreserveSig]
		public static extern ulong ovr_AssetFile_StatusById(ulong assetFileID);

		public static ulong ovr_AssetFile_StatusByName(string assetFileName)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_AssetFile_StatusByName_Native(IntPtr assetFileName);

		[PreserveSig]
		public static extern ulong ovr_Avatar_LaunchAvatarEditor(IntPtr options);

		public static ulong ovr_Avatar_UpdateMetaData(string avatarMetaData, string imageFilePath)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Avatar_UpdateMetaData_Native(IntPtr avatarMetaData, IntPtr imageFilePath);

		public static ulong ovr_Challenges_Create(string leaderboardName, IntPtr challengeOptions)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Challenges_Create_Native(IntPtr leaderboardName, IntPtr challengeOptions);

		[PreserveSig]
		public static extern ulong ovr_Challenges_DeclineInvite(ulong challengeID);

		[PreserveSig]
		public static extern ulong ovr_Challenges_Delete(ulong challengeID);

		[PreserveSig]
		public static extern ulong ovr_Challenges_Get(ulong challengeID);

		[PreserveSig]
		public static extern ulong ovr_Challenges_GetEntries(ulong challengeID, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt);

		[PreserveSig]
		public static extern ulong ovr_Challenges_GetEntriesAfterRank(ulong challengeID, int limit, ulong afterRank);

		[PreserveSig]
		public static extern ulong ovr_Challenges_GetEntriesByIds(ulong challengeID, int limit, LeaderboardStartAt startAt, ulong[] userIDs, uint userIDLength);

		[PreserveSig]
		public static extern ulong ovr_Challenges_GetList(IntPtr challengeOptions, int limit);

		[PreserveSig]
		public static extern ulong ovr_Challenges_GetNextChallenges(IntPtr handle);

		[PreserveSig]
		public static extern ulong ovr_Challenges_GetNextEntries(IntPtr handle);

		[PreserveSig]
		public static extern ulong ovr_Challenges_GetPreviousChallenges(IntPtr handle);

		[PreserveSig]
		public static extern ulong ovr_Challenges_GetPreviousEntries(IntPtr handle);

		[PreserveSig]
		public static extern ulong ovr_Challenges_Join(ulong challengeID);

		[PreserveSig]
		public static extern ulong ovr_Challenges_Leave(ulong challengeID);

		[PreserveSig]
		public static extern ulong ovr_Challenges_UpdateInfo(ulong challengeID, IntPtr challengeOptions);

		[PreserveSig]
		public static extern ulong ovr_Colocation_GetCurrentMapUuid();

		public static ulong ovr_Colocation_RequestMap(string uuid)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Colocation_RequestMap_Native(IntPtr uuid);

		public static ulong ovr_Colocation_ShareMap(string uuid)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Colocation_ShareMap_Native(IntPtr uuid);

		[PreserveSig]
		public static extern ulong ovr_Cowatching_GetPresenterData();

		[PreserveSig]
		public static extern ulong ovr_Cowatching_GetViewersData();

		[PreserveSig]
		public static extern ulong ovr_Cowatching_IsInSession();

		[PreserveSig]
		public static extern ulong ovr_Cowatching_JoinSession();

		[PreserveSig]
		public static extern ulong ovr_Cowatching_LaunchInviteDialog();

		[PreserveSig]
		public static extern ulong ovr_Cowatching_LeaveSession();

		[PreserveSig]
		public static extern ulong ovr_Cowatching_RequestToPresent();

		[PreserveSig]
		public static extern ulong ovr_Cowatching_ResignFromPresenting();

		public static ulong ovr_Cowatching_SetPresenterData(string video_title, string presenter_data)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Cowatching_SetPresenterData_Native(IntPtr video_title, IntPtr presenter_data);

		public static ulong ovr_Cowatching_SetViewerData(string viewer_data)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Cowatching_SetViewerData_Native(IntPtr viewer_data);

		public static ulong ovr_DeviceApplicationIntegrity_GetAttestationToken(string challenge_nonce)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_DeviceApplicationIntegrity_GetAttestationToken_Native(IntPtr challenge_nonce);

		public static ulong ovr_DeviceApplicationIntegrity_GetIntegrityToken(string challenge_nonce)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_DeviceApplicationIntegrity_GetIntegrityToken_Native(IntPtr challenge_nonce);

		[PreserveSig]
		public static extern ulong ovr_Entitlement_GetIsViewerEntitled();

		public static ulong ovr_GraphAPI_Get(string url)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_GraphAPI_Get_Native(IntPtr url);

		public static ulong ovr_GraphAPI_Post(string url)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_GraphAPI_Post_Native(IntPtr url);

		[PreserveSig]
		public static extern ulong ovr_GroupPresence_Clear();

		[PreserveSig]
		public static extern ulong ovr_GroupPresence_GetInvitableUsers(IntPtr options);

		[PreserveSig]
		public static extern ulong ovr_GroupPresence_GetSentInvites();

		[PreserveSig]
		public static extern ulong ovr_GroupPresence_LaunchInvitePanel(IntPtr options);

		[PreserveSig]
		public static extern ulong ovr_GroupPresence_LaunchMultiplayerErrorDialog(IntPtr options);

		public static ulong ovr_GroupPresence_LaunchRejoinDialog(string lobby_session_id, string match_session_id, string destination_api_name)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_GroupPresence_LaunchRejoinDialog_Native(IntPtr lobby_session_id, IntPtr match_session_id, IntPtr destination_api_name);

		[PreserveSig]
		public static extern ulong ovr_GroupPresence_LaunchRosterPanel(IntPtr options);

		[PreserveSig]
		public static extern ulong ovr_GroupPresence_SendInvites(ulong[] userIDs, uint userIDLength);

		[PreserveSig]
		public static extern ulong ovr_GroupPresence_Set(IntPtr groupPresenceOptions);

		public static ulong ovr_GroupPresence_SetDeeplinkMessageOverride(string deeplink_message)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_GroupPresence_SetDeeplinkMessageOverride_Native(IntPtr deeplink_message);

		public static ulong ovr_GroupPresence_SetDestination(string api_name)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_GroupPresence_SetDestination_Native(IntPtr api_name);

		[PreserveSig]
		public static extern ulong ovr_GroupPresence_SetIsJoinable(bool is_joinable);

		public static ulong ovr_GroupPresence_SetLobbySession(string id)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_GroupPresence_SetLobbySession_Native(IntPtr id);

		public static ulong ovr_GroupPresence_SetMatchSession(string id)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_GroupPresence_SetMatchSession_Native(IntPtr id);

		public static ulong ovr_HTTP_Get(string url)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_HTTP_Get_Native(IntPtr url);

		public static ulong ovr_HTTP_GetToFile(string url, string diskFile)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_HTTP_GetToFile_Native(IntPtr url, IntPtr diskFile);

		public static ulong ovr_HTTP_MultiPartPost(string url, string filepath_param_name, string filepath, string access_token, ovrKeyValuePair[] post_params)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_HTTP_MultiPartPost_Native(IntPtr url, IntPtr filepath_param_name, IntPtr filepath, IntPtr access_token, ovrKeyValuePair[] post_params, UIntPtr numItems);

		public static ulong ovr_HTTP_Post(string url)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_HTTP_Post_Native(IntPtr url);

		public static ulong ovr_IAP_ConsumePurchase(string sku)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_IAP_ConsumePurchase_Native(IntPtr sku);

		[PreserveSig]
		public static extern ulong ovr_IAP_GetProductsBySKU(string[] skus, int count);

		[PreserveSig]
		public static extern ulong ovr_IAP_GetViewerPurchases();

		[PreserveSig]
		public static extern ulong ovr_IAP_GetViewerPurchasesDurableCache();

		public static ulong ovr_IAP_LaunchCheckoutFlow(string sku)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_IAP_LaunchCheckoutFlow_Native(IntPtr sku);

		[PreserveSig]
		public static extern ulong ovr_LanguagePack_GetCurrent();

		public static ulong ovr_LanguagePack_SetCurrent(string tag)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_LanguagePack_SetCurrent_Native(IntPtr tag);

		public static ulong ovr_Leaderboard_Get(string leaderboardName)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Leaderboard_Get_Native(IntPtr leaderboardName);

		public static ulong ovr_Leaderboard_GetEntries(string leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Leaderboard_GetEntries_Native(IntPtr leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt);

		public static ulong ovr_Leaderboard_GetEntriesAfterRank(string leaderboardName, int limit, ulong afterRank)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Leaderboard_GetEntriesAfterRank_Native(IntPtr leaderboardName, int limit, ulong afterRank);

		public static ulong ovr_Leaderboard_GetEntriesByIds(string leaderboardName, int limit, LeaderboardStartAt startAt, ulong[] userIDs, uint userIDLength)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Leaderboard_GetEntriesByIds_Native(IntPtr leaderboardName, int limit, LeaderboardStartAt startAt, ulong[] userIDs, uint userIDLength);

		[PreserveSig]
		public static extern ulong ovr_Leaderboard_GetNextEntries(IntPtr handle);

		[PreserveSig]
		public static extern ulong ovr_Leaderboard_GetPreviousEntries(IntPtr handle);

		public static ulong ovr_Leaderboard_WriteEntry(string leaderboardName, long score, byte[] extraData, uint extraDataLength, bool forceUpdate)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Leaderboard_WriteEntry_Native(IntPtr leaderboardName, long score, byte[] extraData, uint extraDataLength, bool forceUpdate);

		public static ulong ovr_Leaderboard_WriteEntryWithSupplementaryMetric(string leaderboardName, long score, long supplementaryMetric, byte[] extraData, uint extraDataLength, bool forceUpdate)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Leaderboard_WriteEntryWithSupplementaryMetric_Native(IntPtr leaderboardName, long score, long supplementaryMetric, byte[] extraData, uint extraDataLength, bool forceUpdate);

		public static ulong ovr_Livestreaming_IsAllowedForApplication(string packageName)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Livestreaming_IsAllowedForApplication_Native(IntPtr packageName);

		[PreserveSig]
		public static extern ulong ovr_Livestreaming_StartPartyStream();

		[PreserveSig]
		public static extern ulong ovr_Livestreaming_StartStream(LivestreamingAudience audience, LivestreamingMicrophoneStatus micStatus);

		[PreserveSig]
		public static extern ulong ovr_Livestreaming_StopPartyStream();

		[PreserveSig]
		public static extern ulong ovr_Livestreaming_StopStream();

		[PreserveSig]
		public static extern ulong ovr_Livestreaming_UpdateMicStatus(LivestreamingMicrophoneStatus micStatus);

		public static ulong ovr_Media_ShareToFacebook(string postTextSuggestion, string filePath, MediaContentType contentType)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_Media_ShareToFacebook_Native(IntPtr postTextSuggestion, IntPtr filePath, MediaContentType contentType);

		[PreserveSig]
		public static extern ulong ovr_NetSync_Connect(IntPtr connect_options);

		[PreserveSig]
		public static extern ulong ovr_NetSync_Disconnect(long connection_id);

		[PreserveSig]
		public static extern ulong ovr_NetSync_GetSessions(long connection_id);

		[PreserveSig]
		public static extern ulong ovr_NetSync_GetVoipAttenuation(long connection_id);

		[PreserveSig]
		public static extern ulong ovr_NetSync_GetVoipAttenuationDefault();

		[PreserveSig]
		public static extern ulong ovr_NetSync_SetVoipAttenuation(long connection_id, float[] distances, float[] decibels, UIntPtr count);

		public static ulong ovr_NetSync_SetVoipAttenuationModel(long connection_id, string name, float[] distances, float[] decibels, UIntPtr count)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_NetSync_SetVoipAttenuationModel_Native(long connection_id, IntPtr name, float[] distances, float[] decibels, UIntPtr count);

		public static ulong ovr_NetSync_SetVoipChannelCfg(long connection_id, string channel_name, string attnmodel, bool disable_spatialization)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_NetSync_SetVoipChannelCfg_Native(long connection_id, IntPtr channel_name, IntPtr attnmodel, bool disable_spatialization);

		public static ulong ovr_NetSync_SetVoipGroup(long connection_id, string group_id)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_NetSync_SetVoipGroup_Native(long connection_id, IntPtr group_id);

		[PreserveSig]
		public static extern ulong ovr_NetSync_SetVoipListentoChannels(long connection_id, string[] listento_channels, UIntPtr count);

		[PreserveSig]
		public static extern ulong ovr_NetSync_SetVoipMicSource(long connection_id, NetSyncVoipMicSource mic_source);

		[PreserveSig]
		public static extern ulong ovr_NetSync_SetVoipSessionMuted(long connection_id, ulong session_id, bool muted);

		[PreserveSig]
		public static extern ulong ovr_NetSync_SetVoipSpeaktoChannels(long connection_id, string[] speakto_channels, UIntPtr count);

		[PreserveSig]
		public static extern ulong ovr_NetSync_SetVoipStreamMode(long connection_id, ulong sessionId, NetSyncVoipStreamMode streamMode);

		[PreserveSig]
		public static extern ulong ovr_Notification_MarkAsRead(ulong notificationID);

		[PreserveSig]
		public static extern ulong ovr_Party_Create();

		[PreserveSig]
		public static extern ulong ovr_Party_GatherInApplication(ulong partyID, ulong appID);

		[PreserveSig]
		public static extern ulong ovr_Party_Get(ulong partyID);

		[PreserveSig]
		public static extern ulong ovr_Party_GetCurrent();

		[PreserveSig]
		public static extern ulong ovr_Party_GetCurrentForUser(ulong userID);

		[PreserveSig]
		public static extern ulong ovr_Party_Invite(ulong partyID, ulong userID);

		[PreserveSig]
		public static extern ulong ovr_Party_Join(ulong partyID);

		[PreserveSig]
		public static extern ulong ovr_Party_Leave(ulong partyID);

		[PreserveSig]
		public static extern ulong ovr_RichPresence_Clear();

		[PreserveSig]
		public static extern ulong ovr_RichPresence_GetDestinations();

		[PreserveSig]
		public static extern ulong ovr_RichPresence_Set(IntPtr richPresenceOptions);

		public static ulong ovr_RichPresence_SetDestination(string api_name)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_RichPresence_SetDestination_Native(IntPtr api_name);

		[PreserveSig]
		public static extern ulong ovr_RichPresence_SetIsJoinable(bool is_joinable);

		public static ulong ovr_RichPresence_SetLobbySession(string id)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_RichPresence_SetLobbySession_Native(IntPtr id);

		public static ulong ovr_RichPresence_SetMatchSession(string id)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_RichPresence_SetMatchSession_Native(IntPtr id);

		public static ulong ovr_User_CancelRecordingForReportFlow(string recordingUUID)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_User_CancelRecordingForReportFlow_Native(IntPtr recordingUUID);

		[PreserveSig]
		public static extern ulong ovr_User_Get(ulong userID);

		[PreserveSig]
		public static extern ulong ovr_User_GetAccessToken();

		[PreserveSig]
		public static extern ulong ovr_User_GetBlockedUsers();

		[PreserveSig]
		public static extern ulong ovr_User_GetLinkedAccounts(IntPtr userOptions);

		[PreserveSig]
		public static extern ulong ovr_User_GetLoggedInUser();

		[PreserveSig]
		public static extern ulong ovr_User_GetLoggedInUserFriends();

		[PreserveSig]
		public static extern ulong ovr_User_GetOrgScopedID(ulong userID);

		[PreserveSig]
		public static extern ulong ovr_User_GetSdkAccounts();

		[PreserveSig]
		public static extern ulong ovr_User_GetUserCapabilities();

		[PreserveSig]
		public static extern ulong ovr_User_GetUserProof();

		[PreserveSig]
		public static extern ulong ovr_User_LaunchBlockFlow(ulong userID);

		[PreserveSig]
		public static extern ulong ovr_User_LaunchFriendRequestFlow(ulong userID);

		[PreserveSig]
		public static extern ulong ovr_User_LaunchReportFlow(ulong userID);

		[PreserveSig]
		public static extern ulong ovr_User_LaunchReportFlow2(ulong optionalUserID, IntPtr abuseReportOptions);

		[PreserveSig]
		public static extern ulong ovr_User_LaunchUnblockFlow(ulong userID);

		[PreserveSig]
		public static extern ulong ovr_User_NewEntitledTestUser();

		[PreserveSig]
		public static extern ulong ovr_User_NewTestUser();

		[PreserveSig]
		public static extern ulong ovr_User_NewTestUserFriends();

		[PreserveSig]
		public static extern ulong ovr_User_StartRecordingForReportFlow();

		public static ulong ovr_User_StopRecordingAndLaunchReportFlow(ulong optionalUserID, string optionalRecordingUUID)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_User_StopRecordingAndLaunchReportFlow_Native(ulong optionalUserID, IntPtr optionalRecordingUUID);

		public static ulong ovr_User_StopRecordingAndLaunchReportFlow2(ulong optionalUserID, string optionalRecordingUUID, IntPtr abuseReportOptions)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_User_StopRecordingAndLaunchReportFlow2_Native(ulong optionalUserID, IntPtr optionalRecordingUUID, IntPtr abuseReportOptions);

		public static ulong ovr_User_TestUserCreateDeviceManifest(string deviceID, ulong[] appIDs, int numAppIDs)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_User_TestUserCreateDeviceManifest_Native(IntPtr deviceID, ulong[] appIDs, int numAppIDs);

		[PreserveSig]
		public static extern ulong ovr_UserAgeCategory_Get();

		[PreserveSig]
		public static extern ulong ovr_UserAgeCategory_Report(AppAgeCategory age_category);

		public static ulong ovr_UserDataStore_PrivateDeleteEntryByKey(ulong userID, string key)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_UserDataStore_PrivateDeleteEntryByKey_Native(ulong userID, IntPtr key);

		[PreserveSig]
		public static extern ulong ovr_UserDataStore_PrivateGetEntries(ulong userID);

		public static ulong ovr_UserDataStore_PrivateGetEntryByKey(ulong userID, string key)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_UserDataStore_PrivateGetEntryByKey_Native(ulong userID, IntPtr key);

		public static ulong ovr_UserDataStore_PrivateWriteEntry(ulong userID, string key, string value)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_UserDataStore_PrivateWriteEntry_Native(ulong userID, IntPtr key, IntPtr value);

		public static ulong ovr_UserDataStore_PublicDeleteEntryByKey(ulong userID, string key)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_UserDataStore_PublicDeleteEntryByKey_Native(ulong userID, IntPtr key);

		[PreserveSig]
		public static extern ulong ovr_UserDataStore_PublicGetEntries(ulong userID);

		public static ulong ovr_UserDataStore_PublicGetEntryByKey(ulong userID, string key)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_UserDataStore_PublicGetEntryByKey_Native(ulong userID, IntPtr key);

		public static ulong ovr_UserDataStore_PublicWriteEntry(ulong userID, string key, string value)
		{
			return 0uL;
		}

		[PreserveSig]
		private static extern ulong ovr_UserDataStore_PublicWriteEntry_Native(ulong userID, IntPtr key, IntPtr value);

		[PreserveSig]
		public static extern ulong ovr_Voip_GetMicrophoneAvailability();

		[PreserveSig]
		public static extern ulong ovr_Voip_ReportAppVoipSessions(ulong[] sessionIDs);

		[PreserveSig]
		public static extern ulong ovr_Voip_SetSystemVoipSuppressed(bool suppressed);

		public static string ovr_AbuseReportRecording_GetRecordingUuid(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AbuseReportRecording_GetRecordingUuid_Native(IntPtr obj);

		[PreserveSig]
		public static extern uint ovr_AchievementDefinition_GetBitfieldLength(IntPtr obj);

		public static string ovr_AchievementDefinition_GetName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AchievementDefinition_GetName_Native(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_AchievementDefinition_GetTarget(IntPtr obj);

		[PreserveSig]
		public static extern AchievementType ovr_AchievementDefinition_GetType(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_AchievementDefinitionArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_AchievementDefinitionArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AchievementDefinitionArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_AchievementDefinitionArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_AchievementDefinitionArray_HasNextPage(IntPtr obj);

		public static string ovr_AchievementProgress_GetBitfield(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AchievementProgress_GetBitfield_Native(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_AchievementProgress_GetCount(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_AchievementProgress_GetIsUnlocked(IntPtr obj);

		public static string ovr_AchievementProgress_GetName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AchievementProgress_GetName_Native(IntPtr obj);

		public static DateTime ovr_AchievementProgress_GetUnlockTime(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		private static extern ulong ovr_AchievementProgress_GetUnlockTime_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_AchievementProgressArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_AchievementProgressArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AchievementProgressArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_AchievementProgressArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_AchievementProgressArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_AchievementUpdate_GetJustUnlocked(IntPtr obj);

		public static string ovr_AchievementUpdate_GetName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AchievementUpdate_GetName_Native(IntPtr obj);

		[PreserveSig]
		public static extern long ovr_AppDownloadProgressResult_GetDownloadBytes(IntPtr obj);

		[PreserveSig]
		public static extern long ovr_AppDownloadProgressResult_GetDownloadedBytes(IntPtr obj);

		[PreserveSig]
		public static extern AppStatus ovr_AppDownloadProgressResult_GetStatusCode(IntPtr obj);

		[PreserveSig]
		public static extern long ovr_AppDownloadResult_GetTimestamp(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_Application_GetID(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_ApplicationInvite_GetDestination(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_ApplicationInvite_GetID(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_ApplicationInvite_GetIsActive(IntPtr obj);

		public static string ovr_ApplicationInvite_GetLobbySessionId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ApplicationInvite_GetLobbySessionId_Native(IntPtr obj);

		public static string ovr_ApplicationInvite_GetMatchSessionId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ApplicationInvite_GetMatchSessionId_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_ApplicationInvite_GetRecipient(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_ApplicationInviteArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_ApplicationInviteArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ApplicationInviteArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_ApplicationInviteArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_ApplicationInviteArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		public static extern int ovr_ApplicationVersion_GetCurrentCode(IntPtr obj);

		public static string ovr_ApplicationVersion_GetCurrentName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ApplicationVersion_GetCurrentName_Native(IntPtr obj);

		[PreserveSig]
		public static extern int ovr_ApplicationVersion_GetLatestCode(IntPtr obj);

		public static string ovr_ApplicationVersion_GetLatestName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ApplicationVersion_GetLatestName_Native(IntPtr obj);

		[PreserveSig]
		public static extern long ovr_ApplicationVersion_GetReleaseDate(IntPtr obj);

		public static string ovr_ApplicationVersion_GetSize(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ApplicationVersion_GetSize_Native(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_AssetDetails_GetAssetId(IntPtr obj);

		public static string ovr_AssetDetails_GetAssetType(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AssetDetails_GetAssetType_Native(IntPtr obj);

		public static string ovr_AssetDetails_GetDownloadStatus(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AssetDetails_GetDownloadStatus_Native(IntPtr obj);

		public static string ovr_AssetDetails_GetFilepath(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AssetDetails_GetFilepath_Native(IntPtr obj);

		public static string ovr_AssetDetails_GetIapStatus(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AssetDetails_GetIapStatus_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_AssetDetails_GetLanguage(IntPtr obj);

		public static string ovr_AssetDetails_GetMetadata(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AssetDetails_GetMetadata_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_AssetDetailsArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		public static extern UIntPtr ovr_AssetDetailsArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_AssetFileDeleteResult_GetAssetFileId(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_AssetFileDeleteResult_GetAssetId(IntPtr obj);

		public static string ovr_AssetFileDeleteResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AssetFileDeleteResult_GetFilepath_Native(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_AssetFileDeleteResult_GetSuccess(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_AssetFileDownloadCancelResult_GetAssetFileId(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_AssetFileDownloadCancelResult_GetAssetId(IntPtr obj);

		public static string ovr_AssetFileDownloadCancelResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AssetFileDownloadCancelResult_GetFilepath_Native(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_AssetFileDownloadCancelResult_GetSuccess(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_AssetFileDownloadResult_GetAssetId(IntPtr obj);

		public static string ovr_AssetFileDownloadResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_AssetFileDownloadResult_GetFilepath_Native(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_AssetFileDownloadUpdate_GetAssetFileId(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_AssetFileDownloadUpdate_GetAssetId(IntPtr obj);

		[PreserveSig]
		public static extern uint ovr_AssetFileDownloadUpdate_GetBytesTotal(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_AssetFileDownloadUpdate_GetBytesTotalLong(IntPtr obj);

		[PreserveSig]
		public static extern int ovr_AssetFileDownloadUpdate_GetBytesTransferred(IntPtr obj);

		[PreserveSig]
		public static extern long ovr_AssetFileDownloadUpdate_GetBytesTransferredLong(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_AssetFileDownloadUpdate_GetCompleted(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_AvatarEditorResult_GetRequestSent(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_BlockedUser_GetId(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_BlockedUserArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_BlockedUserArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_BlockedUserArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_BlockedUserArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_BlockedUserArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		public static extern ChallengeCreationType ovr_Challenge_GetCreationType(IntPtr obj);

		public static string ovr_Challenge_GetDescription(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Challenge_GetDescription_Native(IntPtr obj);

		public static DateTime ovr_Challenge_GetEndDate(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		private static extern ulong ovr_Challenge_GetEndDate_Native(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_Challenge_GetID(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Challenge_GetInvitedUsers(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Challenge_GetLeaderboard(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Challenge_GetParticipants(IntPtr obj);

		public static DateTime ovr_Challenge_GetStartDate(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		private static extern ulong ovr_Challenge_GetStartDate_Native(IntPtr obj);

		public static string ovr_Challenge_GetTitle(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Challenge_GetTitle_Native(IntPtr obj);

		[PreserveSig]
		public static extern ChallengeVisibility ovr_Challenge_GetVisibility(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_ChallengeArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_ChallengeArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ChallengeArray_GetNextUrl_Native(IntPtr obj);

		public static string ovr_ChallengeArray_GetPreviousUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ChallengeArray_GetPreviousUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_ChallengeArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_ChallengeArray_GetTotalCount(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_ChallengeArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_ChallengeArray_HasPreviousPage(IntPtr obj);

		public static string ovr_ChallengeEntry_GetDisplayScore(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ChallengeEntry_GetDisplayScore_Native(IntPtr obj);

		public static byte[] ovr_ChallengeEntry_GetExtraData(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ChallengeEntry_GetExtraData_Native(IntPtr obj);

		[PreserveSig]
		public static extern uint ovr_ChallengeEntry_GetExtraDataLength(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_ChallengeEntry_GetID(IntPtr obj);

		[PreserveSig]
		public static extern int ovr_ChallengeEntry_GetRank(IntPtr obj);

		[PreserveSig]
		public static extern long ovr_ChallengeEntry_GetScore(IntPtr obj);

		public static DateTime ovr_ChallengeEntry_GetTimestamp(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		private static extern ulong ovr_ChallengeEntry_GetTimestamp_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_ChallengeEntry_GetUser(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_ChallengeEntryArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_ChallengeEntryArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ChallengeEntryArray_GetNextUrl_Native(IntPtr obj);

		public static string ovr_ChallengeEntryArray_GetPreviousUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ChallengeEntryArray_GetPreviousUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_ChallengeEntryArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_ChallengeEntryArray_GetTotalCount(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_ChallengeEntryArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_ChallengeEntryArray_HasPreviousPage(IntPtr obj);

		public static string ovr_CowatchViewer_GetData(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_CowatchViewer_GetData_Native(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_CowatchViewer_GetId(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_CowatchViewerArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_CowatchViewerArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_CowatchViewerArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_CowatchViewerArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_CowatchViewerArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_CowatchViewerUpdate_GetDataList(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_CowatchViewerUpdate_GetId(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_CowatchingState_GetInSession(IntPtr obj);

		public static uint ovr_DataStore_Contains(IntPtr obj, string key)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern uint ovr_DataStore_Contains_Native(IntPtr obj, IntPtr key);

		public static string ovr_DataStore_GetKey(IntPtr obj, int index)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_DataStore_GetKey_Native(IntPtr obj, int index);

		[PreserveSig]
		public static extern UIntPtr ovr_DataStore_GetNumKeys(IntPtr obj);

		public static string ovr_DataStore_GetValue(IntPtr obj, string key)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_DataStore_GetValue_Native(IntPtr obj, IntPtr key);

		public static string ovr_Destination_GetApiName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Destination_GetApiName_Native(IntPtr obj);

		public static string ovr_Destination_GetDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Destination_GetDeeplinkMessage_Native(IntPtr obj);

		public static string ovr_Destination_GetDisplayName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Destination_GetDisplayName_Native(IntPtr obj);

		public static string ovr_Destination_GetShareableUri(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Destination_GetShareableUri_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_DestinationArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_DestinationArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_DestinationArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_DestinationArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_DestinationArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		public static extern int ovr_Error_GetCode(IntPtr obj);

		public static string ovr_Error_GetDisplayableMessage(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Error_GetDisplayableMessage_Native(IntPtr obj);

		[PreserveSig]
		public static extern int ovr_Error_GetHttpCode(IntPtr obj);

		public static string ovr_Error_GetMessage(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Error_GetMessage_Native(IntPtr obj);

		public static string ovr_GroupPresenceJoinIntent_GetDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_GroupPresenceJoinIntent_GetDeeplinkMessage_Native(IntPtr obj);

		public static string ovr_GroupPresenceJoinIntent_GetDestinationApiName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_GroupPresenceJoinIntent_GetDestinationApiName_Native(IntPtr obj);

		public static string ovr_GroupPresenceJoinIntent_GetLobbySessionId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_GroupPresenceJoinIntent_GetLobbySessionId_Native(IntPtr obj);

		public static string ovr_GroupPresenceJoinIntent_GetMatchSessionId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_GroupPresenceJoinIntent_GetMatchSessionId_Native(IntPtr obj);

		public static string ovr_GroupPresenceLeaveIntent_GetDestinationApiName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_GroupPresenceLeaveIntent_GetDestinationApiName_Native(IntPtr obj);

		public static string ovr_GroupPresenceLeaveIntent_GetLobbySessionId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_GroupPresenceLeaveIntent_GetLobbySessionId_Native(IntPtr obj);

		public static string ovr_GroupPresenceLeaveIntent_GetMatchSessionId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_GroupPresenceLeaveIntent_GetMatchSessionId_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_HttpTransferUpdate_GetBytes(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_HttpTransferUpdate_GetID(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_HttpTransferUpdate_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_HttpTransferUpdate_IsCompleted(IntPtr obj);

		public static string ovr_InstalledApplication_GetApplicationId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_InstalledApplication_GetApplicationId_Native(IntPtr obj);

		public static string ovr_InstalledApplication_GetPackageName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_InstalledApplication_GetPackageName_Native(IntPtr obj);

		public static string ovr_InstalledApplication_GetStatus(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_InstalledApplication_GetStatus_Native(IntPtr obj);

		[PreserveSig]
		public static extern int ovr_InstalledApplication_GetVersionCode(IntPtr obj);

		public static string ovr_InstalledApplication_GetVersionName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_InstalledApplication_GetVersionName_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_InstalledApplicationArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		public static extern UIntPtr ovr_InstalledApplicationArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_InvitePanelResultInfo_GetInvitesSent(IntPtr obj);

		public static string ovr_LanguagePackInfo_GetEnglishName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LanguagePackInfo_GetEnglishName_Native(IntPtr obj);

		public static string ovr_LanguagePackInfo_GetNativeName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LanguagePackInfo_GetNativeName_Native(IntPtr obj);

		public static string ovr_LanguagePackInfo_GetTag(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LanguagePackInfo_GetTag_Native(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LaunchBlockFlowResult_GetDidBlock(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LaunchBlockFlowResult_GetDidCancel(IntPtr obj);

		public static string ovr_LaunchDetails_GetDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LaunchDetails_GetDeeplinkMessage_Native(IntPtr obj);

		public static string ovr_LaunchDetails_GetDestinationApiName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LaunchDetails_GetDestinationApiName_Native(IntPtr obj);

		public static string ovr_LaunchDetails_GetLaunchSource(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LaunchDetails_GetLaunchSource_Native(IntPtr obj);

		[PreserveSig]
		public static extern LaunchType ovr_LaunchDetails_GetLaunchType(IntPtr obj);

		public static string ovr_LaunchDetails_GetTrackingID(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LaunchDetails_GetTrackingID_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_LaunchDetails_GetUsers(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LaunchFriendRequestFlowResult_GetDidCancel(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LaunchFriendRequestFlowResult_GetDidSendRequest(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_LaunchInvitePanelFlowResult_GetInvitedUsers(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LaunchReportFlowResult_GetDidCancel(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_LaunchReportFlowResult_GetUserReportId(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LaunchUnblockFlowResult_GetDidCancel(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LaunchUnblockFlowResult_GetDidUnblock(IntPtr obj);

		public static string ovr_Leaderboard_GetApiName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Leaderboard_GetApiName_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Leaderboard_GetDestination(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_Leaderboard_GetID(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_LeaderboardArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_LeaderboardArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LeaderboardArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_LeaderboardArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LeaderboardArray_HasNextPage(IntPtr obj);

		public static string ovr_LeaderboardEntry_GetDisplayScore(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LeaderboardEntry_GetDisplayScore_Native(IntPtr obj);

		public static byte[] ovr_LeaderboardEntry_GetExtraData(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LeaderboardEntry_GetExtraData_Native(IntPtr obj);

		[PreserveSig]
		public static extern uint ovr_LeaderboardEntry_GetExtraDataLength(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_LeaderboardEntry_GetID(IntPtr obj);

		[PreserveSig]
		public static extern int ovr_LeaderboardEntry_GetRank(IntPtr obj);

		[PreserveSig]
		public static extern long ovr_LeaderboardEntry_GetScore(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_LeaderboardEntry_GetSupplementaryMetric(IntPtr obj);

		public static DateTime ovr_LeaderboardEntry_GetTimestamp(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		private static extern ulong ovr_LeaderboardEntry_GetTimestamp_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_LeaderboardEntry_GetUser(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_LeaderboardEntryArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_LeaderboardEntryArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LeaderboardEntryArray_GetNextUrl_Native(IntPtr obj);

		public static string ovr_LeaderboardEntryArray_GetPreviousUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LeaderboardEntryArray_GetPreviousUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_LeaderboardEntryArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_LeaderboardEntryArray_GetTotalCount(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LeaderboardEntryArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LeaderboardEntryArray_HasPreviousPage(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LeaderboardUpdateStatus_GetDidUpdate(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_LeaderboardUpdateStatus_GetUpdatedChallengeId(IntPtr obj, uint index);

		[PreserveSig]
		public static extern uint ovr_LeaderboardUpdateStatus_GetUpdatedChallengeIdsSize(IntPtr obj);

		public static string ovr_LinkedAccount_GetAccessToken(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LinkedAccount_GetAccessToken_Native(IntPtr obj);

		[PreserveSig]
		public static extern ServiceProvider ovr_LinkedAccount_GetServiceProvider(IntPtr obj);

		public static string ovr_LinkedAccount_GetUserId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LinkedAccount_GetUserId_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_LinkedAccountArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		public static extern UIntPtr ovr_LinkedAccountArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LivestreamingApplicationStatus_GetStreamingEnabled(IntPtr obj);

		[PreserveSig]
		public static extern LivestreamingStartStatus ovr_LivestreamingStartResult_GetStreamingResult(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LivestreamingStatus_GetCommentsVisible(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LivestreamingStatus_GetIsPaused(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LivestreamingStatus_GetLivestreamingEnabled(IntPtr obj);

		[PreserveSig]
		public static extern int ovr_LivestreamingStatus_GetLivestreamingType(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_LivestreamingStatus_GetMicEnabled(IntPtr obj);

		[PreserveSig]
		public static extern int ovr_LivestreamingVideoStats_GetCommentCount(IntPtr obj);

		[PreserveSig]
		public static extern int ovr_LivestreamingVideoStats_GetReactionCount(IntPtr obj);

		public static string ovr_LivestreamingVideoStats_GetTotalViews(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_LivestreamingVideoStats_GetTotalViews_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAbuseReportRecording(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAchievementDefinitionArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAchievementProgressArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAchievementUpdate(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAppDownloadProgressResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAppDownloadResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetApplicationInviteArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetApplicationVersion(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAssetDetails(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAssetDetailsArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAssetFileDeleteResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAssetFileDownloadCancelResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAssetFileDownloadResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAssetFileDownloadUpdate(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetAvatarEditorResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetBlockedUserArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetChallenge(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetChallengeArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetChallengeEntryArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetCowatchViewerArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetCowatchViewerUpdate(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetCowatchingState(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetDataStore(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetDestinationArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetError(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetGroupPresenceJoinIntent(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetGroupPresenceLeaveIntent(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetHttpTransferUpdate(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetInstalledApplicationArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetInvitePanelResultInfo(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLaunchBlockFlowResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLaunchFriendRequestFlowResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLaunchInvitePanelFlowResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLaunchReportFlowResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLaunchUnblockFlowResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLeaderboardArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLeaderboardEntryArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLeaderboardUpdateStatus(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLinkedAccountArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLivestreamingApplicationStatus(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLivestreamingStartResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLivestreamingStatus(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetLivestreamingVideoStats(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetMicrophoneAvailabilityState(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetNativeMessage(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetNetSyncConnection(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetNetSyncSessionArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetNetSyncSessionsChangedNotification(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetNetSyncSetSessionPropertyResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetNetSyncVoipAttenuationValueArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetOrgScopedID(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetParty(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetPartyID(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetPartyUpdateNotification(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetPidArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetPlatformInitialize(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetProductArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetPurchase(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetPurchaseArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetRejoinDialogResult(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_Message_GetRequestID(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetSdkAccountArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetSendInvitesResult(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetShareMediaResult(IntPtr obj);

		public static string ovr_Message_GetString(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Message_GetString_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetSystemVoipState(IntPtr obj);

		[PreserveSig]
		public static extern Message.MessageType ovr_Message_GetType(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetUser(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetUserAccountAgeCategory(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetUserArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetUserCapabilityArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetUserDataStoreUpdateResponse(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetUserProof(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Message_GetUserReportID(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_Message_IsError(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_Microphone_GetNumSamplesAvailable(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_Microphone_GetOutputBufferMaxSize(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_Microphone_GetPCM(IntPtr obj, short[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		public static extern UIntPtr ovr_Microphone_GetPCMFloat(IntPtr obj, float[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		public static extern UIntPtr ovr_Microphone_ReadData(IntPtr obj, float[] outputBuffer, UIntPtr outputBufferSize);

		[PreserveSig]
		public static extern void ovr_Microphone_SetAcceptableRecordingDelayHint(IntPtr obj, UIntPtr delayMs);

		[PreserveSig]
		public static extern void ovr_Microphone_Start(IntPtr obj);

		[PreserveSig]
		public static extern void ovr_Microphone_Stop(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_MicrophoneAvailabilityState_GetMicrophoneAvailable(IntPtr obj);

		[PreserveSig]
		public static extern long ovr_NetSyncConnection_GetConnectionId(IntPtr obj);

		[PreserveSig]
		public static extern NetSyncDisconnectReason ovr_NetSyncConnection_GetDisconnectReason(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_NetSyncConnection_GetSessionId(IntPtr obj);

		[PreserveSig]
		public static extern NetSyncConnectionStatus ovr_NetSyncConnection_GetStatus(IntPtr obj);

		public static string ovr_NetSyncConnection_GetZoneId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_NetSyncConnection_GetZoneId_Native(IntPtr obj);

		[PreserveSig]
		public static extern long ovr_NetSyncSession_GetConnectionId(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_NetSyncSession_GetMuted(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_NetSyncSession_GetSessionId(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_NetSyncSession_GetUserId(IntPtr obj);

		public static string ovr_NetSyncSession_GetVoipGroup(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_NetSyncSession_GetVoipGroup_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_NetSyncSessionArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		public static extern UIntPtr ovr_NetSyncSessionArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern long ovr_NetSyncSessionsChangedNotification_GetConnectionId(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_NetSyncSessionsChangedNotification_GetSessions(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_NetSyncSetSessionPropertyResult_GetSession(IntPtr obj);

		[PreserveSig]
		public static extern float ovr_NetSyncVoipAttenuationValue_GetDecibels(IntPtr obj);

		[PreserveSig]
		public static extern float ovr_NetSyncVoipAttenuationValue_GetDistance(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_NetSyncVoipAttenuationValueArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		public static extern UIntPtr ovr_NetSyncVoipAttenuationValueArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_OrgScopedID_GetID(IntPtr obj);

		[PreserveSig]
		public static extern void ovr_Packet_Free(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Packet_GetBytes(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_Packet_GetSenderID(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_Packet_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_Party_GetID(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Party_GetInvitedUsers(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Party_GetLeader(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_Party_GetUsers(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_PartyID_GetID(IntPtr obj);

		[PreserveSig]
		public static extern PartyUpdateAction ovr_PartyUpdateNotification_GetAction(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_PartyUpdateNotification_GetPartyId(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_PartyUpdateNotification_GetSenderId(IntPtr obj);

		public static string ovr_PartyUpdateNotification_GetUpdateTimestamp(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_PartyUpdateNotification_GetUpdateTimestamp_Native(IntPtr obj);

		public static string ovr_PartyUpdateNotification_GetUserAlias(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_PartyUpdateNotification_GetUserAlias_Native(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_PartyUpdateNotification_GetUserId(IntPtr obj);

		public static string ovr_PartyUpdateNotification_GetUserName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_PartyUpdateNotification_GetUserName_Native(IntPtr obj);

		public static string ovr_Pid_GetId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Pid_GetId_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_PidArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		public static extern UIntPtr ovr_PidArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern PlatformInitializeResult ovr_PlatformInitialize_GetResult(IntPtr obj);

		[PreserveSig]
		public static extern uint ovr_Price_GetAmountInHundredths(IntPtr obj);

		public static string ovr_Price_GetCurrency(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Price_GetCurrency_Native(IntPtr obj);

		public static string ovr_Price_GetFormatted(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Price_GetFormatted_Native(IntPtr obj);

		public static string ovr_Product_GetDescription(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Product_GetDescription_Native(IntPtr obj);

		public static string ovr_Product_GetFormattedPrice(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Product_GetFormattedPrice_Native(IntPtr obj);

		public static string ovr_Product_GetName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Product_GetName_Native(IntPtr obj);

		public static string ovr_Product_GetSKU(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Product_GetSKU_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_ProductArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_ProductArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_ProductArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_ProductArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_ProductArray_HasNextPage(IntPtr obj);

		public static string ovr_Purchase_GetDeveloperPayload(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Purchase_GetDeveloperPayload_Native(IntPtr obj);

		public static DateTime ovr_Purchase_GetExpirationTime(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		private static extern ulong ovr_Purchase_GetExpirationTime_Native(IntPtr obj);

		public static DateTime ovr_Purchase_GetGrantTime(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		private static extern ulong ovr_Purchase_GetGrantTime_Native(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_Purchase_GetPurchaseID(IntPtr obj);

		public static string ovr_Purchase_GetPurchaseStrID(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Purchase_GetPurchaseStrID_Native(IntPtr obj);

		public static string ovr_Purchase_GetReportingId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Purchase_GetReportingId_Native(IntPtr obj);

		public static string ovr_Purchase_GetSKU(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_Purchase_GetSKU_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_PurchaseArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_PurchaseArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_PurchaseArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_PurchaseArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_PurchaseArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_RejoinDialogResult_GetRejoinSelected(IntPtr obj);

		[PreserveSig]
		public static extern SdkAccountType ovr_SdkAccount_GetAccountType(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_SdkAccount_GetUserId(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_SdkAccountArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		public static extern UIntPtr ovr_SdkAccountArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_SendInvitesResult_GetInvites(IntPtr obj);

		[PreserveSig]
		public static extern ShareMediaStatus ovr_ShareMediaResult_GetStatus(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_SupplementaryMetric_GetID(IntPtr obj);

		[PreserveSig]
		public static extern long ovr_SupplementaryMetric_GetMetric(IntPtr obj);

		[PreserveSig]
		public static extern VoipMuteState ovr_SystemVoipState_GetMicrophoneMuted(IntPtr obj);

		[PreserveSig]
		public static extern SystemVoipStatus ovr_SystemVoipState_GetStatus(IntPtr obj);

		public static string ovr_TestUser_GetAccessToken(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_TestUser_GetAccessToken_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_TestUser_GetAppAccessArray(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_TestUser_GetFbAppAccessArray(IntPtr obj);

		public static string ovr_TestUser_GetFriendAccessToken(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_TestUser_GetFriendAccessToken_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_TestUser_GetFriendAppAccessArray(IntPtr obj);

		public static string ovr_TestUser_GetUserAlias(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_TestUser_GetUserAlias_Native(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_TestUser_GetUserFbid(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_TestUser_GetUserId(IntPtr obj);

		public static string ovr_TestUserAppAccess_GetAccessToken(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_TestUserAppAccess_GetAccessToken_Native(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_TestUserAppAccess_GetAppId(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_TestUserAppAccess_GetUserId(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_TestUserAppAccessArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		public static extern UIntPtr ovr_TestUserAppAccessArray_GetSize(IntPtr obj);

		public static string ovr_User_GetDisplayName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_User_GetDisplayName_Native(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_User_GetID(IntPtr obj);

		public static string ovr_User_GetImageUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_User_GetImageUrl_Native(IntPtr obj);

		public static string ovr_User_GetOculusID(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_User_GetOculusID_Native(IntPtr obj);

		public static string ovr_User_GetPresence(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_User_GetPresence_Native(IntPtr obj);

		public static string ovr_User_GetPresenceDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_User_GetPresenceDeeplinkMessage_Native(IntPtr obj);

		public static string ovr_User_GetPresenceDestinationApiName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_User_GetPresenceDestinationApiName_Native(IntPtr obj);

		public static string ovr_User_GetPresenceLobbySessionId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_User_GetPresenceLobbySessionId_Native(IntPtr obj);

		public static string ovr_User_GetPresenceMatchSessionId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_User_GetPresenceMatchSessionId_Native(IntPtr obj);

		[PreserveSig]
		public static extern UserPresenceStatus ovr_User_GetPresenceStatus(IntPtr obj);

		public static string ovr_User_GetSmallImageUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_User_GetSmallImageUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern AccountAgeCategory ovr_UserAccountAgeCategory_GetAgeCategory(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_UserArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_UserArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_UserArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_UserArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_UserArray_HasNextPage(IntPtr obj);

		public static string ovr_UserCapability_GetDescription(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_UserCapability_GetDescription_Native(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_UserCapability_GetIsEnabled(IntPtr obj);

		public static string ovr_UserCapability_GetName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_UserCapability_GetName_Native(IntPtr obj);

		public static string ovr_UserCapability_GetReasonCode(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_UserCapability_GetReasonCode_Native(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_UserCapabilityArray_GetElement(IntPtr obj, UIntPtr index);

		public static string ovr_UserCapabilityArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_UserCapabilityArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		public static extern UIntPtr ovr_UserCapabilityArray_GetSize(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_UserCapabilityArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_UserDataStoreUpdateResponse_GetSuccess(IntPtr obj);

		public static string ovr_UserProof_GetNonce(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr ovr_UserProof_GetNonce_Native(IntPtr obj);

		[PreserveSig]
		public static extern bool ovr_UserReportID_GetDidCancel(IntPtr obj);

		[PreserveSig]
		public static extern ulong ovr_UserReportID_GetID(IntPtr obj);

		[PreserveSig]
		public static extern void ovr_VoipDecoder_Decode(IntPtr obj, byte[] compressedData, UIntPtr compressedSize);

		[PreserveSig]
		public static extern UIntPtr ovr_VoipDecoder_GetDecodedPCM(IntPtr obj, float[] outputBuffer, UIntPtr outputBufferSize);

		[PreserveSig]
		public static extern void ovr_VoipEncoder_AddPCM(IntPtr obj, float[] inputData, uint inputSize);

		[PreserveSig]
		public static extern UIntPtr ovr_VoipEncoder_GetCompressedData(IntPtr obj, byte[] outputBuffer, UIntPtr intputSize);

		[PreserveSig]
		public static extern UIntPtr ovr_VoipEncoder_GetCompressedDataSize(IntPtr obj);

		[PreserveSig]
		public static extern IntPtr ovr_AbuseReportOptions_Create();

		[PreserveSig]
		public static extern void ovr_AbuseReportOptions_Destroy(IntPtr handle);

		[PreserveSig]
		public static extern void ovr_AbuseReportOptions_SetPreventPeopleChooser(IntPtr handle, bool value);

		[PreserveSig]
		public static extern void ovr_AbuseReportOptions_SetReportType(IntPtr handle, AbuseReportType value);

		[PreserveSig]
		public static extern IntPtr ovr_AdvancedAbuseReportOptions_Create();

		[PreserveSig]
		public static extern void ovr_AdvancedAbuseReportOptions_Destroy(IntPtr handle);

		public static void ovr_AdvancedAbuseReportOptions_SetDeveloperDefinedContextString(IntPtr handle, string key, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_AdvancedAbuseReportOptions_SetDeveloperDefinedContextString_Native(IntPtr handle, IntPtr key, IntPtr value);

		[PreserveSig]
		public static extern void ovr_AdvancedAbuseReportOptions_ClearDeveloperDefinedContext(IntPtr handle);

		public static void ovr_AdvancedAbuseReportOptions_SetObjectType(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_AdvancedAbuseReportOptions_SetObjectType_Native(IntPtr handle, IntPtr value);

		[PreserveSig]
		public static extern void ovr_AdvancedAbuseReportOptions_SetReportType(IntPtr handle, AbuseReportType value);

		[PreserveSig]
		public static extern void ovr_AdvancedAbuseReportOptions_AddSuggestedUser(IntPtr handle, ulong value);

		[PreserveSig]
		public static extern void ovr_AdvancedAbuseReportOptions_ClearSuggestedUsers(IntPtr handle);

		[PreserveSig]
		public static extern void ovr_AdvancedAbuseReportOptions_SetVideoMode(IntPtr handle, AbuseReportVideoMode value);

		[PreserveSig]
		public static extern IntPtr ovr_ApplicationOptions_Create();

		[PreserveSig]
		public static extern void ovr_ApplicationOptions_Destroy(IntPtr handle);

		public static void ovr_ApplicationOptions_SetDeeplinkMessage(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_ApplicationOptions_SetDeeplinkMessage_Native(IntPtr handle, IntPtr value);

		public static void ovr_ApplicationOptions_SetDestinationApiName(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_ApplicationOptions_SetDestinationApiName_Native(IntPtr handle, IntPtr value);

		public static void ovr_ApplicationOptions_SetLobbySessionId(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_ApplicationOptions_SetLobbySessionId_Native(IntPtr handle, IntPtr value);

		public static void ovr_ApplicationOptions_SetMatchSessionId(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_ApplicationOptions_SetMatchSessionId_Native(IntPtr handle, IntPtr value);

		[PreserveSig]
		public static extern void ovr_ApplicationOptions_SetRoomId(IntPtr handle, ulong value);

		[PreserveSig]
		public static extern IntPtr ovr_AvatarEditorOptions_Create();

		[PreserveSig]
		public static extern void ovr_AvatarEditorOptions_Destroy(IntPtr handle);

		public static void ovr_AvatarEditorOptions_SetSourceOverride(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_AvatarEditorOptions_SetSourceOverride_Native(IntPtr handle, IntPtr value);

		[PreserveSig]
		public static extern IntPtr ovr_ChallengeOptions_Create();

		[PreserveSig]
		public static extern void ovr_ChallengeOptions_Destroy(IntPtr handle);

		public static void ovr_ChallengeOptions_SetDescription(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_ChallengeOptions_SetDescription_Native(IntPtr handle, IntPtr value);

		public static void ovr_ChallengeOptions_SetEndDate(IntPtr handle, DateTime value)
		{
		}

		[PreserveSig]
		private static extern void ovr_ChallengeOptions_SetEndDate_Native(IntPtr handle, ulong value);

		[PreserveSig]
		public static extern void ovr_ChallengeOptions_SetIncludeActiveChallenges(IntPtr handle, bool value);

		[PreserveSig]
		public static extern void ovr_ChallengeOptions_SetIncludeFutureChallenges(IntPtr handle, bool value);

		[PreserveSig]
		public static extern void ovr_ChallengeOptions_SetIncludePastChallenges(IntPtr handle, bool value);

		public static void ovr_ChallengeOptions_SetLeaderboardName(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_ChallengeOptions_SetLeaderboardName_Native(IntPtr handle, IntPtr value);

		public static void ovr_ChallengeOptions_SetStartDate(IntPtr handle, DateTime value)
		{
		}

		[PreserveSig]
		private static extern void ovr_ChallengeOptions_SetStartDate_Native(IntPtr handle, ulong value);

		public static void ovr_ChallengeOptions_SetTitle(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_ChallengeOptions_SetTitle_Native(IntPtr handle, IntPtr value);

		[PreserveSig]
		public static extern void ovr_ChallengeOptions_SetViewerFilter(IntPtr handle, ChallengeViewerFilter value);

		[PreserveSig]
		public static extern void ovr_ChallengeOptions_SetVisibility(IntPtr handle, ChallengeVisibility value);

		[PreserveSig]
		public static extern IntPtr ovr_GroupPresenceOptions_Create();

		[PreserveSig]
		public static extern void ovr_GroupPresenceOptions_Destroy(IntPtr handle);

		public static void ovr_GroupPresenceOptions_SetDeeplinkMessageOverride(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_GroupPresenceOptions_SetDeeplinkMessageOverride_Native(IntPtr handle, IntPtr value);

		public static void ovr_GroupPresenceOptions_SetDestinationApiName(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_GroupPresenceOptions_SetDestinationApiName_Native(IntPtr handle, IntPtr value);

		[PreserveSig]
		public static extern void ovr_GroupPresenceOptions_SetIsJoinable(IntPtr handle, bool value);

		public static void ovr_GroupPresenceOptions_SetLobbySessionId(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_GroupPresenceOptions_SetLobbySessionId_Native(IntPtr handle, IntPtr value);

		public static void ovr_GroupPresenceOptions_SetMatchSessionId(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_GroupPresenceOptions_SetMatchSessionId_Native(IntPtr handle, IntPtr value);

		[PreserveSig]
		public static extern IntPtr ovr_InviteOptions_Create();

		[PreserveSig]
		public static extern void ovr_InviteOptions_Destroy(IntPtr handle);

		[PreserveSig]
		public static extern void ovr_InviteOptions_AddSuggestedUser(IntPtr handle, ulong value);

		[PreserveSig]
		public static extern void ovr_InviteOptions_ClearSuggestedUsers(IntPtr handle);

		[PreserveSig]
		public static extern IntPtr ovr_MultiplayerErrorOptions_Create();

		[PreserveSig]
		public static extern void ovr_MultiplayerErrorOptions_Destroy(IntPtr handle);

		[PreserveSig]
		public static extern void ovr_MultiplayerErrorOptions_SetErrorKey(IntPtr handle, MultiplayerErrorErrorKey value);

		[PreserveSig]
		public static extern IntPtr ovr_NetSyncOptions_Create();

		[PreserveSig]
		public static extern void ovr_NetSyncOptions_Destroy(IntPtr handle);

		public static void ovr_NetSyncOptions_SetVoipGroup(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_NetSyncOptions_SetVoipGroup_Native(IntPtr handle, IntPtr value);

		[PreserveSig]
		public static extern void ovr_NetSyncOptions_SetVoipStreamDefault(IntPtr handle, NetSyncVoipStreamMode value);

		public static void ovr_NetSyncOptions_SetZoneId(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_NetSyncOptions_SetZoneId_Native(IntPtr handle, IntPtr value);

		[PreserveSig]
		public static extern IntPtr ovr_RichPresenceOptions_Create();

		[PreserveSig]
		public static extern void ovr_RichPresenceOptions_Destroy(IntPtr handle);

		public static void ovr_RichPresenceOptions_SetApiName(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_RichPresenceOptions_SetApiName_Native(IntPtr handle, IntPtr value);

		public static void ovr_RichPresenceOptions_SetDeeplinkMessageOverride(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		private static extern void ovr_RichPresenceOptions_SetDeeplinkMessageOverride_Native(IntPtr handle, IntPtr value);

		[PreserveSig]
		public static extern void ovr_RichPresenceOptions_SetIsJoinable(IntPtr handle, bool value);

		[PreserveSig]
		public static extern IntPtr ovr_RosterOptions_Create();

		[PreserveSig]
		public static extern void ovr_RosterOptions_Destroy(IntPtr handle);

		[PreserveSig]
		public static extern void ovr_RosterOptions_AddSuggestedUser(IntPtr handle, ulong value);

		[PreserveSig]
		public static extern void ovr_RosterOptions_ClearSuggestedUsers(IntPtr handle);

		[PreserveSig]
		public static extern IntPtr ovr_UserOptions_Create();

		[PreserveSig]
		public static extern void ovr_UserOptions_Destroy(IntPtr handle);

		[PreserveSig]
		public static extern void ovr_UserOptions_SetMaxUsers(IntPtr handle, uint value);

		[PreserveSig]
		public static extern void ovr_UserOptions_AddServiceProvider(IntPtr handle, ServiceProvider value);

		[PreserveSig]
		public static extern void ovr_UserOptions_ClearServiceProviders(IntPtr handle);

		[PreserveSig]
		public static extern void ovr_UserOptions_SetTimeWindow(IntPtr handle, TimeWindow value);

		[PreserveSig]
		public static extern IntPtr ovr_VoipOptions_Create();

		[PreserveSig]
		public static extern void ovr_VoipOptions_Destroy(IntPtr handle);

		[PreserveSig]
		public static extern void ovr_VoipOptions_SetBitrateForNewConnections(IntPtr handle, VoipBitrate value);

		[PreserveSig]
		public static extern void ovr_VoipOptions_SetCreateNewConnectionUseDtx(IntPtr handle, VoipDtxState value);
	}
}
