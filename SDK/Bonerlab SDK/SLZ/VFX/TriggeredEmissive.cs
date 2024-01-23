using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.VFX
{
	public class TriggeredEmissive : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoBlendColor_003Ed__12
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Color startC;

			public Color endC;

			public TriggeredEmissive _003C_003E4__this;

			private float _003CstartH_003E5__2;

			private float _003CstartS_003E5__3;

			private float _003CstartV_003E5__4;

			private float _003CendH_003E5__5;

			private float _003CendS_003E5__6;

			private float _003CendV_003E5__7;

			private float _003Ctime_003E5__8;

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
			public _003CCoBlendColor_003Ed__12(int _003C_003E1__state)
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

		[ColorUsage(true, true)]
		public Color startColor;

		[ColorUsage(true, true)]
		public Color endColor;

		public Renderer ren;

		public CurveData curve;

		public float blendTime;

		private int emmisiveID;

		private Color _curColor;

		private Coroutine _endColorCoroutine;

		private void Awake()
		{
		}

		private void BlendColor(Color targetColor)
		{
		}

		public void BlendToStartColor()
		{
		}

		public void BlendToEndColor()
		{
		}

		[IteratorStateMachine(typeof(_003CCoBlendColor_003Ed__12))]
		private IEnumerator CoBlendColor(Color startC, Color endC)
		{
			return null;
		}
	}
}
