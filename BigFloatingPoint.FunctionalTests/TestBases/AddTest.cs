using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class AddTest
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
        [InlineData(Constant.String.MaxInt, Constant.String.NegativeMaxInt, "0")]
        [InlineData(Constant.String.NegativeMaxInt, Constant.String.MaxInt, "0")]
        [InlineData(Constant.String.MaxInt, "1", Constant.String.MaxIntPlus1)]
        [InlineData(Constant.String.MaxInt, Constant.String.MaxInt, Constant.String.MaxIntTimes2)]
        [InlineData(Constant.String.MaxFloat, Constant.String.NegativeMaxFloat, "0")]
        [InlineData(Constant.String.NegativeMaxFloat, Constant.String.MaxFloat, "0")]
        [InlineData(Constant.String.MaxFloat, "1", Constant.String.MaxFloatPlus1)]
        [InlineData(Constant.String.MaxFloat, Constant.String.MaxFloat, Constant.String.MaxFloatTimes2)]
        [InlineData(Constant.String.MaxDouble, Constant.String.NegativeMaxDouble, "0")]
        [InlineData(Constant.String.NegativeMaxDouble, Constant.String.MaxDouble, "0")]
        [InlineData(Constant.String.MaxDouble, "1", Constant.String.MaxDoublePlus1)]
        [InlineData(Constant.String.MaxDouble, Constant.String.MaxDouble, Constant.String.MaxDoubleTimes2)]
        public void ShouldAdd(
            string leftAddend,
            string rightAddend,
            string expectedSum)
        {
            BigFloat bigLeftAddend = new BigFloat(leftAddend);
            BigFloat bigRightAddend = new BigFloat(rightAddend);

            BigFloat expectedBigSum = new BigFloat(expectedSum);
            BigFloat actualBigSum = Add(bigLeftAddend, bigRightAddend);

            Assert.Equal(
                expected: expectedBigSum,
                actual: actualBigSum);
        }

        protected abstract BigFloat Add(
            BigFloat leftAddend,
            BigFloat rightAddend);
    }
}
