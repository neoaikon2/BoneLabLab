using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	[RequireComponent(typeof(RectTransform))]
	public class TextContainer : UIBehaviour
	{
		private bool m_hasChanged;

		[SerializeField]
		private Vector2 m_pivot;

		[SerializeField]
		private TextContainerAnchors m_anchorPosition;

		[SerializeField]
		private Rect m_rect;

		private bool m_isDefaultWidth;

		private bool m_isDefaultHeight;

		private bool m_isAutoFitting;

		private Vector3[] m_corners;

		private Vector3[] m_worldCorners;

		[SerializeField]
		private Vector4 m_margins;

		private RectTransform m_rectTransform;

		private static Vector2 k_defaultSize;

		private TextMeshPro m_textMeshPro;

		public bool hasChanged
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Vector2 pivot
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public TextContainerAnchors anchorPosition
		{
			get
			{
				return default(TextContainerAnchors);
			}
			set
			{
			}
		}

		public Rect rect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public Vector2 size
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float width
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float height
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool isDefaultWidth
		{
			get
			{
				return default(bool);
			}
		}

		public bool isDefaultHeight
		{
			get
			{
				return default(bool);
			}
		}

		public bool isAutoFitting
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Vector3[] corners
		{
			get
			{
				return null;
			}
		}

		public Vector3[] worldCorners
		{
			get
			{
				return null;
			}
		}

		public Vector4 margins
		{
			get
			{
				return default(Vector4);
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
		}

		public TextMeshPro textMeshPro
		{
			get
			{
				return null;
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnContainerChanged()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void SetRect(Vector2 size)
		{
		}

		private void UpdateCorners()
		{
		}

		private Vector2 GetPivot(TextContainerAnchors anchor)
		{
			return default(Vector2);
		}

		private TextContainerAnchors GetAnchorPosition(Vector2 pivot)
		{
			return default(TextContainerAnchors);
		}

		public TextContainer()
			: base()
		{
		}
	}
}
