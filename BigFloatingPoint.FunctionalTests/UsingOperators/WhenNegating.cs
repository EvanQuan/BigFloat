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
        [InlineData(ConstantStrings.MaxInt, ConstantStrings.NegativeMaxInt)]
        [InlineData(ConstantStrings.NegativeMaxInt, ConstantStrings.MaxInt)]
        [InlineData(ConstantStrings.MaxIntPlus1, ConstantStrings.NegativeMaxIntPlus1)]
        [InlineData(ConstantStrings.NegativeMaxIntPlus1, ConstantStrings.MaxIntPlus1)]
        [InlineData(ConstantStrings.MaxIntTimes2, ConstantStrings.NegativeMaxIntTimes2)]
        [InlineData(ConstantStrings.NegativeMaxIntTimes2, ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.MaxFloat, ConstantStrings.NegativeMaxFloat)]
        [InlineData(ConstantStrings.NegativeMaxFloat, ConstantStrings.MaxFloat)]
        [InlineData(ConstantStrings.MaxFloatPlus1, ConstantStrings.NegativeMaxFloatPlus1)]
        [InlineData(ConstantStrings.NegativeMaxFloatPlus1, ConstantStrings.MaxFloatPlus1)]
        [InlineData(ConstantStrings.MaxFloatTimes2, ConstantStrings.NegativeMaxFloatTimes2)]
        [InlineData(ConstantStrings.NegativeMaxFloatTimes2, ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.MaxDouble, ConstantStrings.NegativeMaxDouble)]
        [InlineData(ConstantStrings.NegativeMaxDouble, ConstantStrings.MaxDouble)]
        [InlineData(ConstantStrings.MaxDoublePlus1, ConstantStrings.NegativeMaxDoublePlus1)]
        [InlineData(ConstantStrings.NegativeMaxDoublePlus1, ConstantStrings.MaxDoublePlus1)]
        [InlineData(ConstantStrings.MaxDoubleTimes2, ConstantStrings.NegativeMaxDoubleTimes2)]
        [InlineData(ConstantStrings.NegativeMaxDoubleTimes2, ConstantStrings.MaxDoubleTimes2)]
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
        [InlineData(ConstantStrings.MinIntTimes2)]
        [InlineData(ConstantStrings.MinIntMinus1)]
        [InlineData(ConstantStrings.MinInt)]
        [InlineData(ConstantStrings.MaxInt)]
        [InlineData(ConstantStrings.MaxIntPlus1)]
        [InlineData(ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.MinFloatTimes2)]
        [InlineData(ConstantStrings.MinFloatMinus1)]
        [InlineData(ConstantStrings.MinFloat)]
        [InlineData(ConstantStrings.MaxFloat)]
        [InlineData(ConstantStrings.MaxFloatPlus1)]
        [InlineData(ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.MinDoubleTimes2)]
        [InlineData(ConstantStrings.MinDoubleMinus1)]
        [InlineData(ConstantStrings.MinDouble)]
        [InlineData(ConstantStrings.MaxDouble)]
        [InlineData(ConstantStrings.MaxDoublePlus1)]
        [InlineData(ConstantStrings.MaxDoubleTimes2)]
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
