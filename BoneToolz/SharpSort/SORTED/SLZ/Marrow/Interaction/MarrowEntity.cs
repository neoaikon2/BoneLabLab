 
 
 
using SLZ.Marrow.Warehouse;
 
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
    [SelectionBase]
    public partial class MarrowEntity : MonoBehaviour, ITaggable
    {
        [field: Header("Marrow Entity")]
        [SerializeField]
        private TagList _tags;
        public TagList Tags => _tags;
#if UNITY_EDITOR || DEVELOPMENT_BUILD
#endif
    }
}