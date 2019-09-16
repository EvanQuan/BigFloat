using BigFloatingPoint.Implementations;
using System;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.TestBases
{
    public abstract class LogTest
    {
        [Theory]
        [InlineData("1")]
        [InlineData(Constant.String.MaxDoubleTimes2)]
        [InlineData(Constant.String.Pi)]
        public void ShouldReturn1WithBase1(string value)
        {
            ShouldLog(
                value: value,
                baseValue: 1,
                expected: 1);
        }

        /// <summary>
        /// All negative values of any base should return NaN.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="baseValue"></param>
        [Theory]
        [InlineData("-1", 0)]
        [InlineData("-1", -1)]
        [InlineData("-1", 1)]
        [InlineData("-1", Math.PI)]
        [InlineData("-1", double.MaxValue)]
        [InlineData("-1", double.MinValue)]
        [InlineData("0.9", 0)]
        [InlineData("0.9", -1)]
        [InlineData("0.9", 1)]
        [InlineData("0.9", Math.PI)]
        [InlineData("0.9", double.MaxValue)]
        [InlineData("0.9", double.MinValue)]
        [InlineData(Constant.String.MinDoubleTimes2, 0)]
        [InlineData(Constant.String.MinDoubleTimes2, -1)]
        [InlineData(Constant.String.MinDoubleTimes2, 1)]
        [InlineData(Constant.String.MinDoubleTimes2, Math.PI)]
        [InlineData(Constant.String.MinDoubleTimes2, double.MaxValue)]
        [InlineData(Constant.String.MinDoubleTimes2, double.MinValue)]
        [InlineData(Constant.String.NegativePi, 0)]
        [InlineData(Constant.String.NegativePi, -1)]
        [InlineData(Constant.String.NegativePi, 1)]
        [InlineData(Constant.String.NegativePi, Math.PI)]
        [InlineData(Constant.String.NegativePi, double.MaxValue)]
        [InlineData(Constant.String.NegativePi, double.MinValue)]
        public void ShouldReturnNaN(string value, double baseValue)
        {
            ShouldLog(
                value: value,
                baseValue: baseValue,
                expected: double.NaN);
        }

        /// <summary>
        /// Value of zero of any base should return negative infinity.
        /// </summary>
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(Math.PI)]
        [InlineData(double.MaxValue)]
        [InlineData(double.MinValue)]
        public void ShouldReturnNegativeInfinity(double baseValue)
        {
            ShouldLog(
                value: "0",
                baseValue: baseValue,
                expected: double.NegativeInfinity);
        }

        [Theory]
        [InlineData("-1", 2, -0.5)]
        [InlineData("2", 2, 1)]
        [InlineData("4", 2, 2)]
        [InlineData(Constant.String.MaxIntPlus1, 2, 31)]
        public void ShouldReturnCorrectly(
            string value,
            double baseValue,
            double expected)
        {
            ShouldLog(
                value: value,
                baseValue: baseValue,
                expected: expected);
        }

        private void ShouldLog(string value, double baseValue, double expected)
        {
            BigFloat bigValue = new BigFloat(value);
            // BigFloat bigExpected = new BigFloat(expected);

            double actual = this.Log(bigValue, baseValue);

            Assert.Equal(
                expected: expected,
                actual: actual);
        }
        protected abstract double Log(BigFloat value, double baseValue);
    }
}
