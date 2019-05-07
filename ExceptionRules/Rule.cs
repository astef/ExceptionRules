﻿namespace ExceptionRules
{
    public sealed partial class Rule
    {
        internal Rule(InternalCreate internalCreate, InternalThrow internalThrow)
        {
            InternalCreate = internalCreate;
            InternalThrow = internalThrow;
        }

        public delegate bool ShouldThrow();

        internal InternalCreate InternalCreate { get; }

        internal InternalThrow InternalThrow { get; }
    }
}