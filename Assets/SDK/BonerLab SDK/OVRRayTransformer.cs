using UnityEngine;

public abstract class OVRRayTransformer : MonoBehaviour
{
	public abstract Ray TransformRay(Ray ray);
}
