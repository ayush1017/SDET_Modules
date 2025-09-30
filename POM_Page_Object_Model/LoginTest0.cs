using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace POM_Page_Object_Model
{
    internal class LoginTest0
    {
        private IWebDriver driver;
        public LoginTest0(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement Username=>driver.FindElement(By.XPath("//*[@id=\"username\"]"));
        private IWebElement Password => driver.FindElement(By.XPath("//*[@id='password']"));
        private IWebElement Submit => driver.FindElement(By.Id("submit"));

        public void Login_Username(string username)
        {
            Username.SendKeys(username);
        }
        public void Login_Password(string password)
        {
            Password.SendKeys(password);
        }
        public void Login_Submit()
        {
            Submit.Click();
        }
    }
}
