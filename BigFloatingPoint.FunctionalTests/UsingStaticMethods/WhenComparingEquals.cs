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
        [InlineData("1.0")]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData("0")]
        public void ShouldEqualForStrings(string obj)
        {
            BigFloat big = (BigFloat)obj;
            Assert.True(BigFloat.Equals(big, obj));
            Assert.True(BigFloat.Equals(obj, big));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        public void ShouldEqualForInt(int obj)
        {
            BigFloat big = (BigFloat)obj;
            Assert.True(BigFloat.Equals(big, obj));
            Assert.True(BigFloat.Equals(obj, big));
        }

        [Theory]
        [InlineData(1L)]
        [InlineData(-1L)]
        [InlineData(0L)]
        [InlineData(long.MaxValue)]
        [InlineData(long.MinValue)]
        public void ShouldEqualForLong(long obj)
        {
            BigFloat big = (BigFloat)obj;
            Assert.True(BigFloat.Equals(big, obj));
            Assert.True(BigFloat.Equals(obj, big));
        }

        [Theory]
        [InlineData(1.0f)]
        [InlineData(-1.0f)]
        [InlineData(0.0f)]
        [InlineData(0.1f)]
        [InlineData(-0.1f)]
        [InlineData(float.MaxValue)]
        [InlineData(float.MinValue)]
        public void ShouldEqualForFloat(float obj)
        {
            BigFloat big = (BigFloat)obj;
            Assert.True(BigFloat.Equals(big, obj));
            Assert.True(BigFloat.Equals(obj, big));
        }

        [Theory]
        [InlineData(1.0d)]
        [InlineData(-1.0d)]
        [InlineData(0.0d)]
        [InlineData(0.1d)]
        [InlineData(-0.1d)]
        [InlineData(double.MaxValue)]
        [InlineData(double.MinValue)]
        public void ShouldEqualForDouble(double obj)
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
            BigFloat bigFloat = new BigFloat(str);

            Assert.True(BigFloat.Equals(bigFloat, bigInt));
            Assert.True(BigFloat.Equals(bigInt, bigFloat));
        }
    }
}
