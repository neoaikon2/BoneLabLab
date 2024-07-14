using SLZ.Marrow.Interaction;

namespace SLZ.Marrow.Zones
{
	public interface IZoneBodyListenable
	{
		void OnZoneBodyEnter(MarrowBody body);

		void OnZoneBodyExit(MarrowBody body);
	}
}
