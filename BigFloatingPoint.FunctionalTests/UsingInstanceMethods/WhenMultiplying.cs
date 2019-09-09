using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenMultiplying : MultiplyTestBase
    {
        protected override BigFloat Multiply(BigFloat multiplicand, BigFloat multiplier)
        {
            return multiplicand.Multiply(multiplier);
        }
    }
}
