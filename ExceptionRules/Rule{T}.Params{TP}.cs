namespace ExceptionRules
{
    public sealed partial class Rule<T>
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

            public delegate string FormatMessage(T value, string paramName, TP argument);

            public delegate bool ShouldThrow(T value, TP argument);

            internal InternalCreate InternalCreate { get; }

            internal InternalThrow InternalThrow { get; }
        }
    }
}