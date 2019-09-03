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
        [InlineData(ConstantStrings.MaxInt, ConstantStrings.Negative + ConstantStrings.MaxInt)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxInt, ConstantStrings.MaxInt)]
        [InlineData(ConstantStrings.MaxIntPlus1, ConstantStrings.Negative + ConstantStrings.MaxIntPlus1)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxIntPlus1, ConstantStrings.MaxIntPlus1)]
        [InlineData(ConstantStrings.MaxIntTimes2, ConstantStrings.Negative + ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxIntTimes2, ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.MaxFloat, ConstantStrings.Negative + ConstantStrings.MaxFloat)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxFloat, ConstantStrings.MaxFloat)]
        [InlineData(ConstantStrings.MaxFloatPlus1, ConstantStrings.Negative + ConstantStrings.MaxFloatPlus1)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxFloatPlus1, ConstantStrings.MaxFloatPlus1)]
        [InlineData(ConstantStrings.MaxFloatTimes2, ConstantStrings.Negative + ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxFloatTimes2, ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.MaxDouble, ConstantStrings.Negative + ConstantStrings.MaxDouble)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxDouble, ConstantStrings.MaxDouble)]
        [InlineData(ConstantStrings.MaxDoublePlus1, ConstantStrings.Negative + ConstantStrings.MaxDoublePlus1)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxDoublePlus1, ConstantStrings.MaxDoublePlus1)]
        [InlineData(ConstantStrings.MaxDoubleTimes2, ConstantStrings.Negative + ConstantStrings.MaxDoubleTimes2)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxDoubleTimes2, ConstantStrings.MaxDoubleTimes2)]
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
