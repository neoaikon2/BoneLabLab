using System.Collections.Generic;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamInput : SteamClientClass<SteamInput>
	{
		private static readonly InputHandle_t[] queryArray;

		internal static Dictionary<string, InputDigitalActionHandle_t> DigitalHandles;

		internal static Dictionary<string, InputAnalogActionHandle_t> AnalogHandles;

		internal static Dictionary<string, InputActionSetHandle_t> ActionSets;

		internal override void InitializeInterface(bool server)
		{
		}

		public SteamInput()
			: base()
		{
		}
	}
}
