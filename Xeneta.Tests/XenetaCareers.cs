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

        [Test, Category("Interact with the out values tabs")]
        public void XenetaIsOne()
        {
            driver.Navigate().Refresh();
            Careers currentCareers = new Careers(driver);

            Assert.That(currentCareers.XenetaIsOneTabs, Is.True);


            Assert.That(currentCareers.ModernizationthroughdataTabs, Is.True);


            Assert.That(currentCareers.VarietyandFairnessTab, Is.True);


            Assert.That(currentCareers.TransparencybuildsTrustTab, Is.True);
        }

        [Test, Category("Interact with the roles accordian")]
        public void CareersTabs()
        {
            Careers currentCareers = new Careers(driver);

            Assert.That(currentCareers.ClickModernizationthroughdataTab, Is.True);

            Assert.That(currentCareers.ClickVarietyandFairnessTab, Is.True);

            Assert.That(currentCareers.ClickTransparencybuildsTrustTab, Is.True);

        }

        [Test, Category("Interact with the global tribe section")]
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

        [Test, Category("Check link redirect url")]
        public void VisitLinks()
        {
            Careers currentCareers = new Careers(driver);
            Assert.That(currentCareers.VisitLinks, Is.True);

        }

        [Test, Category("Interact with the roles")]
        public void ApplyForRoles()
        {
            Careers currentCareers = new Careers(driver);

            Assert.IsTrue(currentCareers.Apply().Contains("bamboohr"));
        }

    }
}
