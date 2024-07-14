using SLZ.Serialize;

namespace SLZ.Marrow.Warehouse
{
	public interface IScannable : IReadOnlyScannable, IPackable, IPackedAssets
	{
		bool Unlockable { get; }

		bool Redacted { get; }

		void GenerateBarcode(bool forceGeneration = false);

		void GenerateBarcodeInternal(bool forceGeneration = false);
	}
}
