using System;

namespace ExceptionRules
{
    public sealed class Rule
    {
        private readonly string _message;

        private readonly Func<Exception> _exceptionFactory;

        private Rule(string message, Func<Exception> exceptionFactory)
        {
            _message = message;
            _exceptionFactory = exceptionFactory;
        }

        public static Rule SetMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new RuleDefinitionException($"'{nameof(message)}' is absent");
            return new Rule(message, null);
        }

        public static Rule SetException<T>()
            where T : Exception
        {
            return new Rule(null, null);
        }

        public static ValuesRule<T> ForValues<T>()
        {
            return new ValuesRule<T>();
        }

        public static ParametersRule<T> ForParameters<T>()
        {
            return new ParametersRule<T>();
        }
    }
}
