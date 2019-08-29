using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.UnitTests.UsingInstanceMethods
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
        [InlineData(double.MaxValue, "179769313486232000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")]
        [InlineData(double.MinValue, "-179769313486232000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")]
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
        [InlineData(float.MaxValue, "340282300000000000000000000000000000000")]
        [InlineData(float.MinValue, "-340282300000000000000000000000000000000")]
        public void ShouldWorkForFloat(float value, string expected)
        {
            Assert.Equal(expected, new BigFloat(value).ToString());
        }

        [Theory]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(-1, "-1")]
        [InlineData(int.MaxValue, "2147483647")]
        [InlineData(int.MinValue, "-2147483648")]
        public void ShouldWorkForInt(int value, string expected)
        {
            Assert.Equal(expected, new BigFloat(value).ToString());
        }

    }
}
