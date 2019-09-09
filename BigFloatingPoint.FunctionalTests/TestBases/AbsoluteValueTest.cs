using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class AbsoluteValueTest
    {
        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("-1", "1")]
        [InlineData("-1.5", "1.5")]
        [InlineData("1.5", "1.5")]
        [InlineData(Constant.MaxInt, Constant.MaxInt)]
        [InlineData(Constant.NegativeMaxInt, Constant.MaxInt)]
        [InlineData(Constant.MaxIntPlus1, Constant.MaxIntPlus1)]
        [InlineData(Constant.NegativeMaxIntPlus1, Constant.MaxIntPlus1)]
        [InlineData(Constant.MaxIntTimes2, Constant.MaxIntTimes2)]
        [InlineData(Constant.NegativeMaxIntTimes2, Constant.MaxIntTimes2)]
        [InlineData(Constant.MaxFloat, Constant.MaxFloat)]
        [InlineData(Constant.NegativeMaxFloat, Constant.MaxFloat)]
        [InlineData(Constant.MaxFloatPlus1, Constant.MaxFloatPlus1)]
        [InlineData(Constant.NegativeMaxFloatPlus1, Constant.MaxFloatPlus1)]
        [InlineData(Constant.MaxFloatTimes2, Constant.MaxFloatTimes2)]
        [InlineData(Constant.NegativeMaxFloatTimes2, Constant.MaxFloatTimes2)]
        [InlineData(Constant.MaxDouble, Constant.MaxDouble)]
        [InlineData(Constant.NegativeMaxDouble, Constant.MaxDouble)]
        [InlineData(Constant.MaxDoublePlus1, Constant.MaxDoublePlus1)]
        [InlineData(Constant.NegativeMaxDoublePlus1, Constant.MaxDoublePlus1)]
        [InlineData(Constant.MaxDoubleTimes2, Constant.MaxDoubleTimes2)]
        [InlineData(Constant.NegativeMaxDoubleTimes2, Constant.MaxDoubleTimes2)]
        public void ShouldGetAbsoluteValue(string value, string expected)
        {
            BigFloat bigValue = new BigFloat(value);
            BigFloat bigExpected = new BigFloat(expected);

            bigValue = this.AbsoluteValue(bigValue);

            Assert.Equal(
                expected: bigExpected,
                actual: bigValue);

        }

        public abstract BigFloat AbsoluteValue(BigFloat value);

    }
}
