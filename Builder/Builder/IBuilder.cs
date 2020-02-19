using ImmutableNet;
using System;

namespace Builder
{
    public interface IBuilder<T>
    {
        T Build();
        Immutable<T> BuildAsImmutable();
        IBuilder<T> WithProperty(Action<T> propertySetter);
    }
}