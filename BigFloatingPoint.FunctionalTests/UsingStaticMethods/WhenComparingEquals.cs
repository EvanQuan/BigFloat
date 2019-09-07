using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenComparingEquals : EqualsTestBase
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
        [InlineData(ConstantStrings.MinIntMinus1)]
        [InlineData(ConstantStrings.MinIntTimes2)]
        [InlineData(ConstantStrings.MinFloatMinus1)]
        [InlineData(ConstantStrings.MinFloatTimes2)]
        [InlineData(ConstantStrings.MinDoubleMinus1)]
        [InlineData(ConstantStrings.MinDoubleTimes2)]
        [InlineData(ConstantStrings.MaxIntPlus1)]
        [InlineData(ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.MaxFloatPlus1)]
        [InlineData(ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.MaxDoublePlus1)]
        [InlineData(ConstantStrings.MaxDoubleTimes2)]
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
