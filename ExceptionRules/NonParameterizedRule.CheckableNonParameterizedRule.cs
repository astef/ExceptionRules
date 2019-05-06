namespace ExceptionRules
{
    public sealed partial class NonParameterizedRule
    {
        public sealed class CheckableNonParameterizedRule : IExceptionCheck
        {
            public CheckableNonParameterizedRule SetMessage(string message)
            {
                return new CheckableNonParameterizedRule();
            }

            public void Check()
            {
            }
        }
    }
}