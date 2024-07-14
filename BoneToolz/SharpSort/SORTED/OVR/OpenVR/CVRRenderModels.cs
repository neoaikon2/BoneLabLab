using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OVR.OpenVR
{
	public class CVRRenderModels
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetComponentStatePacked(string pchRenderModelName, string pchComponentName, ref VRControllerState_t_Packed pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);

		[StructLayout(2)]
		private struct GetComponentStateUnion
		{
			public IVRRenderModels._GetComponentState pGetComponentState;

			public _GetComponentStatePacked pGetComponentStatePacked;
		}

		private IVRRenderModels FnTable;

		internal CVRRenderModels(IntPtr pInterface)
		{
		}

		public EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel)
		{
			return default(EVRRenderModelError);
		}

		public void FreeRenderModel(IntPtr pRenderModel)
		{
		}

		public EVRRenderModelError LoadTexture_Async(int textureId, ref IntPtr ppTexture)
		{
			return default(EVRRenderModelError);
		}

		public void FreeTexture(IntPtr pTexture)
		{
		}

		public EVRRenderModelError LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D)
		{
			return default(EVRRenderModelError);
		}

		public EVRRenderModelError LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture)
		{
			return default(EVRRenderModelError);
		}

		public void FreeTextureD3D11(IntPtr pD3D11Texture2D)
		{
		}

		public uint GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen)
		{
			return 0u;
		}

		public uint GetRenderModelCount()
		{
			return 0u;
		}

		public uint GetComponentCount(string pchRenderModelName)
		{
			return 0u;
		}

		public uint GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen)
		{
			return 0u;
		}

		public ulong GetComponentButtonMask(string pchRenderModelName, string pchComponentName)
		{
			return 0uL;
		}

		public uint GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen)
		{
			return 0u;
		}

		public bool GetComponentStateForDevicePath(string pchRenderModelName, string pchComponentName, ulong devicePath, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState)
		{
			return false;
		}

		public bool GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState)
		{
			return false;
		}

		public bool RenderModelHasComponent(string pchRenderModelName, string pchComponentName)
		{
			return false;
		}

		public uint GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError)
		{
			return 0u;
		}

		public uint GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError)
		{
			return 0u;
		}

		public string GetRenderModelErrorNameFromEnum(EVRRenderModelError error)
		{
			return null;
		}
	}
}
