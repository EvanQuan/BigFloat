using Implementations;
using Xunit;

namespace UnitTests.UsingProperties
{
    public class WhenReadingSign
    {
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(int.MaxValue)]
        public void ShouldBePositiveForInt(int value)
        {
            Assert.Equal(expected: BigFloat.PositiveSign, new BigFloat(value).Sign);
        }

        [Theory]
        [InlineData(2l)]
        [InlineData(1l)]
        [InlineData(long.MaxValue)]
        public void ShouldBePositiveForLong(long value)
        {
            Assert.Equal(expected: BigFloat.PositiveSign, new BigFloat(value).Sign);
        }

        [Theory]
        [InlineData(2.0f)]
        [InlineData(1.0f)]
        [InlineData(0.1f)]
        [InlineData(float.MaxValue)]
        public void ShouldBePositiveForFloat(float value)
        {
            Assert.Equal(expected: BigFloat.PositiveSign, new BigFloat(value).Sign);
        }

        [Theory]
        [InlineData(2.0d)]
        [InlineData(1.0d)]
        [InlineData(0.1d)]
        [InlineData(double.MaxValue)]
        public void ShouldBePositiveForDouble(double value)
        {
            Assert.Equal(expected: BigFloat.PositiveSign, new BigFloat(value).Sign);
        }

        [Theory]
        [InlineData("1")]
        [InlineData("1.0")]
        [InlineData("0.1")]
        [InlineData("9999999999999999999999999")]
        [InlineData("9999999999999999999999999.0")]
        [InlineData("9999999999999999999999999.9")]
        public void ShouldBePositiveForString(string value)
        {
            Assert.Equal(expected: BigFloat.PositiveSign, new BigFloat(value).Sign);
        }
    }
}
