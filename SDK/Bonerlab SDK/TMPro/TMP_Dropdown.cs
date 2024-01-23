using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace TMPro
{
	[AddComponentMenu("UI/Dropdown - TextMeshPro", 35)]
	[RequireComponent(typeof(RectTransform))]
	public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
	{
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
		{
			[SerializeField]
			private TMP_Text m_Text;

			[SerializeField]
			private Image m_Image;

			[SerializeField]
			private RectTransform m_RectTransform;

			[SerializeField]
			private Toggle m_Toggle;

			public TMP_Text text
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Image image
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public RectTransform rectTransform
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Toggle toggle
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public virtual void OnPointerEnter(PointerEventData eventData)
			{
			}

			public virtual void OnCancel(BaseEventData eventData)
			{
			}

			public DropdownItem()
				: base()
			{
			}
		}

		[Serializable]
		public class OptionData
		{
			[SerializeField]
			private string m_Text;

			[SerializeField]
			private Sprite m_Image;

			public string text
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Sprite image
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public OptionData()
				: base()
			{
			}

			public OptionData(string text)
				: this()
			{
			}

			public OptionData(Sprite image)
				: this()
			{
			}

			public OptionData(string text, Sprite image)
				: this()
			{
			}
		}

		[Serializable]
		public class OptionDataList
		{
			[SerializeField]
			private List<OptionData> m_Options;

			public List<OptionData> options
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public OptionDataList()
				: base()
			{
			}
		}

		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
			public DropdownEvent()
				: base()
			{
			}
		}

		[SerializeField]
		private RectTransform m_Template;

		[SerializeField]
		private TMP_Text m_CaptionText;

		[SerializeField]
		private Image m_CaptionImage;

		[SerializeField]
		private Graphic m_Placeholder;

		[SerializeField]
		[Space]
		private TMP_Text m_ItemText;

		[SerializeField]
		private Image m_ItemImage;

		[SerializeField]
		[Space]
		private int m_Value;

		[SerializeField]
		[Space]
		private OptionDataList m_Options;

		[SerializeField]
		[Space]
		private DropdownEvent m_OnValueChanged;

		[SerializeField]
		private float m_AlphaFadeSpeed;

		private GameObject m_Dropdown;

		private GameObject m_Blocker;

		private List<DropdownItem> m_Items;

		private TweenRunner<FloatTween> m_AlphaTweenRunner;

		private bool validTemplate;

		private Coroutine m_Coroutine;

		private static OptionData s_NoOptionData;

		public RectTransform template
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TMP_Text captionText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Image captionImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Graphic placeholder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TMP_Text itemText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Image itemImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<OptionData> options
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DropdownEvent onValueChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float alphaFadeSpeed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int value
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool IsExpanded
		{
			get
			{
				return default(bool);
			}
		}

		public void SetValueWithoutNotify(int input)
		{
		}

		private void SetValue(int value, bool sendCallback = true)
		{
		}

		protected TMP_Dropdown()
			: base()
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDisable()
		{
		}

		public void RefreshShownValue()
		{
		}

		public void AddOptions(List<OptionData> options)
		{
		}

		public void AddOptions(List<string> options)
		{
		}

		public void AddOptions(List<Sprite> options)
		{
		}

		public void ClearOptions()
		{
		}

		private void SetupTemplate()
		{
		}

		private static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			return null;
		}

		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		public virtual void OnCancel(BaseEventData eventData)
		{
		}

		public void Show()
		{
		}

		protected virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			return null;
		}

		protected virtual void DestroyBlocker(GameObject blocker)
		{
		}

		protected virtual GameObject CreateDropdownList(GameObject template)
		{
			return null;
		}

		protected virtual void DestroyDropdownList(GameObject dropdownList)
		{
		}

		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate)
		{
			return null;
		}

		protected virtual void DestroyItem(DropdownItem item)
		{
		}

		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items)
		{
			return null;
		}

		private void AlphaFadeList(float duration, float alpha)
		{
		}

		private void AlphaFadeList(float duration, float start, float end)
		{
		}

		private void SetAlpha(float alpha)
		{
		}

		public void Hide()
		{
		}

		private IEnumerator DelayedDestroyDropdownList(float delay)
		{
			return null;
		}

		private void ImmediateDestroyDropdownList()
		{
		}

		private void OnSelectItem(Toggle toggle)
		{
		}
	}
}
