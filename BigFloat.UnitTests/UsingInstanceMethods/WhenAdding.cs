using BigFloatingPoint.Implementations;
using System;
using Xunit;

namespace BigFloatingPoint.UnitTests.UsingInstanceMethods
{
    public class WhenAdding
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 2)]
        [InlineData(-1, -1, -2)]
        [InlineData(0.5, 0.5, 1)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(0, 0.5, 0.5)]
        [InlineData(1, 0, 1)]
        [InlineData(-1, 0, -1)]
        [InlineData(0.5, 0, 0.5)]
        public void ShouldAddCorrectly(double num1, double num2, double expected)
        {
            BigFloat float1 = new BigFloat(num1);
            BigFloat float2 = new BigFloat(num2);

            BigFloat sum = float1.Add(float2);

            Assert.Equal(new BigFloat(expected), sum);
        }
    }
}
