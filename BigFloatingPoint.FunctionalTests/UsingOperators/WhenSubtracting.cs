﻿using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenSubtracting
    {
        [Theory]
        [InlineData("0", "0", "0")]
        [InlineData("1", "1", "0")]
        [InlineData("-1", "-1", "0")]
        [InlineData("-1.5", "-1.5", "0")]
        [InlineData("1", "-1", "2")]
        [InlineData("-1", "1", "-2")]
        [InlineData("1.5", "-1.5", "3.0")]
        [InlineData("-1.5", "1.5", "-3.0")]
        [InlineData(ConstantStrings.MaxInt, ConstantStrings.Negative + ConstantStrings.MaxInt, ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.Negative + ConstantStrings.MaxInt, ConstantStrings.MaxInt, ConstantStrings.Negative + ConstantStrings.MaxIntTimes2)]
        [InlineData(ConstantStrings.MaxInt, "-1", ConstantStrings.MaxIntPlus1)]
        [InlineData(ConstantStrings.MinInt, "1", ConstantStrings.MinIntMinus1)]
        [InlineData(ConstantStrings.MaxInt, ConstantStrings.MaxInt, "0")]
        [InlineData(ConstantStrings.MaxFloat, ConstantStrings.Negative + ConstantStrings.MaxFloat, ConstantStrings.MaxFloatTimes2)]
        [InlineData(ConstantStrings.MinFloat, ConstantStrings.MaxFloat, ConstantStrings.MinFloatTimes2)]
        [InlineData(ConstantStrings.MaxFloat, "-1", ConstantStrings.MaxFloatPlus1)]
        [InlineData(ConstantStrings.MinFloat, "1", ConstantStrings.MinFloatMinus1)]
        [InlineData(ConstantStrings.MaxFloat, ConstantStrings.MaxFloat, "0")]
        [InlineData(ConstantStrings.MaxDouble, ConstantStrings.Negative + ConstantStrings.MaxDouble, ConstantStrings.MaxDoubleTimes2)]
        [InlineData(ConstantStrings.MinDouble, ConstantStrings.MaxDouble, ConstantStrings.MinDoubleTimes2)]
        [InlineData(ConstantStrings.MaxDouble, "-1", ConstantStrings.MaxDoublePlus1)]
        [InlineData(ConstantStrings.MinDouble, "1", ConstantStrings.MinDoubleMinus1)]
        [InlineData(ConstantStrings.MaxDouble, ConstantStrings.MaxDouble, "0")]
        public void ShouldSubtract(
            string minuend,
            string subtrahend,
            string expectedDifference)
        {
            BigFloat bigMinuend = new BigFloat(minuend);
            BigFloat bigSubtrahend = new BigFloat(subtrahend);

            BigFloat expectedBigDifference = new BigFloat(expectedDifference);
            BigFloat actualBigDifference = bigMinuend - bigSubtrahend;

            Assert.Equal(
                expected: expectedBigDifference,
                actual: actualBigDifference);
        }
    }
}
