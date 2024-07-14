#if UNITY_EDITOR
using System;
 
 
 
using System.Reflection;
using Cysharp.Threading.Tasks;
 
 
using SLZ.Marrow.Warehouse;
using UnityEditor;
 
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.LowLevel;
using UnityEngine.ResourceManagement.Util;

 

namespace SLZ.MarrowEditor
{
    public class AssetWarehousePlaymodeHelper : ScriptableSingleton<AssetWarehousePlaymodeHelper>, ISerializationCallbackReceiver
    {
        [Serializable]
        public struct CustomAsset
        {
        }

        private static FieldInfo addressablesInstanceField;
        private static ConstructorInfo addressablesConstructor;
        [InitializeOnLoadMethod]
        static void Initialize()
        {
            EditorApplication.playModeStateChanged += PlaymodeChanged;
        }

        private static void PlaymodeChanged(PlayModeStateChange stateChange)
        {
            switch (stateChange)
            {
                case PlayModeStateChange.ExitingEditMode:
                    ExitingEditMode();
                    break;
                case PlayModeStateChange.EnteredPlayMode:
                    EnteredPlayMode();
                    break;
                case PlayModeStateChange.ExitingPlayMode:
                    ExitingPlayMode();
                    break;
                case PlayModeStateChange.EnteredEditMode:
                    EnteredEditMode();
                    break;
            }
        }

        private static void ExitingEditMode()
        {
#if false
#endif
        }

        private static void EnteredPlayMode()
        {
#if false
#endif
        }

        private static void ExitingPlayMode()
        {
#if false
#endif
        }

        private static void EnteredEditMode()
        {
            var loop = PlayerLoop.GetCurrentPlayerLoop();
            Cysharp.Threading.Tasks.PlayerLoopHelper.Initialize(ref loop);
            InitWarehouse().Forget();
        }

        private static void SetupAAReflection()
        {
            if (addressablesInstanceField == null)
            {
                addressablesInstanceField = typeof(Addressables).GetField("m_AddressablesInstance", BindingFlags.Static | BindingFlags.NonPublic);
            }

            if (addressablesConstructor == null)
            {
                addressablesConstructor = System.Type.GetType("UnityEngine.AddressableAssets.AddressablesImpl, Unity.Addressables, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null").GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(IAllocationStrategy) }, null);
            }
        }

        private static async UniTaskVoid InitWarehouse()
        {
            QueueEditorUpdateLoop.StartEditorUpdateLoop();
            SetupAAReflection();
            var newAAInstance = addressablesConstructor.Invoke(new object[] { new LRUCacheAllocationStrategy(1000, 1000, 100, 10) });
            addressablesInstanceField.SetValue(null, newAAInstance);
            await UniTask.DelayFrame(1);
            WarehousePathResolver.Setup();
            await UniTask.DelayFrame(1);
            if (AssetWarehouse.Instance == null)
            {
                AssetWarehouse.Instance = new AssetWarehouse();
            }

            await Addressables.InitializeAsync();
            await UniTask.DelayFrame(1);
            await AssetWarehouse.Instance.InitAsync();
            QueueEditorUpdateLoop.StopEditorUpdateLoop();
        }

        public void OnBeforeSerialize()
        {
#if false
#endif
        }

        public void OnAfterDeserialize()
        {
#if false
#endif
        }
    }
}
#endif
