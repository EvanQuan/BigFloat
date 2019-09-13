using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenNegating : NegateTest
    {
        protected override BigFloat Negate(BigFloat value)
        {
            return BigFloat.Negate(value);
        }
    }
}
