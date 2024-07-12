using SLZ.Marrow.Interaction;

namespace SLZ.Marrow.Zones
{
	public interface IZoneLinkPrimaryListenable
	{
		void OnZoneLinkPrimaryEnter(MarrowEntity activator);

		void OnZoneLinkPrimaryExit(MarrowEntity activator);
	}
}
