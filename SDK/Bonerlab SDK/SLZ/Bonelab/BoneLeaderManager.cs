using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Data;
using Steamworks;
using Steamworks.Data;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class BoneLeaderManager : MonoBehaviour
	{
		public enum LeaderMode
		{
			ALL_USER_DATA = 0,
			SINGLE_DATA = 1
		}

		private enum SteamFilter
		{
			FRIENDS = 0,
			USER = 1,
			TOP = 2
		}

		public LeaderMode leaderMode;

		[SerializeField]
		[Header("LEADERBOARD DATA")]
		private List<BoneLeaderData> allLeaderDataList;

		public BoneLeaderData currData;

		[Header("OCULUS USER DATA")]
		[Space(20f)]
		[SerializeField]
		private ulong myID;

		[SerializeField]
		private string myOculusID;

		[Header("STEAM USER DATA")]
		[SerializeField]
		private string steamName;

		[SerializeField]
		private SteamId steamID;

		[SerializeField]
		private Leaderboard board;

		[SerializeField]
		private SteamFilter steamFilter;

		[SerializeField]
		[Header("PREFABS")]
		private GameObject entryPrefab;

		[SerializeField]
		private GameObject userEntryPrefab;

		[Header("UI DISPLAY")]
		public bool allowExitButton;

		[SerializeField]
		private bool isCurrentUser;

		[SerializeField]
		private bool displayPanel;

		[SerializeField]
		private List<GameObject> entryObjectList;

		[SerializeField]
		private GameObject leaderboardEntryParent;

		[SerializeField]
		private bool isAltHighPanel;

		[SerializeField]
		private TMP_Text text_TitleBoard;

		[SerializeField]
		private TMP_Text text_TitleKey;

		[SerializeField]
		private TMP_Text text_ID_Rank_Key;

		[SerializeField]
		private TMP_Text text_ScoreKey;

		[SerializeField]
		private Button button_Filter;

		[SerializeField]
		private Button button_StartAt;

		[SerializeField]
		private TMP_Text startAtButtonText;

		[SerializeField]
		private TMP_Text filterButtonText;

		[SerializeField]
		private Button button_Exit;

		[SerializeField]
		private TMP_Text currPageText;

		[SerializeField]
		private TMP_Text totalPageText;

		[SerializeField]
		private GameObject pageButtonsObj;

		[SerializeField]
		private GameObject pageDownButtonObj;

		[SerializeField]
		private GameObject pageUpButtonObj;

		[SerializeField]
		private TMP_Text text_InternetRequired;

		private int maxEntriesPerPage;

		private int currIndex;

		private int currentPage;

		private int totalPages;

		[HideInInspector]
		public UnityEvent onDataComplete;

		[SerializeField]
		private Transform altLocation;

		private Coroutine timeOutRoutine;

		private void Awake()
		{
		}

		private void PassedEntitlements()
		{
		}

		public void InitializeDisplay()
		{
		}

		private void UpdatePages()
		{
		}

		public void FocusBoardAtIndex(int i)
		{
		}

		public void FocusExplicitLeaderboard(BoneLeaderData data)
		{
		}

		public void ReturnToUserDisplay()
		{
		}

		public void PageUp()
		{
		}

		public void PageDown()
		{
		}

		public void UpdateDisplayState()
		{
		}

		public void ToggleFilterType()
		{
		}

		public void ToggleStartAt()
		{
		}

		public void ToggleAllButtons(bool enable)
		{
		}

		[ContextMenu("DestroyCurrentEntries")]
		public void DestroyCurrentEntries()
		{
		}

		public void GetUserLeaderboardData(int index)
		{
		}

		public void GetUserLeaderboardPage()
		{
		}

		public void UserLeaderboardCallback_Steam(LeaderboardEntry[] entries)
		{
		}

		private void CreateBlankUserEntry()
		{
		}

		private void CreateBlankExplicitEntry()
		{
		}

		[ContextMenu("TeleportToAlt")]
		public void TeleportToAltLocation()
		{
		}

		public void ToggleConnectionText(bool enable)
		{
		}

		public void SubmitLeaderboardScore(uint score)
		{
		}

		private IEnumerator CoWaitAndQuery()
		{
			return null;
		}

		public void QueryCurrentData()
		{
		}

		private IEnumerator CoQueryTimeout(BoneLeaderData data)
		{
			return null;
		}

		public void Steam_QueryData()
		{
		}

		public void SubmitScoreToBoard(BoneLeaderData data, int score)
		{
		}

		public BoneLeaderManager()
			: base()
		{
		}
	}
}
