using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class DecrementTest
    {
        [Theory]
        [InlineData("0.0", "-1.0")]
        [InlineData("1.0", "0.0")]
        [InlineData("-1.0", "-2.0")]
        [InlineData(Constant.String.MinInt, Constant.String.MinIntMinus1)]
        [InlineData(Constant.String.MinLong, Constant.String.MinLongMinus1)]
        [InlineData(Constant.String.MinFloat, Constant.String.MinFloatMinus1)]
        [InlineData(Constant.String.MinDouble, Constant.String.MinDoubleMinus1)]
        public void ShouldPreDecrement(string value, string expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat expectedDecrement = new BigFloat(expected);

            BigFloat beforeDecrement = bigValue;
            BigFloat preDecrement = this.PreDecrement(ref bigValue);
            BigFloat afterDecrement = bigValue;

            Assert.NotEqual(
                expected: beforeDecrement,
                actual: afterDecrement);

            Assert.Equal(
                expected: beforeDecrement - BigFloat.One,
                actual: afterDecrement);

            Assert.Equal(
                expected: expectedDecrement,
                actual: preDecrement);

            Assert.Equal(
                expected: expectedDecrement,
                actual: afterDecrement);
        }


        [Theory]
        [InlineData("0.0", "-1.0")]
        [InlineData("1.0", "0.0")]
        [InlineData("-1.0", "-2.0")]
        [InlineData(Constant.String.MinInt, Constant.String.MinIntMinus1)]
        [InlineData(Constant.String.MinLong, Constant.String.MinLongMinus1)]
        [InlineData(Constant.String.MinFloat, Constant.String.MinFloatMinus1)]
        [InlineData(Constant.String.MinDouble, Constant.String.MinDoubleMinus1)]
        public void ShouldPostDecrement(string value, string expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat expectedDecrement = new BigFloat(expected);

            BigFloat beforeDecrement = bigValue;
            BigFloat preDecrement = this.PostDecrement(ref bigValue);
            BigFloat afterDecrement = bigValue;

            Assert.NotEqual(
                expected: beforeDecrement,
                actual: afterDecrement);

            Assert.Equal(
                expected: beforeDecrement - BigFloat.One,
                actual: afterDecrement);

            Assert.Equal(
                expected: beforeDecrement,
                actual: preDecrement);

            Assert.Equal(
                expected: expectedDecrement,
                actual: afterDecrement);
        }

        protected abstract BigFloat PreDecrement(ref BigFloat value);

        protected abstract BigFloat PostDecrement(ref BigFloat value);
    }
}
