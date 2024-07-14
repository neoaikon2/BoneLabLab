using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

[DisallowMultipleComponent]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_virtual_keyboard")]
public class OVRVirtualKeyboard : MonoBehaviour
{
	public enum KeyboardPosition
	{
		Far = 0,
		Near = 1,
		[Obsolete]
		Direct = 1,
		Custom = 2
	}

	public interface ITextHandler
	{
		Action<string> OnTextChanged { get; set; }

		string Text { get; }

		bool SubmitOnEnter { get; }

		bool IsFocused { get; }

		void Submit();

		void AppendText(string s);

		void ApplyBackspace();

		void MoveTextEnd();
	}

	public abstract class AbstractTextHandler : MonoBehaviour, ITextHandler
	{
		public abstract Action<string> OnTextChanged { get; set; }

		public abstract string Text { get; }

		public abstract bool SubmitOnEnter { get; }

		public abstract bool IsFocused { get; }

		public abstract void Submit();

		public abstract void AppendText(string s);

		public abstract void ApplyBackspace();

		public abstract void MoveTextEnd();
	}

	private class TextHandlerScope : ITextHandler, IDisposable
	{
		private readonly ITextHandler _textHandler;

		private readonly Action<string> _textChangeHandler;

		public Action<string> OnTextChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Text => null;

		public bool SubmitOnEnter => false;

		public bool IsFocused => false;

		public TextHandlerScope(ITextHandler textHandler, Action<string> textChangeHandler)
		{
		}

		public void Dispose()
		{
		}

		public void Submit()
		{
		}

		public void AppendText(string s)
		{
		}

		public void ApplyBackspace()
		{
		}

		public void MoveTextEnd()
		{
		}
	}

	public class WaitUntilKeyboardVisible : CustomYieldInstruction
	{
		private readonly OVRVirtualKeyboard _keyboard;

		public override bool keepWaiting => false;

		public WaitUntilKeyboardVisible(OVRVirtualKeyboard keyboard)
		{
		}
	}

	public class InteractorRootTransformOverride
	{
		private struct InteractorRootOverrideData
		{
			public Transform root;

			public OVRPose originalPose;

			public OVRPose targetPose;
		}
		private Queue<InteractorRootOverrideData> applyQueue;

		private Queue<InteractorRootOverrideData> revertQueue;

		public void Enqueue(Transform interactorRootTransform, OVRPlugin.Posef interactorRootPose)
		{
		}

		public void LateApply(MonoBehaviour coroutineRunner)
		{
		}

		public void Reset()
		{
		}
		private IEnumerator RevertInteractorOverrides()
		{
			return null;
		}

		private static bool ApplyOverride(InteractorRootOverrideData interactorOverride)
		{
			return false;
		}
	}

	public enum InputSource
	{
		ControllerLeft = 0,
		ControllerRight = 1,
		HandLeft = 2,
		HandRight = 3
	}

	private interface IInputSource : IDisposable
	{
		void Update();
	}

	private abstract class BaseInputSource : IInputSource, IDisposable
	{
		protected readonly bool _operatingWithoutOVRCameraRig;

		private readonly OVRCameraRig _rig;

		private bool _disposed;

		private void OnUpdatedAnchors(OVRCameraRig obj)
		{
		}

		public void Update()
		{
		}

		protected abstract void UpdateInput();

		public void Dispose()
		{
		}
	}

	private class ControllerInputSource : BaseInputSource
	{
		private readonly Transform _rootTransform;

		private readonly Transform _directTransform;

		private readonly InputSource _inputSource;

		private readonly OVRInput.Controller _controllerType;

		private readonly OVRVirtualKeyboard _keyboard;

		private int _lastFrameCount;

		private bool TriggerIsPressed => false;

		public ControllerInputSource(OVRVirtualKeyboard keyboard, InputSource inputSource, OVRInput.Controller controllerType, Transform rootTransform, Transform directTransform)
		{
		}

		protected override void UpdateInput()
		{
		}
	}

	private class HandInputSource : BaseInputSource
	{
		private readonly OVRHand _hand;

		private readonly InputSource _inputSource;

		private readonly OVRVirtualKeyboard _keyboard;

		private readonly OVRSkeleton _skeleton;

		private int _lastFrameCount;

		public HandInputSource(OVRVirtualKeyboard keyboard, InputSource inputSource, OVRHand hand)
		{
		}

		protected override void UpdateInput()
		{
		}
	}

	private class KeyboardEventListener : OVRManager.EventListener
	{
		private readonly OVRVirtualKeyboard keyboard_;

		public KeyboardEventListener(OVRVirtualKeyboard keyboard)
		{
		}

		public void OnEvent(OVRPlugin.EventDataBuffer eventDataBuffer)
		{
		}
	}

	private struct VirtualKeyboardTextureInfo
	{
		public IntPtr buffer;

		public uint bufferLength;

		public Texture2D texture;

		public bool hasTexture;

		public List<Material> materials;
	}

	[Serializable]
	public class CommitTextUnityEvent : UnityEvent<string>
	{
	}
	private static OVRVirtualKeyboard singleton_;

	[SerializeField]
	private KeyboardPosition InitialPosition;

	[FormerlySerializedAs("TextCommitField")]
	[Obsolete]
	[HideInInspector]
	[SerializeField]
	private InputField textCommitField;

	[SerializeField]
	private AbstractTextHandler textHandler;

	private ITextHandler _runtimeTextHandler;

	[Header("Controller Input")]
	[FormerlySerializedAs("leftControllerInputTransform")]
	public Transform leftControllerRootTransform;

	public Transform leftControllerDirectTransform;

	[FormerlySerializedAs("rightControllerInputTransform")]
	public Transform rightControllerRootTransform;

	public Transform rightControllerDirectTransform;

	public bool controllerDirectInteraction;

	public bool controllerRayInteraction;

	public OVRPhysicsRaycaster controllerRaycaster;

	[Header("Hand Input")]
	public OVRHand handLeft;

	public OVRHand handRight;

	public bool handDirectInteraction;

	public bool handRayInteraction;

	public OVRPhysicsRaycaster handRaycaster;

	[Header("Graphics")]
	public Shader keyboardModelShader;

	public Shader keyboardModelAlphaBlendShader;

	[NonSerialized]
	public bool InputEnabled;

	private bool isKeyboardCreated_;

	private ulong keyboardSpace_;

	private Dictionary<ulong, VirtualKeyboardTextureInfo> virtualKeyboardTextures_;

	private OVRGLTFScene virtualKeyboardScene_;

	private ulong virtualKeyboardModelKey_;

	private bool modelInitialized_;

	private bool modelAvailable_;

	private bool keyboardVisible_;

	private InteractorRootTransformOverride _interactorRootTransformOverride;

	private List<IInputSource> _inputSources;

	private KeyboardEventListener keyboardEventListener_;

	private Coroutine gltfModelCoroutine_;

	private OVRGLTFLoader _gltfLoader;

	private int _animationStateCount;

	private int _animationStateBufferLength;

	private IntPtr _animationStateBuffer;

	public Collider Collider { get; private set; }

	[Obsolete("TextCommitField has been replaced with TextHandler for more flexibility.")]
	public InputField TextCommitField
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ITextHandler TextHandler
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("Use CommitTextEvent", false)]
	public event Action<string> CommitText
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("Use BackspaceEvent", false)]
	public event Action Backspace
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("Use EnterEvent", false)]
	public event Action Enter
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("Use KeyboardShownEvent", false)]
	public event Action KeyboardShown
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("Use KeyboardHiddenEvent", false)]
	public event Action KeyboardHidden
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UseSuggestedLocation(KeyboardPosition position)
	{
	}

	public void SendVirtualKeyboardRayInput(Transform inputTransform, InputSource source, bool isPressed, bool useRaycastMask = true)
	{
	}

	public void SendVirtualKeyboardDirectInput(Vector3 position, InputSource source, bool isPressed, Transform interactorRootTransform = null)
	{
	}

	public void ChangeTextContext(string textContext)
	{
	}

	private void LoadRuntimeVirtualKeyboardMesh()
	{
	}
	private IEnumerator InitializeGlTFModel()
	{
		return null;
	}

	private static void ApplyHideFlags(Transform t)
	{
	}

	private void PopulateCollision()
	{
	}

	private void ShowKeyboard()
	{
	}

	private void SetKeyboardVisibility(bool visible)
	{
	}

	private void HideKeyboard()
	{
	}

	private void DestroyKeyboard()
	{
	}

	private float MaxElement(Vector3 vec)
	{
		return 0f;
	}

	private OVRPlugin.VirtualKeyboardLocationInfo ComputeLocation(Transform transform)
	{
		return default(OVRPlugin.VirtualKeyboardLocationInfo);
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void SendVirtualKeyboardInput(OVRPlugin.VirtualKeyboardInputSource inputSource, OVRPose pose, bool isPressed, Transform interactorRootTransform = null)
	{
	}

	private void UpdateInputs()
	{
	}

	private void SyncKeyboardLocation()
	{
	}

	private void UpdateAnimationState()
	{
	}

	private IntPtr AnimationStatesBufferProvider(int bufferLength, int count)
	{
		return (IntPtr)0;
	}

	private void AnimationStateHandler(ref OVRPlugin.VirtualKeyboardModelAnimationState state)
	{
	}

	private void OnCommitText(string text)
	{
	}

	private void OnTextHandlerChange(string textContext)
	{
	}

	private void ChangeTextContextInternal(string textContext)
	{
	}

	private void OnBackspace()
	{
	}

	private void OnEnter()
	{
	}

	private void OnKeyboardShown()
	{
	}

	private void OnKeyboardHidden()
	{
	}

	private void UpdateVisibleState()
	{
	}
}
