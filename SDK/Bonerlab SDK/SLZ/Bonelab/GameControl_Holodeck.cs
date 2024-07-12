using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Zones;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class GameControl_Holodeck : BonelabGameControl
	{
		[Serializable]
		public class ProbePair
		{
			public Cubemap cubemap0;

			public Cubemap cubemap1;

			public SphericalHarmonicsL2 harmonics;

			public ProbePair()
				: base()
			{
			}
		}

		public GameObject UI;

		public Renderer[] wallPanels;

		public GameObject doorHide;

		public Renderer doorHideRenderer;

		public Image doorCheckImage;

		public Material[] wallMaterials;

		public GameObject[] lights;

		public float maxPanelTicTime;

		public ReflectionProbe[] probes;

		public ProbePair[] cubemaps;

		public AudioReverbData hugeRoomReverb;

		public AudioReverbData outsideReverb;

		public AudioReverbData voidReverb;

		public AudioClip shipAmbience;

		public AudioClip spaceAmbience;

		public AudioClip desertAmbience;

		public AudioClip beachAmbience;

		public AudioClip cityAmbience;

		public AudioClip stadiumAmbience;

		public AudioClip meadowAmbience;

		public AudioClip voidAmbience;

		public ZoneAmbience zoneAmbience0;

		public ZoneAmbience zoneAmbience1;

		private int materialIndex;

		private IEnumerator matCycle;

		public override void Awake()
		{
		}

		private new void Start()
		{
		}

		private void OnLevelLoad()
		{
		}

		[ContextMenu("CYCLEMATERIAL")]
		public void CYCLEMATERIAL()
		{
		}

		public void SELECTMATERIAL(int i)
		{
		}

		public void TOGGLEDOOR()
		{
		}

		private void SetSky(int materialIndex)
		{
		}

		private IEnumerator CycleMatOverTimeEditor()
		{
			return null;
		}

		private IEnumerator CycleMatOverTime()
		{
			return null;
		}

		private void CueAmbience(AudioClip clipMain)
		{
		}

		[ContextMenu("Generate SphericalHarmonics")]
		public void GenerateSHs()
		{
		}

		private SphericalHarmonicsL2 AddCubemapToSH(Cubemap cubemap, int samplesPerFace)
		{
			return default(SphericalHarmonicsL2);
		}

		private static int FindFace(Vector3 dir)
		{
			return default(int);
		}

		private static int GetTexelIndexFromDirection(Vector3 dir, int cubemap_size)
		{
			return default(int);
		}

		private SphericalHarmonicsL2 NormalizeSH(SphericalHarmonicsL2 sh, int totalSamples)
		{
			return default(SphericalHarmonicsL2);
		}

		public GameControl_Holodeck()
			: base()
		{
		}
	}
}
