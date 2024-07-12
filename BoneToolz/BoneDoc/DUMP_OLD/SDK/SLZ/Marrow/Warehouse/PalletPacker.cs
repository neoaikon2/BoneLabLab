using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine.Networking;

namespace SLZ.Marrow.Warehouse
{
	public class PalletPacker
	{
		public static bool ValidatePallet(Pallet pallet)
		{
			return default(bool);
		}

		public static void PackAndSaveToJson(Pallet pallet, string savePath)
		{
		}

		public static string PackIntoJson(Pallet pallet)
		{
			return null;
		}

		public static Pallet UnpackJsonFromFile(string path)
		{
			return null;
		}

		public static UniTask<Pallet> UnpackJsonFromFileAndroid(string path)
		{
			return default(UniTask<Pallet>);
		}

		public static Pallet UnpackJson(string palletJson)
		{
			return null;
		}

		public static bool TryUnpackManifestJsonFromFile(string path, [Out] PalletManifest palletManifest, [Out] string palletManifestJson)
		{
			return default(bool);
		}

		public static PalletManifest UnpackManifestJson(string palletManifestJson)
		{
			return null;
		}

		public static bool TryPackManifestAndSaveToJson(PalletManifest palletManifest, string savePath, string palletManifestJson = default(string))
		{
			return default(bool);
		}

		public static string PackManifestIntoJson(PalletManifest palletManifest)
		{
			return null;
		}

		public static bool TryUnpackMarrowGameJsonFromFile(string path, [Out] MarrowSettings marrowGame, [Out] string marrowGameJson)
		{
			return default(bool);
		}

		public static MarrowSettings UnpackMarrowGameJson(string marrowGameJson)
		{
			return null;
		}

		[MarrowInternal]
		public static bool TryPackMarrowGameAndSaveToJson(MarrowSettings marrowGame, string filePath, string marrowGameJson = default(string))
		{
			return default(bool);
		}

		[MarrowInternal]
		public static string PackMarrowGameIntoJson(MarrowSettings marrowGame)
		{
			return null;
		}

		public PalletPacker()
			: base()
		{
		}
	}
}
