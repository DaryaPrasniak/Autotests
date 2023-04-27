using NUnit.Framework;

namespace NunutTest
{
    public class Multpl
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 2, 2)]
        [TestCase(2, 3, 6)]
        [TestCase(20, 5, 100)]
        public void MultpTest(int operand1, int operand2, int multplResult)
        {
            var multplActualResult = Calculator.Multpl(operand1, operand2);

            Assert.AreEqual(multplActualResult, multplResult, $"Multpl: {operand1} * {operand2} = {multplActualResult} ");
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}