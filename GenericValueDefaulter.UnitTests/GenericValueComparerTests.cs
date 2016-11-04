using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericValueDefaulter.UnitTests
{
    [TestClass]
    public class GenericValueComparerTests
    {
        #region Int Test Methods

        [TestMethod]
        public void MinOrValue_NegativeInt_ReturnsMinIntValue()
        {
            const int NEGATIVE_VALUE = -1;
            IGenericValueComparer<int> intValueComparer = CreateIntValueComparer();

            int returnValue = intValueComparer.MinOrValue(NEGATIVE_VALUE);

            Assert.AreEqual(returnValue, MIN_INT_VALUE);
        }

        [TestMethod]
        public void MinOrValue_ZeroInt_ReturnsMinIntValue()
        {
            const int ZERO_VALUE = 0;
            IGenericValueComparer<int> intValueComparer = CreateIntValueComparer();

            int returnValue = intValueComparer.MinOrValue(ZERO_VALUE);

            Assert.AreEqual(returnValue, MIN_INT_VALUE);
        }

        [TestMethod]
        public void MinOrValue_PositiveInt_ReturnsSameValue()
        {
            const int POSITIVE_VALUE = 2;
            IGenericValueComparer<int> intValueComparer = CreateIntValueComparer();

            int returnValue = intValueComparer.MinOrValue(POSITIVE_VALUE);

            Assert.AreEqual(returnValue, POSITIVE_VALUE);
        }

        [TestMethod]
        public void MinOrValue_EqualValueInt_ReturnsSameValue()
        {
            const int EQUAL_VALUE = 1;
            IGenericValueComparer<int> intValueComparer = CreateIntValueComparer();

            int returnValue = intValueComparer.MinOrValue(EQUAL_VALUE);

            Assert.AreEqual(returnValue, EQUAL_VALUE);
        }

        #endregion

        #region Long Test Methods

        [TestMethod]
        public void MinOrValue_NegativeLong_ReturnsMinLongValue()
        {
            const long NEGATIVE_VALUE = -1L;
            IGenericValueComparer<long> longValueComparer = CreateLongValueComparer();

            long returnValue = longValueComparer.MinOrValue(NEGATIVE_VALUE);

            Assert.AreEqual(returnValue, MIN_LONG_VALUE);
        }

        [TestMethod]
        public void MinOrValue_ZeroLong_ReturnsMinLongValue()
        {
            const long ZERO_VALUE = 0L;
            IGenericValueComparer<long> longValueComparer = CreateLongValueComparer();

            long returnValue = longValueComparer.MinOrValue(ZERO_VALUE);

            Assert.AreEqual(returnValue, MIN_LONG_VALUE);
        }

        [TestMethod]
        public void MinOrValue_PositiveLong_ReturnsSameValue()
        {
            const long POSITIVE_VALUE = 12L;
            IGenericValueComparer<long> longValueComparer = CreateLongValueComparer();

            long returnValue = longValueComparer.MinOrValue(POSITIVE_VALUE);

            Assert.AreEqual(returnValue, POSITIVE_VALUE);
        }

        [TestMethod]
        public void MinOrValue_EqualValueLong_ReturnsSameValue()
        {
            const long EQUAL_VALUE = 10L;
            IGenericValueComparer<long> longValueComparer = CreateLongValueComparer();

            long returnValue = longValueComparer.MinOrValue(EQUAL_VALUE);

            Assert.AreEqual(returnValue, EQUAL_VALUE);
        }

        #endregion

        #region Decimal Test Methods

        [TestMethod]
        public void MinOrValue_NegativeDecimal_ReturnsMinDecimalValue()
        {
            const decimal NEGATIVE_VALUE = -1.0M;
            IGenericValueComparer<decimal> decimalValueComparer = CreateDecimalValueComparer();

            decimal returnValue = decimalValueComparer.MinOrValue(NEGATIVE_VALUE);

            Assert.AreEqual(returnValue, MIN_DECIMAL_VALUE);
        }

        [TestMethod]
        public void MinOrValue_ZeroDecimal_ReturnsMinDecimalValue()
        {
            const decimal ZERO_VALUE = 0.0M;
            IGenericValueComparer<decimal> decimalValueComparer = CreateDecimalValueComparer();

            decimal returnValue = decimalValueComparer.MinOrValue(ZERO_VALUE);

            Assert.AreEqual(returnValue, MIN_DECIMAL_VALUE);
        }

        [TestMethod]
        public void MinOrValue_PositiveDecimal_ReturnsSameValue()
        {
            const decimal POSITIVE_VALUE = 22.1M;
            IGenericValueComparer<decimal> decimalValueComparer = CreateDecimalValueComparer();

            decimal returnValue = decimalValueComparer.MinOrValue(POSITIVE_VALUE);

            Assert.AreEqual(returnValue, POSITIVE_VALUE);
        }

        [TestMethod]
        public void MinOrValue_EqualValueDecimal_ReturnsSameValue()
        {
            const decimal EQUAL_VALUE = 10.1M;
            IGenericValueComparer<decimal> decimalValueComparer = CreateDecimalValueComparer();

            decimal returnValue = decimalValueComparer.MinOrValue(EQUAL_VALUE);

            Assert.AreEqual(returnValue, EQUAL_VALUE);
        }

        #endregion

        #region Float Test Methods

        [TestMethod]
        public void MinOrValue_NegativeFloat_ReturnsMinFloatValue()
        {
            const float NEGATIVE_VALUE = -1.0F;
            IGenericValueComparer<float> floatValueComparer = CreateFloatValueComparer();

            float returnValue = floatValueComparer.MinOrValue(NEGATIVE_VALUE);

            Assert.AreEqual(returnValue, MIN_FLOAT_VALUE);
        }

        [TestMethod]
        public void MinOrValue_ZeroFloat_ReturnsMinFloatValue()
        {
            const float ZERO_VALUE = 0.0F;
            IGenericValueComparer<float> floatValueComparer = CreateFloatValueComparer();

            float returnValue = floatValueComparer.MinOrValue(ZERO_VALUE);

            Assert.AreEqual(returnValue, MIN_FLOAT_VALUE);
        }

        [TestMethod]
        public void MinOrValue_PositiveFloat_ReturnsSameValue()
        {
            const float POSITIVE_VALUE = 12.1F;
            IGenericValueComparer<float> floatValueComparer = CreateFloatValueComparer();

            float returnValue = floatValueComparer.MinOrValue(POSITIVE_VALUE);

            Assert.AreEqual(returnValue, POSITIVE_VALUE);
        }

        [TestMethod]
        public void MinOrValue_EqualValueFloat_ReturnsSameValue()
        {
            const float EQUAL_VALUE = 11.1F;
            IGenericValueComparer<float> floatValueComparer = CreateFloatValueComparer();

            float returnValue = floatValueComparer.MinOrValue(EQUAL_VALUE);

            Assert.AreEqual(returnValue, EQUAL_VALUE);
        }

        #endregion

        #region String Test Methods

        [TestMethod]
        public void MinOrValue_LowerValueFirstCharacter_ReturnsMinStringValue()
        {
            const string LOWER_VALUE_STRING = "loo!";
            IGenericValueComparer<string> stringValueComparer = CreateStringValueComparer();

            string returnValue = stringValueComparer.MinOrValue(LOWER_VALUE_STRING);

            Assert.AreEqual(returnValue, MIN_STRING_VALUE);
        }

        [TestMethod]
        public void MinOrValue_LowerValueSecondCharacter_ReturnsMinStringValue()
        {
            const string LOWER_VALUE_STRING = "mno!";
            IGenericValueComparer<string> stringValueComparer = CreateStringValueComparer();

            string returnValue = stringValueComparer.MinOrValue(LOWER_VALUE_STRING);

            Assert.AreEqual(returnValue, MIN_STRING_VALUE);
        }

        [TestMethod]
        public void MinOrValue_LowerValueThirdCharacter_ReturnsMinStringValue()
        {
            const string LOWER_VALUE_STRING = "mon!";
            IGenericValueComparer<string> stringValueComparer = CreateStringValueComparer();

            string returnValue = stringValueComparer.MinOrValue(LOWER_VALUE_STRING);

            Assert.AreEqual(returnValue, MIN_STRING_VALUE);
        }


        [TestMethod]
        public void MinOrValue_LowerValueFourthCharacter_ReturnsMinStringValue()
        {
            const string LOWER_VALUE_STRING = "moo ";
            IGenericValueComparer<string> stringValueComparer = CreateStringValueComparer();

            string returnValue = stringValueComparer.MinOrValue(LOWER_VALUE_STRING);

            Assert.AreEqual(returnValue, MIN_STRING_VALUE);
        }

        [TestMethod]
        public void MinOrValue_EqualValueString_ReturnsSameValue()
        {
            const string SAME_VALUE_STRING = "moo!";
            IGenericValueComparer<string> stringValueComparer = CreateStringValueComparer();

            string returnValue = stringValueComparer.MinOrValue(SAME_VALUE_STRING);

            Assert.AreEqual(returnValue, SAME_VALUE_STRING);
        }

        [TestMethod]
        public void MinOrValue_HigherValueFirstCharacter_ReturnsSameValue()
        {
            const string HIGHER_VALUE_STRING = "noo!";
            IGenericValueComparer<string> stringValueComparer = CreateStringValueComparer();

            string returnValue = stringValueComparer.MinOrValue(HIGHER_VALUE_STRING);

            Assert.AreEqual(returnValue, HIGHER_VALUE_STRING);
        }

        [TestMethod]
        public void MinOrValue_HigherValueSecondCharacter_ReturnsSameValue()
        {
            const string HIGHER_VALUE_STRING = "mpo!";
            IGenericValueComparer<string> stringValueComparer = CreateStringValueComparer();

            string returnValue = stringValueComparer.MinOrValue(HIGHER_VALUE_STRING);

            Assert.AreEqual(returnValue, HIGHER_VALUE_STRING);
        }

        [TestMethod]
        public void MinOrValue_HigherValueThirdCharacter_ReturnsSameValue()
        {
            const string HIGHER_VALUE_STRING = "mop!";
            IGenericValueComparer<string> stringValueComparer = CreateStringValueComparer();

            string returnValue = stringValueComparer.MinOrValue(HIGHER_VALUE_STRING);

            Assert.AreEqual(returnValue, HIGHER_VALUE_STRING);
        }

        [TestMethod]
        public void MinOrValue_HigherValueFourthCharacter_ReturnsSameValue()
        {
            const string HIGHER_VALUE_STRING = "moo\"";
            IGenericValueComparer<string> stringValueComparer = CreateStringValueComparer();

            string returnValue = stringValueComparer.MinOrValue(HIGHER_VALUE_STRING);

            Assert.AreEqual(returnValue, HIGHER_VALUE_STRING);
        }

        #endregion

        #region Comparable Object Test Methods

        [TestMethod]
        public void MinOrValue_LowerValueName_ReturnsMinTestComparable()
        {
            var lowerValueNameComparable = new TestComparable()
                                           {
                                               Name = "A",
                                               Age =  2
                                           };

            IGenericValueComparer<TestComparable> stringValueComparer = CreateTestComparableComparer();

            TestComparable returnValue = stringValueComparer.MinOrValue(lowerValueNameComparable);

            Assert.AreEqual(returnValue, MinTestComparableValue);
        }

        [TestMethod]
        public void MinOrValue_LowerValueAge_ReturnsMinTestComparable()
        {
            var lowerValueAgeComparable = new TestComparable()
            {
                Name = "B",
                Age = 1
            };

            IGenericValueComparer<TestComparable> stringValueComparer = CreateTestComparableComparer();

            TestComparable returnValue = stringValueComparer.MinOrValue(lowerValueAgeComparable);

            Assert.AreEqual(returnValue, MinTestComparableValue);
        }

        [TestMethod]
        public void MinOrValue_SameValueAgeAndName_ReturnsSameValue()
        {
            var sameValueComparable = new TestComparable()
            {
                Name = "B",
                Age = 2
            };

            IGenericValueComparer<TestComparable> stringValueComparer = CreateTestComparableComparer();

            TestComparable returnValue = stringValueComparer.MinOrValue(sameValueComparable);

            Assert.AreEqual(returnValue, sameValueComparable);
        }

        [TestMethod]
        public void MinOrValue_HigerValueName_ReturnsSameValue()
        {
            var higherValueNameComparable = new TestComparable()
            {
                Name = "C",
                Age = 2
            };

            IGenericValueComparer<TestComparable> stringValueComparer = CreateTestComparableComparer();

            TestComparable returnValue = stringValueComparer.MinOrValue(higherValueNameComparable);

            Assert.AreEqual(returnValue, higherValueNameComparable);
        }

        [TestMethod]
        public void MinOrValue_HigerValueAge_ReturnsSameValue()
        {
            var higherValueAge = new TestComparable()
            {
                Name = "B",
                Age = 3
            };

            IGenericValueComparer<TestComparable> stringValueComparer = CreateTestComparableComparer();

            TestComparable returnValue = stringValueComparer.MinOrValue(higherValueAge);

            Assert.AreEqual(returnValue, higherValueAge);
        }

        #endregion

        #region Constructor Methods

        private const int MIN_INT_VALUE = 1;
        private const long MIN_LONG_VALUE = 10L;
        private const decimal MIN_DECIMAL_VALUE = 10.1M;
        private const float MIN_FLOAT_VALUE = 11.1F;
        private const string MIN_STRING_VALUE = "moo!";
        private static readonly TestComparable MinTestComparableValue = new TestComparable() { Name = "B", Age = 2};

        private static IGenericValueComparer<int> CreateIntValueComparer()
        {
            return new GenericValueComparer<int>(MIN_INT_VALUE);
        }

        private static IGenericValueComparer<long> CreateLongValueComparer()
        {
            return new GenericValueComparer<long>(MIN_LONG_VALUE);
        }

        private static IGenericValueComparer<decimal> CreateDecimalValueComparer()
        {
            return new GenericValueComparer<decimal>(MIN_DECIMAL_VALUE);
        }

        private static IGenericValueComparer<float> CreateFloatValueComparer()
        {
            return new GenericValueComparer<float>(MIN_FLOAT_VALUE);
        }

        private static IGenericValueComparer<string> CreateStringValueComparer()
        {
            return new GenericValueComparer<string>(MIN_STRING_VALUE);
        }

        private static IGenericValueComparer<TestComparable> CreateTestComparableComparer()
        {
            return new GenericValueComparer<TestComparable>(MinTestComparableValue);
        }

        #endregion
    }
}