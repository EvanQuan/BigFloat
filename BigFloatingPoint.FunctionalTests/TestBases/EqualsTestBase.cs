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

            Assert.True(Potato(big1, big2));
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

            Assert.False(this.Potato(big1, big2));
        }

        [Fact]
        public void ShouldBeEqualWhenNotFactored()
        {
            BigFloat oneHalf = new BigFloat(1, 2);
            BigFloat twoQuarters = new BigFloat(2, 4);

            Assert.True(this.Potato(oneHalf, twoQuarters));
        }

        protected abstract bool Potato(
            BigFloat left,
            BigFloat right);
    }
}
