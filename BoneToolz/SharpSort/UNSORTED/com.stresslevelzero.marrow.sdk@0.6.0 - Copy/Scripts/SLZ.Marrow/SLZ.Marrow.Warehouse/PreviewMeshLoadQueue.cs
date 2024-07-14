#if UNITY_EDITOR
using System;
 
using System.Collections.Generic;
 
using System.Threading;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Warehouse;
using UnityEditor;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
    public class PreviewMeshLoadQueue
    {
        private static Queue<Tuple<string, Func<UniTask<Mesh>>>> loadMeshQueue = new Queue<Tuple<string, Func<UniTask<Mesh>>>>();
        private static HashSet<string> queuedMeshes = new HashSet<string>();
        private static HashSet<string> loadingMeshes = new HashSet<string>();
        private static HashSet<string> failedLoading = new HashSet<string>();
        private static bool queueRunning = false;
        private static HashSet<string> loadedMeshes = new HashSet<string>();
        private static CancellationTokenSource cancellationToken;
        private static int idleTime = 0;
        private static int meshPerSlice = 10;
        [InitializeOnLoadMethod]
        static void Initialize()
        {
            cancellationToken?.Dispose();
            cancellationToken = new CancellationTokenSource();
            AssemblyReloadEvents.beforeAssemblyReload += OnBeforeDomainReload;
            EditorApplication.playModeStateChanged += (stateChange) =>
            {
                if (stateChange == PlayModeStateChange.EnteredEditMode)
                {
                    ClearMeshQueue();
                }
            };
            AssetWarehouse.OnReady(() => AssetWarehouse.Instance.OnClearEditor += ClearMeshQueue);
        }

        private static void OnBeforeDomainReload()
        {
            ClearMeshQueue();
        }

        public static void StartMeshQueue()
        {
            queueRunning = true;
            if (cancellationToken.IsCancellationRequested)
            {
                cancellationToken.Dispose();
                cancellationToken = new CancellationTokenSource();
            }

            LoadMeshQueue(cancellationToken.Token).Forget();
        }

        public static void StopQueue()
        {
            queueRunning = false;
            cancellationToken.Cancel();
        }

        private static void ClearMeshQueue()
        {
            loadMeshQueue.Clear();
            queuedMeshes.Clear();
            loadingMeshes.Clear();
            failedLoading.Clear();
            loadedMeshes.Clear();
            idleTime = 0;
            StopQueue();
        }

        private static async UniTask LoadMeshQueue(CancellationToken cancellationToken)
        {
            int countPerSlice = 0;
            List<UniTask<Mesh>> taskBuffer = new List<UniTask<Mesh>>();
            List<string> taskGuidBuffer = new List<string>();
            idleTime = 0;
            while (queueRunning)
            {
                if (AssetWarehouse.ready)
                {
                    if (idleTime < 50)
                    {
                        if (loadMeshQueue.Count > 0)
                        {
                            idleTime = 0;
                            taskBuffer.Clear();
                            taskGuidBuffer.Clear();
                            while (loadMeshQueue.Count > 0 && countPerSlice < meshPerSlice)
                            {
                                var (assetGUID, loadMeshTask) = loadMeshQueue.Dequeue();
                                queuedMeshes.Remove(assetGUID);
                                taskBuffer.Add(loadMeshTask());
                                loadingMeshes.Add(assetGUID);
                                taskGuidBuffer.Add(assetGUID);
                                countPerSlice++;
                            }

                            for (var i = 0; i < taskBuffer.Count; i++)
                            {
                                var task = taskBuffer[i];
                                var assetGUID = taskGuidBuffer[i];
                                var loadedMesh = await task;
                                if (loadedMesh != null)
                                {
                                    loadedMeshes.Add(assetGUID);
                                    loadingMeshes.Remove(assetGUID);
                                }
                                else
                                {
                                    failedLoading.Add(assetGUID);
                                    loadingMeshes.Remove(assetGUID);
                                }
                            }
                        }
                        else
                        {
                            idleTime += 1;
                        }

                        countPerSlice = 0;
                        await UniTask.Delay(TimeSpan.FromMilliseconds(100), cancellationToken: cancellationToken);
                    }
                    else
                    {
                        queueRunning = false;
                    }
                }
                else
                {
                    await UniTask.Delay(TimeSpan.FromMilliseconds(1000), cancellationToken: cancellationToken);
                }
            }
        }

        public static void QueueLoadMesh(MarrowAssetT<Mesh> marrowMesh)
        {
            if (!queuedMeshes.Contains(marrowMesh.AssetGUID) && !loadingMeshes.Contains(marrowMesh.AssetGUID) && !loadedMeshes.Contains(marrowMesh.AssetGUID) && !failedLoading.Contains(marrowMesh.AssetGUID))
            {
                Func<UniTask<Mesh>> loadMeshTaskDelegate = () => marrowMesh.LoadAssetAsync<Mesh>(cancellationToken.Token);
                loadMeshQueue.Enqueue(new Tuple<string, Func<UniTask<Mesh>>>(marrowMesh.AssetGUID, loadMeshTaskDelegate));
                queuedMeshes.Add(marrowMesh.AssetGUID);
                if (!queueRunning)
                    StartMeshQueue();
            }
        }
    }
}
#endif
