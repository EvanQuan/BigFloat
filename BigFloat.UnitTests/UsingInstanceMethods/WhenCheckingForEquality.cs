using BigFloatingPoint.Implementations;
using Xunit;

namespace Com.Github.EvanQuan.BigFloatingPoint.UnitTests.UsingInstanceMethods
{
    public class WhenCheckingForEquality
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        public void ShouldBeEqualForInt(int value)
        {
            double doubleValue = value;
            string stringValue = value.ToString();

            BigFloat bigFloatFromInt = new BigFloat(value);
            BigFloat bigFloatFromDouble = new BigFloat(doubleValue);
            BigFloat bigFloatFromString = new BigFloat(stringValue);

            Assert.Equal(bigFloatFromInt, bigFloatFromDouble);
            Assert.Equal(bigFloatFromString, bigFloatFromDouble);
            Assert.Equal(bigFloatFromString, bigFloatFromInt);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(-1.5)]
        [InlineData(0.5)]
        [InlineData(1.5)]
        [InlineData(double.MaxValue)]
        [InlineData(double.MinValue)]
        public void ShouldBeEqualForFloat(double value)
        {
            // Lossless conversion from double to string without scientific notation.
            string stringValue = value.ToString("0." + new string('#', 339));

            BigFloat bigFloatFromDouble = new BigFloat(value);
            BigFloat bigFloatFromString = new BigFloat(stringValue);

            Assert.Equal(bigFloatFromString, bigFloatFromDouble);
        }
    }
}
