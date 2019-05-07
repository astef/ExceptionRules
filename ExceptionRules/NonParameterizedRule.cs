using System;

namespace ExceptionRules
{
    public sealed partial class NonParameterizedRule<T> : IExceptionFactory, IExceptionThrow
        where T : Exception
    {
        internal NonParameterizedRule(Create<T> internalCreate, Throw<T> internalThrow)
        {
            InternalCreate = internalCreate;
            InternalThrow = internalThrow;
        }

        public delegate bool ShouldThrow();

        internal Create<T> InternalCreate { get; }

        internal Throw<T> InternalThrow { get; }

        public Exception Create(Exception innerException = null)
        {
            throw new NotImplementedException();
        }

        public void Throw(Exception innerException = null)
        {
            throw new NotImplementedException();
        }
    }
}