using System;

namespace Builder
{
    public interface IBuilder<T>
    {
        T Build();
        IBuilder<T> WithProperty(string propertyName, object value);
        IBuilder<T> WithProperty(Action<T> propertySetter);
    }
}