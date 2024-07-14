#if UNITY_EDITOR
  
 
using Cysharp.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public static class QueueEditorUpdateLoop
{
    private static int refCount = 0;
    private static bool running = false;
    private static bool debugLog = false;
    public static void StartEditorUpdateLoop()
    {
        refCount++;
        if (debugLog)
            Debug.Log($"QueueEditorUpdateLoop: Try Start Loop[{refCount}]");
        if (!running)
            KeepEditorAlive().Forget();
    }

    public static void StopEditorUpdateLoop()
    {
        refCount = Mathf.Max(0, refCount - 1);
        if (debugLog)
            Debug.Log($"QueueEditorUpdateLoop: Try Stop Loop[{refCount}]");
        if (refCount == 0)
            running = false;
    }

    private static async UniTask KeepEditorAlive()
    {
        if (running)
            return;
        if (debugLog)
            Debug.Log("QueueEditorUpdateLoop: Start Loop");
        running = true;
        await UniTask.SwitchToThreadPool();
        while (running)
        {
            await UniTask.SwitchToMainThread();
            if (debugLog)
                Debug.Log("QueueEditorUpdateLoop: Looping");
            EditorApplication.QueuePlayerLoopUpdate();
            await UniTask.SwitchToThreadPool();
            await UniTask.DelayFrame(1);
        }

        running = false;
        await UniTask.SwitchToMainThread();
        if (debugLog)
            Debug.Log("QueueEditorUpdateLoop: End Loop");
    }
}
#endif
