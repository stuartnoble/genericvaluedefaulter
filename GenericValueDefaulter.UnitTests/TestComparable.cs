using System;

namespace GenericValueDefaulter.UnitTests
{
    internal class TestComparable : IComparable<TestComparable>, IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {

            if (obj != null && !(obj is TestComparable))
            {
                throw new ArgumentException("Object must be of type TestComparable.");
            }

            return CompareTo((TestComparable)obj);
        }

        public int CompareTo(TestComparable other)
        {
            if (ReferenceEquals(other, null))
            {
                return 1;
            }

            return String.Compare(Name, other.Name, StringComparison.Ordinal)
                   | Age.CompareTo(other.Age);
        }
    }
}