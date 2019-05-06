namespace ExceptionRules
{
    public sealed partial class ParametersRule<T>
    {
        public sealed class CheckableParametersRule
        {
            public CheckableParametersRule SetMessage(FormatMessage formatMessage)
            {
                return new CheckableParametersRule();
            }

            public void Check()
            {
            }
        }
    }
}