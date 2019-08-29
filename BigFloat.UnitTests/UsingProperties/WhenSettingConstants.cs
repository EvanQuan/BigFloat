using BigFloatingPoint.Implementations;
using Xunit;

namespace Com.Github.EvanQuan.BigFloatingPoint.UnitTests.UsingProperties
{
    public class WhenSettingConstants
    {
        [Fact]
        public void ShouldFailToMutateZero()
        {
            BigFloat.Zero.Add(1);

            Assert.NotEqual(new BigFloat(1), BigFloat.Zero);
            Assert.Equal(new BigFloat(0), BigFloat.Zero);
        }

        [Fact]
        public void ShouldFailToMutateOne()
        {
            BigFloat.One.Add(1);

            Assert.NotEqual(new BigFloat(2), BigFloat.One);
            Assert.Equal(new BigFloat(1), BigFloat.One);
        }

        [Fact]
        public void ShouldFailToMutateMinusOne()
        {
            BigFloat.MinusOne.Add(1);

            Assert.NotEqual(new BigFloat(0), BigFloat.MinusOne);
            Assert.Equal(new BigFloat(-1), BigFloat.MinusOne);
        }

        [Fact]
        public void ShouldFailToMutateOneHalf()
        {
            BigFloat.OneHalf.Add(1);

            Assert.NotEqual(new BigFloat(1.5), BigFloat.OneHalf);
            Assert.Equal(new BigFloat(0.5), BigFloat.OneHalf);
        }
    }
}
