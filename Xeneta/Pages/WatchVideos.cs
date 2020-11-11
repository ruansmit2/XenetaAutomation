using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Xeneta.Pages
{
    public class WatchVideos
    {
        public WatchVideos(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        private IWebDriver driver{ get; }

        public IWebElement WatchNow => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_module_1599651356652287']/div/div/div/div/div/span/div[2]/div/div/p/span/a"));
        public IWebElement CircleWatchVideo => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_module_1599651356652287']/div/div/div/div/div/span/div[2]/div/a/div"));
        public IWebElement FormPopup2 => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_module_1599651356652287']/div/div/div/div/div/span/div[2]/div/div/p/span/a"));
        public IWebElement FirstName =>  driver.FindElement(By.Id("firstname-8c92c318-ab09-46db-a240-a2827276050d"));
        public IWebElement LastName =>  driver.FindElement(By.Id("lastname-8c92c318-ab09-46db-a240-a2827276050d"));
        public IWebElement Company =>  driver.FindElement(By.Id("company-8c92c318-ab09-46db-a240-a2827276050d"));
        public IWebElement Email =>  driver.FindElement(By.Id("email-8c92c318-ab09-46db-a240-a2827276050d"));
        public IWebElement ErrorClass => driver.FindElement(By.XPath("//*[@class='no-list hs-error-msgs inputs-list']"));

        public void FillOutForm()
        {
            FirstName.SendKeys("Ruan");
            LastName.SendKeys("Smit");
            Email.SendKeys("ruansmit2@gmail.com");
            Company.SendKeys("Private");
        }

        public bool Incomplete()
        {
            FirstName.Click();
            LastName.Click();
            Email.Click();
            Company.Click();
            
            var isErrorMessageDisplayed =  ErrorClass.Displayed.Equals(true);
            return isErrorMessageDisplayed;
        }

        public void clearValues()
        {
            FirstName.Clear();
            LastName.Clear();
            Email.Clear();
            Company.Clear();
        }

        public void clickWatchNow()
        {
            WatchNow.Click();
        }

        public bool doesIconExist()
        {
            string icon = CircleWatchVideo.GetCssValue("background-image");
            var isIconDisplayed = icon.Contains("Accessible.png");
            return isIconDisplayed;
        }

        public bool PopUpDisplay()
        {
            string Popup1 = FormPopup2.GetCssValue("display");
            var isPopUpDisplayed =  Popup1.Equals("inline-block");
            return isPopUpDisplayed;
        }
    }
}