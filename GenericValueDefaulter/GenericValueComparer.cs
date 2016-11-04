using System;

namespace GenericValueDefaulter
{
    public class GenericValueComparer<T> : IGenericValueComparer<T>
        where T : IComparable
    {
        private readonly T _minimumValue;

        public GenericValueComparer(T minimumValue)
        {
            if (minimumValue == null) throw new ArgumentNullException(nameof(minimumValue));

            _minimumValue = minimumValue;
        }

        public T MinOrValue(T value)
        {
            return value.CompareTo(_minimumValue) >= 0 ? value : _minimumValue;
        }
    }
}
