using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.UnitTests.UsingFields
{
    public class WhenGettingSignString
    {
        [Theory]
        [InlineData(1.0)]
        [InlineData(0.1)]
        public void ShouldBePositive(double value)
        {
//            Assert.Equal(
//                expected: string.Empty,
//                actual: new BigFloat(value).SignString);
        }
    }
}
