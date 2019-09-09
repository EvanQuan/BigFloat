using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenDividing : DivideTest
    {
        public override BigFloat Divide(
            BigFloat dividend,
            BigFloat divisor)
        {
            return dividend.Divide(divisor);
        }
    }
}
