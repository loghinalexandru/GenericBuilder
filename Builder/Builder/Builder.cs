using System;
using System.Linq;

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

        public IBuilder<T> WithProperty(Action<T> propertySetter)
        {
            propertySetter.Invoke(_classInstance);

            return this;
        }

        public IBuilder<T> WithProperty(string propertyName, object value)
        {
            var property = typeof(T).GetProperties().FirstOrDefault(prop =>
                string.Equals(prop.Name, propertyName, StringComparison.InvariantCultureIgnoreCase));

            if (property == null)
            {
                throw new ArgumentException("Object property could not be found!");
            }

            property.GetSetMethod(true).Invoke(_classInstance, new[] {value});

            return this;
        }
    }
}