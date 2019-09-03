using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenAdding
    {
        [Theory]
        [InlineData("0", "0", "0")]
        [InlineData("1", "1", "2")]
        [InlineData("-1", "-1", "-2")]
        [InlineData("-1.5", "-1.5", "-3.0")]
        [InlineData("1", "-1", "0")]
        [InlineData("-1", "1", "0")]
        [InlineData("1.5", "-1.5", "0")]
        [InlineData("-1.5", "1.5", "0")]
        [InlineData(ConstantStrings.MaxInt, ConstantStrings.NegativeMaxInt, "0")]
        [InlineData(ConstantStrings.NegativeMaxInt, ConstantStrings.MaxInt, "0")]
        [InlineData(ConstantStrings.MaxInt, "1", ConstantStrings.MaxIntPlus1)]
        [InlineData(ConstantStrings.MaxInt, ConstantStrings.MaxInt, ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.MaxFloat, ConstantStrings.NegativeMaxFloat, "0")]
        [InlineData(ConstantStrings.NegativeMaxFloat, ConstantStrings.MaxFloat, "0")]
        [InlineData(ConstantStrings.MaxFloat, "1", ConstantStrings.MaxFloatPlus1)]
        [InlineData(ConstantStrings.MaxFloat, ConstantStrings.MaxFloat, ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.MaxDouble, ConstantStrings.NegativeMaxDouble, "0")]
        [InlineData(ConstantStrings.NegativeMaxDouble, ConstantStrings.MaxDouble, "0")]
        [InlineData(ConstantStrings.MaxDouble, "1", ConstantStrings.MaxDoublePlus1)]
        [InlineData(ConstantStrings.MaxDouble, ConstantStrings.MaxDouble, ConstantStrings.MaxDoubleTimes2)]
        public void ShouldAdd(
            string leftAddend,
            string rightAddend,
            string expectedSum)
        {
            BigFloat bigLeftAddend = new BigFloat(leftAddend);
            BigFloat bigRightAddend = new BigFloat(rightAddend);

            BigFloat expectedBigSum = new BigFloat(expectedSum);
            BigFloat actualBigSum = bigLeftAddend + bigRightAddend;

            Assert.Equal(
                expected: expectedBigSum,
                actual: actualBigSum);
        }
    }
}
