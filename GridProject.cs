using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;

namespace SeleniumGrid
{
    [TestFixture]
    public class Driver
    {
        IWebDriver driver;

        [SetUp]
        public void TestSetUp()
        {
            //driver = new FirefoxDriver();
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities = DesiredCapabilities.Firefox();
            capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.ie");
        }
    }
}
