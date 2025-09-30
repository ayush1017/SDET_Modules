using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Implicit_Explicit_Waits
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        [TestCategory("Waits")]
        
        public void TestMethod1()
        {
            /*IMPLICIT WAITS-:
              if an element is not present in the DOM it still check for that element for a certain amount of time.
              driver.Manage().Timeouts().IMplicitWait=TimeSpan.FromSeconds(5)
              Default Timeout 0 seconds
              Disadvantages:
              useless if the element is hidden on the page 
              Applies to all the future commands
              When to use this waits Never*/

            /*EXPLICIT WAIT
              :This is the code that you wirte to wait for a certain condition to occur before proceeding 
               Default timeout is 0.5 seconds
               Disadvantages:
               should be used for all slow loading elements
               thread.sleep(2000); //This is not a good practice, it will wait for 2 seconds even if the element is loaded before that time.

             */

            driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            get_info();
            Thread.Sleep(4000);
            driver.FindElement(By.Id("submit")).Click();
            Console.WriteLine(driver.Title);
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[contains(text(),\"Log out\")]")).Click();
            Console.WriteLine("Logged out successfully");






        }
        public void get_info()
        {
            driver.FindElement(By.Id("username")).SendKeys("student");
            Thread.Sleep(4000); // This is not a good practice, use explicit waits instead
            driver.FindElement(By.Id("password")).SendKeys("Password123");
            
        }
    }
}
