using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LevelObject : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLerpHideCube_003Ed__20
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public bool hide;

		public LevelObject _003C_003E4__this;

		private float _003Ctime_003E5__2;

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
		public _003CLerpHideCube_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CLerpHyperCube_003Ed__22
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool expand;

		public LevelObject _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

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
		public _003CLerpHyperCube_003Ed__22(int _003C_003E1__state)
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

	[Header("SETTINGS - REQUIRED")]
	[Space(5f)]
	public string string_LevelToload;

	public string string_LongName;

	public Transform hypercube;

	public Vector3 scl_hypercube_IN;

	public Vector3 scl_hypercube_OUT;

	private Vector3 scl_hypercube_CUR;

	private Vector3 scl_hypercube_TAR;

	private Vector3 defaultCubeScale;

	public float scl_length;

	public float scl_speed;

	public float scl_t;

	public ParticleSystem fx_particleHighlight;

	private float elapsedTime;

	public AudioSource src_Audio;

	public AudioClip clip_Select;

	public AudioClip clip_DeSelect;

	private Coroutine lerpHideCubeCoroutine;

	private Coroutine lerpHyperCubeCoroutine;

	public void Start()
	{
	}

	public void ExpandContract(bool expand = false)
	{
	}

	public void HideCube(bool hide = false, float duration = 1f)
	{
	}

	[IteratorStateMachine(typeof(_003CLerpHideCube_003Ed__20))]
	private IEnumerator LerpHideCube(bool hide = false, float duration = 1f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLerpHyperCube_003Ed__22))]
	private IEnumerator LerpHyperCube(bool expand = false)
	{
		return null;
	}
}
