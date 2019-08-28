using Com.Github.EvanQuan.BigFloatingPoint.Implementations;
using Xunit;

namespace Com.Github.EvanQuan.BigFloatingPoint.UnitTests.UsingProperties
{
    public class WhenGettingConstants
    {
        [Fact]
        public void ShouldEqualOne()
        {
            BigFloat bigFloat = BigFloat.One;

            Assert.Equal(
                expected: new BigFloat(1),
                actual: bigFloat);
        }

        [Theory]
        [InlineData(0.5)]
        [InlineData(0.0)]
        [InlineData(-1)]
        public void ShouldNotEqualOne(float value)
        {
            BigFloat bigFloat = BigFloat.One;

            Assert.NotEqual(
                expected: new BigFloat(value),
                actual: bigFloat);
        }


        [Fact]
        public void ShouldEqualZero()
        {
            BigFloat bigFloat = BigFloat.Zero;

            Assert.Equal(
                expected: new BigFloat(0),
                actual: bigFloat);
        }

        [Theory]
        [InlineData(0.5)]
        [InlineData(1.0)]
        [InlineData(-1)]
        public void ShouldNotEqualZero(float value)
        {
            BigFloat bigFloat = BigFloat.Zero;

            Assert.NotEqual(
                expected: new BigFloat(value),
                actual: bigFloat);
        }

        [Fact]
        public void ShouldEqualMinusOne()
        {
            BigFloat bigFloat = BigFloat.MinusOne;

            Assert.Equal(
                expected: new BigFloat(-1),
                actual: bigFloat);
        }

        [Theory]
        [InlineData(0.5)]
        [InlineData(1.0)]
        [InlineData(0.0)]
        public void ShouldNotEqualMinusOne(float value)
        {
            BigFloat bigFloat = BigFloat.MinusOne;

            Assert.NotEqual(
                expected: new BigFloat(value),
                actual: bigFloat);
        }

        [Fact]
        public void ShouldEqualOneHalf()
        {
            BigFloat bigFloat = BigFloat.OneHalf;

            Assert.Equal(
                expected: new BigFloat(0.5),
                actual: bigFloat);
        }

        [Theory]
        [InlineData(-1.0)]
        [InlineData(1.0)]
        [InlineData(0.0)]
        public void ShouldNotEqualOneHalf(float value)
        {
            BigFloat bigFloat = BigFloat.OneHalf;

            Assert.NotEqual(
                expected: new BigFloat(value),
                actual: bigFloat);
        }
    }
}
