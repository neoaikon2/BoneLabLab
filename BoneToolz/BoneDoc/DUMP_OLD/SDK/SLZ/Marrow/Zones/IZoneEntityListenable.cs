using SLZ.Marrow.Interaction;

namespace SLZ.Marrow.Zones
{
	public interface IZoneEntityListenable
	{
		void OnZoneEntityEnter(MarrowEntity entity);

		void OnZoneEntityExit(MarrowEntity entity);
	}
}
