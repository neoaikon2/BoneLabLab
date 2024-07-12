using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	[MarrowPlugin("SLZ.Bonelab", "Time Manager", null)]
	public class TimeManager : IMarrowPluginRunCallbacks, IMarrowPlugin, IMarrowPluginLevelCallbacks
	{
		public delegate void SlowTime(float step);

		private static float max_intensity;

		private static float lrp_time;

		private static float _curTimeScale;

		private static bool _isPaused;

		private static bool _slowMoEnabled;

		public AudioClip decelTime;

		public AudioClip accelTime;

		private static float cur_intensity;

		private static float tar_intensity;

		private static float tmp_intensity;

		private static int cur_timeScaleStep;

		private static int max_timeScaleStep;

		private static bool _controllingTime;

		public static bool slowMoEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static int CurrentTimeScaleStep
		{
			get
			{
				return default(int);
			}
		}

		public static void TOGGLE_TIMESCALE()
		{
		}

		public static void DECREASE_TIMESCALE()
		{
		}

		public static void INCREASE_TIMESCALE()
		{
		}

		public static void STEP_TIMESCALE(int step)
		{
		}

		public static void RESET_TIMESCALE()
		{
		}

		public static void RISE_TIMESCALE()
		{
		}

		public static void DROP_TIMESCALE()
		{
		}

		private static void SET_TIMESCALE(float intensity)
		{
		}

		public static void PAUSE()
		{
		}

		public static void UNPAUSE()
		{
		}

		private void OnMarrowReady()
		{
		}

		private void OnPostTimeUpdate()
		{
		}

		private void OnEndFrame()
		{
		}

		UniTask IMarrowPluginRunCallbacks.OnMarrowPluginStart()
		{
			return default(UniTask);
		}

		UniTask IMarrowPluginRunCallbacks.OnMarrowPluginStop()
		{
			return default(UniTask);
		}

		UniTask IMarrowPluginLevelCallbacks.OnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		public TimeManager()
			: base()
		{
		}

		public static event SlowTime OnSlowTime;
	}
}
