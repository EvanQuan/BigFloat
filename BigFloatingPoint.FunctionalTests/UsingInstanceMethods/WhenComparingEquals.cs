using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System.Numerics;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenComparingEquals : EqualsTestBase
    {
        protected override bool Equal(
            BigFloat left,
            BigFloat right)
        {
            return left.Equals(right);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(1f)]
        [InlineData(1d)]
        [InlineData(1L)]
        [InlineData("1")]
        [InlineData("1.0")]
        public void ShouldReturnTrueForConstObjects(object obj)
        {
            BigFloat big = BigFloat.One;

            Assert.True(BigFloat.Equals(big, obj));
            Assert.True(BigFloat.Equals(obj, big));
        }

        [Fact]
        public void ShouldReturnTrueForBigInteger()
        {
            BigFloat bigFloat = BigFloat.One;
            BigInteger bigInt = BigInteger.One;

            Assert.True(BigFloat.Equals(bigInt, bigFloat));
            Assert.True(BigFloat.Equals(bigFloat, bigInt));
        }
    }

}
