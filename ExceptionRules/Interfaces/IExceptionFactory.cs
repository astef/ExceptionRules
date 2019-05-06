using System;

namespace ExceptionRules
{
    public interface IExceptionFactory
    {
        Exception Create(Exception innerException = null);
    }
}