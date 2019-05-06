namespace ExceptionRules
{
    public sealed partial class ParametersRule<T>
    {
        public sealed partial class ParametersAndValuesRule<TV>
        {
            public sealed class CheckableParametersAndValuesRule
            {
                public CheckableParametersAndValuesRule SetMessage(FormatMessage formatMessage)
                {
                    return new CheckableParametersAndValuesRule();
                }

                public void Check()
                {
                }
            }
        }
    }
}