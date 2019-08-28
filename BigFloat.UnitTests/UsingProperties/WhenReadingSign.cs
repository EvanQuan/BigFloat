﻿using Com.Github.EvanQuan.BigFloat;
using Xunit;

namespace UnitTests.UsingProperties
{
    public class WhenReadingSign
    {
        [Fact]
        public void ShouldBePositive()
        {
            BigFloat bigFloat = new BigFloat(1);

            Assert.Equal(
                expected: BigFloat.PositiveSign,
                actual: bigFloat.Sign);
        }

        [Fact]
        public void ShouldBeNegative()
        {
            BigFloat bigFloat = new BigFloat(-1);

            Assert.Equal(
                expected: BigFloat.NegativeSign,
                actual: bigFloat.Sign);
        }

        [Fact]
        public void ShouldBeNeutral()
        {
            BigFloat bigFloat = new BigFloat(0);

            Assert.Equal(
                expected: BigFloat.NeutralSign,
                actual: bigFloat.Sign);
        }
    }
}
