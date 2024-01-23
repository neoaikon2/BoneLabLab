using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.SceneStreaming;
using SLZ.Marrow.Warehouse;
using SLZ.SFX;
using SLZ.VFX;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_Outro : BonelabInternalGameControl
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass40_0
		{
			public bool isDoneLoading;

			internal void _003CCycleWindmillAirlock_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCycleWindmillAirlock_003Ed__40
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Outro _003C_003E4__this;

			private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCycleWindmillAirlock_003Ed__40(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CChangeChunk_003Ed__50
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public Chunk targetChunk;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CChangeChunk_003Ed__50(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLoadAvatarFromSaveDataAsync_003Ed__58
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameControl_Outro _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public GameObject[] disableTownItemsAirlock;

		public GameObject[] disableTownItemsWindmill;

		public Blip femMBlip;

		public Chunk TownfightChunk;

		public Chunk WindMillOpChunk;

		public Chunk SkyTubeChunk;

		public Chunk TaxiStartChunk;

		public Chunk VoidFloorChunk;

		public Chunk VoidG114Chunk;

		public Chunk TaxiStartConfigChunk;

		public Chunk VoidFloorConfigChunk;

		public Chunk VoidG114ConfigChunk;

		public GameObject TaxiSequence;

		public GameObject WindmillGate;

		public ArmFinale ArmFinale;

		public GameObject VoidMenu;

		public GameObject windmill;

		private IEnumerator WindmillAirlock;

		private Coroutine changeChunk;

		[Header("ArmCinematic")]
		public GameObject[] ceilingtiles;

		public GameObject JimmyArm;

		public float armDelay;

		private Coroutine _coArmDelay;

		public GameObject avatarTransform;

		public MeshFilter avatarMeshFilter;

		public TextMeshProUGUI avatarName;

		public float avatarMeshScaleTune;

		private AvatarCrate avatarCrate;

		public string buildTitle;

		public string buildState;

		private string buildDate;

		public TextMeshPro tmp_Title;

		public TextMeshPro tmp_BuildInfo;

		public ZoneMusic music_menu;

		public ZoneMusic music_keygen;

		public SpawnableCrateReference blueApollo;

		public override void Awake()
		{
		}

		public override void Start()
		{
		}

		public void DespawnTownItemsAirlock()
		{
		}

		public void DespawnItemsWindmill()
		{
		}

		[IteratorStateMachine(typeof(_003CCycleWindmillAirlock_003Ed__40))]
		private IEnumerator CycleWindmillAirlock()
		{
			return null;
		}

		public void WarmUpJimmyArm()
		{
		}

		private void ReachWindmill()
		{
		}

		private void ReachedTaxi()
		{
		}

		private void ArmHide()
		{
		}

		private void VoidDriving()
		{
		}

		private void DrivingEnd()
		{
		}

		private void CompleteGame()
		{
		}

		[ContextMenu("SkipToTaxi")]
		public void SkipToTaxi()
		{
		}

		public void SequenceProgress(int progress)
		{
		}

		[IteratorStateMachine(typeof(_003CChangeChunk_003Ed__50))]
		private IEnumerator ChangeChunk(Chunk targetChunk, float delay = 0f)
		{
			return null;
		}

		public void RemoveObjects()
		{
		}

		public void TweenFogDensity(float _endDensity = 0.05f, float _durration = 1f)
		{
		}

		public void UnityFogDensity(float _density)
		{
		}

		public void BUTTON_QUICKPLAY()
		{
		}

		public void BUTTON_PLAYNEWGAME()
		{
		}

		public void BUTTON_PLAYHUB()
		{
		}

		public void BUTTON_PLAYCONTINUE()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadAvatarFromSaveDataAsync_003Ed__58))]
		public UniTask LoadAvatarFromSaveDataAsync()
		{
			return default(UniTask);
		}

		private void SetPreviewMesh(AvatarCrate crate)
		{
		}

		public void PLAYMENUMUSIC(int song = 0)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
