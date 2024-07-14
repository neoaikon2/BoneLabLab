using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_raycaster")]
public class OVRRaycaster : GraphicRaycaster, IPointerEnterHandler, IEventSystemHandler
{
	private struct RaycastHit
	{
		public Graphic graphic;

		public Vector3 worldPos;

		public bool fromMouse;
	}

	[Tooltip("A world space pointer for this canvas")]
	public GameObject pointer;

	public int sortOrder;

	[NonSerialized]
	private Canvas m_Canvas;

	[NonSerialized]
	private OVRRayTransformer m_RayTransformer;

	[NonSerialized]
	private List<RaycastHit> m_RaycastResults;

	[NonSerialized]
	private static readonly List<RaycastHit> s_SortedGraphics;

	private Canvas canvas => null;

	private OVRRayTransformer rayTransformer => null;

	public override Camera eventCamera => null;

	public override int sortOrderPriority => 0;

	protected OVRRaycaster()
	{
	}

	protected override void Start()
	{
	}

	private void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList, Ray ray, bool checkForBlocking)
	{
	}

	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	public void RaycastPointer(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	private void GraphicRaycast(Canvas canvas, OVRRayTransformer rayTransformer, Ray ray, List<RaycastHit> results)
	{
	}

	public Vector2 GetScreenPosition(RaycastResult raycastResult)
	{
		return default(Vector2);
	}

	private static bool RayIntersectsRectTransform(RectTransform rectTransform, Ray ray, out Vector3 worldPos)
	{
		worldPos = default(Vector3);
		return false;
	}

	public bool IsFocussed()
	{
		return false;
	}

	public void OnPointerEnter(PointerEventData e)
	{
	}
}
