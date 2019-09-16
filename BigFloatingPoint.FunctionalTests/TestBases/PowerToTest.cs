using BigFloatingPoint.Implementations;
using System;
using System.Numerics;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class PowerToTest
    {

        [Theory]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData(Constant.String.E)]
        [InlineData(Constant.String.MaxDoubleTimes2)]
        [InlineData(Constant.String.MinDoubleTimes2)]
        public void ShouldReturnOneWithZeroExponent(
            string @base)
        {
            ShouldRaisePowerToCorrectly(
                @base: @base,
                exponent: 0,
                expected: "1");
        }

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        [InlineData(-1)]
        [InlineData(1)]
        public void ShouldReturnZeroWithZeroBase(
            int exponent)
        {
            ShouldRaisePowerToCorrectly(
                @base: "0",
                exponent: exponent,
                expected: "0");
        }

        [Theory]
        // +base, +exponent = > 0
        [InlineData("0.5", 1, "0.5")]
        [InlineData("0.5", 2, "0.25")]
        [InlineData("0.5", 3, "0.125")]
        [InlineData("0.5", 4, "0.0625")]
        [InlineData("1", 1, "1")]
        [InlineData(Constant.String.MaxDoubleTimes2, 1, Constant.String.MaxDoubleTimes2)]
        [InlineData(Constant.String.MaxDouble, 2, Constant.String.MaxDoubleSquared)]
        [InlineData("1", int.MaxValue, "1")]
        [InlineData("2", 1, "2")]
        [InlineData("2", 2, "4")]
        [InlineData("2", 31, Constant.String.MaxIntPlus1)]
        [InlineData("2.5", 2, "6.25")]
        [InlineData("2.5", 3, "15.625")]
        [InlineData("2.5", 4, "39.0625")]
        // -base, +exponent = - if exponent is odd, else +
        [InlineData("-0.5", 1, "-0.5")]
        [InlineData("-0.5", 2, "0.25")]
        [InlineData("-0.5", 3, "-0.125")]
        [InlineData("-0.5", 4, "0.0625")]
        [InlineData("-1", 1, "-1")]
        [InlineData(Constant.String.NegativeMaxDoubleTimes2, 1, Constant.String.NegativeMaxDoubleTimes2)]
        [InlineData(Constant.String.NegativeMaxDouble, 2, Constant.String.MaxDoubleSquared)]
        [InlineData("-1", int.MaxValue, "-1")]
        [InlineData("-2", 1, "-2")]
        [InlineData("-2", 2, "4")]
        [InlineData("-2", 31, Constant.String.NegativeMaxIntPlus1)]
        [InlineData("-2.5", 2, "6.25")]
        [InlineData("-2.5", 3, "-15.625")]
        [InlineData("-2.5", 4, "39.0625")]
        // -base, -exponent = - if exponent is odd, else +
        [InlineData("-0.5", -1, "-2")]
        [InlineData("-0.5", -2, "4")]
        [InlineData("-0.5", -3, "-8")]
        [InlineData("-0.5", -4, "16")]
        [InlineData("-1", -1, "-1")]
        // [InlineData(Constant.NegativeMaxDoubleTimes2, -1, ?)]
        // [InlineData(Constant.NegativeMaxDouble, -2, ?)]
        [InlineData("-1", -int.MaxValue, "-1")]
        [InlineData("-2", -1, "-0.5")]
        [InlineData("-2", -2, "0.25")]
        // [InlineData("-2", -31, ?)]
        [InlineData("-2.5", -2, "0.16")]
        [InlineData("-2.5", -3, "-0.064")]
        [InlineData("-2.5", -4, "0.0256")]
        // +base, -exponent = - if exponent is odd, else +
        [InlineData("0.5", -1, "2")]
        [InlineData("0.5", -2, "4")]
        [InlineData("0.5", -3, "8")]
        [InlineData("0.5", -4, "16")]
        [InlineData("1", -1, "1")]
        // [InlineData(Constant.MaxDoubleTimes2, -1, ?)]
        // [InlineData(Constant.MaxDouble, -2, ?)]
        [InlineData("1", -int.MaxValue, "1")]
        [InlineData("2", -1, "0.5")]
        [InlineData("2", -2, "0.25")]
        // [InlineData("2", -31, ?)]
        [InlineData("2.5", -2, "0.16")]
        [InlineData("2.5", -3, "0.064")]
        [InlineData("2.5", -4, "0.0256")]

        public void ShouldReturnCorrectly(
            string @base,
            int exponent,
            string expected)
        {
            ShouldRaisePowerToCorrectly(
                @base: @base,
                exponent: exponent,
                expected: expected);
        }

        private void ShouldRaisePowerToCorrectly(
            string @base,
            int exponent,
            string expected)
        {
            BigFloat bigBase = new BigFloat(@base);

            BigFloat actual = this.PowerTo(
                @base: bigBase,
                exponent: exponent);

            BigFloat bigExpected = new BigFloat(expected);

            Assert.Equal(
                expected: bigExpected,
                actual: actual);
        }



        /// <summary>
        /// 0 to the power of 0 is undefined. However, for <see
        /// cref="Math.Pow"/> and <see cref="BigInteger.Pow"/> both return 1.
        /// <see cref="BigFloat"/> should be consistent with this.
        /// </summary>
        [Fact]
        public void ShouldReturnOne()
        {
            Assert.Equal(
                expected: 1,
                actual: Math.Pow(0, 0));

            Assert.Equal(
                expected: BigInteger.One,
                actual: BigInteger.Pow(BigInteger.Zero, 0));

            Assert.Equal(
                expected: BigFloat.One,
                actual: this.PowerTo(BigFloat.Zero, 0));
        }

        protected abstract BigFloat PowerTo(
            BigFloat @base,
            int exponent);
    }
}
