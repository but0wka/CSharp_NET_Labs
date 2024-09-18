using NUnit.Framework;

namespace LB1
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        [TestCase(-2, ExpectedResult = 1)]
        [TestCase(-1, ExpectedResult = 0)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(2, ExpectedResult = -1)]
        public double F_ReturnsExpectedResult(double x)
        {
            return Program.F(x);
        }
    }
}