using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenDecrementing : DecrementTest
    {
        protected override BigFloat PostDecrement(ref BigFloat value)
        {
            BigFloat preValue = value;
            value = BigFloat.Decrement(value);
            return preValue;
        }

        protected override BigFloat PreDecrement(ref BigFloat value)
        {
            value = BigFloat.Decrement(value);
            return value;
        }
    }
}
