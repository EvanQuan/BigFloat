﻿using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class MultiplyTest
    {

        [Theory]
        [InlineData("0", "0", "0")]
        [InlineData("1", "1", "1")]
        [InlineData("-1", "1", "-1")]
        [InlineData("-1", "-1", "1")]
        [InlineData("1", "0", "0")]
        [InlineData("-1", "0", "0")]
        [InlineData("1", "2", "2")]
        [InlineData("2", "2", "4")]
        [InlineData("-2", "2", "-4")]
        [InlineData("-2", "-2", "4")]
        [InlineData("-1.5", "1", "-1.5")]
        [InlineData("1.5", "1", "1.5")]
        [InlineData(Constant.MaxInt, "2", Constant.MaxIntTimes2)]
        [InlineData(Constant.MaxInt, "-2", Constant.NegativeMaxIntTimes2)]
        [InlineData(Constant.MaxFloat, "2", Constant.MaxFloatTimes2)]
        [InlineData(Constant.MaxFloat, "-2", Constant.NegativeMaxFloatTimes2)]
        [InlineData(Constant.MaxDouble, "2", Constant.MaxDoubleTimes2)]
        [InlineData(Constant.MaxDouble, "-2", Constant.NegativeMaxDoubleTimes2)]
        public void ShouldMultiply(
            string multiplicand,
            string multiplier,
            string expected)
        {
            BigFloat bigMultiplicand = new BigFloat(multiplicand);
            BigFloat bigMultiplier = new BigFloat(multiplier);
            BigFloat actualProduct1 = this.Multiply(bigMultiplicand, bigMultiplier);
            BigFloat actualProduct2 = this.Multiply(bigMultiplier, bigMultiplicand);
            BigFloat expectedProduct = new BigFloat(expected);

            Assert.Equal(
                expected: expectedProduct,
                actual: actualProduct1);

            Assert.Equal(
                expected: expectedProduct,
                actual: actualProduct2);
        }

        protected abstract BigFloat Multiply(
            BigFloat multiplicand,
            BigFloat multiplier);
    }
}
