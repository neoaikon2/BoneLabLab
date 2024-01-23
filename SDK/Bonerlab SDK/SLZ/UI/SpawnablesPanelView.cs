using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using SLZ.Props;
using SLZ.SaveData;
using TMPro;
using UnityEngine;

namespace SLZ.UI
{
	public class SpawnablesPanelView : PanelView
	{
		public delegate void SelectSpawnableDelegate(SpawnableCrate data);

		public delegate void SelectUtilityModeDelegate(UtilityModes mode);

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLoadFavorites_003Ed__81
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SpawnablesPanelView _003C_003E4__this;

			private List<string> _003CfavoriteSpawnableBarcodes_003E5__2;

			private int _003Ci_003E5__3;

			private UniTask<AvatarCrate>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Header("Buttons")]
		public ButtonReferenceHolder[] tabButtons;

		public ButtonReferenceHolder[] treeButtons;

		public ButtonReferenceHolder[] itemButtons;

		[Header("Tree Path")]
		public ButtonReferenceHolder treeBackButton;

		public ButtonReferenceHolder swapSortButton;

		public TextMeshPro treePathText;

		public TextMeshPro labelText;

		[Header("Tree Scroll")]
		public ButtonReferenceHolder treeScrollUpButton;

		public ButtonReferenceHolder treeScrollDownButton;

		public TextMeshPro treePageText;

		[Header("Item Scroll")]
		public ButtonReferenceHolder itemScrollUpButton;

		public ButtonReferenceHolder itemScrollDownButton;

		public TextMeshPro itemPageText;

		[Header("Info Section")]
		public ButtonReferenceHolder favoriteButton;

		public TextMeshPro selectedTitle;

		public TextMeshPro selectedPallet;

		public TextMeshPro selectedAuthor;

		public TextMeshPro selectedDescription;

		public TextMeshPro selectedTags;

		[HideInInspector]
		public SpawnableCrate selectedObject;

		private Dictionary<string, SpawnableCrate> favoriteCrates;

		private int _numberOfPages;

		private int _numberOfTagPages;

		private int _currentPage;

		private int _currentTagPage;

		private string _selectedTag;

		private string _selectedItemTag;

		private int _selectedTabIndex;

		private int _selectedTagIndex;

		private int _selectedItemIndex;

		private int _selectedItem;

		private TagTree tagTree;

		private List<string> _activeTags;

		private List<string> _allTags;

		private Dictionary<Pallet, DateTime> palletInstalledDates;

		private Pallet dummyBonelabPallet;

		private List<string> otherStripTags;

		private List<string> palletStripTitles;

		private List<string> ammoBarcodes;

		private bool firstActivation;

		private bool sortSwap;

		public Dictionary<string, List<SpawnableCrate>> SpawnablesQuickMap { get; private set; }

		public SpawnGun spawnGun { private get; set; }

		private static PlayerSettings p => null;

		public event SelectSpawnableDelegate selectSpawnableDelegate
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

		public event SelectUtilityModeDelegate selectModeDelegate
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

		public void SelectTab(int idx)
		{
		}

		public void SelectItem(int idx)
		{
		}

		public void SelectMode(int mode)
		{
		}

		public void SelectCategory(int idx)
		{
		}

		private void HighlightProperSpawnItem()
		{
		}

		public override void Activate()
		{
		}

		private void CollectPalletDates()
		{
		}

		private void CleanupUserTags()
		{
		}

		private void PopulateMenu()
		{
		}

		private void FilterTagTree()
		{
		}

		public void GenerateCategoriesMapping()
		{
		}

		private void UpdatePageItems(int pageIdx, int maxItems)
		{
		}

		private void UpdateTagPageItems(int tagPageIdx, int maxTagItems)
		{
		}

		private void UpdatePageText(int idx, int total)
		{
		}

		private void UpdateTagPageText(int idx, int total)
		{
		}

		public void NextTagPage()
		{
		}

		public void PrevTagPage()
		{
		}

		public void NextPage()
		{
		}

		public void PrevPage()
		{
		}

		public void TreeBackButton()
		{
		}

		public void SwapSortButton()
		{
		}

		public void FavoriteItem()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadFavorites_003Ed__81))]
		private UniTaskVoid LoadFavorites()
		{
			return default(UniTaskVoid);
		}

		public void SaveFavorites()
		{
		}
	}
}
