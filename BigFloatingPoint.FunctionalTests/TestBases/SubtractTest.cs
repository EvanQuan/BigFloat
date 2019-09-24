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
        [InlineData(Constant.String.MaxInt, Constant.String.NegativeMaxInt, Constant.String.MaxIntTimes2)]
        [InlineData(Constant.String.NegativeMaxInt, Constant.String.MaxInt, Constant.String.NegativeMaxIntTimes2)]
        [InlineData(Constant.String.MaxInt, "-1", Constant.String.MaxIntPlus1)]
        [InlineData(Constant.String.MinInt, "1", Constant.String.MinIntMinus1)]
        [InlineData(Constant.String.MaxInt, Constant.String.MaxInt, "0")]
        [InlineData(Constant.String.MaxFloat, Constant.String.NegativeMaxFloat, Constant.String.MaxFloatTimes2)]
        [InlineData(Constant.String.MinFloat, Constant.String.MaxFloat, Constant.String.MinFloatTimes2)]
        [InlineData(Constant.String.MaxFloat, "-1", Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.MinFloat, "1", Constant.String.MinFloatMinus1)]
        [InlineData(Constant.String.MaxFloat, Constant.String.MaxFloat, "0")]
        [InlineData(Constant.String.MaxDouble, Constant.String.NegativeMaxDouble, Constant.String.MaxDoubleTimes2)]
        [InlineData(Constant.String.MinDouble, Constant.String.MaxDouble, Constant.String.MinDoubleTimes2)]
        [InlineData(Constant.String.MaxDouble, "-1", Constant.String.MaxDoublePlus1)]
        [InlineData(Constant.String.MinDouble, "1", Constant.String.MinDoubleMinus1)]
        [InlineData(Constant.String.MaxDouble, Constant.String.MaxDouble, "0")]
        [InlineData(Constant.String.Pi, Constant.String.PiDelta, Constant.String.BelowPi)]
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
