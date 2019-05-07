using System;

namespace ExceptionRules
{
    public sealed partial class ParametersRule<T, TP> : IExceptionFactory, IExceptionThrow
        where T : Exception
    {
        internal ParametersRule(Create<T> internalCreate, Throw<T> internalThrow)
        {
            InternalCreate = internalCreate;
            InternalThrow = internalThrow;
        }

        public delegate string FormatMessage(string par1, TP arg1);

        public delegate bool ShouldThrow(TP argument1);

        internal Create<T> InternalCreate { get; }

        internal Throw<T> InternalThrow { get; }

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