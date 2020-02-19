using ImmutableNet;
using System;

namespace Builder
{
    public class Builder<T> : IBuilder<T>
    {
        private readonly T _classInstance;

        public Builder()
        {
            _classInstance = (T) Activator.CreateInstance(typeof(T), true);
        }

        public T Build()
        {
            return _classInstance;
        }

        public Immutable<T> BuildAsImmutable()
        {
            return Immutable.Create(_classInstance);
        }

        public IBuilder<T> WithProperty(Action<T> propertySetter)
        {
            propertySetter.Invoke(_classInstance);

            return this;
        }
    }
}