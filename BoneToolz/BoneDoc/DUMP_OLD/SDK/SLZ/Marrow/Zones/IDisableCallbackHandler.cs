namespace SLZ.Marrow.Zones
{
	internal interface IDisableCallbackHandler
	{
		bool IsActiveSelf { get; }

		bool AllowDisableOnCull { get; }

		void SetActive(bool isActive);

		void OnDisableStateChanged(DisableTypes type, bool isDisabled);

		void OnHide();

		void OnShow();

		void OnCull();

		void OnUncull();

		void OnDespawn();

		void OnSpawn();
	}
}
