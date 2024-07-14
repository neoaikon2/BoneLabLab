using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Data;
using SLZ.Marrow.VoidLogic;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Control_Gashapon : MonoBehaviour
	{		public PowerSource pusherPower;

		[SerializeField]
		private List<Crate> blackList;

		private List<string> blackListStrings;

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

		private AmmoInventory _ammoInventory;

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

		[ContextMenu("AddAllAmmo")]
		private void ADDALLAMMO()
		{
		}

		public void AddBullets(int addedBullets, int type)
		{
		}

		[ContextMenu("CheckGachaLoop")]
		private void CHECKGACHALOOP()
		{
		}
		private IEnumerator CheckGachaLoop()
		{
			return null;
		}

		public void CheckGacha()
		{
		}
		private UniTaskVoid SpawnGacha(string barcode)
		{
			return default(UniTaskVoid);
		}
		private IEnumerator PusherPaddle()
		{
			return null;
		}
		private IEnumerator BallUpdateLoop()
		{
			return null;
		}
	}
}
