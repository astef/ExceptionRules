using System;

namespace ExceptionRules
{
    public sealed partial class ValuesRule<T, TV>
        where T : Exception
    {
        public sealed class CheckableValuesRule : IExceptionCheck<TV>
        {
            internal CheckableValuesRule(
                Check<TV> internalCheck,
                Create<T> internalCreate,
                Throw<T> internalThrow)
            {
                InternalCheck = internalCheck;
                InternalCreate = internalCreate;
                InternalThrow = internalThrow;
            }

            internal Check<TV> InternalCheck { get; }

            internal Create<T> InternalCreate { get; }

            internal Throw<T> InternalThrow { get; }

            public void Check(TV arg) => InternalApi.Check(
                InternalCheck,
                InternalCreate,
                InternalThrow,
                arg);
        }
    }
}