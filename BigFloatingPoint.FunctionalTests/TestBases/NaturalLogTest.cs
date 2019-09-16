using BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class NaturalLogTest
    {
        [Theory]
        [InlineData("1", 0)]
        [InlineData(Constant.String.E, 1)]
        [InlineData(Constant.String.Pi, Constant.Double.LogPi)]
        public void ShouldReturnNaturalLogForPositive(string value, double expected)
        {
            AssertNaturalLog(
                value: value,
                expected: expected);
        }

        [Fact]
        public void ShouldReturnNegativeInfinityForZero()
        {
            AssertNaturalLog(
                value: "0",
                expected: double.NegativeInfinity);
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("-0.9")]
        [InlineData(Constant.String.NegativeMaxDoubleTimes2)]
        [InlineData(Constant.String.NegativePi)]
        public void ShouldReturnNaNForNegative(string value)
        {
            AssertNaturalLog(
                value: value,
                expected: double.NaN);
        }


        [Fact]
        public void ShouldReturnNaNForNaN()
        {
            AssertNaturalLog(
                value: "NaN",
                expected: double.NaN);
        }

        private void AssertNaturalLog(string value, double expected)
        {
            BigFloat big = new BigFloat(value);

            double actual = this.NaturalLog(big);

            Assert.Equal(
                expected: expected,
                actual: actual);
        }

        protected abstract double NaturalLog(BigFloat value);
    }
}
