using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingProperties
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

        [Fact]
        public void ShouldEqualMaxInt()
        {
            Assert.Equal(
                expected: int.MaxValue,
                actual: BigFloat.MaxInt);
        }

        [Fact]
        public void ShouldEqualMinInt()
        {
            Assert.Equal(
                expected: int.MinValue,
                actual: BigFloat.MinInt);
        }

        [Fact]
        public void ShouldEqualMaxLong()
        {
            Assert.Equal(
                expected: long.MaxValue,
                actual: BigFloat.MaxLong);
        }

        [Fact]
        public void ShouldEqualMinLong()
        {
            Assert.Equal(
                expected: long.MinValue,
                actual: BigFloat.MinLong);
        }

        [Fact]
        public void ShouldEqualMaxFloat()
        {
            Assert.Equal(
                expected: float.MaxValue,
                actual: BigFloat.MaxFloat);
        }

        [Fact]
        public void ShouldEqualMinFloat()
        {
            Assert.Equal(
                expected: float.MinValue,
                actual: BigFloat.MinFloat);
        }

        [Fact]
        public void ShouldEqualMaxDouble()
        {
            Assert.Equal(
                expected: double.MaxValue,
                actual: BigFloat.MaxDouble);
        }

        [Fact]
        public void ShouldEqualMinDouble()
        {
            Assert.Equal(
                expected: double.MinValue,
                actual: BigFloat.MinDouble);
        }
    }
}
