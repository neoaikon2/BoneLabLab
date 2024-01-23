namespace Steamworks
{
	internal enum MarketNotAllowedReasonFlags
	{
		None = 0,
		TemporaryFailure = 1,
		AccountDisabled = 2,
		AccountLockedDown = 4,
		AccountLimited = 8,
		TradeBanned = 0x10,
		AccountNotTrusted = 0x20,
		SteamGuardNotEnabled = 0x40,
		SteamGuardOnlyRecentlyEnabled = 0x80,
		RecentPasswordReset = 0x100,
		NewPaymentMethod = 0x200,
		InvalidCookie = 0x400,
		UsingNewDevice = 0x800,
		RecentSelfRefund = 0x1000,
		NewPaymentMethodCannotBeVerified = 0x2000,
		NoRecentPurchases = 0x4000,
		AcceptedWalletGift = 0x8000
	}
}
