using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenGettingHashCode
    {
        [Theory]
        [InlineData("-1")]
        [InlineData("0")]
        [InlineData("1")]
        public void ShouldReturnSameHashForSameValue(string number)
        {
            BigFloat bigString = (BigFloat)number;
            BigFloat bigInt = int.Parse(number);
            BigFloat bigFloat = float.Parse(number);
            BigFloat bigDouble = double.Parse(number);


            Assert.Equal(
                bigString.GetHashCode(),
                bigInt.GetHashCode());

            Assert.Equal(
                bigInt.GetHashCode(),
                bigFloat.GetHashCode());

            Assert.Equal(
                bigFloat.GetHashCode(),
                bigDouble.GetHashCode());
        }

        [Theory]
        [InlineData(1, 1, 2, 2)]
        [InlineData(1, 2, 2, 4)]
        [InlineData(-1, -1, 1, 1)]
        [InlineData(-1, -2, 1, 2)]
        [InlineData(-1, 1, 1, -1)]
        public void ShouldReturnDifferentHashForSameValueDifferentFactors(
            int numerator1,
            int denominator1,
            int numerator2,
            int denominator2)
        {
            BigFloat one = new BigFloat(numerator1, denominator1);
            BigFloat two = new BigFloat(numerator2, denominator2);

            Assert.NotEqual(
                one.GetHashCode(),
                two.GetHashCode());
        }

        [Theory]
        [InlineData(1, 1, 2, 2)]
        [InlineData(1, 2, 2, 4)]
        [InlineData(-1, -1, 1, 1)]
        [InlineData(-1, -2, 1, 2)]
        [InlineData(-1, 1, 1, -1)]
        public void ShouldReturnSameHashWhenSimplified(
            int numerator1,
            int denominator1,
            int numerator2,
            int denominator2)
        {
            BigFloat one = new BigFloat(numerator1, denominator1).Simplify();
            BigFloat two = new BigFloat(numerator2, denominator2).Simplify();

            Assert.Equal(
                one.GetHashCode(),
                two.GetHashCode());
        }

        [Theory]
        [InlineData("-1", "1")]
        [InlineData("-1", "0")]
        [InlineData("0", "1")]
        public void ShouldReturnDifferentHashForDifferentValues(
            string value1,
            string value2)
        {
            BigFloat one = (BigFloat)value1;
            BigFloat two = (BigFloat)value2;

            Assert.NotEqual(
                one.GetHashCode(),
                two.GetHashCode());
        }

    }
}
