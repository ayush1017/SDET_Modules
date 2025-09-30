using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test2
{
    [TestClass]
    [TestCategory("Quiz")]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(3, a + b);

        }
        [TestMethod]
        public void TestMethod2()
        {
            var a = 1;
            Assert.Fail("This is the TestMethod which has been created for the Failing Purposes");

        }
        [TestMethod]
        public void TestMethod3()
        {
            var a = 10;
            var b = 20;
            Assert.AreEqual(21, a+b);
        }
    }
}
