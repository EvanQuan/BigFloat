using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenPostDecrementing
    {
        [Theory]
        [InlineData("0.0", "-1.0")]
        [InlineData("1.0", "0.0")]
        [InlineData("-1.0", "-2.0")]
        [InlineData(Constant.String.MinInt, Constant.String.MinIntMinus1)]
        [InlineData(Constant.String.MinFloat, Constant.String.MinFloatMinus1)]
        [InlineData(Constant.String.MinDouble, Constant.String.MinDoubleMinus1)]
        public void ShouldMutateSelf(string value, string expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat expectedBigValue = new BigFloat(expected);
            bigValue--;

            Assert.Equal(
                expected: expectedBigValue,
                actual: bigValue);
        }

        [Theory]
        [InlineData("0.0", "-1.0")]
        [InlineData("1.0", "0.0")]
        [InlineData("-1.0", "-2.0")]
        [InlineData(Constant.String.MinInt, Constant.String.MinIntMinus1)]
        [InlineData(Constant.String.MinFloat, Constant.String.MinFloatMinus1)]
        [InlineData(Constant.String.MinDouble, Constant.String.MinDoubleMinus1)]
        public void ShouldPostDecrement(string value, string expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat expectedDecrement = new BigFloat(expected);

            BigFloat beforeDecrement = bigValue;
            BigFloat preDecrement = bigValue--;
            BigFloat afterDecrement = bigValue;

            Assert.NotEqual(
                expected: beforeDecrement,
                actual: afterDecrement);

            Assert.Equal(
                expected: beforeDecrement,
                actual: preDecrement);

            Assert.Equal(
                expected: expectedDecrement,
                actual: afterDecrement);
        }
    }
}
