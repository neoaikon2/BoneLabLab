using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_grid_cube")]
public class OVRGridCube : MonoBehaviour
{
	public KeyCode GridKey;

	private GameObject CubeGrid;

	private bool CubeGridOn;

	private bool CubeSwitchColorOld;

	private bool CubeSwitchColor;

	private int gridSizeX;

	private int gridSizeY;

	private int gridSizeZ;

	private float gridScale;

	private float cubeScale;

	private OVRCameraRig CameraController;

	private void Update()
	{
	}

	public void SetOVRCameraController(ref OVRCameraRig cameraController)
	{
	}

	private void UpdateCubeGrid()
	{
	}

	private void CreateCubeGrid()
	{
	}

	private void CubeGridSwitchColor(bool CubeSwitchColor)
	{
	}
}
