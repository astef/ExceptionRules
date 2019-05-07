using System;

namespace ExceptionRules
{
    internal delegate void Throw<in T>(T exception)
        where T : Exception;
}