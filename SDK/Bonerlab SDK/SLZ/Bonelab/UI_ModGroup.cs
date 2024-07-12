using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Forklift;
using SLZ.Marrow.Forklift.Model;
using SLZ.Marrow.Warehouse;
using SLZ.ModIO.WebSockets;
using SLZ.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class UI_ModGroup : MonoBehaviour
	{
		[Serializable]
		public enum PageType
		{
			Installed = 0,
			Approved = 1,
			External = 2,
			Repos = 3,
			Mods = 4
		}

		[Serializable]
		public struct UI_ModPager
		{
			public GameObject forwardButton;

			public GameObject backButton;

			public TextMeshProUGUI txt_pageNumber;

			public PageType currentPageType;

			public int currentPage;
		}

		[Serializable]
		public struct UI_ModSettings
		{
			public TextMeshProUGUI txt_developerMode;

			public TextMeshProUGUI txt_developerModePort;

			public TextMeshProUGUI txt_modioDiagnostics;
		}

		[Serializable]
		public class UI_ModViewModel
		{
			public string text;

			public Pallet pallet;

			public ModRepository modRepository;

			public ModListing modListing;

			public ModTarget modTarget;

			public string targetName;

			public bool useItemImage;

			public string itemImageUrl;

			public bool useVersion;

			public bool useProgressBar;

			public FileDownloadProgress progress;

			public bool isInstalled;

			public CancellationTokenSource StopThisDownloadCTS;

			public UI_ModViewModel()
				: base()
			{
			}
		}

		[Serializable]
		public class UI_ModCell
		{
			public ButtonReferenceHolder button;

			public ProgressBar progressBar;

			[HideInInspector]
			public string itemImageUrl;

			public UniTask<Sprite> itemImageTask;

			public CancellationTokenSource itemImageCTS;

			[HideInInspector]
			public bool selected;

			[HideInInspector]
			public int viewModelIndex;

			public UniTask UpdateFromViewModel(UI_ModViewModel viewModel, UI_ModGroup context)
			{
				return default(UniTask);
			}

			public UI_ModCell()
				: base()
			{
			}
		}

		[Space(10f)]
		[Header("Global")]
		public TextMeshProUGUI txt_pageTitle;

		public TextMeshProUGUI txt_sdkVersion;

		public string[] string_pageTitle;

		public Sprite defaultImage;

		[Header("Group")]
		[Space(10f)]
		public GameObject Group_Mods;

		public GameObject Group_Main;

		[Header("SubMenus")]
		[Space(10f)]
		public GameObject Menu_ModsMain;

		public GameObject Menu_Downloads;

		[Header("Popups")]
		[Space(10f)]
		public GameObject Popup_ModWarning;

		public GameObject Popup_AvatarWarning;

		[Header("Pages")]
		[Space(10f)]
		public GameObject Page_Installed;

		public GameObject Page_Approved;

		public GameObject Page_Modio;

		public GameObject Page_Illegal;

		public GameObject Page_Settings;

		public GameObject Page_Repos;

		public GameObject Page_ModLevels;

		private int currentPage;

		[Space(10f)]
		[Header("Paged Pallets")]
		public GameObject Page_Pallets;

		public UI_ModSettings uiModSettings;

		public UI_ModPager pager;

		public UI_ModCell[] PalletButtons;

		public GameObject loadingIcon;

		[Header("Mod.io")]
		[Space(10f)]
		public ButtonReferenceHolder modioButton;

		public TextMeshPro modioReadout;

		public TextMeshPro modioCodeTimer;

		public TextMeshPro modioInstructions;

		[Header("Warning")]
		[Space(10f)]
		public GameObject obj_DevModeWarning;

		public GameObject obj_AvatarWarning;

		public GameObject obj_ModWarning;

		public ModIOManager _modIOManager;

		private ModRepository _officialRepository;

		private ModRepository[] _otherRepositories;

		private List<UI_ModViewModel> _viewModels;

		private Dictionary<string, Sprite> _spriteCache;

		private CancellationTokenSource _stopAllDownloadsCTS;

		private ModSubscriptionDownloader _modSubscriptionDownloader;

		private bool logInProcessActive;

		private CancellationTokenSource codeTimerToken;

		private bool firstEnable;

		private CancellationTokenSource ParseRepoCancelToken;

		private CancellationTokenSource LoadingIconCancelToken;

		public UnityEvent returnEvent;

		private const string REPO_APPROVED = "https://mods.stresslevelzero.com/repository.json";

		private readonly Regex NonAlphanumeric;

		private int _pageCount
		{
			get
			{
				return default(int);
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private UniTaskVoid CheckLogIn()
		{
			return default(UniTaskVoid);
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void PortChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		private UniTask Load_Repositories()
		{
			return default(UniTask);
		}

		public void MODS_BUTTON()
		{
		}

		public void RETURN_BUTTON()
		{
		}

		public void GOTO_PAGE(int page)
		{
		}

		public void BUTTON_MODSETTINGS(int buttonNumber = 0)
		{
		}

		private void DevModeWarning()
		{
		}

		public void MODIO_BUTTON()
		{
		}

		private void LogInTask()
		{
		}

		private UniTaskVoid CodeTimmer(DeviceLoginResponseContext loginResponseContext, CancellationTokenSource cts, CancellationTokenSource maincts)
		{
			return default(UniTaskVoid);
		}

		public void BUTTON_INSTALLSUBSCRIPTION(bool yesInstall = false)
		{
		}

		private void DownloadComplete()
		{
		}

		public void BUTTON_SELECT(int idx)
		{
		}

		private void OnCellClicked(UI_ModCell button)
		{
		}

		public void BUTTON_OPENPAGE(int pageTypeInt = 0)
		{
		}

		public void BUTTON_BACK(int pages = 1)
		{
		}

		public void BUTTON_FORWARD(int pages = 1)
		{
		}

		public void BUTTON_DELETE(bool deleteAll = true)
		{
		}

		private UniTask PopulateMenu()
		{
			return default(UniTask);
		}

		private void ParseRepositories(ModRepository modRepo, List<Pallet> pallets)
		{
		}

		private UniTaskVoid LoadingIcon(CancellationTokenSource cts)
		{
			return default(UniTaskVoid);
		}

		private void UpdatePagerUI(int newPageIndex)
		{
		}

		private UniTask UpdateCells(int newPageIndex)
		{
			return default(UniTask);
		}

		private int ModSorterLettersAndNumbersOnly(UI_ModViewModel x, UI_ModViewModel y)
		{
			return default(int);
		}

		public void WARNINGS()
		{
		}

		public UI_ModGroup()
			: base()
		{
		}
	}
}
