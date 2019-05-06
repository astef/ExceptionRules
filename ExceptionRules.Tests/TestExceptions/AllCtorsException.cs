using System;
using System.Runtime.Serialization;

namespace ExceptionRules.Tests.TestExceptions
{
    [Serializable]
    internal class AllCtorsException : Exception, IExceptionCtorMock
    {
        public AllCtorsException()
        {
            CtorStatus = ExceptionCtorStatus.EmptySetup;
        }

        public AllCtorsException(string message) : base(message)
        {
            if (message != null)
                CtorStatus = ExceptionCtorStatus.MessageSetup;
        }

        public AllCtorsException(string message, Exception inner) : base(message, inner)
        {
            if (inner != null)
                CtorStatus = ExceptionCtorStatus.FullSetup;
        }

        public AllCtorsException(Exception exception)
        {
        }

        public AllCtorsException(Exception exception, string message)
        {
        }

        public AllCtorsException(object message)
        {
        }

        protected AllCtorsException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

        public ExceptionCtorStatus CtorStatus { get; protected set; }
    }
}