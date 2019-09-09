using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class TruncateTest
    {
        [Theory]
        [InlineData("1", "1")]
        [InlineData("-1", "-1")]
        [InlineData("0", "0")]
        [InlineData("1.1", "1")]
        [InlineData("-1.1", "-1")]
        [InlineData("1.01", "1")]
        [InlineData("-1.01", "-1")]
        [InlineData(Constant.Pi, "3")]
        [InlineData(Constant.NegativePi, "-3")]
        [InlineData(Constant.E, "2")]
        [InlineData(Constant.NegativeE, "-2")]
        [InlineData(Constant.Phi, "1")]
        [InlineData(Constant.NegativePhi, "-1")]
        [InlineData(Constant.W, "2")]
        [InlineData(Constant.NegativeW, "-2")]
        public void ShouldTruncate(
            string value,
            string expected)
        {
            BigFloat actualTruncated = new BigFloat(value).Truncate();
            BigFloat expectedTruncate = new BigFloat(expected);

            Assert.Equal(
                expected: expectedTruncate,
                actual: actualTruncated);
        }

        protected abstract BigFloat Truncate(BigFloat value);
    }
}
