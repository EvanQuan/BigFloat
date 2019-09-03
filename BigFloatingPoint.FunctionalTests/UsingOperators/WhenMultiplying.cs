using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenMultiplying
    {
        [Theory]
        [InlineData("0", "0", "0")]
        [InlineData("1", "0", "0")]
        [InlineData("-1", "0", "0")]
        [InlineData("1", "1", "1")]
        [InlineData("-1.5", "1", "-1.5")]
        [InlineData("1.5", "1", "1.5")]
        [InlineData(ConstantStrings.MaxInt, "2", ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.MaxFloat, "2", ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.MaxDouble, "2", ConstantStrings.MaxDoubleTimes2)]
        [InlineData(ConstantStrings.MinInt, "2", ConstantStrings.MinIntTimes2)]
        [InlineData(ConstantStrings.MinFloat, "2", ConstantStrings.MinFloatTimes2)]
        [InlineData(ConstantStrings.MinDouble, "2", ConstantStrings.MinDoubleTimes2)]
        public void ShouldMultiply(
            string multiplicand,
            string multiplier,
            string expected)
        {
            BigFloat bigMultiplicand = new BigFloat(multiplicand);
            BigFloat bigMultiplier = new BigFloat(multiplier);
            BigFloat bigExpectedProduct = new BigFloat(expected);

            BigFloat actualProduct1 = bigMultiplicand * bigMultiplier;
            BigFloat actualProduct2 = bigMultiplier * bigMultiplicand;

            Assert.Equal(
                expected: bigExpectedProduct,
                actual: actualProduct1);

            Assert.Equal(
                expected: bigExpectedProduct,
                actual: actualProduct2);
        }
    }
}
