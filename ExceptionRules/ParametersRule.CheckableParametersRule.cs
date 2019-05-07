using System;

namespace ExceptionRules
{
    public sealed partial class ParametersRule<T, TP>
        where T : Exception
    {
        public sealed class CheckableParametersRule : IExceptionCheck<TP>
        {
            internal CheckableParametersRule(
                Check<TP> internalCheck,
                Create<T> internalCreate,
                Throw<T> internalThrow)
            {
                InternalCheck = internalCheck;
                InternalCreate = internalCreate;
                InternalThrow = internalThrow;
            }

            internal Check<TP> InternalCheck { get; }

            internal Create<T> InternalCreate { get; }

            internal Throw<T> InternalThrow { get; }

            public void Check(TP arg) => InternalApi.Check(InternalCheck, InternalCreate, InternalThrow, arg);
        }
    }
}