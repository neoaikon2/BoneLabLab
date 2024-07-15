using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Pool;
using UnityEngine;
using UnityEngine.Rendering;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Volume))]
	public class FadeAndDespawnVolume : SpawnEvents
	{
		public Volume volume;

		public Action onComplete;

		public float duration;

		private float startValue;

		private float endValue;

		public MeshRenderer meshRenderer;

		private Material mat;

		private Color black;

		private Color clear;

		protected override void Awake()
		{
		}

		public override void OnPoolInitialize()
		{
		}
		private UniTaskVoid FadeOverTime(float seconds)
		{
			return default(UniTaskVoid);
		}

		private void SetValues(float lerper)
		{
		}
	}
}
