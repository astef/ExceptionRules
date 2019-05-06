using System;

namespace ExceptionRules
{
    public sealed partial class NonParameterizedRule : IExceptionFactory, IExceptionThrow
    {
        internal NonParameterizedRule()
        {

        }

        public delegate bool ShouldThrow();

        public NonParameterizedRule SetMessage(string message)
        {
            return new NonParameterizedRule();
        }

        //

        public ValuesRule<T> UsingValues<T>()
        {
            return new ValuesRule<T>();
        }

        public ParametersRule<T> UsingParameters<T>()
        {
            return new ParametersRule<T>();
        }

        public CheckableNonParameterizedRule SetThrowCondition(ShouldThrow shouldThrow)
        {
            return new CheckableNonParameterizedRule();
        }

        public Exception Create(Exception innerException = null)
        {
            throw new NotImplementedException();
        }

        public void Throw(Exception innerException = null)
        {
            throw new NotImplementedException();
        }
    }
}