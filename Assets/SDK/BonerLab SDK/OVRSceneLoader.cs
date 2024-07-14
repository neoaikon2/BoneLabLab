using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class OVRSceneLoader : MonoBehaviour
{
	private struct SceneInfo
	{
		public List<string> scenes;

		public long version;

		public SceneInfo(List<string> sceneList, long currentSceneEpochVersion)
		{
			scenes = null;
			version = 0L;
		}
	}
	public const string externalStoragePath = "/sdcard/Android/data";

	public const string sceneLoadDataName = "SceneLoadData.txt";

	public const string resourceBundleName = "asset_resources";

	public float sceneCheckIntervalSeconds;

	public float logCloseTime;

	public Canvas mainCanvas;

	public Text logTextBox;

	private AsyncOperation loadSceneOperation;

	private string formattedLogText;

	private float closeLogTimer;

	private bool closeLogDialogue;

	private bool canvasPosUpdated;

	private string scenePath;

	private string sceneLoadDataPath;

	private List<AssetBundle> loadedAssetBundles;

	private SceneInfo currentSceneInfo;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LoadScene(SceneInfo sceneInfo)
	{
	}

	private void LoadSceneOperation_completed(AsyncOperation obj)
	{
	}

	public void Update()
	{
	}

	private void UpdateCanvasPosition()
	{
	}

	private SceneInfo GetSceneInfo()
	{
		return default(SceneInfo);
	}
	private IEnumerator DelayCanvasPosUpdate()
	{
		return null;
	}
	private IEnumerator onCheckSceneCoroutine()
	{
		return null;
	}

	private void DestroyAllGameObjects()
	{
	}
}
