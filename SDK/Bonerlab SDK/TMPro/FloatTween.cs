using UnityEngine.Events;

namespace TMPro
{
	internal struct FloatTween : ITweenValue
	{
		public class FloatTweenCallback : UnityEvent<float>
		{
			public FloatTweenCallback()
				: base()
			{
			}
		}

		private FloatTweenCallback m_Target;

		private float m_StartValue;

		private float m_TargetValue;

		private float m_Duration;

		private bool m_IgnoreTimeScale;

		public float startValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float targetValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float duration
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool ignoreTimeScale
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void TweenValue(float floatPercentage)
		{
		}

		public void AddOnChangedCallback(UnityAction<float> callback)
		{
		}

		public bool GetIgnoreTimescale()
		{
			return default(bool);
		}

		public float GetDuration()
		{
			return default(float);
		}

		public bool ValidTarget()
		{
			return default(bool);
		}
	}
}
