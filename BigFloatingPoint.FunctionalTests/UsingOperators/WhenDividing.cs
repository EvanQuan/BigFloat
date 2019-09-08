using BigFloatingPoint.Implementations;
using System;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenDividing
    {
        [Theory]
        [InlineData("0.0", "1.0", "0.0")]
        [InlineData("0.0", "-1.0", "0.0")]
        [InlineData("1.0", "0.5", "2.0")]
        [InlineData("1.0", "-0.5", "-2.0")]
        [InlineData("-1.0", "0.5", "-2.0")]
        [InlineData("1.0", "2.0", "0.5")]
        [InlineData("1.0", "0.8", "1.25")]
        [InlineData("1.0", "-0.8", "-1.25")]
        [InlineData("2.0", "0.8", "2.5")]
        [InlineData("2.0", "-0.8", "-2.5")]
        [InlineData("1.0", "1.0", "1.0")]
        [InlineData("3.0", "1.0", "3.0")]
        [InlineData("3.0", "-1.0", "-3.0")]
        [InlineData("3.0", "2.0", "1.5")]
        [InlineData("3.0", "1.5", "2.0")]
        [InlineData("5.0", "4.0", "1.25")]
        [InlineData("5.0", "-4.0", "-1.25")]
        [InlineData("-5.0", "4.0", "-1.25")]
        [InlineData("-5.0", "-4.0", "1.25")]
        public void ShouldGetQuotient(
            string dividend,
            string divisor,
            string expectedQuotient)
        {
            BigFloat bigDividend = new BigFloat(dividend);
            BigFloat bigDivisor = new BigFloat(divisor);
            BigFloat bigExpectedQuotient = new BigFloat(expectedQuotient);

            BigFloat actualQuotient = bigDividend / bigDivisor;

            Assert.Equal(
                expected: bigExpectedQuotient,
                actual: actualQuotient);
        }

        [Theory]
        [InlineData("1.0", "3.0", 1, 3)]
        [InlineData("1.0", "-3.0", 1, -3)]
        [InlineData("1.0", "-3.0", -1, 3)]
        [InlineData("1.0", "1.5", 2, 3)]
        [InlineData("1.0", "-1.5", -2, 3)]
        [InlineData("1.0", "-1.5", 2, -3)]
        public void ShouldGetQuotientForRepeatingDecimalFractions(
            string dividend,
            string divisor,
            int expectedNumerator,
            int expectedDenominator)
        {
            BigFloat expected = new BigFloat(expectedNumerator, expectedDenominator);

            BigFloat bigDividend = new BigFloat(dividend);
            BigFloat bigDivisor = new BigFloat(divisor);

            BigFloat actualQuotient = bigDividend / bigDivisor;

            Assert.Equal(
                expected: expected,
                actual: actualQuotient);
        }

        [Theory]
        [InlineData("0.0")]
        [InlineData("1.0")]
        [InlineData("-1.0")]
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
        public void ShouldThrowDivideByZeroException(
            string dividend)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                BigFloat bigDividend = new BigFloat(dividend);

                _ = bigDividend / BigFloat.Zero;
            });
        }
    }
}
