using NUnit.Framework;

namespace NunutTest
{
    public class Sum
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 2, 3)]
        [TestCase(-2, -4, 4)]
        [TestCase(-2, -3, -5)]
        [Category("Calculator")]
        public void SumTest(int operand1, int operand2, int sumResult)
        {
            var sumActualResult = Calculator.Sum(operand1, operand2);

            Assert.AreEqual(sumActualResult, sumResult, $"Sum: {operand1} + {operand2} = {sumActualResult} ");
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}