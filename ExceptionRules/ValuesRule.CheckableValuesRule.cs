namespace ExceptionRules
{
    public sealed partial class ValuesRule<T>
    {
        public sealed class CheckableValuesRule
        {
            public CheckableValuesRule SetMessage(FormatMessage formatMessage)
            {
                return new CheckableValuesRule();
            }

            public void Check()
            {
            }
        }
    }
}