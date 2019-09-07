using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class CompareToTestBase
    {
        [Theory]
        [InlineData("0", "0.0")]
        [InlineData("-1", "-1.0")]
        [InlineData("1", "1.0")]
        public void ShouldReturnZero(string left, string right)
        {
            Assert.Equal(
                expected: 0,
                this.CompareTo((BigFloat)left, (BigFloat)right));

        }
            protected abstract int CompareTo(BigFloat left, BigFloat right);
    }
}
