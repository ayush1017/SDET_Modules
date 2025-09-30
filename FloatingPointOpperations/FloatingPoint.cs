using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FloatingPointOpperations
{
   

    [TestClass]
    [TestCategory("FloatingPoint_Operations")]
    public class FloatingPoint
    {
        

        //static double num1;
        //static double num2;
        //[ClassInitialize]
        //public static void In(TestContext textContext)
        //{
        //    num1 = 10.0;
        //    num2 = 20.5;

        //}
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    var sum = num1 + num2;
        //    Assert.AreEqual(sum, 30.5);

        //}
        //[TestMethod]
        //public void TestMethod2()
        //{
        //    var sum = num1 - num2;
        //    Assert.AreEqual(sum, -10.5);

        //}
        //[TestMethod]
        //public void TestMethod3()
        //{
        //    var sum = num1 * num2;
        //    Assert.AreEqual(sum, 205,$"The Actual Result will be ${sum}");

        //}
        //[TestMethod]
        //public void TestMethod4()
        //{
        //    var sum = num1 / num2;
        //    Assert.AreEqual(sum,0.4878,$"The Actual Value would be {sum}");

        //}

        static decimal num1;
        static decimal num2;

        [ClassInitialize]
        public static void In(TestContext textContext)
        {
            num1 = 10.0M;
            num2 = 20.5M;

        }
        [TestMethod]
        public void TestMethod1()
        {
            var sum = num1 + num2;
            Assert.AreEqual(sum, 30.5M);

        }
        [TestMethod]
        public void TestMethod2()
        {
            var sum = num1 - num2;
            Assert.AreEqual(sum, -10.5M);

        }
        [TestMethod]
        public void TestMethod3()
        {
            var sum = num1 * num2;
            Assert.AreEqual(sum, 205M, $"The Actual Result will be ${sum}");

        }
        [TestMethod]
        public void TestMethod4()
        {
            var sum = num1 / num2;
            Assert.AreEqual(sum, 0.4878M, $"The Actual Value would be {sum}");

        }


    }
}
