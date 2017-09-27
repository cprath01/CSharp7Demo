using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7Demo.Tests
{
    [TestClass]
    public class RefLocalRefOutTest
    {
        [TestMethod]
        public void GetStructTest_CantChangeValue()
        {
            var classBeingTested = new RefLocalRefOut();

            var result = classBeingTested.GetStruct();
            result.value = 456;

            var result2 = classBeingTested.GetStruct();

            Assert.AreNotEqual(result.value, result2.value);
        }

        [TestMethod]
        public void GetStructTest_CanChangeValue()
        {
            var classBeingTested = new RefLocalRefOut();

            ref var result = ref classBeingTested.GetStruct();
            result.value = 456;

            var result2 = classBeingTested.GetStruct();

            Assert.AreEqual(result.value, result2.value);
        }
    }
}
