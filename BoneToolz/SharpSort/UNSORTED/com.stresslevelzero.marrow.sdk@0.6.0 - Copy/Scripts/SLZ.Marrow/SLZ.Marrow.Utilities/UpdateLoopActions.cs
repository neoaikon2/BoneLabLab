namespace SLZ.Marrow.Utilities
{
	public enum UpdateLoopActions
	{
		PostTimeUpdate = 0,
		StartFrame = 1,
		PreNewInputUpdate = 2,
		PostNewInputUpdate = 3,
		EarlyUpdate = 4,
		PreFixedUpdate = 5,
		PostFixedUpdate = 6,
		Update = 7,
		EndFrame = 8
	}
}
