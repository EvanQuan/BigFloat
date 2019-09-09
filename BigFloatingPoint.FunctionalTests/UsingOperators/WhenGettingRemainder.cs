using BigFloatingPoint.Implementations;
using System;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenGettingRemainder
    {
        [Theory]
        [InlineData("0.0", "1.0", "0.0")]
        [InlineData("0.0", "-1.0", "0.0")]
        [InlineData("1.0", "0.5", "0.0")]
        [InlineData("1.0", "-0.5", "0.0")]
        [InlineData("-1.0", "0.5", "0.0")]
        [InlineData("1.0", "1.5", "1.0")]
        [InlineData("1.0", "-1.5", "1.0")]
        [InlineData("1.0", "2.0", "1.0")]
        [InlineData("1.0", "0.8", "0.2")]
        [InlineData("1.0", "-0.8", "0.2")]
        [InlineData("2.0", "0.8", "0.4")]
        [InlineData("2.0", "-0.8", "0.4")]
        [InlineData("1.0", "1.0", "0.0")]
        [InlineData("3.0", "1.0", "0.0")]
        [InlineData("3.0", "-1.0", "0.0")]
        [InlineData("3.0", "2.0", "1.0")]
        [InlineData("3.0", "1.5", "0.0")]
        [InlineData("5.0", "4.0", "1.0")]
        [InlineData("5.0", "-4.0", "1.0")]
        [InlineData("-5.0", "4.0", "-1.0")]
        [InlineData("-5.0", "-4.0", "-1.0")]
        public void ShouldGetRemainder(
            string dividend,
            string divisor,
            string expectedRemainder)
        {
            BigFloat bigDividend = new BigFloat(dividend);
            BigFloat bigDivisor = new BigFloat(divisor);
            BigFloat bigExpectedRemainder = new BigFloat(expectedRemainder);

            BigFloat actualRemainder = bigDividend % bigDivisor;

            Assert.Equal(
                expected: bigExpectedRemainder,
                actual: actualRemainder);
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

                _ = bigDividend % BigFloat.Zero;
            });
        }
    }
}
