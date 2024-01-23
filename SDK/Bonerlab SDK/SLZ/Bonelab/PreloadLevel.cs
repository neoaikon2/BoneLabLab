using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace SLZ.Bonelab
{
	public class PreloadLevel : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLocationWarmer_003Ed__20
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PreloadLevel _003C_003E4__this;

			private int _003Cj_003E5__2;

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
			public _003CLocationWarmer_003Ed__20(int _003C_003E1__state)
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

		[SerializeField]
		private ShaderVariantCollection variantCollection;

		public List<Vector3> positions;

		public static Action onPreloadStartDelegate;

		public static Action onPreloadCompleteDelegate;

		private Camera[] cam;

		private List<Material> mats;

		private MeshRenderer MR;

		private MeshFilter MF;

		private Mesh mesh;

		private Vector3[] vertices;

		private CommandBuffer renderBuffer;

		private HashSet<Material> matHash;

		private void Start()
		{
		}

		private void InitializeWarmupCameras()
		{
		}

		private void BlackOutVRCamera()
		{
		}

		private void makeBlackoutCommandBuffer(Camera camera)
		{
		}

		private void MakeWarmupCameras()
		{
		}

		private void MaterialWarmup()
		{
		}

		private void GatherMaterials()
		{
		}

		private void InitializeMesh()
		{
		}

		[IteratorStateMachine(typeof(_003CLocationWarmer_003Ed__20))]
		private IEnumerator LocationWarmer()
		{
			return null;
		}
	}
}
