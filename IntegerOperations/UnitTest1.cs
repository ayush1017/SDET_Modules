using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IntegerOperations
{
    [TestClass]
    public class UnitTest1
    {
        static int number1;
        static int number2;
      


        [ClassInitialize]
        [TestCategory("Integer_Operations")]
        public static void start(TestContext context)
        {
            // This method will be called once before any test method is executed in the class.
            number1 = 5;
            number2 = 10;
        }

        [TestMethod]
        public void TestMethod1()
        {
            int sum= number1 + number2;
            Console.WriteLine($"Sum of {number1} and {number2} is: {sum}");
            Assert.AreEqual(15, sum);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int difference = number2 - number1;
            Console.WriteLine($"Difference of {number2} and {number1} is: {difference}");
        }
        [TestMethod]
        public void TestMethod3()
        {
            int product = number1 * number2;
            Console.WriteLine($"Product of {number1} and {number2} is: {product}");
        }
    }
}
