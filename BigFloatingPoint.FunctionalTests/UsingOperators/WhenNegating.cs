﻿using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenNegating : NegateTest
    {
        protected override BigFloat Negate(BigFloat value)
        {
            return -value;
        }
    }
}
