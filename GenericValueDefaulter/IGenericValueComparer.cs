namespace GenericValueDefaulter
{
    public interface IGenericValueComparer<T>
    {
        T MinOrValue(T value);
    }
}