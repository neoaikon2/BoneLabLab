using System.Collections.Generic;

namespace SLZ.Marrow.Warehouse
{
	public interface IPackedAssets
	{
		List<PackedAsset> PackedAssets { get; }

		void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets);

		List<PackedAsset> ExportPackedAssets();
	}
}
