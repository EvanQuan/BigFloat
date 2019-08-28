﻿using Com.Github.EvanQuan.BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Github.EvanQuan.BigFloatingPoint.UnitTests.UsingInstanceMethods
{
    public class WhenAdding
    {
        [Fact]
        public void ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(
                () =>
                {
                    BigFloat.Zero.Add(null);
                });
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 2)]
        [InlineData(-1, -1, -2)]
        [InlineData(0.5, 0.5, 1)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(0, 0.5, 0.5)]
        [InlineData(1, 0, 1)]
        [InlineData(-1, 0, -1)]
        [InlineData(0.5, 0, 0.5)]
        public void ShouldAddCorrectly(float num1, float num2, float expected)
        {
            BigFloat float1 = new BigFloat(num1);
            BigFloat float2 = new BigFloat(num2);

            BigFloat sum = float1.Add(float2);

            Assert.Equal(new BigFloat(expected), sum);
        }
    }
}
