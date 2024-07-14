using System.Collections.Generic;
using UnityEngine;

public struct OVRGLTFScene
{
	public GameObject root;

	public Dictionary<OVRGLTFInputNode, OVRGLTFAnimatinonNode> animationNodes;

	public Dictionary<int, OVRGLTFAnimatinonNode[]> animationNodeLookup;

	public List<OVRGLTFAnimationNodeMorphTargetHandler> morphTargetHandlers;
}
