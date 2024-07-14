#if UNITY_EDITOR
using SLZ.Marrow.Warehouse;
 
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
    public class EditorPreviewMeshGizmo : EditorMeshGizmo
    {
        public static EditorPreviewMeshGizmo Draw(string id, GameObject targetGameObject, SpawnableCrateReference crateReference, Material material, bool hidePreviewMesh = false, bool hideBounds = false, bool showInPlayMode = false)
        {
            Mesh previewMesh = null;
            Bounds bounds = default;
            if (!Application.isPlaying)
            {
                SpawnableCrate crate = crateReference?.Crate;
                if (!hidePreviewMesh)
                {
                    if (crateReference != null && crate != null && crate.PreviewMesh != null)
                    {
                        var editorAsset = crate.PreviewMesh.EditorAsset;
                        if (editorAsset != null)
                        {
                            previewMesh = editorAsset;
                        }
                        else if (crate.PreviewMesh.Asset != null)
                        {
                            previewMesh = crate.PreviewMesh.Asset;
                        }
                        else if (crate.PreviewMesh.Asset == null)
                        {
                            PreviewMeshLoadQueue.QueueLoadMesh(crate.PreviewMesh);
                        }
                        else
                        {
                            previewMesh = MarrowSDK.VoidMesh;
                        }
                    }
                    else
                    {
                        previewMesh = MarrowSDK.VoidMesh;
                    }
                }

                if (hideBounds)
                {
                    bounds = default;
                }
                else if (crateReference != null && crate != null)
                {
                    bounds = crate.ColliderBounds;
                }
                else if (previewMesh == MarrowSDK.VoidMesh)
                {
                    bounds = MarrowSDK.VoidMesh.bounds;
                }
            }

            return Draw<EditorPreviewMeshGizmo>(id, targetGameObject, previewMesh, material, bounds, showInPlayMode);
        }
    }
}
#endif
