using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prettifier.Tests
{
    [TestClass()]
    public class NumberManupulationTests
    {
        [TestMethod()]
        public void TestLessThanMilionNumers()
        {
            string expected_result = "532";
            var result = NumberManupulation.NumberPrettifier(532);
            Assert.AreEqual(expected_result, result);
        }

        [TestMethod()]
        public void TestMoreThanMilionNumers()
        {
            string expected_result = "1M";
            var result = NumberManupulation.NumberPrettifier(10000000);
            Assert.AreEqual(expected_result, result);
        }

        [TestMethod()]
        public void TestMoreThanTrillionNumers()
        {
            string expected_result = "1.1B";
            var result = NumberManupulation.NumberPrettifier(1123456789);
            Assert.AreEqual(expected_result, result);
        }

        [TestMethod()]
        public void TestNumbersWithFloatingPart()
        {
            string expected_result = "2.5M";
            var result = NumberManupulation.NumberPrettifier(2500000.34);
            Assert.AreEqual(expected_result, result);
        }
    }
}