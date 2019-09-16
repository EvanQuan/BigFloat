using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class CompareToTest
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
        public void ShouldReturnZeroForSelf(string value)
        {
            BigFloat big = new BigFloat(value);

            Assert.Equal(
                expected: 0,
                actual: this.CompareTo(big, big));
        }

        [Theory]
        [InlineData("1", "1.0")]
        [InlineData("-1", "-1.0")]
        [InlineData("0", "0.0")]
        public void ShouldReturnZeroForDifferentStrings(string left, string right)
        {
            Assert.Equal(
                expected: 0,
                actual: this.CompareTo((BigFloat)left, (BigFloat)right));

            Assert.Equal(
                expected: 0,
                actual: this.CompareTo((BigFloat)right, (BigFloat)left));
        }

        [Theory]
        [InlineData(1, 1, 1, 1)]
        [InlineData(-1, 1, 1, -1)]
        [InlineData(1, 1, -1, -1)]
        [InlineData(1, 2, 2, 4)]
        public void ShouldReturnZeroForEquivalentFractions(
            int numerator1,
            int denominator1,
            int numerator2,
            int denominator2)
        {
            BigFloat one = new BigFloat(numerator1, denominator1);
            BigFloat two = new BigFloat(numerator2, denominator2);

            Assert.Equal(
                expected: 0,
                actual: this.CompareTo(one, two));
        }

        [Theory]
        [InlineData("1", "0.0")]
        [InlineData("0", "-1.0")]
        [InlineData("2", "1.0")]
        [InlineData(Constant.String.MinInt, Constant.String.MinIntMinus1)]
        [InlineData(Constant.String.MinInt, Constant.String.MinIntTimes2)]
        [InlineData(Constant.String.MinFloat, Constant.String.MinFloatMinus1)]
        [InlineData(Constant.String.MinFloat, Constant.String.MinFloatTimes2)]
        [InlineData(Constant.String.MinDouble, Constant.String.MinDoubleMinus1)]
        [InlineData(Constant.String.MinDouble, Constant.String.MinDoubleTimes2)]
        [InlineData(Constant.String.MaxIntPlus1, Constant.String.MaxInt)]
        [InlineData(Constant.String.MaxIntTimes2, Constant.String.MaxInt)]
        [InlineData(Constant.String.MaxFloatPlus1, Constant.String.MaxFloat)]
        [InlineData(Constant.String.MaxFloatTimes2, Constant.String.MaxFloat)]
        [InlineData(Constant.String.MaxDoublePlus1, Constant.String.MaxDouble)]
        [InlineData(Constant.String.MaxDoubleTimes2, Constant.String.MaxDouble)]
        public void ShouldGreaterThanZero(string left, string right)
        {
            Assert.InRange(
                actual: this.CompareTo((BigFloat)left, (BigFloat)right),
                low: 1,
                high: int.MaxValue);
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
        [InlineData(Constant.String.MaxInt, Constant.String.MaxIntPlus1)]
        [InlineData(Constant.String.MaxInt, Constant.String.MaxIntTimes2)]
        [InlineData(Constant.String.MaxFloat, Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.MaxFloat, Constant.String.MaxFloatTimes2)]
        [InlineData(Constant.String.MaxDouble, Constant.String.MaxDoublePlus1)]
        [InlineData(Constant.String.MaxDouble, Constant.String.MaxDoubleTimes2)]
        public void ShouldLessThanZero(string left, string right)
        {
            Assert.InRange(
                actual: this.CompareTo((BigFloat)left, (BigFloat)right),
                low: int.MinValue,
                high: -1);
        }

        protected abstract int CompareTo(BigFloat left, BigFloat right);
    }
}
