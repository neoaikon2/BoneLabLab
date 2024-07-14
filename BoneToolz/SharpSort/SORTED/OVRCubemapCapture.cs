using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_cubemap_capture")]
public class OVRCubemapCapture : MonoBehaviour
{
	public bool autoTriggerAfterLaunch;

	public float autoTriggerDelay;

	private float autoTriggerElapse;

	public KeyCode triggeredByKey;

	public string pathName;

	public int cubemapSize;

	private void Update()
	{
	}

	public static void TriggerCubemapCapture(Vector3 capturePos, int cubemapSize = 2048, string pathName = null)
	{
	}

	public static void RenderIntoCubemap(Camera ownerCamera, Cubemap outCubemap)
	{
	}

	public static bool SaveCubemapCapture(Cubemap cubemap, string pathName = null)
	{
		return false;
	}
}
