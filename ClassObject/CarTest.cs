using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
/*
 * Class ->Blueprint Everything you need to create.
 * Constructor -> Factory whatever obkect is in the blureprint/ Builds an Object from a Blueprint.
 * Object-> The instanctiation or menefestation od our BluePrint /Result of the Blueprint being created by the Constructor.
 *    ---> Properties -> Characteristics of the Object/Describe the Object.
 *    --> Methods -> Actions that the Object can perform/Behaviours of the Object.
 *   
 *   
 *   Class Car{
 *    //Private variables that help us define the properties of the Car.
 *    //Constructor -> Factory for creating objects of the class Car.
 *    // Get and Set Accessors-> Properties of the Car.     
}
 
 */
namespace ClassObject
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        [TestCategory("Car Tests")]
        public void TestMethod1()
        {
            Car  MyCar= new Car("Red", 4, false);
            Assert.AreEqual(MyCar.Color, "Red");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Employer MyCar = new Employer("Ayush", "Singh", "10/02/2003", "Department of Energy", "Scientist", 200000);
            Assert.AreEqual(MyCar.FName, "Ayush");
            Console.WriteLine("Test Case Passed");
        }

    }
}
