using UnityEngine;
using UnityEngine.Events;

namespace SLZ.UI
{
	public class Control_UI_Profile : MonoBehaviour
	{
		[Space(10f)]
		public UnityEvent completionEvent;

		public Feedback_Tactile tactiler;

		private bool clickedLoad;

		public void COMPLETE()
		{
		}

		public Control_UI_Profile()
			: base()
		{
		}
	}
}
