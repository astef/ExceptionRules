using System;

namespace ExceptionRules.Tests.TestExceptions
{
    [Serializable]
    public sealed class OnlyFullCtorException : Exception, IExceptionCtorMock
    {
        public OnlyFullCtorException(string message, Exception inner) : base(message, inner)
        {
            if (message == null && inner == null)
                CtorStatus = ExceptionCtorStatus.EmptySetup;
            if (message != null && inner == null)
                CtorStatus = ExceptionCtorStatus.MessageSetup;
            if (inner != null)
                CtorStatus = ExceptionCtorStatus.FullSetup;
        }

        public ExceptionCtorStatus CtorStatus { get; }
    }
}