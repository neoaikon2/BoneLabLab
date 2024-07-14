using System.IO;
using SLZ.Marrow;
using UnityEditor;
using UnityEditor.SceneTemplate;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SLZ.MarrowEditor
{
    public class MarrowSceneTemplatePipeline : ISceneTemplatePipeline
    {
        public bool IsValidTemplateForInstantiation(SceneTemplateAsset sceneTemplateAsset)
        {
            return true;
        }

        public void BeforeTemplateInstantiation(SceneTemplateAsset sceneTemplateAsset, bool isAdditive, string sceneName)
        {
        }

        public void AfterTemplateInstantiation(SceneTemplateAsset sceneTemplateAsset, Scene scene, bool isAdditive, string sceneName)
        {
            if (sceneName.Contains("_MarrowAssets") && sceneName.Contains("Levels"))
            {
                if (sceneTemplateAsset == null)
                {
                    sceneTemplateAsset = AssetDatabase.LoadAssetAtPath<SceneTemplateAsset>(MarrowSDK.GetPackagePath("Editor/Assets/Scene Template/Default Marrow SceneTemplate.scenetemplate"));
                }

                var sceneDirPath = sceneName.Split(".unity")[0];
                foreach (var sceneTempDependency in sceneTemplateAsset.dependencies)
                {
                    if (sceneTempDependency.instantiationMode == TemplateInstantiationMode.Clone)
                    {
                        var assetPath = AssetDatabase.GetAssetPath(sceneTempDependency.dependency);
                        assetPath = Path.Combine(sceneDirPath, Path.GetFileName(assetPath));
                        var newFileName = Path.GetFileName(assetPath);
                        if (newFileName.StartsWith("Marrow Template"))
                            newFileName = newFileName.Replace("Marrow Template", scene.name);
                        else if (newFileName.StartsWith("Template"))
                            newFileName = newFileName.Replace("Marrow Template", scene.name);
                        AssetDatabase.RenameAsset(assetPath, newFileName);
                    }
                }

                var lightSettingsPath = Path.Combine(sceneDirPath, "Template Light Settings.lighting");
                AssetDatabase.RenameAsset(lightSettingsPath, $"{scene.name} Light Settings.lighting");
            }
        }
    }
}