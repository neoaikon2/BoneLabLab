using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using UnityEditor.SceneManagement;

public class GUIDUpdater : EditorWindow
{
    // Variables to store file path, GUID mapping, scroll position, and counts
    private string filePath = "";
    private Dictionary<string, string> guidMapping = new Dictionary<string, string>();
    private Vector2 scrollPosition = Vector2.zero;
    private int totalGUIDsToScan;
    private int scannedGUIDsCount;
    private string currentFile = "";

    // MenuItem to display the window under the StressLevelZero menu
    [MenuItem("StressLevelZero/BoneToolz/Splint2")]
    public static void ShowWindow()
    {
        GetWindow(typeof(GUIDUpdater), false, "BoneToolz GUID Updater");
    }

    // GUI setup
    void OnGUI()
    {
        // Description text
        GUILayout.TextArea("Takes the guidmap.txt file created by BoneDoc and applies the GUID updates across all assets in the project (Will take some time depending on the size of your project! WARNING! This action is not reversible! It is recommended you back up your assets before running this action!");

        // File path selection
        GUILayout.Label("GuidMap: ", EditorStyles.boldLabel);
        GUILayout.BeginHorizontal();
        // Text field for displaying and editing the file path
        filePath = GUILayout.TextField(filePath, GUILayout.ExpandWidth(false));
        // Browse button to open a file selection dialog
        if (GUILayout.Button("Browse", GUILayout.ExpandWidth(false)))
        {
            // Open file dialog and parse the selected file
            filePath = EditorUtility.OpenFilePanel("Select BoneDoc Guid Map", "", "txt");
            ParseGUIDMapping();
        }
        GUILayout.EndHorizontal();

        // Display GUID tables
        EditorGUILayout.Separator();
        GUILayout.Space(10);
        DisplayGUIDTables();
        GUILayout.Space(10);

        // Update GUIDs button
        EditorGUILayout.Separator();
        EditorGUILayout.LabelField($"Total GUIDs to Scan: {totalGUIDsToScan}");
        if (GUILayout.Button("Update GUIDs"))
        {
            // Update GUIDs for asset and prefab files
            UpdateGUIDs("*.asset");
            UpdateGUIDs("*.prefab");
            EditorUtility.DisplayDialog("BoneToolz GUID Updater", "GUIDs updated successfully!", "OK");
        }
    }

    // Display Old and New GUIDs side by side
    private void DisplayGUIDTables()
    {
        GUILayout.Label("GUID Mapping", EditorStyles.boldLabel);

        EditorGUILayout.BeginHorizontal();

        // Display Old GUIDs
        DisplayGuidList(guidMapping.Keys, "Old GUIDs");
        // Display New GUIDs
        DisplayGuidList(guidMapping.Values, "New GUIDs");

        EditorGUILayout.EndHorizontal();
    }

    // Display a list of GUIDs with a specified label
    private void DisplayGuidList(IEnumerable<string> guids, string label)
    {
        EditorGUILayout.BeginVertical();
        GUILayout.Label(label, EditorStyles.boldLabel);
        // Scroll view for displaying a list of GUIDs
        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.Width(position.width / 2 - 10), GUILayout.Height(position.height - 180));
        foreach (var guid in guids)
        {
            GUILayout.Label(guid);
        }
        EditorGUILayout.EndScrollView();
        EditorGUILayout.EndVertical();
    }

    // Parse the guidmap.txt file
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
            // Clear the existing GUID mapping
            guidMapping.Clear();

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

    // Update GUIDs in asset and prefab files
    private void UpdateGUIDs(string fileType)
    {
        // Get a list of files with the specified file type in the project
        string[] guidFiles = Directory.GetFiles(Application.dataPath, fileType, SearchOption.AllDirectories);

        // Display progress bar
        EditorUtility.DisplayProgressBar("Updating GUIDs", $"Scanning {fileType} files...", 0f);

        // Iterate over each file and update GUIDs
        foreach (var guidfile in guidFiles)
        {
            string fileRelativePath = "Assets" + guidfile.Substring(Application.dataPath.Length);
            currentFile = fileRelativePath;

            string fileContent = File.ReadAllText(guidfile);

            // Iterate over each old GUID in the mapping and replace with the new GUID
            foreach (var entry in guidMapping)
            {
                fileContent = fileContent.Replace(entry.Key, entry.Value);
            }

            // Write the updated content back to the file
            File.WriteAllText(guidfile, fileContent);
            // Import the asset to apply changes
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
