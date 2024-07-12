using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	internal interface ISubsystemPlugin
	{
		void CreateSubsystem<TDescriptor, TSubsystem>(List<TDescriptor> descriptors, string id) where TDescriptor : ISubsystemDescriptor where TSubsystem : ISubsystem;

		void StartSubsystem<T>() where T : class, ISubsystem;

		void StopSubsystem<T>() where T : class, ISubsystem;

		void DestroySubsystem<T>() where T : class, ISubsystem;
	}
}
