using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
/*
 * Method Call Stack 
 * Static Method is a method that belongs to the class itself rather than to instances of the class.
 * that means you cant creat the object of the class to call the method.
 * Static Method is used when that does not require any  instance specific data
 * Real Life Example: MathHelper.Square(6) is a static method call, it does not require any instance of MathHelper class to be created.
 */
namespace Methods
{
    [TestClass]
    [TestCategory("Methods_Sections")]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Static_Square()
        {
            int result = MathHelper.Square(6);
            Assert.AreEqual(36, result);
            Console.WriteLine("Static Method Test Passed: Square of 6 is " + result);


        }
        [TestMethod]
        public void Test_Mehtod()
        {
            MathHelper mat=new MathHelper();
            string result = mat.PayType("Manager");
            Assert.AreEqual("Salary", result);
        }

        [TestMethod]
        public void Test_MethodOverLoading() {

            //MathHelper mathhelper = new MathHelper();
            //string result= 
        }
    }
}
