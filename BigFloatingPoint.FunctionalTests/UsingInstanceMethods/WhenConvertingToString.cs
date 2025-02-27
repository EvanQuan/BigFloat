﻿using BigFloatingPoint.FunctionalTests;
using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenConvertingToString
    {
        [Theory]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(-1, "-1")]
        [InlineData(0.1d, "0.1")]
        [InlineData(0.01d, "0.01")]
        [InlineData(0.15d, "0.15")]
        [InlineData(0.00001d, "0.00001")]
        [InlineData(0.000001d, "0.000001")]
        [InlineData(-0.1d, "-0.1")]
        [InlineData(-0.01d, "-0.01")]
        [InlineData(-0.15d, "-0.15")]
        [InlineData(-0.00001d, "-0.00001")]
        [InlineData(-0.000001d, "-0.000001")]
        [InlineData(double.MaxValue, Constant.String.MaxDouble)]
        [InlineData(double.MinValue, Constant.String.MinDouble)]
        public void ShouldWorkForDouble(double value, string expected)
        {
            Assert.Equal(expected, new BigFloat(value).ToString());
        }

        [Theory]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(-1, "-1")]
        [InlineData(0.1, "0.1")]
        [InlineData(0.01f, "0.01")]
        [InlineData(0.15f, "0.15")]
        [InlineData(0.00001f, "0.00001")]
        [InlineData(0.000001f, "0.000001")]
        [InlineData(-0.1f, "-0.1")]
        [InlineData(-0.01f, "-0.01")]
        [InlineData(-0.15f, "-0.15")]
        [InlineData(-0.00001f, "-0.00001")]
        [InlineData(-0.000001f, "-0.000001")]
        [InlineData(float.MaxValue, Constant.String.MaxFloat)]
        [InlineData(float.MinValue, Constant.String.MinFloat)]
        public void ShouldWorkForFloat(float value, string expected)
        {
            Assert.Equal(expected, new BigFloat(value).ToString());
        }

        [Theory]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(-1, "-1")]
        [InlineData(int.MaxValue, Constant.String.MaxInt)]
        [InlineData(int.MinValue, Constant.String.MinInt)]
        public void ShouldWorkForInt(int value, string expected)
        {
            Assert.Equal(expected, new BigFloat(value).ToString());
        }

    }
}
