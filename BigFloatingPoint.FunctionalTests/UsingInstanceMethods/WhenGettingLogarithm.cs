using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenGettingLogarithm : LogTest
    {
        protected override double Log(BigFloat value, double baseValue)
        {
            return value.Log(baseValue);
        }
    }
}
