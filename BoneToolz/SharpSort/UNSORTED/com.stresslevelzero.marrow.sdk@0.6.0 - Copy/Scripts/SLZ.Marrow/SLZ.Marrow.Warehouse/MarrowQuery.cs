using System;
 
using System.Collections.Generic;
 
 
 
using UnityEngine;

 

namespace SLZ.Marrow.Warehouse
{
    [Serializable]
    public class MarrowQuery
    {
        [Tooltip("Matches if contains ALL listed tags")]
        [SerializeField]
        private List<TagQuery> _tags = new List<TagQuery>();
        public List<TagQuery> Tags { get => _tags; set => _tags = value; }

        [Tooltip("Sets the operator between Tags/Crates")]
        [SerializeField]
        private LogicOperator _operator = LogicOperator.And;
        public LogicOperator TagCrateOperator { get => _operator; set => _operator = value; }

        [Tooltip("Matches if is any listed crates")]
        [SerializeField]
        private List<GenericCrateReference> _crates = new List<GenericCrateReference>();
        public List<GenericCrateReference> Crates { get => _crates; set => _crates = value; }

        public enum LogicOperator
        {
            And = 0,
            Or = 1
        }
    }
}