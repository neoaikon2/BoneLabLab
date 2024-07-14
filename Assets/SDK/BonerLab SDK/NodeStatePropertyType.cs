using System;

public enum NodeStatePropertyType
{
	[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
	Acceleration = 0,
	[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
	AngularAcceleration = 1,
	Velocity = 2,
	AngularVelocity = 3,
	Position = 4,
	Orientation = 5
}
