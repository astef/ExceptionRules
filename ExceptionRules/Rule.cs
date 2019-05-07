using System;

namespace ExceptionRules
{
    public static class Rule
    {
        public static NonParameterizedRule<T> For<T>()
            where T : Exception
        {
            return new NonParameterizedRule<T>(null, null);
        }
    }
}
