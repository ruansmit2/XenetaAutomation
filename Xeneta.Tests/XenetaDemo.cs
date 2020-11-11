using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using Xeneta.Pages;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class XenetaDemo
    {

        IWebDriver driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));


        [OneTimeSetUp]
        public void beforeEach()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.xeneta.com/demo";
            OneOnOneDemo demo = new OneOnOneDemo(driver);
            demo.cookieConfirm();
        }

        [OneTimeTearDown]
        public void afterEach()
        {
            driver.Quit();
        }

        [Test, Category("Check Icon on the One to One Demo")]
        public void OneOnOneIcon()
        {
            OneOnOneDemo demo = new OneOnOneDemo(driver);
            demo.doesIconExist();
            Assert.That(demo.doesIconExist, Is.True);

            demo.clickSheduleNow();
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Assert.That(demo.PopUpDisplay, Is.True);
            demo.Incomplete();
            Assert.That(demo.Incomplete, Is.True);    
            demo.FillOutForm();

            demo.closeModalDialog();
        }

        [Test, Category("Click on the one one one Schedule button")]
        public void OneOnOneShedule()
        {
            WatchVideos Video = new WatchVideos(driver);
            OneOnOneDemo demo = new OneOnOneDemo(driver);

            Video.doesIconExist();
            Assert.That(Video.doesIconExist, Is.True);

            Video.clickWatchNow();

            Video.clearValues();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Assert.That(Video.PopUpDisplay, Is.True);
            Video.Incomplete();
            Assert.That(Video.Incomplete, Is.True);    
            Video.FillOutForm();

            demo.closeModalDialog();
        }

        [Test]
        public void NegativeTest()
        {
            OneOnOneDemo demo = new OneOnOneDemo(driver);
            demo.clickSheduleNow();
            demo.clearValues();
            demo.NegativeTest();
            Assert.That(demo.PhoneFormatNegativeTestError, Is.True);
            Assert.That(demo.EmailNegativeTestError, Is.True);
            Assert.That(demo.PhoneLengthNegativeTestError, Is.True);
            demo.clearValues();
            demo.NegativeTestPhone();
            Assert.That(demo.PhoneLengthNegativeTestError, Is.True);

            demo.closeModalDialog();
        }

        [Test]
        public void SignUpHere()
        {
            GroupLiveDemo LiveDemo = new GroupLiveDemo(driver);
            LiveDemo.signUpHere();
            LiveDemo.FillOutForm();
            LiveDemo.myCompanyBCO();
            
            Assert.That(LiveDemo.Global_TEUs, Is.True);
            Assert.That(LiveDemo.FreightTonTrue, Is.True);

            LiveDemo.myCompanyForwarder();

            Assert.That(LiveDemo.Global_TEUs, Is.True);

            LiveDemo.closeModalDialog();
        }
    }
}