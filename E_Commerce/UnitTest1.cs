using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace E_Commerce
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        
        [TestMethod]
        public void Login_Page()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            driver.Manage().Window.Maximize();
            IWebElement login = driver.FindElement(By.XPath("//*[@class=\"H6-NpN _3N4_BX\"]"));
            login.Click();

            var phone = driver.FindElement(By.XPath("//*[@class=\"r4vIwl BV+Dqf\"]"));

            phone.SendKeys("8080255609");
            driver.FindElement(By.XPath("//*[@class=\"QqFHMw twnTnD _7Pd1Fp\"]")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(6000));
         var electronics=   wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class=\"YBLJE4\"]")));
            //IWebElement electronics = driver.FindElement(By.XPath("//*[@class=\"YBLJE4\"]"));
            electronics.Click();
            IWebElement Phone_Image2 = driver.FindElement(By.XPath("//*[@class=\"xTaogf _3iTqAS\"]"));
            Phone_Image2.Click();
            IWebElement Phone_Image3 = driver.FindElement(By.XPath("//*[@class=\"col col-7 - 12\"]"));
            Phone_Image3.Click();
            IWebElement Add_toCart = driver.FindElement(By.XPath("//*[@class=\"QqFHMw vslbG+In9uk2 JTo6b7\"]"));
            Add_toCart.Click();
           

        }


        //
        

    }
}
