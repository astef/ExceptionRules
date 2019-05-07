using System;

namespace ExceptionRules
{
    internal delegate Exception InternalCreate(string message = null, Exception innerException = null);
}