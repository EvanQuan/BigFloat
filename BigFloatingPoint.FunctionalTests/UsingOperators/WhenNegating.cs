using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenNegating
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
        public void ShouldNegate(string expected, string actual)
        {
            BigFloat bigActual = -new BigFloat(actual);
            BigFloat bigExpected = new BigFloat(expected);

            Assert.Equal(
                expected: bigExpected,
                actual: bigActual);
        }

        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData("1.5")]
        [InlineData("-1.5")]
        [InlineData(Constant.MinIntTimes2)]
        [InlineData(Constant.MinIntMinus1)]
        [InlineData(Constant.MinInt)]
        [InlineData(Constant.MaxInt)]
        [InlineData(Constant.MaxIntPlus1)]
        [InlineData(Constant.MaxIntTimes2)]
        [InlineData(Constant.MinFloatTimes2)]
        [InlineData(Constant.MinFloatMinus1)]
        [InlineData(Constant.MinFloat)]
        [InlineData(Constant.MaxFloat)]
        [InlineData(Constant.MaxFloatPlus1)]
        [InlineData(Constant.MaxFloatTimes2)]
        [InlineData(Constant.MinDoubleTimes2)]
        [InlineData(Constant.MinDoubleMinus1)]
        [InlineData(Constant.MinDouble)]
        [InlineData(Constant.MaxDouble)]
        [InlineData(Constant.MaxDoublePlus1)]
        [InlineData(Constant.MaxDoubleTimes2)]
        public void ShouldReturnSelfWhenDoubleNegating(string value)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat doubleNegatedValue = -(-bigValue);

            Assert.Equal(
                expected: bigValue,
                actual: doubleNegatedValue);
        }
    }
}
