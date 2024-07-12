using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityMeshSimplifier;

namespace SLZ.Marrow.Utilities
{
	public class MeshCroncher
	{
		private struct PreivewMeshData
		{
			public float posX;

			public float posY;

			public float posZ;

			public uint normal;

			public void SetData(Vector3 pos, Vector3 normalVec)
			{
			}

			private uint ConvertFloat4ToSNorm4(float4 value)
			{
				return default(uint);
			}
		}

		public static Mesh CronchMesh(GameObject gameObject, int maxLODLevel = 0, float quality = 0.5f, bool forceQuality = false)
		{
			return null;
		}

		public static UniTask<Mesh> CronchMeshAsync(GameObject gameObject)
		{
			return default(UniTask<Mesh>);
		}

		private static void AutoSimplifyMesh(Mesh inputMesh, [Out] Mesh outputMesh, float quality = 0.5f, bool forceQuality = false, string name = default(string), bool forceLossless = false)
		{
		}

		private static UniTask<Mesh> AutoSimplifyMeshAsync(Mesh inputMesh, string name = default(string), bool forceLossless = false)
		{
			return default(UniTask<Mesh>);
		}

		private static void OptimizeMesh(Mesh originalMesh, Mesh optimizedMesh)
		{
		}

		public MeshCroncher()
			: base()
		{
		}
	}
}
