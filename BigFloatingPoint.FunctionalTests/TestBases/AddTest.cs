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
        [InlineData(Constant.MaxInt, Constant.NegativeMaxInt, "0")]
        [InlineData(Constant.NegativeMaxInt, Constant.MaxInt, "0")]
        [InlineData(Constant.MaxInt, "1", Constant.MaxIntPlus1)]
        [InlineData(Constant.MaxInt, Constant.MaxInt, Constant.MaxIntTimes2)]
        [InlineData(Constant.MaxFloat, Constant.NegativeMaxFloat, "0")]
        [InlineData(Constant.NegativeMaxFloat, Constant.MaxFloat, "0")]
        [InlineData(Constant.MaxFloat, "1", Constant.MaxFloatPlus1)]
        [InlineData(Constant.MaxFloat, Constant.MaxFloat, Constant.MaxFloatTimes2)]
        [InlineData(Constant.MaxDouble, Constant.NegativeMaxDouble, "0")]
        [InlineData(Constant.NegativeMaxDouble, Constant.MaxDouble, "0")]
        [InlineData(Constant.MaxDouble, "1", Constant.MaxDoublePlus1)]
        [InlineData(Constant.MaxDouble, Constant.MaxDouble, Constant.MaxDoubleTimes2)]
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
