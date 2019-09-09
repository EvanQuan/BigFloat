using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenComparingTo : CompareToTest
    {
        protected override int CompareTo(BigFloat left, BigFloat right)
        {
            return left.CompareTo(right);
        }
    }
}
