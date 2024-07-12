namespace SLZ.Marrow.Zones
{
	public interface IZoneLinkable<in TZoneActivator> where TZoneActivator : class
	{
		void OnEnter(TZoneActivator activator);

		void OnExit(TZoneActivator activator);

		void OnPrimaryEnter(TZoneActivator activator);

		void OnPrimaryExit(TZoneActivator activator);

		void OnSecondaryEnter(TZoneActivator activator);

		void OnSecondaryExit(TZoneActivator activator);
	}
}
