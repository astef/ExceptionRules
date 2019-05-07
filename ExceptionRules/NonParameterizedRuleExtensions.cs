using System;

namespace ExceptionRules
{
    public static class NonParameterizedRuleExtensions
    {
        //public static NonParameterizedRule<T> SetMessage<T>(this NonParameterizedRule<T> npRule, string message)
        //    where T : Exception
        //{
        //    return new NonParameterizedRule<T>(npRule.InternalCreate, npRule.InternalThrow);
        //}

        ////

        //public static ValuesRule<TV> UsingValues<T, TV>(this NonParameterizedRule<T> npRule)
        //    where T : Exception
        //{
        //    return new ValuesRule<TV>();
        //}

        //public static ParametersRule<TP> UsingParameters<T, TP>(this NonParameterizedRule<T> npRule)
        //    where T : Exception
        //{
        //    return new ParametersRule<TP>();
        //}

        //public static NonParameterizedRule<T>.CheckableNonParameterizedRule SetThrowCondition<T>(
        //    this NonParameterizedRule<T> npRule,
        //    NonParameterizedRule<T>.ShouldThrow shouldThrow)
        //    where T : Exception
        //{
        //    return new NonParameterizedRule<T>.CheckableNonParameterizedRule(null, null, null);
        //}

    }
}