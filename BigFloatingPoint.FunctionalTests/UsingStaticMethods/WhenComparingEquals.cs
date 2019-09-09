using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenComparingEquals : EqualsTest
    {
        protected override bool Equal(
            BigFloat left,
            BigFloat right)
        {
            return BigFloat.Equals(left, right);
        }

        [Theory]
        [InlineData(1.0d)]
        [InlineData(1.0f)]
        [InlineData(1)]
        [InlineData(1L)]
        [InlineData("1.0")]
        [InlineData("1")]
        public void ShouldEqualForCastableTypes(
            object obj)
        {
            BigFloat big = (BigFloat)obj;
            Assert.True(BigFloat.Equals(big, obj));
            Assert.True(BigFloat.Equals(obj, big));
        }

        [Theory]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData("0")]
        [InlineData(Constant.MinIntMinus1)]
        [InlineData(Constant.MinIntTimes2)]
        [InlineData(Constant.MinFloatMinus1)]
        [InlineData(Constant.MinFloatTimes2)]
        [InlineData(Constant.MinDoubleMinus1)]
        [InlineData(Constant.MinDoubleTimes2)]
        [InlineData(Constant.MaxIntPlus1)]
        [InlineData(Constant.MaxIntTimes2)]
        [InlineData(Constant.MaxFloatPlus1)]
        [InlineData(Constant.MaxFloatTimes2)]
        [InlineData(Constant.MaxDoublePlus1)]
        [InlineData(Constant.MaxDoubleTimes2)]
        public void ShouldEqualForBigInteger(
            string str)
        {
            BigInteger bigInt = BigInteger.Parse(str);
            BigFloat bigFloat = (BigFloat)str;

            Assert.True(BigFloat.Equals(bigFloat, bigInt));
            Assert.True(BigFloat.Equals(bigInt, bigFloat));
        }
    }
}
