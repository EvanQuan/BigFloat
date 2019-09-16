using BigFloatingPoint.Implementations;
using System;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class DivideTest
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

            BigFloat actualQuotient = this.Divide(bigDividend, bigDivisor);

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

            BigFloat actualQuotient = this.Divide(bigDividend, bigDivisor);

            Assert.Equal(
                expected: expected,
                actual: actualQuotient);
        }

        [Theory]
        [InlineData("0.0")]
        [InlineData("1.0")]
        [InlineData("-1.0")]
        [InlineData(Constant.String.MinIntTimes2)]
        [InlineData(Constant.String.MinIntMinus1)]
        [InlineData(Constant.String.MinInt)]
        [InlineData(Constant.String.MaxInt)]
        [InlineData(Constant.String.MaxIntPlus1)]
        [InlineData(Constant.String.MaxIntTimes2)]
        [InlineData(Constant.String.MinFloatTimes2)]
        [InlineData(Constant.String.MinFloatMinus1)]
        [InlineData(Constant.String.MinFloat)]
        [InlineData(Constant.String.MaxFloat)]
        [InlineData(Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.MaxFloatTimes2)]
        [InlineData(Constant.String.MinDoubleTimes2)]
        [InlineData(Constant.String.MinDoubleMinus1)]
        [InlineData(Constant.String.MinDouble)]
        [InlineData(Constant.String.MaxDouble)]
        [InlineData(Constant.String.MaxDoublePlus1)]
        [InlineData(Constant.String.MaxDoubleTimes2)]
        public void ShouldThrowDivideByZeroException(
            string dividend)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                BigFloat bigDividend = new BigFloat(dividend);

                this.Divide(bigDividend, BigFloat.Zero);
            });
        }

        public abstract BigFloat Divide(
            BigFloat dividend,
            BigFloat divisor);
    }
}
