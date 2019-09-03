using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenPreIncrementing
    {
        [Theory]
        [InlineData(0.0, 1.0)]
        [InlineData(1.0, 2.0)]
        [InlineData(-1.0, 0.0)]
        public void ShouldMutateSelf(double value, double expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat expectedBigValue = new BigFloat(expected);
            ++bigValue;

            Assert.Equal(
                expected: expectedBigValue,
                actual: bigValue);
        }

        [Theory]
        [InlineData(0.0, 1.0)]
        [InlineData(1.0, 2.0)]
        [InlineData(-1.0, 0.0)]
        public void ShouldPreIncrement(double value, double expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat expectedDecrement = new BigFloat(expected);

            BigFloat beforeIncrement = bigValue;
            BigFloat preIncrement = ++bigValue;
            BigFloat afterIncrement = bigValue;

            Assert.NotEqual(
                expected: beforeIncrement,
                actual: afterIncrement);

            Assert.Equal(
                expected: expectedDecrement,
                actual: preIncrement);

            Assert.Equal(
                expected: expectedDecrement,
                actual: afterIncrement);
        }
    }
}
