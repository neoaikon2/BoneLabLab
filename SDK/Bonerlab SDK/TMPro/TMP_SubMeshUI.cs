using System;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	[RequireComponent(typeof(CanvasRenderer))]
	[ExecuteAlways]
	public class TMP_SubMeshUI : MaskableGraphic
	{
		[SerializeField]
		private TMP_FontAsset m_fontAsset;

		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset;

		[SerializeField]
		private Material m_material;

		[SerializeField]
		private Material m_sharedMaterial;

		private Material m_fallbackMaterial;

		private Material m_fallbackSourceMaterial;

		[SerializeField]
		private bool m_isDefaultMaterial;

		[SerializeField]
		private float m_padding;

		private Mesh m_mesh;

		[SerializeField]
		private TextMeshProUGUI m_TextComponent;

		[NonSerialized]
		private bool m_isRegisteredForEvents;

		private bool m_materialDirty;

		[SerializeField]
		private int m_materialReferenceIndex;

		private Transform m_RootCanvasTransform;

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

		public TMP_SpriteAsset spriteAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Texture mainTexture
		{
			get
			{
				return null;
			}
		}

		public override Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material sharedMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material fallbackMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material fallbackSourceMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Material materialForRendering
		{
			get
			{
				return null;
			}
		}

		public bool isDefaultMaterial
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float padding
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Mesh mesh
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
		}

		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference)
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		public float GetPaddingForMaterial()
		{
			return default(float);
		}

		public float GetPaddingForMaterial(Material mat)
		{
			return default(float);
		}

		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
		{
		}

		public override void SetAllDirty()
		{
		}

		public override void SetVerticesDirty()
		{
		}

		public override void SetLayoutDirty()
		{
		}

		public override void SetMaterialDirty()
		{
		}

		public void SetPivotDirty()
		{
		}

		private Transform GetRootCanvasTransform()
		{
			return null;
		}

		public override void Cull(Rect clipRect, bool validRect)
		{
		}

		protected override void UpdateGeometry()
		{
		}

		public override void Rebuild(CanvasUpdate update)
		{
		}

		public void RefreshMaterial()
		{
		}

		protected override void UpdateMaterial()
		{
		}

		public override void RecalculateClipping()
		{
		}

		private Material GetMaterial()
		{
			return null;
		}

		private Material GetMaterial(Material mat)
		{
			return null;
		}

		private Material CreateMaterialInstance(Material source)
		{
			return null;
		}

		private Material GetSharedMaterial()
		{
			return null;
		}

		private void SetSharedMaterial(Material mat)
		{
		}

		public TMP_SubMeshUI()
			: base()
		{
		}
	}
}
