using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result= UnitestClasslibrary.Class1.Add(10, 5);
            Assert.AreEqual(result, 15);

        }
    }
}
