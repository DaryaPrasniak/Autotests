using NUnit.Framework;

namespace NunutTest
{
    public class Diff
    {
        [SetUp]
        public void Setup()
        {
        }

        [Category("Calculator")]
        [TestCase(3, 2, 1)]
        [TestCase(6, 8, -2)]
        [TestCase(-2, -3, 1)]

        public void DiffTest(int operand1, int operand2, int diffResult)
        {
            var diffActualResult = Calculator.Diff(operand1, operand2);

            Assert.AreEqual(diffActualResult, diffResult, $"Diff: {operand1} - {operand2} = {diffActualResult} ");
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}