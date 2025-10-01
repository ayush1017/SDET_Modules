using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V137.Browser;
using OpenQA.Selenium.Firefox;
using System;

namespace Organized
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        Edge
    }
    internal class WebdriverFactory
    {
        public IWebDriver Create(BrowserType browser)
        {
            IWebDriver driver;
            switch (browser) {
                case BrowserType.Chrome:
                    driver= new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    driver=new FirefoxDriver();
                    break;
                default:
                    throw new NotSupportedException($"Browser {browser} is not supported");

            }
            return driver;        
        }
       
    }
}