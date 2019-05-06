namespace ExceptionRules
{
    public sealed partial class ParametersRule<T>
    {
        internal ParametersRule()
        {
        }

        public delegate string FormatMessage(string par1, T arg1);

        public delegate bool ShouldThrow(T argument1);

        public ParametersRule<T> SetMessage(FormatMessage formatMessage)
        {
            return new ParametersRule<T>();
        }

        public CheckableParametersRule SetThrowCondition(ShouldThrow shouldThrow)
        {
            return new CheckableParametersRule();
        }

        public ParametersAndValuesRule<TV> AndValues<TV>()
        {
            return new ParametersAndValuesRule<TV>();
        }
    }
}