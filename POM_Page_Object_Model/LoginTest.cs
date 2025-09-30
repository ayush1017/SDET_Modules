using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace POM_Page_Object_Model
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver driver;
        [Test]
        public void Login_Test()
        {
            var log = new LoginTest0(driver);
            log.Login_Username("student");
            log.Login_Password("Password123");
            log.Login_Submit();
            Thread.Sleep(10000);




        }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        //Keyword driven technique should be used when there are multiple test cases 
        //In Page object Model Our Object Page Interacts with the Web Elements
        /*Advantages of Page object Model
         * Code Reusability
         * Code Maintainability
         * Code Readability
         * Reduces code duplication
         * Enhances test case reliability
         * Separation of test code and page specific code
         * Improves collaboration between testers and developers
         * Facilitates easier updates when UI changes occur
         * Supports better organization of test scripts
         */ 

    }
}