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
        [InlineData(Constant.String.MaxInt, Constant.String.MaxInt)]
        [InlineData(Constant.String.NegativeMaxInt, Constant.String.MaxInt)]
        [InlineData(Constant.String.MaxIntPlus1, Constant.String.MaxIntPlus1)]
        [InlineData(Constant.String.NegativeMaxIntPlus1, Constant.String.MaxIntPlus1)]
        [InlineData(Constant.String.MaxIntTimes2, Constant.String.MaxIntTimes2)]
        [InlineData(Constant.String.NegativeMaxIntTimes2, Constant.String.MaxIntTimes2)]
        [InlineData(Constant.String.MaxFloat, Constant.String.MaxFloat)]
        [InlineData(Constant.String.NegativeMaxFloat, Constant.String.MaxFloat)]
        [InlineData(Constant.String.MaxFloatPlus1, Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.NegativeMaxFloatPlus1, Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.MaxFloatTimes2, Constant.String.MaxFloatTimes2)]
        [InlineData(Constant.String.NegativeMaxFloatTimes2, Constant.String.MaxFloatTimes2)]
        [InlineData(Constant.String.MaxDouble, Constant.String.MaxDouble)]
        [InlineData(Constant.String.NegativeMaxDouble, Constant.String.MaxDouble)]
        [InlineData(Constant.String.MaxDoublePlus1, Constant.String.MaxDoublePlus1)]
        [InlineData(Constant.String.NegativeMaxDoublePlus1, Constant.String.MaxDoublePlus1)]
        [InlineData(Constant.String.MaxDoubleTimes2, Constant.String.MaxDoubleTimes2)]
        [InlineData(Constant.String.NegativeMaxDoubleTimes2, Constant.String.MaxDoubleTimes2)]
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
