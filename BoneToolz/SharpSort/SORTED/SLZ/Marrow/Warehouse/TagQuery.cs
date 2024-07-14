using System;
 
 
 
 
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
    [Serializable]
    public class TagQuery
    {
        [SerializeField]
        private BoneTagReference _boneTag;
        public BoneTagReference BoneTag { get => _boneTag; set => _boneTag = value; }

        [Tooltip("Exclude")]
        [SerializeField]
        public bool _invert = false;
        public bool Invert { get => _invert; set => _invert = value; }
    }
}