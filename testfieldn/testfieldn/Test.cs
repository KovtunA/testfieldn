using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace testfieldn
{
    [TestFixture()]
    public class Test
    {
        static IWebDriver driver;

        [Test()]
        public void TestCase()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://saucelabs.com");
            IWebElement header = driver.FindElement(By.Id("site-header"));
            Assert.True(header.Displayed);
            driver.Close();
        }
    }
}
