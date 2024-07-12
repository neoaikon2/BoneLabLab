using UnityEngine;
using UnityEngine.Events;

namespace TMPro
{
	internal struct ColorTween : ITweenValue
	{
		public enum ColorTweenMode
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}

		public class ColorTweenCallback : UnityEvent<Color>
		{
			public ColorTweenCallback()
				: base()
			{
			}
		}

		private ColorTweenCallback m_Target;

		private Color m_StartColor;

		private Color m_TargetColor;

		private ColorTweenMode m_TweenMode;

		private float m_Duration;

		private bool m_IgnoreTimeScale;

		public Color startColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color targetColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public ColorTweenMode tweenMode
		{
			get
			{
				return default(ColorTweenMode);
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

		public void AddOnChangedCallback(UnityAction<Color> callback)
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
