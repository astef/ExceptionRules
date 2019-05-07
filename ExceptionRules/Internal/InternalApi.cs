namespace ExceptionRules
{
    internal static class InternalApi
    {
        public static void Create(InternalCreate create)
        {
        }

        public static void Throw(InternalCreate create, InternalThrow @throw)
        {
        }

        public static void Check(InternalCheck check, InternalCreate create, InternalThrow @throw)
        {
        }

        public static void Check<T1>(
            InternalCheck<T1> check,
            InternalCreate create,
            InternalThrow @throw,
            T1 arg)
        {
        }

        public static void Check<T1, T2>(
            InternalCheck<T1, T2> check,
            InternalCreate create,
            InternalThrow @throw,
            T1 arg1,
            T2 arg2)
        {
        }
    }
}