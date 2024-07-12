using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace OccaSoftware.Exposure.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Auto Exposure", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class AutoExposure : VolumeComponent, IPostProcessComponent
	{
		[Tooltip("Set to On to enable auto exposure processing. This effect automatically overrides the Color Adjustments \"Post Exposure\" Setting.")]
		public AutoExposureModeParameter mode;

		[Tooltip("The exposure value that will be used for the darkest scenes. Decrease this to brighten the scene in low brightness shots.")]
		public FloatParameter evMin;

		[Tooltip("The exposure value that will be used for the brightest scenes. Increase this to darken the scene for high brightness shots.")]
		public FloatParameter evMax;

		[Tooltip("Amount to offset the calculated scene EV. Increase this to darken your scene.")]
		public FloatParameter evCompensation;

		[Header("Adaptation")]
		[Tooltip("The mode that will be used to adjust exposure over time. Progressive animates the exposure over time. Instant jumps the exposure to the target value instantly.")]
		[InspectorName("Mode")]
		public AutoExposureAdapationModeParameter adaptationMode;

		[Tooltip("The rate (in f-stops) at which the Auto Exposure will adjust from dark to light scenes. Eyes are faster to adapt when moving from a dark to a light environment, so this value should generally be larger than the Light to Dark Speed.")]
		public FloatParameter darkToLightSpeed;

		[Tooltip("The rate (in f-stops) at which the Auto Exposure will adjust from light to dark scenes. Eyes are slower to adapt when moving from a light to a dark environment, so this value should generally be smaller than the Dark to Light Speed.")]
		public FloatParameter lightToDarkSpeed;

		[Tooltip("Set whether the metering mask should be sampled from a procedural radial falloff or a texture mask (to be provided by user). Textural mode with no texture results in no metering mask being applied.")]
		public AutoExposureMeteringMaskModeParameter meteringMaskMode;

		[Tooltip("A texture mask used to weight the relative importance of samples taken from various positions on screen. Automatically stretched to fit. Greyscale texture is expected and only the red channel is sampled.")]
		public TextureParameter meteringMaskTexture;

		[Tooltip("Controls the radial importance falloff for procedural metering masks. A higher value means that the importance decreases more rapidly as you approach the screen edges.")]
		public MinFloatParameter meteringProceduralFalloff;

		public bool IsActive()
		{
			return default(bool);
		}

		public bool IsTileCompatible()
		{
			return default(bool);
		}

		public AutoExposure()
			: base()
		{
		}
	}
}
