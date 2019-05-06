namespace ExceptionRules
{
    public sealed partial class ParametersRule<T>
    {
        public sealed partial class ParametersAndValuesRule<TV>
        {
            public delegate string FormatMessage(string par1, T arg1, TV value1);

            public delegate bool ShouldThrow(T argument1, TV value1);

            public ParametersAndValuesRule<TV> SetMessage(FormatMessage messageFormat)
            {
                return new ParametersAndValuesRule<TV>();
            }

            public CheckableParametersAndValuesRule SetThrowCondition(ShouldThrow shouldThrow)
            {
                return new CheckableParametersAndValuesRule();
            }
        }
    }
}