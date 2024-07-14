using System.ComponentModel;

namespace Oculus.Platform
{
	public enum LogEventName
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("AD_CLICK")]
		AdClick = 1,
		[Description("AD_IMPRESSION")]
		AdImpression = 2,
		[Description("VR_COMPLETE_REGISTRATION")]
		VrCompleteRegistration = 3,
		[Description("VR_TUTORIAL_COMPLETION")]
		VrTutorialCompletion = 4,
		[Description("CONTACT")]
		Contact = 5,
		[Description("CUSTOMIZE_PRODUCT")]
		CustomizeProduct = 6,
		[Description("DONATE")]
		Donate = 7,
		[Description("FIND_LOCATION")]
		FindLocation = 8,
		[Description("VR_RATE")]
		VrRate = 9,
		[Description("SCHEDULE")]
		Schedule = 10,
		[Description("VR_SEARCH")]
		VrSearch = 11,
		[Description("SMART_TRIAL")]
		SmartTrial = 12,
		[Description("SUBMIT_APPLICATION")]
		SubmitApplication = 13,
		[Description("SUBSCRIBE")]
		Subscribe = 14,
		[Description("VR_CONTENT_VIEW")]
		VrContentView = 15,
		[Description("VR_SDK_INITIALIZE")]
		VrSdkInitialize = 16,
		[Description("VR_SDK_BACKGROUND_STATUS_AVAILABLE")]
		VrSdkBackgroundStatusAvailable = 17,
		[Description("VR_SDK_BACKGROUND_STATUS_DENIED")]
		VrSdkBackgroundStatusDenied = 18,
		[Description("VR_SDK_BACKGROUND_STATUS_RESTRICTED")]
		VrSdkBackgroundStatusRestricted = 19,
		[Description("VR_ADD_PAYMENT_INFO")]
		VrAddPaymentInfo = 20,
		[Description("VR_ADD_TO_CART")]
		VrAddToCart = 21,
		[Description("VR_ADD_TO_WISHLIST")]
		VrAddToWishlist = 22,
		[Description("VR_INITIATED_CHECKOUT")]
		VrInitiatedCheckout = 23,
		[Description("VR_PURCHASE")]
		VrPurchase = 24,
		[Description("VR_CATALOG_UPDATE")]
		VrCatalogUpdate = 25,
		[Description("VR_PURCHASE_FAILED")]
		VrPurchaseFailed = 26,
		[Description("VR_PURCHASE_RESTORED")]
		VrPurchaseRestored = 27,
		[Description("SUBSCRIPTION_INITIATED_CHECKOUT")]
		SubscriptionInitiatedCheckout = 28,
		[Description("SUBSCRIPTION_FAILED")]
		SubscriptionFailed = 29,
		[Description("SUBSCRIPTION_RESTORE")]
		SubscriptionRestore = 30,
		[Description("VR_LEVEL_ACHIEVED")]
		VrLevelAchieved = 31,
		[Description("VR_ACHIEVEMENT_UNLOCKED")]
		VrAchievementUnlocked = 32,
		[Description("VR_SPENT_CREDITS")]
		VrSpentCredits = 33,
		[Description("VR_OBTAIN_PUSH_TOKEN")]
		VrObtainPushToken = 34,
		[Description("VR_PUSH_OPENED")]
		VrPushOpened = 35,
		[Description("VR_ACTIVATE_APP")]
		VrActivateApp = 36,
		[Description("VR_DEACTIVATE_APP")]
		VrDeactivateApp = 37
	}
}
