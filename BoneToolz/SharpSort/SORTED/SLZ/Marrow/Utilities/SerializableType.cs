 
 
using System;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
    [Serializable]
    public sealed class SerializableType : ISerializationCallbackReceiver
    {
        private Type _type;
        public Type Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        [SerializeField]
        private string _typeString = "(INIT)";
        [SerializeField]
        private string _typeName = "[NAME]";
        public SerializableType(Type type)
        {
            Type = type;
            if (Type != null)
            {
                _typeString = Type.AssemblyQualifiedName;
                _typeName = Type.Name;
            }
        }

        public void OnBeforeSerialize()
        {
            if (Type != null)
            {
                _typeString = Type.AssemblyQualifiedName;
                _typeName = Type.Name;
            }
            else
            {
                _typeString = "(NONE)";
            }
        }

        public void OnAfterDeserialize()
        {
            if (!string.IsNullOrEmpty(_typeString) && !_typeString.Equals("(NONE)") && !_typeString.Equals("(INIT)") && !_typeString.Equals("(SERR)"))
            {
                Type = TypeFromString(_typeString);
            }
            else
            {
                Type = null;
            }

            _typeString = "(SERR)";
        }

        public static Type TypeFromString(string text)
        {
            return Type.GetType(text);
        }

        public static implicit operator Type(SerializableType serializableType)
        {
            return serializableType.Type;
        }

        public static implicit operator SerializableType(Type type)
        {
            return new SerializableType(type);
        }

        public override string ToString()
        {
            return Type != null ? Type.Name : "(None)";
        }

        public override int GetHashCode()
        {
            return Type != null ? Type.GetHashCode() : 0;
        }

        public override bool Equals(object obj)
        {
            return Type != null && obj.GetType() == typeof(SerializableType) && Type.Equals(((SerializableType)obj).Type);
        }
    }
}