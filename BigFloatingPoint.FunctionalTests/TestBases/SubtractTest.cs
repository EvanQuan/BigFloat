using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class SubtractTest
    {
        [Theory]
        [InlineData("0", "0", "0")]
        [InlineData("1", "1", "0")]
        [InlineData("-1", "-1", "0")]
        [InlineData("-1.5", "-1.5", "0")]
        [InlineData("1", "-1", "2")]
        [InlineData("-1", "1", "-2")]
        [InlineData("1.5", "-1.5", "3.0")]
        [InlineData("-1.5", "1.5", "-3.0")]
        [InlineData(Constant.MaxInt, Constant.NegativeMaxInt, Constant.MaxIntTimes2)]
        [InlineData(Constant.NegativeMaxInt, Constant.MaxInt, Constant.NegativeMaxIntTimes2)]
        [InlineData(Constant.MaxInt, "-1", Constant.MaxIntPlus1)]
        [InlineData(Constant.MinInt, "1", Constant.MinIntMinus1)]
        [InlineData(Constant.MaxInt, Constant.MaxInt, "0")]
        [InlineData(Constant.MaxFloat, Constant.NegativeMaxFloat, Constant.MaxFloatTimes2)]
        [InlineData(Constant.MinFloat, Constant.MaxFloat, Constant.MinFloatTimes2)]
        [InlineData(Constant.MaxFloat, "-1", Constant.MaxFloatPlus1)]
        [InlineData(Constant.MinFloat, "1", Constant.MinFloatMinus1)]
        [InlineData(Constant.MaxFloat, Constant.MaxFloat, "0")]
        [InlineData(Constant.MaxDouble, Constant.NegativeMaxDouble, Constant.MaxDoubleTimes2)]
        [InlineData(Constant.MinDouble, Constant.MaxDouble, Constant.MinDoubleTimes2)]
        [InlineData(Constant.MaxDouble, "-1", Constant.MaxDoublePlus1)]
        [InlineData(Constant.MinDouble, "1", Constant.MinDoubleMinus1)]
        [InlineData(Constant.MaxDouble, Constant.MaxDouble, "0")]
        public void ShouldSubtract(
            string minuend,
            string subtrahend,
            string expectedDifference)
        {
            BigFloat bigMinuend = new BigFloat(minuend);
            BigFloat bigSubtrahend = new BigFloat(subtrahend);

            BigFloat expectedBigDifference = new BigFloat(expectedDifference);
            BigFloat actualBigDifference = Subtract(bigMinuend, bigSubtrahend);

            Assert.Equal(
                expected: expectedBigDifference,
                actual: actualBigDifference);
        }

        protected abstract BigFloat Subtract(
            BigFloat minuend,
            BigFloat subtrahend);
    }
}
