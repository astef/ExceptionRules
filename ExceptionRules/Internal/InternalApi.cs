using System;

namespace ExceptionRules
{
    internal static class InternalApi
    {
        public static void Create<T>(Create<T> create)
            where T : Exception
        {
        }

        public static void Throw<T>(Create<T> create, Throw<T> @throw)
            where T : Exception
        {
        }

        public static void Check<T>(Check check, Create<T> create, Throw<T> @throw)
            where T : Exception
        {
        }

        public static void Check<T, T1>(
            Check<T1> check,
            Create<T> create,
            Throw<T> @throw,
            T1 arg)
            where T : Exception
        {
        }

        public static void Check<T, T1, T2>(
            Check<T1, T2> check,
            Create<T> create,
            Throw<T> @throw,
            T1 arg1,
            T2 arg2)
            where T : Exception
        {
        }
    }
}