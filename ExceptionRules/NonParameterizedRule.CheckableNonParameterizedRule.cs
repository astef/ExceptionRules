using System;

namespace ExceptionRules
{
    public sealed partial class NonParameterizedRule<T>
        where T : Exception
    {
        public sealed class CheckableNonParameterizedRule : IExceptionCheck
        {
            internal CheckableNonParameterizedRule(
                Check internalCheck,
                Create<T> internalCreate,
                Throw<T> internalThrow)
            {
                InternalCheck = internalCheck;
                InternalCreate = internalCreate;
                InternalThrow = internalThrow;
            }

            //public Check SetMessage(string message)
            //{
            //    return new CheckableNonParameterizedRule();
            //}

            internal Check InternalCheck { get; }

            internal Create<T> InternalCreate { get; }

            internal Throw<T> InternalThrow { get; }

            public void Check() => InternalApi.Check(InternalCheck, InternalCreate, InternalThrow);
        }
    }
}