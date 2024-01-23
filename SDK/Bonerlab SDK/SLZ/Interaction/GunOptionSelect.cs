using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Props.Weapons;
using TMPro;
using UnityEngine;

namespace SLZ.Interaction
{
	public class GunOptionSelect : MonoBehaviour
	{
		private enum SelectOptions
		{
			NONE = 0,
			FIREMODE = 1,
			EJECT = 2
		}

		[CompilerGenerated]
		private sealed class _003CCoFadeToColor_003Ed__24
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TextMeshPro text;

			public float duration;

			public Color targetColor;

			private float _003Cvelocity_003E5__2;

			private float _003Ctime_003E5__3;

			private Vector3 _003CsHSV_003E5__4;

			private Vector3 _003CtHSV_003E5__5;

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
			public _003CCoFadeToColor_003Ed__24(int _003C_003E1__state)
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
		private sealed class _003CCoFade_003Ed__25
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TextMeshPro text;

			public float duration;

			public float targetOpac;

			private float _003Cvelocity_003E5__2;

			private float _003Cperc_003E5__3;

			private float _003Ctime_003E5__4;

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
			public _003CCoFade_003Ed__25(int _003C_003E1__state)
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
		private sealed class _003CCoFade_003Ed__26
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Material mat;

			public float duration;

			public float targetOpac;

			private float _003Cvelocity_003E5__2;

			private float _003Cperc_003E5__3;

			private float _003Ctime_003E5__4;

			private Color _003CstartColor_003E5__5;

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
			public _003CCoFade_003Ed__26(int _003C_003E1__state)
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

		[Header("Options")]
		public bool displayUI;

		public bool canChangeFiremode;

		public bool canEjectMag;

		public Color uiColor;

		public Color uiHighlightColor;

		[Header("References")]
		public Grip grip;

		public Gun gun;

		public AmmoSocket reciever;

		public GameObject uiBorderObject;

		public GameObject uiCursorObject;

		public GameObject uiEjectText;

		public GameObject uiFireModeText;

		private Material m_UiBorderMat;

		private Material m_UiCursorMat;

		private TextMeshPro m_UiEjectTextMesh;

		private TextMeshPro m_UiFireModeTextMesh;

		private bool m_IsOptionsActive;

		private SelectOptions m_SelectOption;

		private Coroutine m_FireModeColorCoroutine;

		private Coroutine m_EjectColorCoroutine;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CCoFadeToColor_003Ed__24))]
		public IEnumerator CoFadeToColor(TextMeshPro text, Color targetColor, float duration)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoFade_003Ed__25))]
		public IEnumerator CoFade(TextMeshPro text, float targetOpac, float duration)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoFade_003Ed__26))]
		public IEnumerator CoFade(Material mat, float targetOpac, float duration)
		{
			return null;
		}

		public void OnOptionsActive()
		{
		}

		public void OnOptionsDeactive()
		{
		}
	}
}
