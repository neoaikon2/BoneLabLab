using SLZ.Marrow.Interaction;

namespace SLZ.Marrow.Zones
{
	public interface IZoneLinkListenable
	{
		void OnZoneLinkEnter(MarrowEntity activator);

		void OnZoneLinkExit(MarrowEntity activator);
	}
}
