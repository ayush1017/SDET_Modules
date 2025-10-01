using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V137.HeapProfiler;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.CodeDom;
using System.Threading;

namespace Organized
{
    internal class Homepage
    {
        public IWebDriver driver;
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }
        internal void GoTO()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.marvel.com/movies");
        }
        
        public void Nav()
        {
            for (int i = 0; i < 8; i++)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement button = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//*[@id='mvl-flyout-button-{i}']")));
                button.Click();
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//*[@id='mvl-flyout-button-{i}']")));

            }
           
     
           

        }

        internal void SearchFunctionality()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
                driver.FindElement(By.Id("search")).Click();
                IWebElement Search_text= wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//*[@class='typeahead__input']")));
                Search_text.SendKeys("Wanda");
                Actions act = new Actions(driver);
                act.MoveToElement(Search_text).SendKeys(Keys.Enter).Perform();
                var img=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//*[@class='img__wrapper'")));
                img.Click();
                
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}