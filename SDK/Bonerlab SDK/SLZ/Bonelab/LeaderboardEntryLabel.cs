using System;
using SLZ.Data;
using SLZ.Marrow.Utilities;
using Steamworks.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class LeaderboardEntryLabel : MonoBehaviour
	{
		private static ComponentCache<LeaderboardEntryLabel> _cache;

		public int rank;

		public string oculusID;

		public long score;

		public DateTime timeStamp;

		public TMP_Text IDText;

		public TMP_Text titleText;

		public TMP_Text rankText;

		public TMP_Text userIDText;

		public TMP_Text scoreText;

		public TMP_Text timeStampText;

		public Image panelImage;

		public Image highlightPanelImage;

		public Button button;

		public int itemIndex;

		public static ComponentCache<LeaderboardEntryLabel> Cache => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void PopulateBoneUserText_Steam(LeaderboardEntry entry, BoneLeaderData data, BoneLeaderManager manager, bool displayPanel)
		{
		}

		public void PopulateBoneText_Steam(LeaderboardEntry entry, bool displayPanel, bool isUser, BoneLeaderData data)
		{
		}

		public void PopulateBlankUserBoneText(BoneLeaderData data, BoneLeaderManager manager, bool displayPanel)
		{
		}

		public void PopulateBlankBoneText(string userName, BoneLeaderData data, BoneLeaderManager manager, bool displayPanel)
		{
		}

		public void OnDataComplete()
		{
		}
	}
}
