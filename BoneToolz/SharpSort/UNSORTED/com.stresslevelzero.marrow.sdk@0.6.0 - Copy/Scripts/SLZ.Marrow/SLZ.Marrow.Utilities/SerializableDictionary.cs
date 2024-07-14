using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
    public interface ISerializableDictionary
    {
        SerializableType KeyType { get; }

        SerializableType ValueType { get; }
    }

    [Serializable]
    public class SerializableDictionary<K, V> : Dictionary<K, V>, ISerializationCallbackReceiver, ISerializableDictionary
    {
        [SerializeField]
        private List<K> _keys = new List<K>();
        [SerializeField]
        private List<V> _values = new List<V>();
        [SerializeField]
        private SerializableType _keyType = typeof(K);
        public SerializableType KeyType
        {
            get
            {
                return _keyType;
            }
        }

        [SerializeField]
        private SerializableType _valueType = typeof(V);
        public SerializableType ValueType
        {
            get
            {
                return _valueType;
            }
        }

        public void OnBeforeSerialize()
        {
            _keys.Clear();
            _values.Clear();
            foreach (var kvp in this)
            {
                _keys.Add(kvp.Key);
                _values.Add(kvp.Value);
            }
        }

        public void OnAfterDeserialize()
        {
            for (int i = 0; i < _keys.Count; i++)
            {
                if (!ContainsKey(_keys[i]))
                    Add(_keys[i], _values[i]);
                else
                    this[_keys[i]] = _values[i];
            }

            _keys.Clear();
            _values.Clear();
        }

        public void AddSafe(K key, V value)
        {
            if (!ContainsKey(key))
            {
                Add(key, value);
            }
        }
    }

    public class SerializeDictionaryAttribute : PropertyAttribute
    {
        public SerializeDictionaryAttribute()
        {
        }
    }

    public class ReadOnlyDictionaryAttribute : PropertyAttribute
    {
    }
}