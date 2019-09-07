using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class EqualsTestBase
    {
        [Theory]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData("0")]
        [InlineData(ConstantStrings.MinIntMinus1)]
        [InlineData(ConstantStrings.MinIntTimes2)]
        [InlineData(ConstantStrings.MinFloatMinus1)]
        [InlineData(ConstantStrings.MinFloatTimes2)]
        [InlineData(ConstantStrings.MinDoubleMinus1)]
        [InlineData(ConstantStrings.MinDoubleTimes2)]
        [InlineData(ConstantStrings.MaxIntPlus1)]
        [InlineData(ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.MaxFloatPlus1)]
        [InlineData(ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.MaxDoublePlus1)]
        [InlineData(ConstantStrings.MaxDoubleTimes2)]
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
        [InlineData(ConstantStrings.MinIntMinus1, ConstantStrings.MinInt)]
        [InlineData(ConstantStrings.MinIntTimes2, ConstantStrings.MinInt)]
        [InlineData(ConstantStrings.MinFloatMinus1, ConstantStrings.MinFloat)]
        [InlineData(ConstantStrings.MinFloatTimes2, ConstantStrings.MinFloat)]
        [InlineData(ConstantStrings.MinDoubleMinus1, ConstantStrings.MinDouble)]
        [InlineData(ConstantStrings.MinDoubleTimes2, ConstantStrings.MinDouble)]
        [InlineData(ConstantStrings.MaxIntPlus1, ConstantStrings.MaxInt)]
        [InlineData(ConstantStrings.MaxIntTimes2, ConstantStrings.MaxInt)]
        [InlineData(ConstantStrings.MaxFloatPlus1, ConstantStrings.MaxFloat)]
        [InlineData(ConstantStrings.MaxFloatTimes2, ConstantStrings.MaxFloat)]
        [InlineData(ConstantStrings.MaxDoublePlus1, ConstantStrings.MaxDouble)]
        [InlineData(ConstantStrings.MaxDoubleTimes2, ConstantStrings.MaxDouble)]
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
