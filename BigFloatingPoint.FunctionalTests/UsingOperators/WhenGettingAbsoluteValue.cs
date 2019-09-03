using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{

    public class WhenGettingAbsoluteValue
    {
        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("-1", "1")]
        [InlineData("-1.5", "1.5")]
        [InlineData("1.5", "1.5")]
        [InlineData(ConstantStrings.MaxInt, ConstantStrings.MaxInt)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxInt, ConstantStrings.MaxInt)]
        [InlineData(ConstantStrings.MaxIntPlus1, ConstantStrings.MaxIntPlus1)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxIntPlus1, ConstantStrings.MaxIntPlus1)]
        [InlineData(ConstantStrings.MaxIntTimes2, ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxIntTimes2, ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.MaxFloat, ConstantStrings.MaxFloat)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxFloat, ConstantStrings.MaxFloat)]
        [InlineData(ConstantStrings.MaxFloatPlus1, ConstantStrings.MaxFloatPlus1)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxFloatPlus1, ConstantStrings.MaxFloatPlus1)]
        [InlineData(ConstantStrings.MaxFloatTimes2, ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxFloatTimes2, ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.MaxDouble, ConstantStrings.MaxDouble)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxDouble, ConstantStrings.MaxDouble)]
        [InlineData(ConstantStrings.MaxDoublePlus1, ConstantStrings.MaxDoublePlus1)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxDoublePlus1, ConstantStrings.MaxDoublePlus1)]
        [InlineData(ConstantStrings.MaxDoubleTimes2, ConstantStrings.MaxDoubleTimes2)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxDoubleTimes2, ConstantStrings.MaxDoubleTimes2)]
        public void ShouldGetAbsoluteValue(string value, string expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat bigExpected = new BigFloat(expected);

            bigValue = +bigValue;

            Assert.Equal(
                expected: bigExpected,
                actual: bigValue);
        }
            
    }
}
