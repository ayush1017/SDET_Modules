using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
//How to make test more efficient/
namespace Organized
{
    [TestClass]
    [TestCategory("unit")]
    public class UnitTest1
    {

        IWebDriver driver;
       
        
        [TestMethod]
        [Description("This is a Description of How Things work when Organizing the Project")]
        [TestProperty("Author","Ayush")]
        public void TC1()
        {
            WebdriverFactory factory= new WebdriverFactory();
            driver= factory.Create(BrowserType.Chrome);
            Homepage home = new Homepage(driver);
            home.GoTO();
            Thread.Sleep(5000);


        }
        [TestMethod]
        public void TC2()
        {
            WebdriverFactory factory = new WebdriverFactory();
            driver = factory.Create(BrowserType.Chrome);
            Homepage home = new Homepage(driver);
            home.GoTO();
            Thread.Sleep(5000);
            home.Nav();
                
        }
        [TestMethod]
        public void TC4() {
            WebdriverFactory factory = new WebdriverFactory();
            driver = factory.Create(BrowserType.Chrome);
            Homepage home = new Homepage(driver);
            home.GoTO();
            Thread.Sleep(5000);
            home.SearchFunctionality();
        }


        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }

    }
}
