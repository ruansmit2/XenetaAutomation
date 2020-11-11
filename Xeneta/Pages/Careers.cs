using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Xeneta.Pages
{
    public class Careers
    {
        public Careers(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        private IWebDriver driver { get; }

        public IWebElement XenetaIsOne => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_widget_27351556886']/div/div/div/ul/li[1]"));
        public IWebElement Modernizationthroughdata => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_widget_27351556886']/div/div/div/ul/li[2]"));
        public IWebElement VarietyandFairness => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_widget_27351556886']/div/div/div/ul/li[3]"));
        public IWebElement TransparencybuildsTrust => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_widget_27351556886']/div/div/div/ul/li[4]"));
        public IWebElement Title => driver.FindElement(By.TagName("title"));
        IList<IWebElement> Roles => driver.FindElements(By.ClassName("accordion_group"));
        public IWebElement RoleExpanded => driver.FindElement(By.ClassName("accordion_group expanded"));
        public IWebElement VisitOslo => driver.FindElement(By.XPath("//*[@id='slick-slide00']/div/div/div/a[2]"));
        public IWebElement VisitNewYork => driver.FindElement(By.XPath("//*[@id='slick-slide01']/div/div/div/a[2]"));
        public IWebElement VisitHamberg => driver.FindElement(By.XPath("//*[@id='slick-slide02']/div/div/div/a[2]"));
        public IWebElement ApplyHere => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_widget_27351556888']/div/div/div/div/div/div[2]/div/div[2]/div[1]/p[10]/a"));
        public IWebElement OpenApplication => driver.FindElement(By.XPath("//*[@id='hs_cos_wrapper_widget_27351556888']/div/div/div/div/div/div[2]/div"));

        public bool XenetaIsOneTabs()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("tabs")));
            bool result = false;
            string classNameContains = XenetaIsOne.GetAttribute("class");
            if (classNameContains.Contains("current"))
            {
                result = true;
            }

            return result;
        }

        public bool ModernizationthroughdataTabs()
        {
            bool result = false;
            string classNameContains = Modernizationthroughdata.GetAttribute("class");
            if (!(classNameContains.Contains("current")))
            {
                result = true;
            }

            return result;
        }

        public bool VarietyandFairnessTab()
        {
            bool result = false;
            string classNameContains = VarietyandFairness.GetAttribute("class");
            if (!(classNameContains.Contains("current")))
            {
                result = true;
            }

            return result;
        }

        public bool TransparencybuildsTrustTab()
        {
            bool result = false;
            string classNameContains = VarietyandFairness.GetAttribute("class");
            if (!(classNameContains.Contains("current")))
            {
                result = true;
            }

            return result;
        }

        public bool ClickModernizationthroughdataTab()
        {
            Modernizationthroughdata.Click();
            bool result = false;
            string classNameContains = Modernizationthroughdata.GetAttribute("class");
            if (classNameContains.Contains("current"))
            {
                result = true;
            }

            return result;
        }

        public bool ClickVarietyandFairnessTab()
        {
            VarietyandFairness.Click();
            bool result = false;
            string classNameContains = VarietyandFairness.GetAttribute("class");
            if (classNameContains.Contains("current"))
            {
                result = true;
            }

            return result;
        }

        public bool ClickTransparencybuildsTrustTab()
        {
            TransparencybuildsTrust.Click();
            bool result = false;
            string classNameContains = TransparencybuildsTrust.GetAttribute("class");
            if (classNameContains.Contains("current"))
            {
                result = true;
            }

            return result;
        }

        public void OsloNorway()
        {
            VisitOslo.Click();
        }

        public void NyUSA()
        {
            VisitNewYork.Click();
           
        }

        public void HambergGermany()
        {
            VisitHamberg.Click();
        }

        public bool OpenAccordian()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("subscription-model-inner")));
            bool result = false;
            string RoleExpanded = VarietyandFairness.GetAttribute("class");
            if (RoleExpanded.Contains("expandednt"))
            {
                result = true;
            }

            return result;
        }

        public bool VisitLinks()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.TagName("title")));
            bool result = false;
            string VisitOsloLink = VisitOslo.GetAttribute("href");
            string VisitNewYorkLink = VisitNewYork.GetAttribute("href");
            string VisitHambergLink = VisitHamberg.GetAttribute("href");
            if (VisitOsloLink.Contains("oslo") && VisitNewYorkLink.Contains("new-york") && VisitHambergLink.Contains("hamburg"))
            {
                result = true;
            }

            return result;
        }

        public string Apply()
        {
            OpenApplication.Click();
            ApplyHere.Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.TagName("title")));
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string URL = driver.Url;
            driver.SwitchTo().Window(driver.WindowHandles.First());
            return URL;
        }
    }
}
