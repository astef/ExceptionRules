using System;

namespace ExceptionRules
{
    internal delegate T Create<out T>(
        string message = null,
        Exception innerException = null)
        where T : Exception;
}