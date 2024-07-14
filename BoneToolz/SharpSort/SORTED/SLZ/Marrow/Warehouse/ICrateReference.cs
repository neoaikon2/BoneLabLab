namespace SLZ.Marrow.Warehouse
{
	public interface ICrateReference
	{
		Barcode Barcode { get; set; }

		Crate Crate { get; }

		bool TryGetCrate(out Crate crate);
	}
}
