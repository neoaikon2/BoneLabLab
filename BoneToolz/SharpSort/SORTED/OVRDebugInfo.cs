using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_debug_info")]
public class OVRDebugInfo : MonoBehaviour
{
	private GameObject debugUIManager;

	private GameObject debugUIObject;

	private GameObject riftPresent;

	private GameObject fps;

	private GameObject ipd;

	private GameObject fov;

	private GameObject height;

	private GameObject depth;

	private GameObject resolutionEyeTexture;

	private GameObject latencies;

	private GameObject texts;

	private string strRiftPresent;

	private string strFPS;

	private string strIPD;

	private string strFOV;

	private string strHeight;

	private string strDepth;

	private string strResolutionEyeTexture;

	private string strLatencies;

	private float updateInterval;

	private float accum;

	private int frames;

	private float timeLeft;

	private bool initUIComponent;

	private bool isInited;

	private float offsetY;

	private float riftPresentTimeout;

	private bool showVRVars;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void InitUIComponents()
	{
	}

	private void UpdateVariable()
	{
	}

	private void UpdateStrings()
	{
	}

	private void RiftPresentGUI(GameObject guiMainOBj)
	{
	}

	private void UpdateDeviceDetection()
	{
	}

	private GameObject VariableObjectManager(GameObject gameObject, string name, float posY, string str, int fontSize)
	{
		return null;
	}

	private GameObject ComponentComposition(GameObject GO)
	{
		return null;
	}

	private void UpdateIPD()
	{
	}

	private void UpdateEyeHeightOffset()
	{
	}

	private void UpdateEyeDepthOffset()
	{
	}

	private void UpdateFOV()
	{
	}

	private void UpdateResolutionEyeTexture()
	{
	}

	private void UpdateLatencyValues()
	{
	}

	private void UpdateFPS()
	{
	}
}
