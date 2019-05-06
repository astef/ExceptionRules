namespace ExceptionRules.Tests.TestExceptions
{
    internal sealed class DerivedAllCtorsException : AllCtorsException
    {
        public DerivedAllCtorsException()
        {
            CtorStatus = ExceptionCtorStatus.EmptySetup;
        }
    }
}