using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class NegateTest
    {

        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "-1")]
        [InlineData("-1", "1")]
        [InlineData("1.5", "-1.5")]
        [InlineData("-1.5", "1.5")]
        [InlineData(Constant.String.MaxInt, Constant.String.NegativeMaxInt)]
        [InlineData(Constant.String.NegativeMaxInt, Constant.String.MaxInt)]
        [InlineData(Constant.String.MaxIntPlus1, Constant.String.NegativeMaxIntPlus1)]
        [InlineData(Constant.String.NegativeMaxIntPlus1, Constant.String.MaxIntPlus1)]
        [InlineData(Constant.String.MaxIntTimes2, Constant.String.NegativeMaxIntTimes2)]
        [InlineData(Constant.String.NegativeMaxIntTimes2, Constant.String.MaxIntTimes2)]
        [InlineData(Constant.String.MaxFloat, Constant.String.NegativeMaxFloat)]
        [InlineData(Constant.String.NegativeMaxFloat, Constant.String.MaxFloat)]
        [InlineData(Constant.String.MaxFloatPlus1, Constant.String.NegativeMaxFloatPlus1)]
        [InlineData(Constant.String.NegativeMaxFloatPlus1, Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.MaxFloatTimes2, Constant.String.NegativeMaxFloatTimes2)]
        [InlineData(Constant.String.NegativeMaxFloatTimes2, Constant.String.MaxFloatTimes2)]
        [InlineData(Constant.String.MaxDouble, Constant.String.NegativeMaxDouble)]
        [InlineData(Constant.String.NegativeMaxDouble, Constant.String.MaxDouble)]
        [InlineData(Constant.String.MaxDoublePlus1, Constant.String.NegativeMaxDoublePlus1)]
        [InlineData(Constant.String.NegativeMaxDoublePlus1, Constant.String.MaxDoublePlus1)]
        [InlineData(Constant.String.MaxDoubleTimes2, Constant.String.NegativeMaxDoubleTimes2)]
        [InlineData(Constant.String.NegativeMaxDoubleTimes2, Constant.String.MaxDoubleTimes2)]
        [InlineData(Constant.String.Phi, Constant.String.NegativePhi)]
        [InlineData(Constant.String.NegativePhi, Constant.String.Phi)]
        public void ShouldNegate(
            string value,
            string expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat bigExpected = new BigFloat(expected);
            BigFloat actualNegated = this.Negate(bigValue);

            Assert.Equal(
                expected: bigExpected,
                actual: actualNegated);
        }

        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData("1.5")]
        [InlineData("-1.5")]
        [InlineData(Constant.String.MaxInt)]
        [InlineData(Constant.String.NegativeMaxInt)]
        [InlineData(Constant.String.MaxIntPlus1)]
        [InlineData(Constant.String.NegativeMaxIntPlus1)]
        [InlineData(Constant.String.MaxIntTimes2)]
        [InlineData(Constant.String.NegativeMaxIntTimes2)]
        [InlineData(Constant.String.MaxFloat)]
        [InlineData(Constant.String.NegativeMaxFloat)]
        [InlineData(Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.NegativeMaxFloatPlus1)]
        [InlineData(Constant.String.MaxFloatTimes2)]
        [InlineData(Constant.String.NegativeMaxFloatTimes2)]
        [InlineData(Constant.String.MaxDouble)]
        [InlineData(Constant.String.NegativeMaxDouble)]
        [InlineData(Constant.String.MaxDoublePlus1)]
        [InlineData(Constant.String.NegativeMaxDoublePlus1)]
        [InlineData(Constant.String.MaxDoubleTimes2)]
        [InlineData(Constant.String.NegativeMaxDoubleTimes2)]
        [InlineData(Constant.String.Phi)]
        [InlineData(Constant.String.NegativePhi)]
        public void ShouldReturnSelfWhenDoubleNegating(string value)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat doubleNegatedValue = Negate(Negate(bigValue));

            Assert.Equal(
                expected: bigValue,
                actual: doubleNegatedValue);
        }

        protected abstract BigFloat Negate(BigFloat value);
    }
}
