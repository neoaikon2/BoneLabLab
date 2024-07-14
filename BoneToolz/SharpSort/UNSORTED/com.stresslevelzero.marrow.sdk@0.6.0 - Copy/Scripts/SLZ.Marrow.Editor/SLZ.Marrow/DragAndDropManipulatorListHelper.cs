using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace SLZ.Marrow
{
    public class DragAndDropManipulatorListHelper : PointerManipulator
    {
        Label dropLabel;
        public Object[] droppedObjects = null;
        string assetPath = string.Empty;
        public DragAndDropManipulatorListHelper(VisualElement root)
        {
            target = root.Q<VisualElement>(className: "drop-area");
            dropLabel = root.Q<Label>(className: "drop-area__label");
        }

        protected override void RegisterCallbacksOnTarget()
        {
            target.RegisterCallback<PointerDownEvent>(OnPointerDown);
            target.RegisterCallback<DragEnterEvent>(OnDragEnter);
            target.RegisterCallback<DragLeaveEvent>(OnDragLeave);
            target.RegisterCallback<DragUpdatedEvent>(OnDragUpdate);
            target.RegisterCallback<DragPerformEvent>(OnDragPerform);
        }

        protected override void UnregisterCallbacksFromTarget()
        {
            target.UnregisterCallback<PointerDownEvent>(OnPointerDown);
            target.UnregisterCallback<DragEnterEvent>(OnDragEnter);
            target.UnregisterCallback<DragLeaveEvent>(OnDragLeave);
            target.UnregisterCallback<DragUpdatedEvent>(OnDragUpdate);
            target.UnregisterCallback<DragPerformEvent>(OnDragPerform);
        }

        void OnPointerDown(PointerDownEvent _)
        {
            if (droppedObjects != null)
            {
                DragAndDrop.PrepareStartDrag();
                DragAndDrop.objectReferences = droppedObjects;
                if (assetPath != string.Empty)
                {
                    DragAndDrop.paths = new[]
                    {
                        assetPath
                    };
                }
                else
                {
                    DragAndDrop.paths = new string[]
                    {
                    };
                }

                DragAndDrop.StartDrag(string.Empty);
            }
        }

        void OnDragEnter(DragEnterEvent _)
        {
            var draggedName = string.Empty;
            if (DragAndDrop.paths.Length > 0)
            {
                assetPath = DragAndDrop.paths[0];
                var splitPath = assetPath.Split('/');
                draggedName = splitPath[splitPath.Length - 1];
            }
            else if (DragAndDrop.objectReferences.Length > 0)
            {
                draggedName = DragAndDrop.objectReferences[0].name;
            }

            dropLabel.text = $"Dropping '{draggedName}'...";
            target.AddToClassList("drop-area--dropping");
        }

        void OnDragLeave(DragLeaveEvent _)
        {
            assetPath = string.Empty;
            droppedObjects = null;
            dropLabel.text = "Drag an asset here...";
            target.RemoveFromClassList("drop-area--dropping");
        }

        void OnDragUpdate(DragUpdatedEvent _)
        {
            DragAndDrop.visualMode = DragAndDropVisualMode.Generic;
        }

        void OnDragPerform(DragPerformEvent _)
        {
            droppedObjects = DragAndDrop.objectReferences;
            string draggedName = "";
            if (assetPath != string.Empty)
            {
                var splitPath = assetPath.Split('/');
                draggedName = splitPath[splitPath.Length - 1];
            }
            else
            {
                foreach (var droppedObject in droppedObjects)
                {
                    draggedName += droppedObject.name;
                }
            }

            target.RemoveFromClassList("drop-area--dropping");
        }
    }
}