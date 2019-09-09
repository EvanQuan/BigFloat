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
        [InlineData(Constant.MinInt, Constant.MinIntMinus1)]
        [InlineData(Constant.MinInt, Constant.MinIntTimes2)]
        [InlineData(Constant.MinFloat, Constant.MinFloatMinus1)]
        [InlineData(Constant.MinFloat, Constant.MinFloatTimes2)]
        [InlineData(Constant.MinDouble, Constant.MinDoubleMinus1)]
        [InlineData(Constant.MinDouble, Constant.MinDoubleTimes2)]
        [InlineData(Constant.MaxIntPlus1, Constant.MaxInt)]
        [InlineData(Constant.MaxIntTimes2, Constant.MaxInt)]
        [InlineData(Constant.MaxFloatPlus1, Constant.MaxFloat)]
        [InlineData(Constant.MaxFloatTimes2, Constant.MaxFloat)]
        [InlineData(Constant.MaxDoublePlus1, Constant.MaxDouble)]
        [InlineData(Constant.MaxDoubleTimes2, Constant.MaxDouble)]
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
        [InlineData(Constant.MinIntMinus1, Constant.MinInt)]
        [InlineData(Constant.MinIntTimes2, Constant.MinInt)]
        [InlineData(Constant.MinFloatMinus1, Constant.MinFloat)]
        [InlineData(Constant.MinFloatTimes2, Constant.MinFloat)]
        [InlineData(Constant.MinDoubleMinus1, Constant.MinDouble)]
        [InlineData(Constant.MinDoubleTimes2, Constant.MinDouble)]
        [InlineData(Constant.MaxInt, Constant.MaxIntPlus1)]
        [InlineData(Constant.MaxInt, Constant.MaxIntTimes2)]
        [InlineData(Constant.MaxFloat, Constant.MaxFloatPlus1)]
        [InlineData(Constant.MaxFloat, Constant.MaxFloatTimes2)]
        [InlineData(Constant.MaxDouble, Constant.MaxDoublePlus1)]
        [InlineData(Constant.MaxDouble, Constant.MaxDoubleTimes2)]
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
