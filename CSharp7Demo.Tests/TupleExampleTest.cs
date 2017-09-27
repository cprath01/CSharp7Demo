using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp7Demo.Tests
{
    [TestClass]
    public class TupleExampleTest
    {
        [TestMethod]
        public void TestOutput()
        {
            var tuple = new TupleExample(1, 2);

            var result = tuple.GetNumbers();

            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(2, result.Item2);
        }

        [TestMethod]
        public void TestOutput2()
        {
            var tuple = new TupleExample(1, 2);

            (var resultX, var resultY) = tuple.GetNumbers();

            Assert.AreEqual(1, resultX);
            Assert.AreEqual(2, resultY);
        }

        [TestMethod]
        public void TestOutput2_5()
        {
            var tuple = new TupleExample(1, 2);

            (int resultX, int resultY) = tuple.GetNumbers();

            Assert.AreEqual(1, resultX);
            Assert.AreEqual(2, resultY);
        }

        [TestMethod]
        public void TestOutput3()
        {
            var tuple = new TupleExample(1, 2);

            var result = tuple.GetNumbers2();

            Assert.AreEqual(1, result.x);
            Assert.AreEqual(2, result.y);
        }
    }
}
