namespace ExceptionRules
{
    public sealed partial class Rule
    {
        public sealed class Check
        {
            internal Check(
                InternalCheck internalCheck,
                InternalCreate internalCreate,
                InternalThrow internalThrow)
            {
                InternalCheck = internalCheck;
                InternalCreate = internalCreate;
                InternalThrow = internalThrow;
            }

            internal InternalCheck InternalCheck { get; }

            internal InternalCreate InternalCreate { get; }

            internal InternalThrow InternalThrow { get; }
        }
    }
}