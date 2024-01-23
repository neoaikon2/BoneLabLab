using System.IO;
using UnityEngine;
using UnityEditor;
using SLZ.Serialize;
using SLZ.Marrow.Warehouse;
using Newtonsoft.Json.Linq;

public static class PalletToJsonEditor
{
	[MenuItem("Stress Level Zero/BoneToolz/Pallet to JSON")]
	private static void ConvertPalletToJson()
	{
		// Get the selected object in the project window
		Object selectedObject = Selection.activeObject;

		if (selectedObject != null && selectedObject is Pallet)
		{			
			// Assuming the Pallet component is attached to the GameObject
			Pallet pallet = (Pallet)selectedObject;

			if (pallet != null)
			{
				string json = PackIntoJson(pallet);

				// Copy the JSON to the clipboard
				EditorGUIUtility.systemCopyBuffer = json;

				Debug.Log("Pallet converted to JSON and copied to clipboard:\n" + json);
			}
			else
			{
				Debug.LogWarning("Selected GameObject does not have a Pallet component.");
			}
		}
		else
		{
			Debug.LogWarning("Please select a GameObject with the Pallet component in the project window.");
		}
	}

	private static string PackIntoJson(Pallet pallet)
	{
		string json = "";
		if (ValidatePallet(pallet))
		{
			var store = new ObjectStore();
			store.TryPack(pallet, out JObject obj);
			json = obj.ToString();
		}

		return json;
	}

	private static bool ValidatePallet(Pallet pallet)
	{
		// Implement your validation logic here
		// Return true if the pallet is valid, otherwise return false
		return pallet is Pallet; // Example: Assuming a valid pallet has been provided
	}
}