using BigFloatingPoint.Implementations;
using System;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingExplicitConversion
{
    public class WhenConvertingBigFloatToFloat
    {
        [Theory]
        [InlineData(Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.MinFloatMinus1)]
        public void ShouldThrowOverflowException(string value)
        {
            BigFloat bigValue = new BigFloat(value);

            Assert.Throws<OverflowException>(() =>
            {
                float f = (float)bigValue;
            });
        }

        [Theory]
        [InlineData(Constant.String.MaxFloat, float.MaxValue)]
        [InlineData(Constant.String.MinFloat, float.MinValue)]
        [InlineData("-1", -1f)]
        [InlineData("0", 0f)]
        [InlineData("1", 1f)]
        public void ShouldConvert(string value, float expectedValue)
        {
            BigFloat bigValue = new BigFloat(value);

            float actualValue = (float)bigValue;

            Assert.Equal(
                expected: expectedValue,
                actual: actualValue);
        }
    }
}
