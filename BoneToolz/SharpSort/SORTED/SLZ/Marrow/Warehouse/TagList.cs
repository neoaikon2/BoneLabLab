using System;
 
using System.Collections.Generic;
 
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
    [Serializable]
    public class TagList
    {
        [SerializeField]
        public List<BoneTagReference> _tags = new List<BoneTagReference>();
        public List<BoneTagReference> Tags { get => _tags; }

        private HashSet<string> _cachedTagBarcodes = new HashSet<string>();
        public HashSet<string> CachedTagBarcodes
        {
            get
            {
                if (!initialCache)
                {
                    UpdateCache();
                }

                return _cachedTagBarcodes;
            }

            set => _cachedTagBarcodes = value;
        }

        public ITaggable InheritTags { get => _inheritTags; set => _inheritTags = value; }

        private ITaggable _inheritTags;
        private bool initialCache = false;
        public void UpdateCache(bool initializeOnly = false)
        {
            if (!initializeOnly || !initialCache)
            {
                initialCache = true;
                _cachedTagBarcodes ??= new HashSet<string>();
                _cachedTagBarcodes.Clear();
                if (_inheritTags != null)
                {
                    _inheritTags.Tags.UpdateCache(true);
                    foreach (var tag in _inheritTags.Tags.Tags)
                    {
                        if (!_tags.Contains(tag))
                        {
                            _tags.Add(tag);
                        }
                    }
                }

                foreach (var tag in _tags)
                {
                    if (!_cachedTagBarcodes.Contains(tag.Barcode))
                    {
                        _cachedTagBarcodes.Add(tag.Barcode);
                    }
                }
            }
        }
    }

    public interface ITaggable
    {
        public TagList Tags { get; }
    }
}