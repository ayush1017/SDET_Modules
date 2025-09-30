using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//Composition
//Protected access modifier 
/*Main feature of Protected class is That d*/
namespace Inheritence
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Person myPerson = new Person("1", "Baler", "Sarah", 24);
            Student myStudent = new Student("1111", "BOb", "Baker", "HJJJ", "Computer Science", 56, DateTime.Now);
            myStudent.ExerCise();
            
        }
        [TestCategory("Protected_KeyWord")]
        [TestMethod]
        public void Protected_Test()
        {
            DateTime dateTime = DateTime.Now;

            Student myStudent = new Student("1111", "BOb", "Baker", "HJJJ", "Computer Science", 56, dateTime);
            myStudent.GetDob();


        }
    }
}
