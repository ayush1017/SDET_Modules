
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Drawing;
using System.Threading;

namespace Interractions
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();
        private Actions _actions;
        private WebDriverWait _wait;

        [Test]

        public void TestMethod1()
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));
            IWebElement sourceElement = driver.FindElement(By.Id("draggable"));
            IWebElement targetElement = driver.FindElement(By.Id("droppable"));
            //Performing Drag and Drop 
            _actions.DragAndDrop(sourceElement, targetElement).Perform();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Dropped!", targetElement.Text);


        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
        [Test]
        public void DragandDrop2()
        {
            driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));
            IWebElement sourceElement = driver.FindElement(By.Id("draggable"));
            IWebElement targetElement = driver.FindElement(By.Id("droppable"));

          var drag=  _actions.ClickAndHold(sourceElement).MoveToElement(targetElement).Build();
            drag.Perform();

        }

        [Test]
        public void Resizable()
        {
            driver.Navigate().GoToUrl("https://jqueryui.com/resizable/");
            IWebElement resizable = driver.FindElement(By.XPath("//*[@class='ui-resizable-handle ui-resizable-se ui-icon ui-icon-gripsmall-diagonal-se']"));
            _actions.ClickAndHold(resizable).MoveByOffset(100, 100).Perform();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"resizable\" and @style]")).Displayed);


        }
        [Test]
        public void DevTools()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            _actions.KeyDown(Keys.Control).KeyDown(Keys.Shift).SendKeys("N").Perform();
        }
        [Test]
        public void DragandDrop3()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            driver.Manage().Window.Maximize();
            IWebElement sourceElement = driver.FindElement(By.Id("column-a"));
            IWebElement targetElement = driver.FindElement(By.Id("column-b"));
            var action=_actions.DragAndDrop(sourceElement, targetElement).Build();
            action.Perform();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("A",driver.FindElement(By.XPath("//*[@id='column-b']/header")).Text);

        }
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            _actions = new Actions(driver);
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }
        [TearDown]
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }

        

    }
}
