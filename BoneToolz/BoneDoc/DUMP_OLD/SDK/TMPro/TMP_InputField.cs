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
	[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler
	{
		public enum ContentType
		{
			Standard = 0,
			Autocorrected = 1,
			IntegerNumber = 2,
			DecimalNumber = 3,
			Alphanumeric = 4,
			Name = 5,
			EmailAddress = 6,
			Password = 7,
			Pin = 8,
			Custom = 9
		}

		public enum InputType
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}

		public enum CharacterValidation
		{
			None = 0,
			Digit = 1,
			Integer = 2,
			Decimal = 3,
			Alphanumeric = 4,
			Name = 5,
			Regex = 6,
			EmailAddress = 7,
			CustomValidator = 8
		}

		public enum LineType
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}

		public delegate char OnValidateInput(string text, int charIndex, char addedChar);

		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
			public SubmitEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
			public OnChangeEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class SelectionEvent : UnityEvent<string>
		{
			public SelectionEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			public TextSelectionEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status>
		{
			public TouchScreenKeyboardEvent()
				: base()
			{
			}
		}

		protected enum EditState
		{
			Continue = 0,
			Finish = 1
		}

		protected TouchScreenKeyboard m_SoftKeyboard;

		private static readonly char[] kSeparators;

		protected RectTransform m_RectTransform;

		[SerializeField]
		protected RectTransform m_TextViewport;

		protected RectMask2D m_TextComponentRectMask;

		protected RectMask2D m_TextViewportRectMask;

		private Rect m_CachedViewportRect;

		[SerializeField]
		protected TMP_Text m_TextComponent;

		protected RectTransform m_TextComponentRectTransform;

		[SerializeField]
		protected Graphic m_Placeholder;

		[SerializeField]
		protected Scrollbar m_VerticalScrollbar;

		[SerializeField]
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;

		private bool m_IsDrivenByLayoutComponents;

		[SerializeField]
		private LayoutGroup m_LayoutGroup;

		private IScrollHandler m_IScrollHandlerParent;

		private float m_ScrollPosition;

		[SerializeField]
		protected float m_ScrollSensitivity;

		[SerializeField]
		private ContentType m_ContentType;

		[SerializeField]
		private InputType m_InputType;

		[SerializeField]
		private char m_AsteriskChar;

		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		[SerializeField]
		private LineType m_LineType;

		[SerializeField]
		private bool m_HideMobileInput;

		[SerializeField]
		private bool m_HideSoftKeyboard;

		[SerializeField]
		private CharacterValidation m_CharacterValidation;

		[SerializeField]
		private string m_RegexValue;

		[SerializeField]
		private float m_GlobalPointSize;

		[SerializeField]
		private int m_CharacterLimit;

		[SerializeField]
		private SubmitEvent m_OnEndEdit;

		[SerializeField]
		private SubmitEvent m_OnSubmit;

		[SerializeField]
		private SelectionEvent m_OnSelect;

		[SerializeField]
		private SelectionEvent m_OnDeselect;

		[SerializeField]
		private TextSelectionEvent m_OnTextSelection;

		[SerializeField]
		private TextSelectionEvent m_OnEndTextSelection;

		[SerializeField]
		private OnChangeEvent m_OnValueChanged;

		[SerializeField]
		private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged;

		[SerializeField]
		private OnValidateInput m_OnValidateInput;

		[SerializeField]
		private Color m_CaretColor;

		[SerializeField]
		private bool m_CustomCaretColor;

		[SerializeField]
		private Color m_SelectionColor;

		[SerializeField]
		[TextArea(5, 10)]
		protected string m_Text;

		[SerializeField]
		[Range(0f, 4f)]
		private float m_CaretBlinkRate;

		[SerializeField]
		[Range(1f, 5f)]
		private int m_CaretWidth;

		[SerializeField]
		private bool m_ReadOnly;

		[SerializeField]
		private bool m_RichText;

		protected int m_StringPosition;

		protected int m_StringSelectPosition;

		protected int m_CaretPosition;

		protected int m_CaretSelectPosition;

		private RectTransform caretRectTrans;

		protected UIVertex[] m_CursorVerts;

		private CanvasRenderer m_CachedInputRenderer;

		private Vector2 m_LastPosition;

		[NonSerialized]
		protected Mesh m_Mesh;

		private bool m_AllowInput;

		private bool m_ShouldActivateNextUpdate;

		private bool m_UpdateDrag;

		private bool m_DragPositionOutOfBounds;

		private const float kHScrollSpeed = 0.05f;

		private const float kVScrollSpeed = 0.1f;

		protected bool m_CaretVisible;

		private Coroutine m_BlinkCoroutine;

		private float m_BlinkStartTime;

		private Coroutine m_DragCoroutine;

		private string m_OriginalText;

		private bool m_WasCanceled;

		private bool m_HasDoneFocusTransition;

		private WaitForSecondsRealtime m_WaitForSecondsRealtime;

		private bool m_PreventCallback;

		private bool m_TouchKeyboardAllowsInPlaceEditing;

		private bool m_IsTextComponentUpdateRequired;

		private bool m_isLastKeyBackspace;

		private float m_PointerDownClickStartTime;

		private float m_KeyDownStartTime;

		private float m_DoubleClickDelay;

		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		private bool m_IsCompositionActive;

		private bool m_ShouldUpdateIMEWindowPosition;

		private int m_PreviousIMEInsertionLine;

		[SerializeField]
		protected TMP_FontAsset m_GlobalFontAsset;

		[SerializeField]
		protected bool m_OnFocusSelectAll;

		protected bool m_isSelectAll;

		[SerializeField]
		protected bool m_ResetOnDeActivation;

		private bool m_SelectionStillActive;

		private bool m_ReleaseSelection;

		private GameObject m_PreviouslySelectedObject;

		[SerializeField]
		private bool m_RestoreOriginalTextOnEscape;

		[SerializeField]
		protected bool m_isRichTextEditingAllowed;

		[SerializeField]
		protected int m_LineLimit;

		[SerializeField]
		protected TMP_InputValidator m_InputValidator;

		private bool m_isSelected;

		private bool m_IsStringPositionDirty;

		private bool m_IsCaretPositionDirty;

		private bool m_forceRectTransformAdjustment;

		private Event m_ProcessingEvent;

		private BaseInput inputSystem
		{
			get
			{
				return null;
			}
		}

		private string compositionString
		{
			get
			{
				return null;
			}
		}

		private int compositionLength
		{
			get
			{
				return default(int);
			}
		}

		protected Mesh mesh
		{
			get
			{
				return null;
			}
		}

		public bool shouldHideMobileInput
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool shouldHideSoftKeyboard
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

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

		public bool isFocused
		{
			get
			{
				return default(bool);
			}
		}

		public float caretBlinkRate
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int caretWidth
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public RectTransform textViewport
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TMP_Text textComponent
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

		public Scrollbar verticalScrollbar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float scrollSensitivity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Color caretColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool customCaretColor
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Color selectionColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public SubmitEvent onEndEdit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SubmitEvent onSubmit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SelectionEvent onSelect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SelectionEvent onDeselect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextSelectionEvent onTextSelection
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextSelectionEvent onEndTextSelection
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public OnChangeEvent onValueChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public OnValidateInput onValidateInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int characterLimit
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float pointSize
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public TMP_FontAsset fontAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool onFocusSelectAll
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool resetOnDeActivation
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool restoreOriginalTextOnEscape
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isRichTextEditingAllowed
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public ContentType contentType
		{
			get
			{
				return default(ContentType);
			}
			set
			{
			}
		}

		public LineType lineType
		{
			get
			{
				return default(LineType);
			}
			set
			{
			}
		}

		public int lineLimit
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public InputType inputType
		{
			get
			{
				return default(InputType);
			}
			set
			{
			}
		}

		public TouchScreenKeyboardType keyboardType
		{
			get
			{
				return default(TouchScreenKeyboardType);
			}
			set
			{
			}
		}

		public CharacterValidation characterValidation
		{
			get
			{
				return default(CharacterValidation);
			}
			set
			{
			}
		}

		public TMP_InputValidator inputValidator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool readOnly
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool richText
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool multiLine
		{
			get
			{
				return default(bool);
			}
		}

		public char asteriskChar
		{
			get
			{
				return default(char);
			}
			set
			{
			}
		}

		public bool wasCanceled
		{
			get
			{
				return default(bool);
			}
		}

		protected int caretPositionInternal
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		protected int stringPositionInternal
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		protected int caretSelectPositionInternal
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		protected int stringSelectPositionInternal
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		private bool hasSelection
		{
			get
			{
				return default(bool);
			}
		}

		public int caretPosition
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int selectionAnchorPosition
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int selectionFocusPosition
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int stringPosition
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int selectionStringAnchorPosition
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int selectionStringFocusPosition
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		private static string clipboard
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual float minWidth
		{
			get
			{
				return default(float);
			}
		}

		public virtual float preferredWidth
		{
			get
			{
				return default(float);
			}
		}

		public virtual float flexibleWidth
		{
			get
			{
				return default(float);
			}
		}

		public virtual float minHeight
		{
			get
			{
				return default(float);
			}
		}

		public virtual float preferredHeight
		{
			get
			{
				return default(float);
			}
		}

		public virtual float flexibleHeight
		{
			get
			{
				return default(float);
			}
		}

		public virtual int layoutPriority
		{
			get
			{
				return default(int);
			}
		}

		protected TMP_InputField()
			: base()
		{
		}

		private bool isKeyboardUsingEvents()
		{
			return default(bool);
		}

		public void SetTextWithoutNotify(string input)
		{
		}

		private void SetText(string value, bool sendCallback = true)
		{
		}

		protected void ClampStringPos(int pos)
		{
		}

		protected void ClampCaretPos(int pos)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		private IEnumerator CaretBlink()
		{
			return null;
		}

		private void SetCaretVisible()
		{
		}

		private void SetCaretActive()
		{
		}

		protected void OnFocus()
		{
		}

		protected void SelectAll()
		{
		}

		public void MoveTextEnd(bool shift)
		{
		}

		public void MoveTextStart(bool shift)
		{
		}

		public void MoveToEndOfLine(bool shift, bool ctrl)
		{
		}

		public void MoveToStartOfLine(bool shift, bool ctrl)
		{
		}

		private bool InPlaceEditing()
		{
			return default(bool);
		}

		private void UpdateStringPositionFromKeyboard()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			return null;
		}

		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		protected EditState KeyPressed(Event evt)
		{
			return default(EditState);
		}

		protected virtual bool IsValidChar(char c)
		{
			return default(bool);
		}

		public void ProcessEvent(Event e)
		{
		}

		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		private float GetScrollPositionRelativeToViewport()
		{
			return default(float);
		}

		private string GetSelectedString()
		{
			return null;
		}

		private int FindNextWordBegin()
		{
			return default(int);
		}

		private void MoveRight(bool shift, bool ctrl)
		{
		}

		private int FindPrevWordBegin()
		{
			return default(int);
		}

		private void MoveLeft(bool shift, bool ctrl)
		{
		}

		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		private int PageDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		private void MoveDown(bool shift)
		{
		}

		private void MoveDown(bool shift, bool goToLastChar)
		{
		}

		private void MoveUp(bool shift)
		{
		}

		private void MoveUp(bool shift, bool goToFirstChar)
		{
		}

		private void MovePageUp(bool shift)
		{
		}

		private void MovePageUp(bool shift, bool goToFirstChar)
		{
		}

		private void MovePageDown(bool shift)
		{
		}

		private void MovePageDown(bool shift, bool goToLastChar)
		{
		}

		private void Delete()
		{
		}

		private void DeleteKey()
		{
		}

		private void Backspace()
		{
		}

		protected virtual void Append(string input)
		{
		}

		protected virtual void Append(char input)
		{
		}

		private void Insert(char c)
		{
		}

		private void UpdateTouchKeyboardFromEditChanges()
		{
		}

		private void SendOnValueChangedAndUpdateLabel()
		{
		}

		private void SendOnValueChanged()
		{
		}

		protected void SendOnEndEdit()
		{
		}

		protected void SendOnSubmit()
		{
		}

		protected void SendOnFocus()
		{
		}

		protected void SendOnFocusLost()
		{
		}

		protected void SendOnTextSelection()
		{
		}

		protected void SendOnEndTextSelection()
		{
		}

		protected void SendTouchScreenKeyboardStatusChanged()
		{
		}

		protected void UpdateLabel()
		{
		}

		private void UpdateScrollbar()
		{
		}

		private void OnScrollbarValueChange(float value)
		{
		}

		private void UpdateMaskRegions()
		{
		}

		private void AdjustTextPositionRelativeToViewport(float relativePosition)
		{
		}

		private int GetCaretPositionFromStringIndex(int stringIndex)
		{
			return default(int);
		}

		private int GetMinCaretPositionFromStringIndex(int stringIndex)
		{
			return default(int);
		}

		private int GetMaxCaretPositionFromStringIndex(int stringIndex)
		{
			return default(int);
		}

		private int GetStringIndexFromCaretPosition(int caretPosition)
		{
			return default(int);
		}

		public void ForceLabelUpdate()
		{
		}

		private void MarkGeometryAsDirty()
		{
		}

		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		public virtual void LayoutComplete()
		{
		}

		public virtual void GraphicUpdateComplete()
		{
		}

		private void UpdateGeometry()
		{
		}

		private void AssignPositioningIfNeeded()
		{
		}

		private void OnFillVBO(Mesh vbo)
		{
		}

		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		private void CreateCursorVerts()
		{
		}

		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
		{
		}

		protected char Validate(string text, int pos, char ch)
		{
			return default(char);
		}

		public void ActivateInputField()
		{
		}

		private void ActivateInputFieldInternal()
		{
		}

		public override void OnSelect(BaseEventData eventData)
		{
		}

		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnControlClick()
		{
		}

		public void ReleaseSelection()
		{
		}

		public void DeactivateInputField(bool clearSelection = false)
		{
		}

		public override void OnDeselect(BaseEventData eventData)
		{
		}

		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		private void EnforceContentType()
		{
		}

		private void SetTextComponentWrapMode()
		{
		}

		private void SetTextComponentRichTextMode()
		{
		}

		private void SetToCustomIfContentTypeIsNot(params ContentType[] allowedContentTypes)
		{
			allowedContentTypes = default(ContentType[]);
		}

		private void SetToCustom()
		{
		}

		private void SetToCustom(CharacterValidation characterValidation)
		{
		}

		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public virtual void CalculateLayoutInputVertical()
		{
		}

		public void SetGlobalPointSize(float pointSize)
		{
		}

		public void SetGlobalFontAsset(TMP_FontAsset fontAsset)
		{
		}

		Transform ICanvasElement.transform
		{
			get
			{
				return null;
			}
		}
	}
}
