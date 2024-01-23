using System.Runtime.InteropServices;
using UnityEngine;

namespace TMPro
{
	public static class TMP_TextUtilities
	{
		private struct LineSegment
		{
			public Vector3 Point1;

			public Vector3 Point2;

			public LineSegment(Vector3 p1, Vector3 p2)
			{
				this.Point2 = default(Vector3);
				this.Point1 = default(Vector3);
			}
		}

		private static Vector3[] m_rectWorldCorners;

		private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";

		private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera)
		{
			return default(int);
		}

		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, [Out] CaretPosition cursor)
		{
			return default(int);
		}

		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera)
		{
			return default(int);
		}

		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly)
		{
			return default(int);
		}

		public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera)
		{
			return default(bool);
		}

		public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly)
		{
			return default(int);
		}

		public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly)
		{
			return default(int);
		}

		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera)
		{
			return default(int);
		}

		public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera)
		{
			return default(int);
		}

		public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera)
		{
			return default(int);
		}

		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera)
		{
			return default(int);
		}

		public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera)
		{
			return default(int);
		}

		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			return default(bool);
		}

		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, [Out] Vector3 worldPoint)
		{
			return default(bool);
		}

		private static bool IntersectLinePlane(LineSegment line, Vector3 point, Vector3 normal, [Out] Vector3 intersectingPoint)
		{
			return default(bool);
		}

		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point)
		{
			return default(float);
		}

		public static char ToLowerFast(char c)
		{
			return default(char);
		}

		public static char ToUpperFast(char c)
		{
			return default(char);
		}

		internal static uint ToUpperASCIIFast(uint c)
		{
			return default(uint);
		}

		public static int GetHashCode(string s)
		{
			return default(int);
		}

		public static int GetSimpleHashCode(string s)
		{
			return default(int);
		}

		public static uint GetSimpleHashCodeLowercase(string s)
		{
			return default(uint);
		}

		public static int HexToInt(char hex)
		{
			return default(int);
		}

		public static int StringHexToInt(string s)
		{
			return default(int);
		}
	}
}
