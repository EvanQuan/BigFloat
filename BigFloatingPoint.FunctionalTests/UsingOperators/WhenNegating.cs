using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenNegating
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, -1)]
        [InlineData(-1, 1)]
        [InlineData(1.5, -1.5)]
        [InlineData(-1.5, 1.5)]
        [InlineData(int.MaxValue, -int.MaxValue)]
        [InlineData(-int.MaxValue, int.MaxValue)]
        [InlineData(float.MaxValue, -float.MaxValue)]
        [InlineData(-float.MaxValue, float.MaxValue)]
        [InlineData(double.MaxValue, -double.MaxValue)]
        [InlineData(-double.MaxValue, double.MaxValue)]
        public void ShouldNegate(double expected, double actual)
        {
            BigFloat bigActual = -new BigFloat(actual);
            BigFloat bigExpected = new BigFloat(expected);

            Assert.Equal(
                expected: bigExpected,
                actual: bigActual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-1)]
        [InlineData(1.5)]
        [InlineData(-1.5)]
        [InlineData(int.MaxValue)]
        [InlineData(-int.MaxValue)]
        [InlineData(float.MaxValue)]
        [InlineData(-float.MaxValue)]
        [InlineData(double.MaxValue)]
        [InlineData(-double.MaxValue)]
        public void ShouldReturnSelfWhenDoubleNegating(double value)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat doubleNegatedValue = -(-bigValue);

            Assert.Equal(
                expected: bigValue,
                actual: doubleNegatedValue);
        }
    }
}
