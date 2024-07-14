using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_progress_indicator")]
public class OVRProgressIndicator : MonoBehaviour
{
	public MeshRenderer progressImage;

	[Range(0f, 1f)]
	public float currentProgress;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
