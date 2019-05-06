using System;
using System.Runtime.Serialization;

namespace ExceptionRules
{
    [Serializable]
    public class RuleDefinitionException : Exception
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

        protected RuleDefinitionException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}