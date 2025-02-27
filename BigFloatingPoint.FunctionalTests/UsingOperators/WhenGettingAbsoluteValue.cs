﻿using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{

    public class WhenGettingAbsoluteValue : AbsoluteValueTest
    {
        public override BigFloat AbsoluteValue(BigFloat value)
        {
            return +value;
        }
    }
}
