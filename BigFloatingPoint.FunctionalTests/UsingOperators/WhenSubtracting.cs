﻿using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenSubtracting : SubtractingTestBase
    {
        protected override BigFloat Subtract(
            BigFloat minuend,
            BigFloat subtrahend)
        {
            return minuend - subtrahend;
        }
    }
}
