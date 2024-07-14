// UltEvents // Copyright 2021 Kybernetik //

namespace UltEvents
{
    /// <summary>[Editor-Only] The names of various types and members in <see cref="UltEvents"/>.</summary>
    internal static class Names
    {
        public const string
            Namespace = "UltEvents";
        public const string
            PersistentArgumentType = "PersistentArgumentType";

        /// <summary>[Editor-Only] The names of various members in <see cref="UltEvents.PersistentArgument"/>.</summary>
        internal static class PersistentArgument
        {
            public const string
                Class = "PersistentArgument";
            public const string

                Type = "_Type";
            public const string
                Int = "_Int";
            public const string
                String = "_String";
            public const string
                X = "_X";
            public const string
                Y = "_Y";
            public const string
                Z = "_Z";
            public const string
                W = "_W";
            public const string
                Object = "_Object";

            /// <summary>[Editor-Only] The full names of various members in <see cref="UltEvents.PersistentArgument"/>.</summary>
            internal static class Full
            {
                public const string
                    Type = "PersistentArgument.Type";
            }
        }

        /// <summary>[Editor-Only] The names of various members in <see cref="UltEvents.PersistentCall"/>.</summary>
        internal static class PersistentCall
        {
            public const string
                Target = "_Target";
            public const string
                MethodName = "_MethodName";
            public const string
                PersistentArguments = "_PersistentArguments";
        }

        /// <summary>[Editor-Only] The names of various members in <see cref="UltEvents.UltEvent"/>.</summary>
        internal static class UltEvent
        {
            public const string
                Class = "UltEvent";
            public const string
                PersistentCalls = "_PersistentCalls";
        }
    }
}