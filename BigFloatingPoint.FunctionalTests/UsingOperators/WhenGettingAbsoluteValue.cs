using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{

    public class WhenGettingAbsoluteValue
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(-1, 1)]
        [InlineData(-1.5, 1.5)]
        [InlineData(1.5, 1.5)]
        [InlineData(int.MaxValue, int.MaxValue)]
        [InlineData(-int.MaxValue, int.MaxValue)]
        [InlineData(float.MaxValue, float.MaxValue)]
        [InlineData(-float.MaxValue, float.MaxValue)]
        [InlineData(double.MaxValue, double.MaxValue)]
        [InlineData(-double.MaxValue, double.MaxValue)]
        public void ShouldGetAbsoluteValue(double value, double expected)
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
