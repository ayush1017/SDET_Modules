using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//Test Organization how to write the Test Organization
namespace PBI
{
    [TestClass]
    [TestCategory("HomePage")]
    public class UnitTest1
    {
        [Description("This is a sample test method")]
        [TestProperty("Author", "Ayush")]//it helps to add the property to the test method 
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
