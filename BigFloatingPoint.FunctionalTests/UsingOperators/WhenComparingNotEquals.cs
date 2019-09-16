using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenComparingNotEquals
    {
        [Theory]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData("0")]
        [InlineData(Constant.String.MinIntMinus1)]
        [InlineData(Constant.String.MinIntTimes2)]
        [InlineData(Constant.String.MinFloatMinus1)]
        [InlineData(Constant.String.MinFloatTimes2)]
        [InlineData(Constant.String.MinDoubleMinus1)]
        [InlineData(Constant.String.MinDoubleTimes2)]
        [InlineData(Constant.String.MaxIntPlus1)]
        [InlineData(Constant.String.MaxIntTimes2)]
        [InlineData(Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.MaxFloatTimes2)]
        [InlineData(Constant.String.MaxDoublePlus1)]
        [InlineData(Constant.String.MaxDoubleTimes2)]
        public void ShouldReturnFalse(string value)
        {
            BigFloat big1 = new BigFloat(value);
            BigFloat big2 = new BigFloat(value);

            Assert.False(big1 != big2);
        }

        [Theory]
        [InlineData("1", "2")]
        [InlineData("-1", "1")]
        [InlineData("0", "1")]
        [InlineData(Constant.String.MinIntMinus1, Constant.String.MinInt)]
        [InlineData(Constant.String.MinIntTimes2, Constant.String.MinInt)]
        [InlineData(Constant.String.MinFloatMinus1, Constant.String.MinFloat)]
        [InlineData(Constant.String.MinFloatTimes2, Constant.String.MinFloat)]
        [InlineData(Constant.String.MinDoubleMinus1, Constant.String.MinDouble)]
        [InlineData(Constant.String.MinDoubleTimes2, Constant.String.MinDouble)]
        [InlineData(Constant.String.MaxIntPlus1, Constant.String.MaxInt)]
        [InlineData(Constant.String.MaxIntTimes2, Constant.String.MaxInt)]
        [InlineData(Constant.String.MaxFloatPlus1, Constant.String.MaxFloat)]
        [InlineData(Constant.String.MaxFloatTimes2, Constant.String.MaxFloat)]
        [InlineData(Constant.String.MaxDoublePlus1, Constant.String.MaxDouble)]
        [InlineData(Constant.String.MaxDoubleTimes2, Constant.String.MaxDouble)]
        public void ShouldReturnTrue(string value1, string value2)
        {
            BigFloat big1 = new BigFloat(value1);
            BigFloat big2 = new BigFloat(value2);

            Assert.True(big1 != big2);
        }
    }
}
