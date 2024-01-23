using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.VoidLogic;
using SLZ.Marrow.Warehouse;
using SLZ.Props.Weapons;
using SLZ.SaveData;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Bonelab
{
	public class Control_Gashapon : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnGacha_003Ed__42
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public string barcode;

			public Control_Gashapon _003C_003E4__this;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CPusherPaddle_003Ed__43
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Control_Gashapon _003C_003E4__this;

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
			public _003CPusherPaddle_003Ed__43(int _003C_003E1__state)
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
		private sealed class _003CBallUpdateLoop_003Ed__44
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Control_Gashapon _003C_003E4__this;

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
			public _003CBallUpdateLoop_003Ed__44(int _003C_003E1__state)
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

		public SourceNode pusherPower;

		[SerializeField]
		private List<Crate> blackList;

		private List<string> blackListStrings;

		private List<string> blackListPalletStrings;

		[SerializeField]
		private int _itemPrice;

		[SerializeField]
		private int _lightBullets;

		[SerializeField]
		private int _mediumBullets;

		[SerializeField]
		private int _heavyBullets;

		[SerializeField]
		private TextMeshPro _refundTextmesh;

		[SerializeField]
		private TextMeshPro _totalAmmo;

		[SerializeField]
		private TextMeshPro _spentAmmo;

		[SerializeField]
		private TextMeshPro _gachasLeft;

		[SerializeField]
		private AmmoReciever reciever;

		[SerializeField]
		private Spawnable gachaSpawnable;

		[SerializeField]
		private Spawnable lightRefundSpawnable;

		[SerializeField]
		private Spawnable mediumRefundSpawnable;

		[SerializeField]
		private Spawnable heavyRefundSpawnable;

		[SerializeField]
		private AudioClip despenceGachaClip;

		[SerializeField]
		private AudioClip noGachaClip;

		[SerializeField]
		private AudioClip lowFundsClip;

		[SerializeField]
		private AudioClip refundClip;

		[SerializeField]
		private AudioMixerGroup _mixergroup;

		public Transform giveChangeTransform;

		public Transform gachaSpawnTransform;

		private int loadedAmmoOffset;

		private static System.Random random;

		private bool leverCycle;

		private IEnumerator ballCoolDownCoroutine;

		private float ballCoolDown;

		public float ballHangTime;

		public float gravityFactor;

		public Rigidbody[] ballRbs;

		private static PlayerUnlocks u => null;

		private static PlayerProgression p => null;

		private void Start()
		{
		}

		public void SetupAmmo()
		{
		}

		public void GiveChange()
		{
		}

		public void InsertMagazine(Magazine magazine)
		{
		}

		public void AddBullets(int addedBullets, int type)
		{
		}

		public void CheckGacha()
		{
		}

		[AsyncStateMachine(typeof(_003CSpawnGacha_003Ed__42))]
		private UniTaskVoid SpawnGacha(string barcode)
		{
			return default(UniTaskVoid);
		}

		[IteratorStateMachine(typeof(_003CPusherPaddle_003Ed__43))]
		private IEnumerator PusherPaddle()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CBallUpdateLoop_003Ed__44))]
		private IEnumerator BallUpdateLoop()
		{
			return null;
		}
	}
}
