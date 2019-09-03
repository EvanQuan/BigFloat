using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenComparingGreaterThan
    {
        [Theory]
        [InlineData(
            "-0.99999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999",
            "-1")]
        [InlineData("0", "-0.1")]
        [InlineData("0.1", "0")]
        [InlineData("1", "0.1")]
        [InlineData(
            "1.0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001",
            "1")]
        public void ShouldReturnTrue(string left, string right)
        {
            BigFloat bigLeft = new BigFloat(left);
            BigFloat bigRight = new BigFloat(right);

            Assert.True(bigLeft > bigRight);
        }

        [Theory]
        [InlineData("-1", "-1")]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("-1", "-0.99999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999")]
        [InlineData("-0.1", "0")]
        [InlineData("0", "0.1")]
        [InlineData("1", "0.1")]
        [InlineData("1", "1.0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001")]
        public void ShouldReturnFalse(string left, string right)
        {
            BigFloat bigLeft = new BigFloat(left);
            BigFloat bigRight = new BigFloat(right);

            Assert.False(bigLeft > bigRight);
        }
    }
}
