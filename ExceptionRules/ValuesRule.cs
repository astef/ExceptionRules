using System;

namespace ExceptionRules
{
    public sealed partial class ValuesRule<T, TV> : IExceptionFactory, IExceptionThrow
        where T : Exception
    {
        internal ValuesRule(
            Create<T> internalCreate,
            Throw<T> internalThrow)
        {
            InternalCreate = internalCreate;
            InternalThrow = internalThrow;
        }

        public delegate string FormatMessage(TV value1);

        public delegate bool ShouldThrow(TV value1);

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