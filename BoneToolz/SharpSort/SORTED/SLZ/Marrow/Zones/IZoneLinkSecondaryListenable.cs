using SLZ.Marrow.Interaction;

namespace SLZ.Marrow.Zones
{
	public interface IZoneLinkSecondaryListenable
	{
		void OnZoneLinkSecondaryEnter(MarrowEntity activator);

		void OnZoneLinkSecondaryExit(MarrowEntity activator);
	}
}
