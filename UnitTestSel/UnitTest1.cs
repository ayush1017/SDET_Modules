using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V136.Overlay;
using OpenQA.Selenium.Internal;
using System;
using System.Threading;
using OpenQA.Selenium.DevTools.V136.Browser;
/*
 * Unit Tests
 * Service/API Layer Tests
 * User Interface Test
 * Inverted Automated test Pyramid just reverse of that
 * Benefits of Selenium
 * Huge Support of different languages 
 * Huge Support from Cloud Testing 
 * Huge Community
 * Easy to Use
 * The Perfect FrameWork
 * Resusable 
 * Scalable
 * Easy to maintain
 * Flexible
 * Not Keyword Driven
 * 
 * 
 * 
 * IWebdriver is an Interface it helps to return an interface but not the complete implementation
 * 
 * By Class allow us to identify an element using By Properties.
 * 
 * 
 */
namespace UnitTestSel
{

    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.ultimateqa.com");
            Thread.Sleep(10000);
            driver.Quit();
        }
        //public IWebDriver Driver { get; private set; }//This executes once before every test method
        IWebDriver driver = new ChromeDriver();
        //FindElement returns you the IWebElemnt and FindElements return Only the ReadOnlyCollections of IWebElement
        //If No element then it returns NoSuchElementException. 
        [TestCategory("Locating web Elementdds")]
        [TestMethod]
        public void TestMethod2()
        {

            driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
            HighlightElementUsingJavaScript(By.ClassName("buttonClass"));
            HighlightElementUsingJavaScript(By.Id("button1"));
            //HighlightElementUsingJavaScript(By.LinkText("Click me using this link text"));
            HighlightElementUsingJavaScript(By.TagName("div"));
        }

        private void HighlightElementUsingJavaScript(By LocationStrategy, int duration = 2)
        {
            var element = driver.FindElement(LocationStrategy);
            var originalStyle = element.GetAttribute("style");
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].setAttribute(arguments[1],arguments[2]);", element, "style", "border: 2px solid red; background-color: yellow;");

            if (duration <= 0) return;
            Thread.Sleep(TimeSpan.FromSeconds(duration));
            js.ExecuteScript("arguments[0].setAttribute(arguments[1],arguments[2]);", element, "style", originalStyle);
        }
        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }
        [TestCategory("Finding_location")]
        [TestMethod]
        public void Finding_Method()
        {
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
            Find_Element(By.XPath("//*[@id=\"post-909\"]/div/div/div/div[2]/div/div[1]/div[3]/div/div/div/a"));
        }

        public void Find_Element(By location)
        {
            var element = driver.FindElement(location);
            element.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Finished going to Sleep");
            return;

        }

        [TestCleanup]
        public void CleanupTest()
        {
            driver.Quit();
        }

       
    }
}
