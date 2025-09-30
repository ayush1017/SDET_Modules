using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;
//For By Class the package is
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
namespace UnitTestProject2
{
    [TestCategory("Marvel_Testing")]
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.marvel.com/");
            driver.Manage().Window.Maximize();
            var element = driver.FindElement(By.XPath("//*[@id=\"page-wrapper\"]/header/nav/div/section/div/div[2]/ul/li[2]"));
            element.Click();
            //Thread.Sleep(TimeSpan.FromSeconds(6));
            var element2 = driver.FindElement(By.XPath("//*[@id=\"themeProvider\"]/div[1]/div/div/div/div[1]/div[1]/div/div/div[3]/div/div/div/a[2]/h1"));
            var title = element2.Text;
            Console.WriteLine("Page Title: " + title);
            driver.Quit();
            //Thread.Sleep(10000);

        }
        //Id is the best match for the identifying an element
        //Xpath is the second best match for identifying an element
        /*/ Selects the root Node
         //Selects the Node from the Correct Node it is the best choice 
        . selects the Current Node
        .. Select Parent of the Current Node
        * Matches any Element
        @ Helps you to find the Arrtribute
        Contains() is used to find the element with the text
        it takes two arguments the frist one is the attributr anf the second is th text you want to match
        
        Xpath Parent and Compound componebts 
        Cpmpound Components are used to find the element in the DOM
         */
        [TestMethod]
        public void Test_login_func_for_DMania()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://tv.apple.com/");
            driver.Manage().Window.Maximize();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

            // Wait for "Sign In" button and click
            IWebElement signInButton = wait.Until(
                ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(text(), 'Sign In')]"))
            );
            signInButton.Click();

            //// Wait for the label element in the modal
            //IWebElement loginLabel = wait.Until(
            //    ExpectedConditions.ElementIsVisible(
            //        By.XPath("//*[@class=\"form-textbox-label\"]")
            //    )
            //);

            // Interact with the field (assuming label is for input)

            //IWebElement inputField = wait.Until(
            //    ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div/div[1]/cwc-app/div/div/div[2]/div[1]/form/div/input]"))
            //);
            //inputField.SendKeys("555555");

            // Wait for and click Continue button
            IWebElement continueButton = wait.Until(
                ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(text(), 'Continue')]"))
            );
            continueButton.Click();

            driver.Quit();

            /*Navigate has several methods includes, GoToUrl, forward(), Back(),Refresh()
             Need to learn about CurrentWindowHandle, WindowHandle,PageSource, Title, Url*/





        }

        /*GetCssValue() and GetAttribute()*/




    }
}
