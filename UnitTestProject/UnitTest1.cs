using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]//these are called attributes in C# method or assembly to behave some kind of a way.
    [TestCategory("Login_Feature")] //provides us the ability to Categrize our tests on the basis of features. 
    //[TestInitialize] will make a method to be called again and again be`fore each test method is executed.
    public class UnitTest1
    {
        [TestMethod]// tells the compiler that this method is a test method which needs to be tested.
        [TestCategory("Positive_Testcase")]
        [Description("Provides the Desctoption of a test_Method")]// it can only be applicable for a test method//Provides the decription of the testMethod.
        public void TestMethod1()
        {
            var a = 1;
            var b = 2;
            Assert.AreEqual(3, a + b);
        }

        [TestMethod]// tells the compiler that this method is a test method which needs to be tested.
        public void TestMethod2()
        {
            var a = 1;
            Assert.IsTrue(a == 1);
        }
        [TestMethod]
        [TestCategory("Negative_Testcase")]
        [ExpectedException(typeof(AssertFailedException))]
        public void Negative()
        {
            var a = 1;
            Assert.AreNotEqual(1, 1);
        }
        private int a;

        [TestInitialize] // this method will be called before each test method is executed.
        public void RunBefor()
        {
            a = 1;



        }


        [TestCleanup] // this method will be called after each test method is executed.

        public void RunAfter()
        {
            Trace.WriteLine("This method will be called after each test method is executed.");//Output to the Console.
        }
        [ClassInitialize]  //is method will be called once before any test method is executed in the class.
        public static void ClassInitialize(TestContext context)
        {
            //TestContext is a property that provides information about the test run, such as the name of the test class, the name of the test method, and other details.
            Trace.WriteLine("This method will be called once before any test method is executed in the class.");

        }
        [ClassCleanup] // this method will be called once after all test methods are executed in the class.
        public static void ClassCleanup()
        {
            Trace.WriteLine("This method will be called once after all test methods are executed in the class.");
        }
    }
}