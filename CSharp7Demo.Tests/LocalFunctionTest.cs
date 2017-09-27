using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7Demo.Tests
{
    [TestClass]
    public class LocalFunctionTest
    {
        [TestMethod]
        public void TestFibSequence()
        {
            var localFunction = new LocalFunctionExample();

            var result = localFunction.FigSequenceBuilder(7, 1, 2);

            Assert.AreEqual("1, 2, 3, 5, 8, 13, 21", result);
        }
    }
}
