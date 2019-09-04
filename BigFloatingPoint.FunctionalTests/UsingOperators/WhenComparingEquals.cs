﻿using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenComparingEquals : EqualsTestBase
    {
        protected override bool Potato(
            BigFloat left,
            BigFloat right)
        {
            return left == right;
        }
    }
}
