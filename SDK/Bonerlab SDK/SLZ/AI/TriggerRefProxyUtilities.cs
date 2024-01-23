namespace SLZ.AI
{
	public static class TriggerRefProxyUtilities
	{
		public static bool CheckAgro(this TriggerRefProxy myTrp, TriggerRefProxy otherTrp)
		{
			return false;
		}

		public static float CheckAlliance(this TriggerRefProxy myTrp, TriggerRefProxy otherTrp)
		{
			return 0f;
		}

		public static bool IsAgroEnabledTowards(this TriggerRefProxy.NpcType agroOnNpcType, TriggerRefProxy.NpcType towards)
		{
			return false;
		}

		public static float HostilityTowards(this TriggerRefProxy myTrp, TriggerRefProxy otherTrp)
		{
			return 0f;
		}

		public static bool IsHostileTowards(this TriggerRefProxy myTrp, TriggerRefProxy otherTrp, float hostileThreshold = 0.5f, bool neutralIsHostile = false)
		{
			return false;
		}
	}
}
