using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow
{
	public interface IResumePoint
	{
		Transform SpawnLocation { get; }

		UnityEvent OnReachedResumePoint { get; }
	}
}
