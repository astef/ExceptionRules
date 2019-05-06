using System;

namespace ExceptionRules
{
    [Serializable]
    public sealed class RuleDefinitionException : Exception
    {
        public RuleDefinitionException()
        {
        }

        public RuleDefinitionException(string message) : base(message)
        {
        }

        public RuleDefinitionException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}