using BigFloatingPoint.Implementations;
using System;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenGettingRemainder
    {
        [Theory]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(1.0, 1.0, 0.0)]
        [InlineData(2.0, 1.0, 0.0)]
        [InlineData(3.0, 2.0, 1.0)]
        public void ShouldPreDecrement(
            double dividend,
            double divisor,
            double expectedRemainder)
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
        [InlineData(0.0)]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void ShouldThrowDivideByZeroException(
            double dividend)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                BigFloat bigDividend = new BigFloat(dividend);

                _ = bigDividend % BigFloat.Zero;
            });
        }
    }
}
