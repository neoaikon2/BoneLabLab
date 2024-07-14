namespace SLZ.Marrow.Pool
{
	public class DespawnDelay : SpawnEvents
	{
		public float secondsUntilDisable;

		private float _timeEnabled;

		private bool _wasInitialize;

		public override void OnPoolInitialize()
		{
		}

		private void Update()
		{
		}
	}
}
