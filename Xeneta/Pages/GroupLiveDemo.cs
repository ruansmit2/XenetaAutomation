using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Xeneta.Pages
{
    public class GroupLiveDemo
    {
        public GroupLiveDemo(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        private IWebDriver driver { get; }

        public IWebElement SignUpHere => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_module_1599651356652287']/div/div/div/div/div/span/div[3]/div/div/p/span[2]/a"));
        public IWebElement FirstName => driver.FindElement(By.Id("firstname-ca1bf2c1-adc4-4658-88c5-d88e45c8129b"));
        public IWebElement LastName => driver.FindElement(By.Id("lastname-ca1bf2c1-adc4-4658-88c5-d88e45c8129b"));
        public IWebElement Company => driver.FindElement(By.Id("company-ca1bf2c1-adc4-4658-88c5-d88e45c8129b"));
        public IWebElement Email => driver.FindElement(By.Id("email-ca1bf2c1-adc4-4658-88c5-d88e45c8129b"));
        public IWebElement JobTitle => driver.FindElement(By.Id("jobtitle-ca1bf2c1-adc4-4658-88c5-d88e45c8129b"));
        public IWebElement MyComapny => driver.FindElement(By.Id("type_of_prospect-ca1bf2c1-adc4-4658-88c5-d88e45c8129b"));
        public IWebElement TEU => driver.FindElement(By.XPath("//*[@id='hsForm_ca1bf2c1-adc4-4658-88c5-d88e45c8129b']/div[6]/div[2]"));
        public IWebElement AnnualFreightTon => driver.FindElement(By.XPath("//*[@id='hsForm_ca1bf2c1-adc4-4658-88c5-d88e45c8129b']/div[6]/div[3]"));
        public IWebElement closeModal => driver.FindElement(By.ClassName("close-modal"));

        public void FillOutForm()
        {
            FirstName.SendKeys("Ruan");
            LastName.SendKeys("Smit");
            Email.SendKeys("ruansmit2@gmail.com");
            Company.SendKeys("Private");
            JobTitle.SendKeys("Private");
        }

        public void myCompanyBCO()
        {
            var countrySelect = new SelectElement(MyComapny);
            countrySelect.SelectByText("Shipper/BCO");
        }

        public void signUpHere()
        {
            SignUpHere.Click();
        }

        public void myCompanyForwarder()
        {
            var countrySelect = new SelectElement(MyComapny);
            countrySelect.SelectByText("Freight Forwarder");
        }

        public bool Global_TEUs()
        {
            var isTEUDisplayed = TEU.Displayed.Equals(true);
            return isTEUDisplayed;
        }

        public bool FreightTonTrue()
        {
            var isAnnualFreightTonDisplayed = AnnualFreightTon.Displayed.Equals(true);
            return isAnnualFreightTonDisplayed;
        }

        public void closeModalDialog()
        {
            closeModal.Click();
        }
    }
}
