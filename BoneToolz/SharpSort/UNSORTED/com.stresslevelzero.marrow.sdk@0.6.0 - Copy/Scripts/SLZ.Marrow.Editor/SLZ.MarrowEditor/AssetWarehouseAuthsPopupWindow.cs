 
using UnityEngine;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using SLZ.Marrow.Warehouse;
using System.Linq;

#if UNITY_EDITOR
namespace SLZ.MarrowEditor
{
    public class AssetWarehouseAuthsPopupWindow : PopupWindowContent
    {
        TreeViewState treeViewState;
        AssetWarehouseTreeView treeViewAW;
        private Vector2 toolScrollPos;
        int buttonsPerRow = 4;
        int padding = 5;
        Vector2 buttonSize = new Vector2(120, 20);
        public AssetWarehouseAuthsPopupWindow(AssetWarehouseTreeView treeViewAW)
        {
            this.treeViewAW = treeViewAW;
        }

        public override Vector2 GetWindowSize()
        {
            float winSizeFromCount = 10;
            if (treeViewAW.uniqueAuthors.Count > 9)
            {
                winSizeFromCount = treeViewAW.uniqueAuthors.Count;
            }

            return new Vector2((buttonSize.x * buttonsPerRow) + (padding * 5), ((winSizeFromCount / buttonsPerRow) * buttonSize.y) + (buttonSize.y * 4));
        }

        public override void OnGUI(Rect rect)
        {
            padding = 5;
            GUIStyle style = new GUIStyle();
            style.padding = new RectOffset(padding, padding, padding, padding);
            toolScrollPos = EditorGUILayout.BeginScrollView(toolScrollPos, false, false, GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            using (new GUILayout.VerticalScope(style))
            {
                EditorGUI.BeginChangeCheck();
                if (treeViewAW != null)
                {
                    int buttonCount = 0;
                    EditorGUILayout.BeginHorizontal();
                    GUILayout.Label("Authors: ", GUILayout.Width(65));
                    if (GUILayout.Button(new GUIContent("All", "Select All Authors"), MarrowGUIStyles.DefaultButton))
                    {
                        foreach (var kvp in treeViewAW.uniqueAuthors.ToArray())
                        {
                            treeViewAW.uniqueAuthors[kvp.Key] = true;
                        }
                    }

                    if (GUILayout.Button(new GUIContent("None", "Deselect All Authors"), MarrowGUIStyles.DefaultButton))
                    {
                        foreach (var kvp in treeViewAW.uniqueAuthors.ToArray())
                        {
                            treeViewAW.uniqueAuthors[kvp.Key] = false;
                        }
                    }

                    GUILayout.FlexibleSpace();
                    if (GUILayout.Button(new GUIContent("X", "Close Authors Window"), MarrowGUIStyles.DefaultButton))
                    {
                        editorWindow.Close();
                    }

                    EditorGUILayout.EndHorizontal();
                    foreach (var kvp in treeViewAW.uniqueAuthors.ToArray())
                    {
                        if (buttonCount % buttonsPerRow == 0)
                        {
                            EditorGUILayout.BeginHorizontal();
                        }

                        treeViewAW.uniqueAuthors[kvp.Key] = GUILayout.Toggle(treeViewAW.uniqueAuthors[kvp.Key], new GUIContent(kvp.Key.ToString(), "Filter by Author: " + kvp.Key.ToString()), MarrowGUIStyles.DefaultButton, GUILayout.Width(buttonSize.x), GUILayout.Height(buttonSize.y));
                        if (buttonCount % buttonsPerRow == buttonsPerRow - 1)
                        {
                            EditorGUILayout.EndHorizontal();
                        }

                        buttonCount++;
                    }

                    if (buttonCount % buttonsPerRow != 0 && buttonCount % buttonsPerRow > 4)
                    {
                        EditorGUILayout.EndHorizontal();
                    }
                    else
                    {
                        if (buttonCount == treeViewAW.uniqueAuthors.Count)
                        {
                            EditorGUILayout.EndHorizontal();
                        }
                    }
                }

                if (EditorGUI.EndChangeCheck())
                {
                    ApplyCrateFilters();
                }
            }

            EditorGUILayout.EndScrollView();
        }

        private void ApplyCrateFilters()
        {
            if (!treeViewAW.list)
            {
                RefreshTree();
                treeViewAW.CollapseAll();
                for (int t = 0; t < treeViewAW.orderedObjs.Count; t++)
                {
                    if (treeViewAW.orderedObjs[t] != null && treeViewAW.showAvatars && treeViewAW.orderedObjs[t].GetType() == typeof(AvatarCrate))
                    {
                        treeViewAW.FrameItem(t);
                    }

                    if (treeViewAW.orderedObjs[t] != null && treeViewAW.showLevels && treeViewAW.orderedObjs[t].GetType() == typeof(LevelCrate))
                    {
                        treeViewAW.FrameItem(t);
                    }

                    if (treeViewAW.orderedObjs[t] != null && treeViewAW.showSpawnables && treeViewAW.orderedObjs[t].GetType() == typeof(SpawnableCrate))
                    {
                        treeViewAW.FrameItem(t);
                    }
                }

                treeViewAW.ExpandAll();
            }
            else
            {
                RefreshTree();
                treeViewAW.ExpandAll();
            }

            if (!EditorApplication.isPlaying)
            {
                StoreAWState();
            }
        }

        private void StoreAWState()
        {
            EditorPrefs.SetBool("awSettingsListOrTree", treeViewAW.list);
            EditorPrefs.SetBool("awSettingsShowLevels", treeViewAW.showLevels);
            EditorPrefs.SetBool("awSettingsShowAvatars", treeViewAW.showAvatars);
            EditorPrefs.SetBool("awSettingsShowSpawnabes", treeViewAW.showSpawnables);
            EditorPrefs.SetBool("awSettingsShowDatacards", treeViewAW.showDataCards);
            string selIDString = "";
            foreach (int selID in treeViewAW.state.selectedIDs)
            {
                selIDString += selID.ToString() + ",";
            }

            if (selIDString != "")
            {
                selIDString = selIDString.Remove(selIDString.Length - 1);
            }

            EditorPrefs.SetString("awSettingsSelectedIDs", selIDString);
        }

        private void RefreshTree()
        {
            if (treeViewAW != null)
            {
                treeViewAW.Reload();
            }
        }
    }
}
#endif
