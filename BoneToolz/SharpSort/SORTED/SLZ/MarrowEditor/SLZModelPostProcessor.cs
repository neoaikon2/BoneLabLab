using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace SLZ.MarrowEditor
{
    public class ModelPoseSpacePostProcessor : AssetPostprocessor
    {
        private void OnPostprocessModel(GameObject gameObject)
        {
            if (assetPath.EndsWith(".fbx") == false && assetPath.EndsWith(".FBX") == false)
                return;
            SkinnedMeshRenderer[] skinnedMeshRenderers = gameObject.GetComponentsInChildren<SkinnedMeshRenderer>();
            foreach (SkinnedMeshRenderer skinnedMeshRenderer in skinnedMeshRenderers)
            {
                if (skinnedMeshRenderer != null)
                {
                    ProcessMesh(skinnedMeshRenderer.sharedMesh);
                }
            }
        }

        private void ProcessMesh(Mesh mesh)
        {
            mesh.SetUVs(1, GeneratePosespace(mesh));
        }

        Vector3[] GeneratePosespace(Mesh source)
        {
            var outUV2 = new List<Vector3>();
            for (var i = 0; i < source.vertices.Length; i += 1)
            {
                var v1 = source.vertices[i];
                outUV2.Add(new Vector3(v1.x, v1.y, v1.z));
            }

            return outUV2.ToArray();
        }
    }
}