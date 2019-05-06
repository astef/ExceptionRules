using System;

namespace ExceptionRules
{
    public static class Rule
    {
        public static NonParameterizedRule For<T>()
            where T : Exception
        {
            return new NonParameterizedRule();
        }
    }
}
