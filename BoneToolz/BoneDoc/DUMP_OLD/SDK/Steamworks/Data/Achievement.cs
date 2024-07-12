namespace Steamworks.Data
{
	public struct Achievement
	{
		internal string Value;

		public Achievement(string name)
		{
			this.Value = default(string);
		}

		public override string ToString()
		{
			return null;
		}

		public bool Trigger(bool apply = true)
		{
			return default(bool);
		}
	}
}
