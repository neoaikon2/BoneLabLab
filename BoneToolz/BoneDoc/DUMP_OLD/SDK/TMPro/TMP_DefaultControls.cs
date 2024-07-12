using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	public static class TMP_DefaultControls
	{
		public struct Resources
		{
			public Sprite standard;

			public Sprite background;

			public Sprite inputField;

			public Sprite knob;

			public Sprite checkmark;

			public Sprite dropdown;

			public Sprite mask;
		}

		private const float kWidth = 160f;

		private const float kThickHeight = 30f;

		private const float kThinHeight = 20f;

		private static Vector2 s_TextElementSize;

		private static Vector2 s_ThickElementSize;

		private static Vector2 s_ThinElementSize;

		private static Color s_DefaultSelectableColor;

		private static Color s_TextColor;

		private static GameObject CreateUIElementRoot(string name, Vector2 size)
		{
			return null;
		}

		private static GameObject CreateUIObject(string name, GameObject parent)
		{
			return null;
		}

		private static void SetDefaultTextValues(TMP_Text lbl)
		{
		}

		private static void SetDefaultColorTransitionValues(Selectable slider)
		{
		}

		private static void SetParentAndAlign(GameObject child, GameObject parent)
		{
		}

		private static void SetLayerRecursively(GameObject go, int layer)
		{
		}

		public static GameObject CreateScrollbar(Resources resources)
		{
			return null;
		}

		public static GameObject CreateButton(Resources resources)
		{
			return null;
		}

		public static GameObject CreateText(Resources resources)
		{
			return null;
		}

		public static GameObject CreateInputField(Resources resources)
		{
			return null;
		}

		public static GameObject CreateDropdown(Resources resources)
		{
			return null;
		}
	}
}
