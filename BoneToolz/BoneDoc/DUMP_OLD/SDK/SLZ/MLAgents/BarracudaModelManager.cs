using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Barracuda;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.MLAgents
{
	public class BarracudaModelManager : MonoBehaviour
	{
		public class AgentBackFill : UnityEvent<int, int>
		{
			public AgentBackFill()
				: base()
			{
			}
		}

		public static List<BarracudaModelManager> Instances;

		[Header("Model/Inference Pipeline Specific")]
		[Tooltip("Config holding values for Model Manager")]
		public ModelManagerConfig bmmConfig;

		[Tooltip("The neural network to do inference with")]
		public NNModel srcModel;

		[Tooltip("Indicates if model, engine, and dicts are fully ready")]
		public bool warm;

		private Model _model;

		private IWorker _engine;

		[Tooltip("Indicates if model and engine need to be loaded/created")]
		private bool _needsInit;

		public UnityEvent agentTakeActionEvent;

		public UnityEvent agentCollectObservationsEvent;

		public AgentBackFill agentBackFill;

		[Header("Inference Agent Specific")]
		[Tooltip("How many agents the BMM is responsible for managing")]
		public int nbAgents;

		private List<int> _availableInds;

		[Header("BMM Data Specific")]
		public Dictionary<string, Tensor> TensorObservationDict;

		public Dictionary<string, float[]> FloatObservationDict;

		public Dictionary<string, Tensor> TensorActionDict;

		private List<InferenceAgent> _agentList;

		[Tooltip("Fills public arrays that can be used for quick debugging")]
		public bool useDbgArrays;

		[Tooltip("Public array containing all agent's inputs")]
		public float[] fullDbgInput;

		[Tooltip("Indicates if tensor dictionaries need to be re-instantiated")]
		public bool reInitDicts;

		[Tooltip("Size of action mask (this is required for discrete actions)")]
		public int actionmaskSize;

		[Tooltip("Names of the different outputs to reference when agents are trying to get their actions")]
		public string[] outputNames;

		[Tooltip("Size of input for nn")]
		public int observationSize;

		private int _batchSize;

		private Tensor _output;

		private Dictionary<string, Tensor> _outputDict;

		private Tensor _actionMaskTensor;

		private float[] _actionMask;

		[Tooltip("How many layers to operate on per BMM output tick")]
		public int nbNetworkSlices;

		[Tooltip("Whether to allow for extra steps in the decision request pipeline for the simulation to update before next observation is made")]
		public bool doSimUpdate;

		[Tooltip("How many steps to use that updates the sim state before next observation is made")]
		public int nbSimSteps;

		[Tooltip("Used for breaking out of inference loop")]
		public bool exitWorker;

		[Tooltip("Indicates if the inference coroutine is running")]
		public bool running;

		private IEnumerator _engineIterator;

		private void Awake()
		{
		}

		public void InitBMM()
		{
		}

		public void InitFromConfig(ModelManagerConfig bmmConfig)
		{
		}

		public void WarmStartFromConfig(ModelManagerConfig bmmConfig)
		{
		}

		public void WarmUp()
		{
		}

		public void StartManager()
		{
		}

		public void StopManager()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		public void ConnectAgentToBmm(GameObject agent, int agentId)
		{
		}

		public void RegisterAgent(InferenceAgent agent, ulong pooleeId)
		{
		}

		public void UnRegisterAgent(InferenceAgent agent, ulong pooleeId)
		{
		}

		public void InitDictionaries()
		{
		}

		private void InitializeObservationDict()
		{
		}

		private void IngestAgentObservations(int id, float[] observations, string observationString)
		{
		}

		private void AcceptAllActionMask()
		{
		}

		public void WipeEverything()
		{
		}

		public void DisposeDataOnly()
		{
		}

		private void TensorDisposal()
		{
		}

		private void DisposeObservationTensors()
		{
		}

		private void DisposeActionTensors()
		{
		}

		private void DisposeOutputTensor()
		{
		}

		private void DisposeEngine()
		{
		}

		private void ClearAllDictionaries()
		{
		}

		private IEnumerator Run()
		{
			return null;
		}

		private void QueryModelOutput()
		{
		}

		private Dictionary<string, Tensor> QueryModelOutputs()
		{
			return null;
		}

		private IEnumerator WaitForAllOutputs(Dictionary<string, Tensor> outputs)
		{
			return null;
		}

		private void FillTensorActions()
		{
		}

		private IEnumerator SlicedInference()
		{
			return null;
		}

		private void AgentCollectSignal()
		{
		}

		private void SendActionsToAgents()
		{
		}

		private IEnumerator DoSimUpdate()
		{
			return null;
		}

		private bool CheckForEarlyInferenceExit()
		{
			return default(bool);
		}

		private IEnumerator CheckForLateInferenceExit()
		{
			return null;
		}

		public BarracudaModelManager()
			: base()
		{
		}
	}
}
