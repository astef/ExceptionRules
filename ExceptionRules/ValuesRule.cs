namespace ExceptionRules
{
    public sealed partial class ValuesRule<T>
    {
        internal ValuesRule()
        {
        }

        public delegate string FormatMessage(T value1);

        public delegate bool ShouldThrow(T value1);

        public ValuesRule<T> SetMessage(FormatMessage formatMessage)
        {
            return new ValuesRule<T>();
        }

        public CheckableValuesRule SetThrowCondition(ShouldThrow shouldThrow)
        {
            return new CheckableValuesRule();
        }
    }
}