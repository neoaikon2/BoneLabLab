using System.Runtime.InteropServices;

public static class OculusXRPlugin
{
	[PreserveSig]
	public static extern void SetColorScale(float x, float y, float z, float w);

	[PreserveSig]
	public static extern void SetColorOffset(float x, float y, float z, float w);

	[PreserveSig]
	public static extern void SetSpaceWarp(OVRPlugin.Bool on);

	[PreserveSig]
	public static extern void SetAppSpacePosition(float x, float y, float z);

	[PreserveSig]
	public static extern void SetAppSpaceRotation(float x, float y, float z, float w);

	[PreserveSig]
	public static extern void SetDepthSubmission(bool enable);
}
