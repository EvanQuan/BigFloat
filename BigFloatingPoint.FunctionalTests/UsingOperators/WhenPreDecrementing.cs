using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenPreDecrementing
    {
        [Theory]
        [InlineData(0.0, -1.0)]
        [InlineData(1.0, 0.0)]
        [InlineData(-1.0, -2.0)]
        public void ShouldMutateSelf(double value, double expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat expectedBigValue = new BigFloat(expected);
            --bigValue;

            Assert.Equal(
                expected: expectedBigValue,
                actual: bigValue);
        }

        [Theory]
        [InlineData(0.0, -1.0)]
        [InlineData(1.0, 0.0)]
        [InlineData(-1.0, -2.0)]
        public void ShouldPreDecrement(double value, double expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat expectedDecrement = new BigFloat(expected);

            BigFloat beforeDecrement = bigValue;
            BigFloat preDecrement = --bigValue;
            BigFloat afterDecrement = bigValue;

            Assert.NotEqual(
                expected: beforeDecrement,
                actual: afterDecrement);

            Assert.Equal(
                expected: expectedDecrement,
                actual: preDecrement);

            Assert.Equal(
                expected: expectedDecrement,
                actual: afterDecrement);
        }
    }
}
