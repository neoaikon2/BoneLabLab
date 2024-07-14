using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_MultiMeshBaker : MB3_MeshBakerCommon
{
	[SerializeField]
	protected MB3_MultiMeshCombiner _meshCombiner;

	public override MB3_MeshCombiner meshCombiner => null;

	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return false;
	}

	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOs, bool disableRendererInSource)
	{
		return false;
	}

	public void OnDestroy()
	{
	}
}
