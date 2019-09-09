using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenDividing : DivideTest
    {
        public override BigFloat Divide(
            BigFloat dividend,
            BigFloat divisor)
        {
            return BigFloat.Divide(dividend, divisor);
        }
    }
}
