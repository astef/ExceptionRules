using System;

namespace ExceptionRules
{
    public interface IExceptionThrow
    {
        void Throw(Exception innerException = null);
    }
}