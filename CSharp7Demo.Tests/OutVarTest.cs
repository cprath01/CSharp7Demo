using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7Demo.Tests
{
    [TestClass]
    public class OutVarTest
    {
        [TestMethod]
        public void ConvertToInt_Test()
        {
            var classBeingTested = new OutVar();

            var result = classBeingTested.ConvertToInt("1");

            Assert.AreEqual(1, result);
        }
    }
}
