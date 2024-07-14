 
 
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

 

namespace SLZ.Marrow.Utilities
{
    [System.Serializable]
    public struct SimpleTransform
    {
        public static SimpleTransform Identity = new()
        {
            position = Vector3.zero,
            rotation = Quaternion.identity
        };
        public Vector3 position;
        public Quaternion rotation;
        public Vector3 forward
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => rotation * Vector3.forward;
        }
        public Vector3 up
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => rotation * Vector3.up;
        }
        public Vector3 right
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => rotation * Vector3.right;
        }
        public SimpleTransform inverse
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Inverse(position, rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SimpleTransform Create(Vector3 p, Quaternion r) => new(p, r);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SimpleTransform Create(SimpleTransform st) => new(st);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SimpleTransform Inverse(Transform t) => Inverse(t.position, t.rotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SimpleTransform Create(Transform t) => new(t);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SimpleTransform Inverse(SimpleTransform st) => Inverse(st.position, st.rotation);
        public static SimpleTransform Inverse(Vector3 p, Quaternion r)
        {
            Quaternion inverse = Quaternion.Inverse(r);
            return new SimpleTransform(inverse * -p, inverse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SimpleTransform Transform(Transform transformA, SimpleTransform transformB) => new SimpleTransform(transformA).Transform(transformB);
        public static SimpleTransform Transform(Transform transformA, Transform transformB)
        {
            var st = new SimpleTransform(transformA);
            return st.InverseTransform(transformB);
        }

        public static SimpleTransform InverseTransform(Transform transformA, SimpleTransform transformB)
        {
            var st = new SimpleTransform(transformA);
            return st.InverseTransform(transformB);
        }

        public static SimpleTransform InverseTransform(Transform transformA, Transform transformB)
        {
            return new SimpleTransform(transformA).InverseTransform(transformB);
        }

        public SimpleTransform(Vector3 p, Quaternion r) => (position, rotation) = (p, r);
        public SimpleTransform(Transform t) => (position, rotation) = (t.position, t.rotation);
        public SimpleTransform(SimpleTransform st) => (position, rotation) = (st.position, st.rotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Copy(SimpleTransform st) => (position, rotation) = (st.position, st.rotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Copy(Transform t) => (position, rotation) = (t.position, t.rotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyLocal(Transform t) => (position, rotation) = (t.localPosition, t.localRotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyToLocal(Transform t) => t.SetLocalPositionAndRotation(position, rotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyTo(Transform t) => t.SetPositionAndRotation(position, rotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SimpleTransform InverseTransform(Transform t) => InverseTransform(t.position, t.rotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SimpleTransform InverseTransform(SimpleTransform st) => InverseTransform(st.position, st.rotation);
        public SimpleTransform InverseTransform(Vector3 p, Quaternion r)
        {
            Quaternion inverse = Quaternion.Inverse(rotation);
            return new SimpleTransform(inverse * (p - position), inverse * r);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 InverseTransformPoint(Vector3 p) => Quaternion.Inverse(rotation) * (p - position);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 InverseTransformDirection(Vector3 d) => Quaternion.Inverse(rotation) * d;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Quaternion InverseTransformRotation(Quaternion r) => Quaternion.Inverse(rotation) * r;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SimpleTransform RotateFrom(Quaternion r) => new(r * position, r * rotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SimpleTransform Transform(Transform t) => Transform(t.position, t.rotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SimpleTransform Transform(SimpleTransform st) => Transform(st.position, st.rotation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SimpleTransform Transform(Vector3 p, Quaternion r) => new(TransformPoint(p), TransformRotation(r));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 TransformPoint(Vector3 p) => position + rotation * p;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 TransformDirection(Vector3 d) => rotation * d;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Quaternion TransformRotation(Quaternion r) => rotation * r;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 DirectionTo(Vector3 p) => p - position;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 DirectionTo(SimpleTransform st) => st.position - position;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 DirectionTo(Transform t) => t.position - position;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 DirectionFrom(Vector3 p) => position - p;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 DirectionFrom(SimpleTransform st) => position - st.position;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 DirectionFrom(Transform t) => position - t.position;
        public static SimpleTransform Lerp(SimpleTransform fromST, SimpleTransform toST, float perc)
        {
            var percent = Mathf.Clamp01(perc);
            var position = Vector3.LerpUnclamped(fromST.position, toST.position, percent);
            var rotation = Quaternion.LerpUnclamped(fromST.rotation, toST.rotation, percent);
            return new SimpleTransform(position, rotation);
        }

        public bool Approximately(SimpleTransform other)
        {
            return Approximately(position, other.position) && Approximately(rotation, other.rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(float3 positionA, float3 positionB, float threshold = math.EPSILON)
        {
            float3 delta = positionA - positionB;
            return math.abs(delta.x) <= threshold && math.abs(delta.y) <= threshold && math.abs(delta.z) <= threshold;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(quaternion rotationA, quaternion rotationB, float threshold = math.EPSILON)
        {
            return math.abs(math.dot(rotationA, rotationB)) >= (1 - threshold);
        }
    }
}