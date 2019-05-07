namespace ExceptionRules
{
    public sealed partial class Rule
    {
        public sealed partial class Params<TP>
        {
            public sealed class Check
            {
                internal Check(
                    InternalCheck<TP> internalCheck,
                    InternalCreate internalCreate,
                    InternalThrow internalThrow)
                {
                    InternalCheck = internalCheck;
                    InternalCreate = internalCreate;
                    InternalThrow = internalThrow;
                }

                internal InternalCheck<TP> InternalCheck { get; }

                internal InternalCreate InternalCreate { get; }

                internal InternalThrow InternalThrow { get; }
            }
        }
    }
}