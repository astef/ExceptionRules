using System;

namespace ExceptionRules
{
    public sealed partial class ParametersRule<T, TP>
        where T : Exception
    {
        public sealed partial class ParametersAndValuesRule<TV> : IExceptionFactory, IExceptionThrow
        {
            internal ParametersAndValuesRule(
                Create<T> internalCreate,
                Throw<T> internalThrow)
            {
                InternalCreate = internalCreate;
                InternalThrow = internalThrow;
            }

            public delegate string FormatMessage(string par1, TP arg1, TV value1);

            public delegate bool ShouldThrow(TP argument1, TV value1);

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
}