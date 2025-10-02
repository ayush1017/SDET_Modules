using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Organized
{
    internal class Moviepage
    {
        public IWebDriver Driver;
        public Moviepage(IWebDriver driver)
        {
            Driver = driver;
        }
       
        internal void MovieFunctionality()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement button = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//*[@id='mvl-flyout-button-3']")));
            button.Click();
            IList<IWebElement> MovieTitle = Driver.FindElements(By.XPath("//p[@class='LOBCard__Info_Headline']"));
            IList<IWebElement> MovieYear = Driver.FindElements(By.XPath("//p[@class='LOBCard__Info_Subheadline']"));
            IList<IWebElement> MovieImg = Driver.FindElements(By.XPath("//*[@class='ImageSkeleton movie']//img"));


            Assert.AreEqual(MovieTitle.Count, MovieImg.Count, "Count Not Matching");
            //Assert.AreEqual(MovieTitle.Count, MovieYear.Count, "Count Not Matching");
           

            for(int i=0; i < MovieTitle.Count; i++)
            {
                string title= MovieTitle[i].Text;
                //string year= MovieYear[i].Text;
                string img= MovieImg[i].GetAttribute("src");
                Console.WriteLine($"Title: {title} , Image_Src: {img}");
                Assert.IsFalse(string.IsNullOrEmpty(title), $"Title is null or empty at index {i}");
               // Assert.IsFalse(string.IsNullOrEmpty(year), $"Year is null or empty at index {i}");
                Assert.IsFalse(string.IsNullOrEmpty(img), $"Image URL is null or empty at index {i}");
            }
           

        }

        internal void PageInition()
        {
            IJavaScriptExecutor exe = (IJavaScriptExecutor)Driver;
            exe.ExecuteScript("window.scrollTo(0,700);");

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));

            for (int i = 1; i <= 315; i++) // If you really want to loop through all 315
            {
                try
                {
                    // Find the NEXT button every iteration (fresh element)
                    IWebElement nextBtn = wait.Until(ExpectedConditions.ElementToBeClickable(
                        By.XPath("//button[contains(@class,'Pagination__Item_Nav__Button')]//span[text()='Next']")
                    ));

                    exe.ExecuteScript("arguments[0].scrollIntoView(true);", nextBtn);
                    exe.ExecuteScript("arguments[0].click();", nextBtn);

                    Console.WriteLine($"✅ Navigated to page {i + 1}");
                }
                catch (WebDriverTimeoutException)
                {
                    Console.WriteLine("⚠️ No more pages found, stopping loop.");
                    break; // exit if Next button no longer exists
                }
            }
        }

    }
}