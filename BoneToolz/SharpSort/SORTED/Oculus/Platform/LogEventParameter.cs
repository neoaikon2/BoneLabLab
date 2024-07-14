using System.ComponentModel;

namespace Oculus.Platform
{
	public enum LogEventParameter
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("VR_CURRENCY")]
		VrCurrency = 1,
		[Description("VR_REGISTRATION_METHOD")]
		VrRegistrationMethod = 2,
		[Description("VR_CONTENT_TYPE")]
		VrContentType = 3,
		[Description("VR_CONTENT")]
		VrContent = 4,
		[Description("VR_CONTENT_ID")]
		VrContentId = 5,
		[Description("VR_SEARCH_STRING")]
		VrSearchString = 6,
		[Description("VR_SUCCESS")]
		VrSuccess = 7,
		[Description("VR_MAX_RATING_VALUE")]
		VrMaxRatingValue = 8,
		[Description("VR_PAYMENT_INFO_AVAILABLE")]
		VrPaymentInfoAvailable = 9,
		[Description("VR_NUM_ITEMS")]
		VrNumItems = 10,
		[Description("VR_LEVEL")]
		VrLevel = 11,
		[Description("VR_DESCRIPTION")]
		VrDescription = 12,
		[Description("AD_TYPE")]
		AdType = 13,
		[Description("VR_ORDER_ID")]
		VrOrderId = 14,
		[Description("EVENT_NAME")]
		EventName = 15,
		[Description("LOG_TIME")]
		LogTime = 16,
		[Description("IMPLICITLY_LOGGED")]
		ImplicitlyLogged = 17,
		[Description("IN_BACKGROUND")]
		InBackground = 18,
		[Description("VR_PUSH_CAMPAIGN")]
		VrPushCampaign = 19,
		[Description("VR_PUSH_ACTION")]
		VrPushAction = 20,
		[Description("VR_IAP_PRODUCT_TYPE")]
		VrIapProductType = 21,
		[Description("VR_CONTENT_TITLE")]
		VrContentTitle = 22,
		[Description("VR_TRANSACTION_ID")]
		VrTransactionId = 23,
		[Description("VR_TRANSACTION_DATE")]
		VrTransactionDate = 24,
		[Description("VR_IAP_SUBS_PERIOD")]
		VrIapSubsPeriod = 25,
		[Description("VR_IAP_IS_START_TRIAL")]
		VrIapIsStartTrial = 26,
		[Description("VR_IAP_HAS_FREE_TRIAL")]
		VrIapHasFreeTrial = 27,
		[Description("VR_IAP_TRIAL_PERIOD")]
		VrIapTrialPeriod = 28,
		[Description("VR_IAP_TRIAL_PRICE")]
		VrIapTrialPrice = 29,
		[Description("SESSION_ID")]
		SessionId = 30
	}
}
