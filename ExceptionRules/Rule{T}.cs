namespace ExceptionRules
{
    public sealed partial class Rule<T>
    {
        internal Rule(InternalCreate internalCreate, InternalThrow internalThrow)
        {
            InternalCreate = internalCreate;
            InternalThrow = internalThrow;
        }

        public delegate string FormatMessage(T value);

        public delegate bool ShouldThrow(T value);

        internal InternalCreate InternalCreate { get; }

        internal InternalThrow InternalThrow { get; }
    }
}