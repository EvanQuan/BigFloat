using BigFloatingPoint.Implementations;
using System.Numerics;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class EqualsTest
    {
        [Theory]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData("0")]
        [InlineData(Constant.MinIntMinus1)]
        [InlineData(Constant.MinIntTimes2)]
        [InlineData(Constant.MinFloatMinus1)]
        [InlineData(Constant.MinFloatTimes2)]
        [InlineData(Constant.MinDoubleMinus1)]
        [InlineData(Constant.MinDoubleTimes2)]
        [InlineData(Constant.MaxIntPlus1)]
        [InlineData(Constant.MaxIntTimes2)]
        [InlineData(Constant.MaxFloatPlus1)]
        [InlineData(Constant.MaxFloatTimes2)]
        [InlineData(Constant.MaxDoublePlus1)]
        [InlineData(Constant.MaxDoubleTimes2)]
        public void ShouldReturnTrue(string value)
        {
            BigFloat big1 = new BigFloat(value);
            BigFloat big2 = new BigFloat(value);

            Assert.True(this.Equal(big1, big2));
        }

        [Theory]
        [InlineData("1", "2")]
        [InlineData("-1", "1")]
        [InlineData("0", "1")]
        [InlineData(Constant.MinIntMinus1, Constant.MinInt)]
        [InlineData(Constant.MinIntTimes2, Constant.MinInt)]
        [InlineData(Constant.MinFloatMinus1, Constant.MinFloat)]
        [InlineData(Constant.MinFloatTimes2, Constant.MinFloat)]
        [InlineData(Constant.MinDoubleMinus1, Constant.MinDouble)]
        [InlineData(Constant.MinDoubleTimes2, Constant.MinDouble)]
        [InlineData(Constant.MaxIntPlus1, Constant.MaxInt)]
        [InlineData(Constant.MaxIntTimes2, Constant.MaxInt)]
        [InlineData(Constant.MaxFloatPlus1, Constant.MaxFloat)]
        [InlineData(Constant.MaxFloatTimes2, Constant.MaxFloat)]
        [InlineData(Constant.MaxDoublePlus1, Constant.MaxDouble)]
        [InlineData(Constant.MaxDoubleTimes2, Constant.MaxDouble)]
        public void ShouldReturnFalse(string value1, string value2)
        {
            BigFloat big1 = new BigFloat(value1);
            BigFloat big2 = new BigFloat(value2);

            Assert.False(this.Equal(big1, big2));
        }

        [Theory]
        [InlineData(1, 2, 2, 4)]
        [InlineData(1, 1, -1, -1)]
        [InlineData(-1, 1, 1, -1)]
        public void ShouldBeEqualWhenNotSimplified(
            int numerator1,
            int denominator1,
            int numerator2,
            int denominator2)
        {
            BigFloat one = new BigFloat(
                numerator1,
                denominator1);

            BigFloat two = new BigFloat(
                numerator2,
                denominator2);

            Assert.True(this.Equal(one, two));
        }

        protected abstract bool Equal(
            BigFloat left,
            BigFloat right);
    }
}
