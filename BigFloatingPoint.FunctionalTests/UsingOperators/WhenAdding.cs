using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenAdding
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 2)]
        [InlineData(-1, -1, -2)]
        [InlineData(-1.5, -1.5, -3.0)]
        [InlineData(int.MaxValue, -int.MaxValue, 0)]
        [InlineData(-int.MaxValue, int.MaxValue, 0)]
        [InlineData(float.MaxValue, -float.MaxValue, 0)]
        [InlineData(-float.MaxValue, float.MaxValue, 0)]
        [InlineData(-double.MaxValue, double.MaxValue, 0)]
        [InlineData(1, -1, 0)]
        [InlineData(-1, 1, 0)]
        [InlineData(1.5, -1.5, 0)]
        [InlineData(-1.5, 1.5, 0)]
        public void ShouldAdd(
            double leftAddend,
            double rightAddend,
            double expectedSum)
        {
            BigFloat bigLeftAddend = new BigFloat(leftAddend);
            BigFloat bigRightAddend = new BigFloat(rightAddend);

            BigFloat expectedBigSum = new BigFloat(expectedSum);
            BigFloat actualBigSum = bigLeftAddend + bigRightAddend;

            Assert.Equal(
                expected: expectedBigSum,
                actual: actualBigSum);
        }
    }
}
