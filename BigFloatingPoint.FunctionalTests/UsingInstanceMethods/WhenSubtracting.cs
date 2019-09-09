﻿using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenSubtracting : SubtractTest
    {
        protected override BigFloat Subtract(
            BigFloat minuend,
            BigFloat subtrahend)
        {
            return minuend.Subtract(subtrahend);
        }
    }
}
