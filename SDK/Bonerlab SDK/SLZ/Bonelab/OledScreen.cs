using UnityEngine;

namespace SLZ.Bonelab
{
	public class OledScreen : MonoBehaviour
	{
		[SerializeField]
		[Header("Electronic Ref")]
		private Powerable m_Electronic;

		[Header("Renderer")]
		[SerializeField]
		private Renderer m_Renderer;

		private void Awake()
		{
		}

		private void M_DisplayIcon()
		{
		}

		private void M_SetShader(bool on)
		{
		}
	}
}
