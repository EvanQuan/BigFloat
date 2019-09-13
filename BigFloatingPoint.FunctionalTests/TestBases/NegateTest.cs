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
        [InlineData(Constant.MaxInt, Constant.NegativeMaxInt)]
        [InlineData(Constant.NegativeMaxInt, Constant.MaxInt)]
        [InlineData(Constant.MaxIntPlus1, Constant.NegativeMaxIntPlus1)]
        [InlineData(Constant.NegativeMaxIntPlus1, Constant.MaxIntPlus1)]
        [InlineData(Constant.MaxIntTimes2, Constant.NegativeMaxIntTimes2)]
        [InlineData(Constant.NegativeMaxIntTimes2, Constant.MaxIntTimes2)]
        [InlineData(Constant.MaxFloat, Constant.NegativeMaxFloat)]
        [InlineData(Constant.NegativeMaxFloat, Constant.MaxFloat)]
        [InlineData(Constant.MaxFloatPlus1, Constant.NegativeMaxFloatPlus1)]
        [InlineData(Constant.NegativeMaxFloatPlus1, Constant.MaxFloatPlus1)]
        [InlineData(Constant.MaxFloatTimes2, Constant.NegativeMaxFloatTimes2)]
        [InlineData(Constant.NegativeMaxFloatTimes2, Constant.MaxFloatTimes2)]
        [InlineData(Constant.MaxDouble, Constant.NegativeMaxDouble)]
        [InlineData(Constant.NegativeMaxDouble, Constant.MaxDouble)]
        [InlineData(Constant.MaxDoublePlus1, Constant.NegativeMaxDoublePlus1)]
        [InlineData(Constant.NegativeMaxDoublePlus1, Constant.MaxDoublePlus1)]
        [InlineData(Constant.MaxDoubleTimes2, Constant.NegativeMaxDoubleTimes2)]
        [InlineData(Constant.NegativeMaxDoubleTimes2, Constant.MaxDoubleTimes2)]
        [InlineData(Constant.Phi, Constant.Negative + Constant.Phi)]
        [InlineData(Constant.Negative + Constant.Phi, Constant.Phi)]
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
        [InlineData(Constant.MaxInt)]
        [InlineData(Constant.NegativeMaxInt)]
        [InlineData(Constant.MaxIntPlus1)]
        [InlineData(Constant.NegativeMaxIntPlus1)]
        [InlineData(Constant.MaxIntTimes2)]
        [InlineData(Constant.NegativeMaxIntTimes2)]
        [InlineData(Constant.MaxFloat)]
        [InlineData(Constant.NegativeMaxFloat)]
        [InlineData(Constant.MaxFloatPlus1)]
        [InlineData(Constant.NegativeMaxFloatPlus1)]
        [InlineData(Constant.MaxFloatTimes2)]
        [InlineData(Constant.NegativeMaxFloatTimes2)]
        [InlineData(Constant.MaxDouble)]
        [InlineData(Constant.NegativeMaxDouble)]
        [InlineData(Constant.MaxDoublePlus1)]
        [InlineData(Constant.NegativeMaxDoublePlus1)]
        [InlineData(Constant.MaxDoubleTimes2)]
        [InlineData(Constant.NegativeMaxDoubleTimes2)]
        [InlineData(Constant.Phi)]
        [InlineData(Constant.Negative + Constant.Phi)]
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
