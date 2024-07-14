using System.Collections.Generic;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_semantic_classification")]
[RequireComponent(typeof(OVRSceneAnchor))]
[DisallowMultipleComponent]
public class OVRSemanticClassification : MonoBehaviour, IOVRSceneComponent
{
	public const char LabelSeparator = ',';

	private readonly List<string> _labels;

	public IReadOnlyList<string> Labels => null;

	public bool Contains(string label)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void IOVRSceneComponent_002EInitialize()
	{
	}

	internal static string ValidateAndUpgradeLabels(string labels)
	{
		return null;
	}

	public void Initialize()
	{
		throw new System.NotImplementedException();
	}
}
