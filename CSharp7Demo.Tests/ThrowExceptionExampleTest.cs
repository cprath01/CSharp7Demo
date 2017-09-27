using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7Demo.Tests
{
    [TestClass]
    public class ThrowExceptionExampleTest
    {
        [TestMethod]
        public void CatchException()
        {
            Assert.ThrowsException<Exception>(() => new ThrowExceptionExample(null));
        }

        [TestMethod]
        public void PassBetterLiteral()
        {
            var classBeingTested = new ThrowExceptionExample(0b0000_0001);

            Assert.AreEqual(1, classBeingTested.Id);
        }
    }
}
