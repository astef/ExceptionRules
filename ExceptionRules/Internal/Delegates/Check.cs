namespace ExceptionRules
{
    internal delegate bool Check();

    internal delegate bool Check<in T>(T arg);

    internal delegate bool Check<in T1, in T2>(T1 arg1, T2 arg2);
}