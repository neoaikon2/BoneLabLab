using System;
using System.Reflection;
using SLZ.Marrow;
 
using SLZ.MarrowEditor;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[InitializeOnLoad]
public static class AWToolbarButton
{
    static Type m_toolbarType = typeof(Editor).Assembly.GetType("UnityEditor.Toolbar");
    static ScriptableObject m_currentToolbar;
    public static GUIStyle iconButtonStyle;
    public static Action OnToolbarGUILeft;
    private static GUIContent iconButton;
    private static GUIStyle iconStyle;
    private static Texture2D spawnableIcon;
    private static FieldInfo mRootFieldInfo;
    static AWToolbarButton()
    {
        EditorApplication.update -= OnUpdate;
        EditorApplication.update += OnUpdate;
        Type toolbarType = typeof(Editor).Assembly.GetType("UnityEditor.Toolbar");
        string fieldName = "k_ToolCount";
        FieldInfo toolIcons = toolbarType.GetField(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        OnToolbarGUILeft = GUILeft;
    }

    public static void GUILeft()
    {
        GUILayout.BeginHorizontal();
        OnToolbarGUI();
        GUILayout.EndHorizontal();
    }

    public static void OnToolbarGUI()
    {
        GUILayout.Space(4);
        if (iconButton == null)
        {
            string buttonIconPath = MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/hunter.png");
            spawnableIcon = EditorGUIUtility.Load(buttonIconPath) as Texture2D;
            iconButton = new GUIContent(spawnableIcon, "Asset Warehouse");
        }

        if (iconButtonStyle == null)
        {
            iconButtonStyle = new GUIStyle("Command")
            {
                fontSize = 16,
                alignment = TextAnchor.MiddleCenter,
                imagePosition = ImagePosition.ImageAbove,
                fontStyle = FontStyle.Bold,
                fixedHeight = 20,
                padding = new RectOffset(1, 1, 1, 1)
            };
        }

        if (GUILayout.Button(iconButton, iconButtonStyle))
        {
            AssetWarehouseWindow.ShowWindow();
        }
    }

    static void OnUpdate()
    {
        if (m_currentToolbar == null)
        {
            var toolbars = Resources.FindObjectsOfTypeAll(m_toolbarType);
            m_currentToolbar = toolbars.Length > 0 ? (ScriptableObject)toolbars[0] : null;
            if (m_currentToolbar != null)
            {
                if (mRootFieldInfo == null)
                {
                    mRootFieldInfo = m_currentToolbar.GetType().GetField("m_Root", BindingFlags.NonPublic | BindingFlags.Instance);
                }

                var rawRoot = mRootFieldInfo.GetValue(m_currentToolbar);
                var mRoot = rawRoot as VisualElement;
                RegisterCallback("ToolbarZoneLeftAlign", OnToolbarGUILeft);
                void RegisterCallback(string root, Action cb)
                {
                    var toolbarZone = mRoot.Q(root);
                    var parent = new VisualElement()
                    {
                        style =
                        {
                            flexGrow = 1,
                            flexDirection = FlexDirection.Row,
                        }
                    };
                    var container = new IMGUIContainer();
                    container.style.flexGrow = 1;
                    container.onGUIHandler += () =>
                    {
                        cb?.Invoke();
                    };
                    parent.Add(container);
                    toolbarZone.Add(parent);
                }
            }
        }
    }
}