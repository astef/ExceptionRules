using System;

namespace ExceptionRules
{
    public sealed partial class ParametersRule<T, TP>
        where T : Exception
    {
        public sealed partial class ParametersAndValuesRule<TV>
        {
            public sealed class CheckableParametersAndValuesRule : IExceptionCheck<TP, TV>
            {
                internal CheckableParametersAndValuesRule(
                    Check<TP, TV> internalCheck,
                    Create<T> internalCreate,
                    Throw<T> internalThrow)
                {
                    InternalCheck = internalCheck;
                    InternalCreate = internalCreate;
                    InternalThrow = internalThrow;
                }

                internal Check<TP, TV> InternalCheck { get; }

                internal Create<T> InternalCreate { get; }

                internal Throw<T> InternalThrow { get; }

                public void Check(TP arg1, TV arg2) => InternalApi.Check(
                    InternalCheck,
                    InternalCreate,
                    InternalThrow,
                    arg1,
                    arg2);
            }
        }
    }
}