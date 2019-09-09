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
        [InlineData(ConstantStrings.MinInt, ConstantStrings.MinIntMinus1)]
        [InlineData(ConstantStrings.MinInt, ConstantStrings.MinIntTimes2)]
        [InlineData(ConstantStrings.MinFloat, ConstantStrings.MinFloatMinus1)]
        [InlineData(ConstantStrings.MinFloat, ConstantStrings.MinFloatTimes2)]
        [InlineData(ConstantStrings.MinDouble, ConstantStrings.MinDoubleMinus1)]
        [InlineData(ConstantStrings.MinDouble, ConstantStrings.MinDoubleTimes2)]
        [InlineData(ConstantStrings.MaxIntPlus1, ConstantStrings.MaxInt)]
        [InlineData(ConstantStrings.MaxIntTimes2, ConstantStrings.MaxInt)]
        [InlineData(ConstantStrings.MaxFloatPlus1, ConstantStrings.MaxFloat)]
        [InlineData(ConstantStrings.MaxFloatTimes2, ConstantStrings.MaxFloat)]
        [InlineData(ConstantStrings.MaxDoublePlus1, ConstantStrings.MaxDouble)]
        [InlineData(ConstantStrings.MaxDoubleTimes2, ConstantStrings.MaxDouble)]
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
        [InlineData(ConstantStrings.MinIntMinus1, ConstantStrings.MinInt)]
        [InlineData(ConstantStrings.MinIntTimes2, ConstantStrings.MinInt)]
        [InlineData(ConstantStrings.MinFloatMinus1, ConstantStrings.MinFloat)]
        [InlineData(ConstantStrings.MinFloatTimes2, ConstantStrings.MinFloat)]
        [InlineData(ConstantStrings.MinDoubleMinus1, ConstantStrings.MinDouble)]
        [InlineData(ConstantStrings.MinDoubleTimes2, ConstantStrings.MinDouble)]
        [InlineData(ConstantStrings.MaxInt, ConstantStrings.MaxIntPlus1)]
        [InlineData(ConstantStrings.MaxInt, ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.MaxFloat, ConstantStrings.MaxFloatPlus1)]
        [InlineData(ConstantStrings.MaxFloat, ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.MaxDouble, ConstantStrings.MaxDoublePlus1)]
        [InlineData(ConstantStrings.MaxDouble, ConstantStrings.MaxDoubleTimes2)]
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
