using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_controller_helper")]
public class OVRControllerHelper : MonoBehaviour
{
	private enum ControllerType
	{
		QuestAndRiftS = 1,
		Rift = 2,
		Quest2 = 3,
		TouchPro = 4,
		TouchPlus = 5
	}

	public GameObject m_modelOculusTouchQuestAndRiftSLeftController;

	public GameObject m_modelOculusTouchQuestAndRiftSRightController;

	public GameObject m_modelOculusTouchRiftLeftController;

	public GameObject m_modelOculusTouchRiftRightController;

	public GameObject m_modelOculusTouchQuest2LeftController;

	public GameObject m_modelOculusTouchQuest2RightController;

	public GameObject m_modelMetaTouchProLeftController;

	public GameObject m_modelMetaTouchProRightController;

	public GameObject m_modelMetaTouchPlusLeftController;

	public GameObject m_modelMetaTouchPlusRightController;

	public OVRInput.Controller m_controller;

	public OVRInput.InputDeviceShowState m_showState;

	public bool showWhenHandsArePoweredByNaturalControllerPoses;

	private Animator m_animator;

	private GameObject m_activeController;

	private bool m_controllerModelsInitialized;

	private bool m_hasInputFocus;

	private bool m_hasInputFocusPrev;

	private ControllerType activeControllerType;

	private bool m_prevControllerConnected;

	private bool m_prevControllerConnectedCached;

	private OVRInput.ControllerInHandState m_prevControllerInHandState;

	private void Start()
	{
	}

	private void InitializeControllerModels()
	{
	}

	private void Update()
	{
	}

	public void InputFocusAquired()
	{
	}

	public void InputFocusLost()
	{
	}
}
