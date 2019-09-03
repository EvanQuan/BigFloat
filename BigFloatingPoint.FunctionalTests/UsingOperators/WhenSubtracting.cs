using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenSubtracting
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 0)]
        [InlineData(-1, -1, 0)]
        [InlineData(-1.5, -1.5, 0)]
        [InlineData(int.MaxValue, int.MaxValue, 0)]
        [InlineData(-int.MaxValue, -int.MaxValue, 0)]
        [InlineData(float.MaxValue, float.MaxValue, 0)]
        [InlineData(-float.MaxValue, -float.MaxValue, 0)]
        [InlineData(double.MaxValue, double.MaxValue, 0)]
        [InlineData(-double.MaxValue, -double.MaxValue, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(-1, 1, -2)]
        [InlineData(1.5, -1.5, 3.0)]
        [InlineData(-1.5, 1.5, -3.0)]
        public void ShouldSubtract(
            double minuend,
            double subtrahend,
            double expectedDifference)
        {
            BigFloat bigMinuend = new BigFloat(minuend);
            BigFloat bigSubtrahend = new BigFloat(subtrahend);

            BigFloat expectedBigDifference = new BigFloat(expectedDifference);
            BigFloat actualBigDifference = bigMinuend - bigSubtrahend;

            Assert.Equal(
                expected: expectedBigDifference,
                actual: actualBigDifference);
        }
    }
}
