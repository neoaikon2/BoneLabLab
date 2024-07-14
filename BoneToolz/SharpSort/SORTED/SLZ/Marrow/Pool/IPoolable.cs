namespace SLZ.Marrow.Pool
{
	public interface IPoolable
	{
		void OnPoolInitialize();

		void OnPoolSpawn();

		void OnPoolDeInitialize();
	}
}
