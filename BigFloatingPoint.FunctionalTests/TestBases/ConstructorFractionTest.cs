using BigFloatingPoint.Implementations;
using System;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class ConstructorFractionTest
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-1, 1, -1)]
        [InlineData(1, -1, -1)]
        [InlineData(-1, -1, 1)]
        [InlineData(1, 2, 0.5)]
        [InlineData(2, 4, 0.5)]
        public void ShouldConstructCorrectly(
            int numerator,
            int denominator,
            double expected)
        {
            BigFloat actual = ConstructByFraction(numerator, denominator);

            Assert.Equal(
                expected: expected,
                actual: actual);

        }
        public void ShouldThrowDivideByZeroException(
            int numerator,
            int denominator)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                ConstructByFraction(numerator, denominator);
            });
        }

        protected abstract BigFloat ConstructByFraction(
            int numerator,
            int denominator);
    }
}
