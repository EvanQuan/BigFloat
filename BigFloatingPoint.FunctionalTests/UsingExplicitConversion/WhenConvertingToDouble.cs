using BigFloatingPoint.Implementations;
using System;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingExplicitConversion
{
    public class WhenConvertingToDouble
    {
        [Theory]
        [InlineData(Constant.String.MaxDoublePlus1)]
        [InlineData(Constant.String.MinDoubleMinus1)]
        public void ShouldThrowOverflowException(string value)
        {
            BigFloat bigValue = new BigFloat(value);

            Assert.Throws<OverflowException>(() =>
            {
                double f = (double)bigValue;
            });
        }

        [Theory]
        [InlineData(Constant.String.MaxDouble, double.MaxValue)]
        [InlineData(Constant.String.MinDouble, double.MinValue)]
        [InlineData("-1", -1d)]
        [InlineData("0", 0d)]
        [InlineData("1", 1d)]
        public void ShouldConvert(string value, double expectedValue)
        {
            BigFloat bigValue = new BigFloat(value);

            double actualValue = (double)bigValue;

            Assert.Equal(
                expected: expectedValue,
                actual: actualValue,
                precision: 15);
        }
    }
}
