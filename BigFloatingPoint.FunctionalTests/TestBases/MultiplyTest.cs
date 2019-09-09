using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class MultiplyTest
    {

        [Theory]
        [InlineData("0", "0", "0")]
        [InlineData("1", "1", "1")]
        [InlineData("-1", "1", "-1")]
        [InlineData("-1", "-1", "1")]
        [InlineData("1", "0", "0")]
        [InlineData("-1", "0", "0")]
        [InlineData("1", "2", "2")]
        [InlineData("2", "2", "4")]
        [InlineData("-2", "2", "-4")]
        [InlineData("-2", "-2", "4")]
        [InlineData("-1.5", "1", "-1.5")]
        [InlineData("1.5", "1", "1.5")]
        [InlineData(ConstantStrings.MaxInt, "2", ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.MaxInt, "-2", ConstantStrings.NegativeMaxIntTimes2)]
        [InlineData(ConstantStrings.MaxFloat, "2", ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.MaxFloat, "-2", ConstantStrings.NegativeMaxFloatTimes2)]
        [InlineData(ConstantStrings.MaxDouble, "2", ConstantStrings.MaxDoubleTimes2)]
        [InlineData(ConstantStrings.MaxDouble, "-2", ConstantStrings.NegativeMaxDoubleTimes2)]
        public void ShouldMultiply(
            string multiplicand,
            string multiplier,
            string expected)
        {
            BigFloat bigMultiplicand = new BigFloat(multiplicand);
            BigFloat bigMultiplier = new BigFloat(multiplier);
            BigFloat actualProduct1 = this.Multiply(bigMultiplicand, bigMultiplier);
            BigFloat actualProduct2 = this.Multiply(bigMultiplier, bigMultiplicand);
            BigFloat expectedProduct = new BigFloat(expected);

            Assert.Equal(
                expected: expectedProduct,
                actual: actualProduct1);

            Assert.Equal(
                expected: expectedProduct,
                actual: actualProduct2);
        }

        protected abstract BigFloat Multiply(
            BigFloat multiplicand,
            BigFloat multiplier);
    }
}
