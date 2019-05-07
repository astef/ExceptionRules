namespace ExceptionRules
{
    public sealed partial class Rule<T>
    {
        public sealed class Check
        {
            internal Check(
                InternalCheck<T> internalCheck,
                InternalCreate internalCreate,
                InternalThrow internalThrow)
            {
                InternalCheck = internalCheck;
                InternalCreate = internalCreate;
                InternalThrow = internalThrow;
            }

            internal InternalCheck<T> InternalCheck { get; }

            internal InternalCreate InternalCreate { get; }

            internal InternalThrow InternalThrow { get; }
        }
    }
}