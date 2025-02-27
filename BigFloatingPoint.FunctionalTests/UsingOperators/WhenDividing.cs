﻿using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenDividing : DivideTest
    {
        public override BigFloat Divide(
            BigFloat dividend,
            BigFloat divisor)
        {
            return dividend / divisor;
        }
    }
}
