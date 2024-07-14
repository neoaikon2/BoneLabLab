 
 
 
 
using SLZ.Marrow.Warehouse;
 
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
    [DisallowMultipleComponent]
    public partial class MarrowBody : MonoBehaviour, ITaggable
    {
        [field: SerializeField]
        public MarrowEntity Entity { get; private set; }

        [SerializeField]
        private TagList _tags;
        public TagList Tags => _tags;
    }
}