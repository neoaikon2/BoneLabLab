using System.Collections.Generic;
using UnityEngine;

public class OVRResources : MonoBehaviour
{
	private static AssetBundle resourceBundle;

	private static List<string> assetNames;

	public static Object Load(string path)
	{
		return null;
	}

	public static T Load<T>(string path) where T : Object
	{
		return null;
	}

	public static void SetResourceBundle(AssetBundle bundle)
	{
	}
}
