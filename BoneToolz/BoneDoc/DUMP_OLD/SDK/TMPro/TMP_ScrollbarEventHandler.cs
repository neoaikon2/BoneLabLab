using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler
	{
		public bool isSelected;

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		public TMP_ScrollbarEventHandler()
			: base()
		{
		}
	}
}
