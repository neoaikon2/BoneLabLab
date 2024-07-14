 
 
using UnityEditor;
using UnityEngine;

namespace SLZ.MarrowEditor
{
    public static class MarrowGUIStyles
    {
        private static GUIStyle _defaultButton;
        public static GUIStyle DefaultButton
        {
            get
            {
                if (_defaultButton == null)
                {
                    _defaultButton = new GUIStyle(EditorStyles.miniButton)
                    {
                        stretchWidth = false
                    };
                    var paddingOffset = _defaultButton.padding;
                    int offset = (int)(EditorGUIUtility.singleLineHeight / 4f);
                    paddingOffset.left += offset;
                    paddingOffset.right += offset;
                    paddingOffset.top = 1;
                    paddingOffset.bottom = 1;
                }

                return _defaultButton;
            }
        }

        private static GUIStyle _defaultIconButton;
        public static GUIStyle DefaultIconButton
        {
            get
            {
                if (_defaultIconButton == null)
                {
                    _defaultIconButton = new GUIStyle(EditorStyles.miniButton)
                    {
                        stretchWidth = false
                    };
                    _defaultIconButton.padding = new RectOffset(0, 0, 0, 0);
                }

                return _defaultIconButton;
            }
        }

        private static GUIStyle _bigIconButton;
        public static GUIStyle BigIconButton
        {
            get
            {
                if (_bigIconButton == null)
                {
                    _bigIconButton = new GUIStyle(EditorStyles.miniButton)
                    {
                        stretchWidth = false
                    };
                    _bigIconButton.padding = new RectOffset(2, 2, 2, 2);
                    _bigIconButton.fixedWidth = EditorGUIUtility.singleLineHeight * 3f;
                    _bigIconButton.fixedHeight = EditorGUIUtility.singleLineHeight * 2f;
                }

                return _bigIconButton;
            }
        }

        private static GUIStyle _listViewButton;
        public static GUIStyle ListViewButton
        {
            get
            {
                if (_listViewButton == null)
                {
                    _listViewButton = new GUIStyle(EditorStyles.miniButton)
                    {
                        stretchWidth = true,
                    };
                    _listViewButton.padding = new RectOffset(0, 0, 0, 0);
                }

                return _listViewButton;
            }
        }

        private static GUIStyle _skinnyIconButton;
        public static GUIStyle SkinnyIconButton
        {
            get
            {
                if (_skinnyIconButton == null)
                {
                    _skinnyIconButton = new GUIStyle(EditorStyles.miniButton)
                    {
                        stretchWidth = false
                    };
                    _skinnyIconButton.padding = new RectOffset((int)-EditorGUIUtility.singleLineHeight / 4, (int)-EditorGUIUtility.singleLineHeight / 4, 0, 0);
                }

                return _skinnyIconButton;
            }
        }

        private static GUIStyle _trimButton;
        public static GUIStyle TrimButton
        {
            get
            {
                if (_trimButton == null)
                {
                    _trimButton = new GUIStyle(EditorStyles.miniButton)
                    {
                        stretchWidth = false
                    };
                    _trimButton.padding = new RectOffset(6, 6, 0, 0);
                }

                return _trimButton;
            }
        }

        private static GUIStyle _boldFoldout;
        public static GUIStyle BoldFoldout
        {
            get
            {
                if (_boldFoldout == null)
                {
                    _boldFoldout = new GUIStyle(EditorStyles.foldout)
                    {
                        fontStyle = FontStyle.Bold
                    };
                }

                return _boldFoldout;
            }
        }

        private static GUIStyle _defaultRichText;
        public static GUIStyle DefaultRichText
        {
            get
            {
                if (_defaultRichText == null)
                {
                    _defaultRichText = new GUIStyle()
                    {
                        richText = true,
                        wordWrap = true,
                    };
                    _defaultRichText.padding = new RectOffset(0, 0, 0, 0);
                    if (EditorGUIUtility.isProSkin)
                    {
                        _defaultRichText.normal.textColor = new Color(0.8f, 0.8f, 0.8f);
                    }
                    else
                    {
                        _defaultRichText.normal.textColor = Color.black;
                    }
                }

                return _defaultRichText;
            }
        }
    }
}