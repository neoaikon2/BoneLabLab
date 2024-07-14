namespace SLZ.Marrow.VoidLogic
{
	public enum SupportFlags
	{
		Unsupported = 0,
		YouAreCompletelyOnYourOwnAndYouOwnAllBugs = 0,
		Supported = 1,
		BetaSupported = 2,
		AlphaSupported = 3,
		CowboySupported = 4,
		IncubatingWithNoCommitmentForInclusion = 4,
		NotForRelease = 1000,
		Deprecated = 1001
	}
}
