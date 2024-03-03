using UnityEditor;
using UnityEngine;
using System.IO;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Warehouse;
using SLZ.Serialize;
using System;
using Object = UnityEngine.Object;

public class PalletExportToJson : MonoBehaviour
{
#if UNITY_EDITOR
	[MenuItem("Assets/Pallet to JSON")]
	private static void ConvertPalletToJson()
	{
		// Get the selected asset in the project window
		Object selectedObject = Selection.activeObject;

		if (selectedObject != null && selectedObject is Pallet)
		{
			Pallet pallet = (Pallet)selectedObject;

			if (pallet != null)
			{
				// Copy the JSON to the clipboard
				EditorGUIUtility.systemCopyBuffer = PalletPacker.PackIntoJson(pallet);

				Debug.Log("Pallet converted to JSON and copied to clipboard!");
			}
			else
			{
				Debug.LogWarning("Selected asset is not a valid Pallet.");
			}
		}
		else
		{
			Debug.LogWarning("Please select a Pallet asset in the project window.");
		}
	}
#endif
}
