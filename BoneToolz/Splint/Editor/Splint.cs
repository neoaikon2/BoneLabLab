using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using UnityEditor.SceneManagement;

public class GUIDUpdater : EditorWindow
{
	private string filePath = "";
	private Dictionary<string, string> guidMapping = new Dictionary<string, string>();
	private Vector2 scrollPosition = Vector2.zero;
	private int totalGUIDsToScan = 0;
	private int scannedGUIDsCount = 0;
	private string currentFile = "";

	[MenuItem("StressLevelZero/BoneToolz/Splint")]
	public static void ShowWindow()
	{
		GetWindow(typeof(GUIDUpdater), false, "BoneToolz GUID Updater");
	}

	void OnGUI()
	{
		GUILayout.TextArea("Takes the guidmap.txt file created by BoneDoc and applies the GUID updates across all assets in the project (Will take some time depending on the size of your project! WARNING! This action is not reversable! It is recommended you back up your assets before running this action!");
		
		GUILayout.Label("GuidMap: ", EditorStyles.boldLabel);
		GUILayout.BeginHorizontal();
		GUILayout.TextField(filePath, GUILayout.ExpandWidth(true));
		if (GUILayout.Button("Browse", GUILayout.ExpandWidth(false)))
		{
			filePath = EditorUtility.OpenFilePanel("Select BoneDoc Guid Map", "", "txt");
			ParseGUIDMapping();
		}
		GUILayout.EndHorizontal();

		EditorGUILayout.Separator();
		GUILayout.Space(10);
		DisplayGUIDTables();
		GUILayout.Space(10);

		EditorGUILayout.Separator();
		EditorGUILayout.LabelField($"Total GUIDs to Scan: {totalGUIDsToScan}");
		if (GUILayout.Button("Update GUIDs"))
		{
			UpdateGUIDs("*.asset");
			UpdateGUIDs("*.prefab");
			EditorUtility.DisplayDialog("BoneToolz GUID Updater", "GUIDs updated successfully!", "OK");
		}
	}

	private void DisplayGUIDTables()
	{
		GUILayout.Label("GUID Mapping", EditorStyles.boldLabel);

		EditorGUILayout.BeginHorizontal();

		EditorGUILayout.BeginVertical();
		GUILayout.Label("Old GUIDs", EditorStyles.boldLabel);
		scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.Width(position.width / 2 - 10), GUILayout.Height(position.height - 180));
		foreach (var oldGuid in guidMapping.Keys)
		{
			GUILayout.Label(oldGuid);
		}
		EditorGUILayout.EndScrollView();
		EditorGUILayout.EndVertical();

		EditorGUILayout.BeginVertical();
		GUILayout.Label("New GUIDs", EditorStyles.boldLabel);
		scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.Width(position.width / 2 - 10), GUILayout.Height(position.height - 180));
		foreach (var newGuid in guidMapping.Values)
		{
			GUILayout.Label(newGuid);
		}
		EditorGUILayout.EndScrollView();
		EditorGUILayout.EndVertical();

		EditorGUILayout.EndHorizontal();
	}

	/*
	 * Parses the guidmap.txt file created by BoneToolz BoneDoc, allowing you to fix broken assets after a SDK update
	 */
	private void ParseGUIDMapping()
	{
		if (string.IsNullOrEmpty(filePath))
		{
			Debug.LogError("Please select a valid file path.");
			return;
		}

		try
		{
			// Read all the lines from the guidmap.txt file
			string[] fileLines = File.ReadAllLines(filePath);
			// Loop through each line...
			foreach (var line in fileLines)
			{
				// Remove extra characters and split into parts
				string trimmedLine = line.Replace("{", "").Replace("}", "").Replace("'", "").Replace("\"", "").Replace(",", "");

				// Split by the ':' delimiter
				string[] parts = trimmedLine.Split(':');

				// Parse these entries
				string oldGuid = parts[0].Trim().TrimStart('\'');
				string newGuid = parts[1].TrimStart('\'').Trim();
				guidMapping[oldGuid] = newGuid;				
			}

			// Update the totalGUIDsToScan count
			totalGUIDsToScan = guidMapping.Count;
		}
		catch (System.Exception e)
		{
			Debug.LogError($"Error parsing GUID mapping file: {e.Message}");
		}
	}

	/*
	 * Uses the GUIDs from guidmap.txt to scan through all the files based on fileType in the project, if any of these files contain
	 * an old guid it gets updated to the new one; fixing the 'Missing MonoScript' errors.
	 * 
	 * fileType - A string containing the type of file to scan for (I.E. "*.asset" or "*.prefab")
	 */
	private void UpdateGUIDs(string fileType)
	{
		string[] guidFiles = Directory.GetFiles(Application.dataPath, fileType, SearchOption.AllDirectories);

		// Display progress bar
		EditorUtility.DisplayProgressBar("Updating GUIDs", $"Scanning {fileType} files...", 0f);

		foreach (var guidfile in guidFiles)
		{
			string fileRelativePath = "Assets" + guidfile.Substring(Application.dataPath.Length);
			currentFile = fileRelativePath;

			string fileContent = File.ReadAllText(guidfile);

			foreach (var oldGuid in guidMapping.Keys)
			{
				fileContent = fileContent.Replace(oldGuid, guidMapping[oldGuid]);
			}

			File.WriteAllText(guidfile, fileContent);
			AssetDatabase.ImportAsset(fileRelativePath);

			// Update progress
			scannedGUIDsCount++;
			float progress = (float)scannedGUIDsCount / totalGUIDsToScan;
			EditorUtility.DisplayProgressBar("Updating GUIDs", $"Updating {currentFile}", progress);
		}		

		// Refresh the scene to apply changes
		EditorSceneManager.MarkAllScenesDirty();

		// Clear progress bar
		EditorUtility.ClearProgressBar();
	}
}
