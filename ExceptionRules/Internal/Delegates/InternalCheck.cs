namespace ExceptionRules
{
    internal delegate bool InternalCheck();

    internal delegate bool InternalCheck<in T>(T arg);

    internal delegate bool InternalCheck<in T1, in T2>(T1 arg1, T2 arg2);
}