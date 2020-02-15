namespace Builder
{
    public interface IBuilder<T>
    {
        T Build();
        IBuilder<T> WithProperty(string propertyName, object value);
    }
}