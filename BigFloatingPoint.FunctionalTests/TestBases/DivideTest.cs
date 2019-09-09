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
