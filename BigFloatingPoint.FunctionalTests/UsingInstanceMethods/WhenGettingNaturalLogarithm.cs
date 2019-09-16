using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenGettingNaturalLogarithm : NaturalLogTest
    {
        protected override double NaturalLog(BigFloat value)
        {
            return value.Log();
        }
    }
}
