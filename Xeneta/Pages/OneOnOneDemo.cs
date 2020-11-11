using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Xeneta.Pages
{
    public class OneOnOneDemo
    {
        public OneOnOneDemo(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        private IWebDriver driver{ get; }

        public IWebElement Cookie => driver.FindElement(By.XPath("//*[@id='hs-eu-confirmation-button']"));
        public IWebElement ScheduleNow => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_module_1599651356652287']/div/div/div/div/div/span/div[1]/div/div/p/span[2]/a"));
        public IWebElement CircleOneOnOne => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_module_1599651356652287']/div/div/div/div/div/span/div[1]/div/a/div"));
        public IWebElement FormPopup1 => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_module_1599651356652287']/div/div/div/div/div/span/div[1]/div/div/p/span[2]/a"));
        public IWebElement FirstName =>  driver.FindElement(By.Id("firstname-0e41acd7-514b-4f39-9a5e-59831bb5592d"));
        public IWebElement LastName =>  driver.FindElement(By.Id("lastname-0e41acd7-514b-4f39-9a5e-59831bb5592d"));
        public IWebElement Company =>  driver.FindElement(By.Id("company-0e41acd7-514b-4f39-9a5e-59831bb5592d"));
        public IWebElement Email =>  driver.FindElement(By.Id("email-0e41acd7-514b-4f39-9a5e-59831bb5592d"));
        public IWebElement Phone =>  driver.FindElement(By.Id("phone-0e41acd7-514b-4f39-9a5e-59831bb5592d"));
        public IWebElement JobTitle =>  driver.FindElement(By.Id("jobtitle-0e41acd7-514b-4f39-9a5e-59831bb5592d"));
        public IWebElement MyComapny => driver.FindElement(By.Id("type_of_prospect-0e41acd7-514b-4f39-9a5e-59831bb5592d"));
        public IWebElement ErrorClass => driver.FindElement(By.XPath("//*[@class='hs-input invalid error']"));
        public IWebElement closeModal => driver.FindElement(By.ClassName("close-modal"));
        public IWebElement CoockieAgree => driver.FindElement(By.XPath("//*[@id='hs-eu-confirmation-button']"));
        public IWebElement PhoneErrorLength => driver.FindElement(By.XPath("//*[@id='hsForm_0e41acd7-514b-4f39-9a5e-59831bb5592d']/div[5]/ul/li[1]/label"));
        public IWebElement PhoneErrorFormat => driver.FindElement(By.XPath("//*[@id='hsForm_0e41acd7-514b-4f39-9a5e-59831bb5592d']/div[5]/ul/li[2]/label"));
        public IWebElement EmailError => driver.FindElement(By.XPath("//*[@id='hsForm_0e41acd7-514b-4f39-9a5e-59831bb5592d']/div[4]/ul/li/label"));
        
        public void FillOutForm()
        {
            FirstName.SendKeys("Ruan");
            LastName.SendKeys("Smit");
            Phone.SendKeys("0720127992");
            Email.SendKeys("ruansmit2@gmail.com");
            Company.SendKeys("Private");
            JobTitle.SendKeys("Private");

            var countrySelect = new SelectElement(MyComapny);
            countrySelect.SelectByText("Other");
        }

        public bool Incomplete()
        {
            FirstName.Click();
            LastName.Click();
            Phone.Click();
            Email.Click();
            Company.Click();
            JobTitle.Click();
            MyComapny.Click();
            
            var isErrorMessageDisplayed =  ErrorClass.Displayed.Equals(true);
            return isErrorMessageDisplayed;
        }

        public void clearValues()
        {
            Phone.Clear();
            Email.Clear();
        }

        public void clickSheduleNow()
        {
            ScheduleNow.Click();
        }

        public bool doesIconExist()
        {
            string icon = CircleOneOnOne.GetCssValue("background-image");
            var isIconDisplayed = icon.Contains("services.png");
            return isIconDisplayed;
        }

        public bool PopUpDisplay()
        {
            string Popup1 = FormPopup1.GetCssValue("display");
            var isPopUpDisplayed =  Popup1.Equals("inline-block");
            return isPopUpDisplayed;
        }

        public void closeModalDialog()
        {
            closeModal.Click();
        }

        public void cookieConfirm()
        {
            double waitTime = 15;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("hs-eu-cookie-confirmation-inner")));
            CoockieAgree.Click();
        }

        public void NegativeTest()
        {
            Email.SendKeys("a");
            Phone.SendKeys("a");
        }

        public bool EmailNegativeTestError()
        {
            var isErrorMessageDisplayed = EmailError.Displayed.Equals(true);
            return isErrorMessageDisplayed;

        }
        public bool PhoneFormatNegativeTestError()
        {
            var isErrorMessageDisplayed = PhoneErrorFormat.Displayed.Equals(true);
            return isErrorMessageDisplayed;
        }

        public bool PhoneLengthNegativeTestError()
        {
            var isErrorMessageDisplayed = PhoneErrorLength.Displayed.Equals(true);
            return isErrorMessageDisplayed;
        }

        public void NegativeTestPhone()
        {
            Phone.SendKeys("1");
        }
    }
}