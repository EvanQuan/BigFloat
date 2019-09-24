using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class IncrementTest
    {
        [Theory]
        [InlineData("0.0", "1.0")]
        [InlineData("-1.0", "0.0")]
        [InlineData("-2.0", "-1.0")]
        [InlineData(Constant.String.MaxInt, Constant.String.MaxIntPlus1)]
        [InlineData(Constant.String.MaxLong, Constant.String.MaxLongPlus1)]
        [InlineData(Constant.String.MaxFloat, Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.MaxDouble, Constant.String.MaxDoublePlus1)]
        public void ShouldPreIncrement(string value, string expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat expectedIncrement = new BigFloat(expected);

            BigFloat beforeIncrement = bigValue;
            BigFloat preIncrement = this.PreIncrement(ref bigValue);
            BigFloat afterIncrement = bigValue;

            Assert.NotEqual(
                expected: beforeIncrement,
                actual: afterIncrement);

            Assert.Equal(
                expected: beforeIncrement + BigFloat.One,
                actual: afterIncrement);

            Assert.Equal(
                expected: expectedIncrement,
                actual: preIncrement);

            Assert.Equal(
                expected: expectedIncrement,
                actual: afterIncrement);
        }

        [Theory]
        [InlineData("0.0", "1.0")]
        [InlineData("-1.0", "0.0")]
        [InlineData("-2.0", "-1.0")]
        [InlineData(Constant.String.MaxInt, Constant.String.MaxIntPlus1)]
        [InlineData(Constant.String.MaxLong, Constant.String.MaxLongPlus1)]
        [InlineData(Constant.String.MaxFloat, Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.MaxDouble, Constant.String.MaxDoublePlus1)]
        public void ShouldPostIncrement(string value, string expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat expectedIncrement = new BigFloat(expected);

            BigFloat beforeIncrement = bigValue;
            BigFloat preIncrement = this.PreIncrement(ref bigValue);
            BigFloat afterIncrement = bigValue;

            Assert.NotEqual(
                expected: beforeIncrement,
                actual: afterIncrement);

            Assert.Equal(
                expected: beforeIncrement + BigFloat.One,
                actual: afterIncrement);

            Assert.Equal(
                expected: expectedIncrement,
                actual: preIncrement);

            Assert.Equal(
                expected: expectedIncrement,
                actual: afterIncrement);
        }

        protected abstract BigFloat PreIncrement(ref BigFloat value);
        protected abstract BigFloat PostIncrement(ref BigFloat value);
    }
}
