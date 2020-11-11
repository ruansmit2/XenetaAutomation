using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using Xeneta.Pages;
using OpenQA.Selenium.Support.UI;

namespace Xeneta.Tests
{
    public class XenetaCareers
    {
        IWebDriver driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));

        [OneTimeSetUp]
        public void beforeEach()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.xeneta.com/careers";

            OneOnOneDemo demo = new OneOnOneDemo(driver);
            demo.cookieConfirm();
        }

        [OneTimeTearDown]
        public void afterEach()
        {
            driver.Quit();
        }

        [Test]
        public void XenetaIsOne()
        {
            driver.Navigate().Refresh();
            Careers currentCareers = new Careers(driver);

            currentCareers.XenetaIsOneTabs();
            Assert.That(currentCareers.XenetaIsOneTabs, Is.True);

            currentCareers.ModernizationthroughdataTabs();
            Assert.That(currentCareers.ModernizationthroughdataTabs, Is.True);

            currentCareers.VarietyandFairnessTab();
            Assert.That(currentCareers.VarietyandFairnessTab, Is.True);

            currentCareers.TransparencybuildsTrustTab();
            Assert.That(currentCareers.TransparencybuildsTrustTab, Is.True);
        }

        [Test]
        public void CareersTabs()
        {
            Careers currentCareers = new Careers(driver);

            currentCareers.ClickModernizationthroughdataTab();
            Assert.That(currentCareers.ClickModernizationthroughdataTab, Is.True);

            currentCareers.ClickVarietyandFairnessTab();
            Assert.That(currentCareers.ClickVarietyandFairnessTab, Is.True);

            currentCareers.ClickTransparencybuildsTrustTab();
            Assert.That(currentCareers.ClickTransparencybuildsTrustTab, Is.True);

        }

        [Test]
        public void GlobalTribe()
        {
            var title = string.Empty;
            Careers currentCareers = new Careers(driver);

            currentCareers.OsloNorway();
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleContains("Oslo"));
            title = driver.Title;
            Assert.That(title, Is.EqualTo("Oslo Careers"));

            driver.Navigate().Back();

            currentCareers.NyUSA();
            title = driver.Title;
            Assert.That(title, Is.EqualTo("New York City Careers"));

            driver.Navigate().Back();

            currentCareers.HambergGermany();
            title = driver.Title;
            Assert.That(title, Is.EqualTo("Hamburg Careers"));

            driver.Navigate().Back();

        }

        [Test]
        public void Roles()
        {
            Careers currentCareers = new Careers(driver);

            currentCareers.OpenRoles();
            currentCareers.OpenAccordian();
        }

        [Test]
        public void VisitLinks()
        {
            Careers currentCareers = new Careers(driver);
            Assert.That(currentCareers.VisitLinks, Is.True);

        }
    }
}
