namespace ExceptionRules
{
    public interface IExceptionCheck
    {
        void Check();
    }

    public interface IExceptionCheck<in T>
    {
        void Check(T arg);
    }

    public interface IExceptionCheck<in T1, in T2>
    {
        void Check(T1 arg1, T2 arg2);
    }
}