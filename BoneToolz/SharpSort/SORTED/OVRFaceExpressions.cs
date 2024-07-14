using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_face_expressions")]
public class OVRFaceExpressions : MonoBehaviour, IReadOnlyCollection<float>, IEnumerable<float>, IEnumerable, OVRFaceExpressions.WeightProvider
{
	public interface WeightProvider
	{
		float GetWeight(FaceExpression expression);
	}

	public enum FaceRegionConfidence
	{
		Lower = 0,
		Upper = 1,
		Max = 2
	}

	public enum FaceTrackingDataSource
	{
		Visual = 0,
		Audio = 1,
		[InspectorName(null)]
		Count = 2
	}

	public enum FaceExpression
	{
		[InspectorName("None")]
		Invalid = -1,
		BrowLowererL = 0,
		BrowLowererR = 1,
		CheekPuffL = 2,
		CheekPuffR = 3,
		CheekRaiserL = 4,
		CheekRaiserR = 5,
		CheekSuckL = 6,
		CheekSuckR = 7,
		ChinRaiserB = 8,
		ChinRaiserT = 9,
		DimplerL = 10,
		DimplerR = 11,
		EyesClosedL = 12,
		EyesClosedR = 13,
		EyesLookDownL = 14,
		EyesLookDownR = 15,
		EyesLookLeftL = 16,
		EyesLookLeftR = 17,
		EyesLookRightL = 18,
		EyesLookRightR = 19,
		EyesLookUpL = 20,
		EyesLookUpR = 21,
		InnerBrowRaiserL = 22,
		InnerBrowRaiserR = 23,
		JawDrop = 24,
		JawSidewaysLeft = 25,
		JawSidewaysRight = 26,
		JawThrust = 27,
		LidTightenerL = 28,
		LidTightenerR = 29,
		LipCornerDepressorL = 30,
		LipCornerDepressorR = 31,
		LipCornerPullerL = 32,
		LipCornerPullerR = 33,
		LipFunnelerLB = 34,
		LipFunnelerLT = 35,
		LipFunnelerRB = 36,
		LipFunnelerRT = 37,
		LipPressorL = 38,
		LipPressorR = 39,
		LipPuckerL = 40,
		LipPuckerR = 41,
		LipStretcherL = 42,
		LipStretcherR = 43,
		LipSuckLB = 44,
		LipSuckLT = 45,
		LipSuckRB = 46,
		LipSuckRT = 47,
		LipTightenerL = 48,
		LipTightenerR = 49,
		LipsToward = 50,
		LowerLipDepressorL = 51,
		LowerLipDepressorR = 52,
		MouthLeft = 53,
		MouthRight = 54,
		NoseWrinklerL = 55,
		NoseWrinklerR = 56,
		OuterBrowRaiserL = 57,
		OuterBrowRaiserR = 58,
		UpperLidRaiserL = 59,
		UpperLidRaiserR = 60,
		UpperLipRaiserL = 61,
		UpperLipRaiserR = 62,
		TongueTipInterdental = 63,
		TongueTipAlveolar = 64,
		TongueFrontDorsalPalate = 65,
		TongueMidDorsalPalate = 66,
		TongueBackDorsalVelar = 67,
		TongueOut = 68,
		TongueRetreat = 69,
		[InspectorName(null)]
		Max = 70
	}

	public struct FaceExpressionsEnumerator : IEnumerator<float>, IEnumerator, IDisposable
	{
		private float[] _faceExpressions;

		private int _index;

		private int _count;

		public float Current => 0f;

		private object System_002ECollections_002EIEnumerator_002ECurrent => null;

		object IEnumerator.Current => throw new NotImplementedException();

		internal FaceExpressionsEnumerator(float[] array)
		{
			_faceExpressions = null;
			_index = 0;
			_count = 0;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	private OVRPlugin.FaceState _currentFaceState;

	private const OVRPermissionsRequester.Permission FaceTrackingPermission = OVRPermissionsRequester.Permission.FaceTracking;

	private const OVRPermissionsRequester.Permission RecordAudioPermission = OVRPermissionsRequester.Permission.RecordAudio;

	private Action<string> _onPermissionGranted;

	private static int _trackingInstanceCount;

	public bool FaceTrackingEnabled => false;

	public bool ValidExpressions { get; private set; }

	public bool EyeFollowingBlendshapesValid { get; private set; }

	public float this[FaceExpression expression] => 0f;

	public int Count => 0;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnPermissionGranted(string permissionId)
	{
	}

	private OVRPlugin.FaceTrackingDataSource[] GetRequestedFaceTrackingDataSources()
	{
		return null;
	}

	private bool StartFaceTracking()
	{
		return false;
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public float GetWeight(FaceExpression expression)
	{
		return 0f;
	}

	public bool TryGetFaceExpressionWeight(FaceExpression expression, out float weight)
	{
		weight = default(float);
		return false;
	}

	public bool TryGetWeightConfidence(FaceRegionConfidence region, out float weightConfidence)
	{
		weightConfidence = default(float);
		return false;
	}

	public bool TryGetFaceTrackingDataSource(out FaceTrackingDataSource dataSource)
	{
		dataSource = default(FaceTrackingDataSource);
		return false;
	}

	internal void CheckValidity()
	{
	}

	public void CopyTo(float[] array, int startIndex = 0)
	{
	}

	public float[] ToArray()
	{
		return null;
	}

	public FaceExpressionsEnumerator GetEnumerator()
	{
		return default(FaceExpressionsEnumerator);
	}

	private IEnumerator<float> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ESingle_003E_002EGetEnumerator()
	{
		return null;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		throw new NotImplementedException();
	}

	IEnumerator<float> IEnumerable<float>.GetEnumerator()
	{
		throw new NotImplementedException();
	}
}
