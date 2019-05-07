namespace ExceptionRules
{
    public sealed partial class Rule
    {
        public sealed partial class Params<TP>
        {
            internal Params(
                InternalCreate internalCreate,
                InternalThrow internalThrow)
            {
                InternalCreate = internalCreate;
                InternalThrow = internalThrow;
            }

            public delegate string FormatMessage(string paramName, TP argument);

            public delegate bool ShouldThrow(TP argument);

            internal InternalCreate InternalCreate { get; }

            internal InternalThrow InternalThrow { get; }
        }
    }
}