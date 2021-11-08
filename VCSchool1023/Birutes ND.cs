using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VCSchool1023
{
    class Birutes_ND
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.italala.lt/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            IWebElement kukis = _driver.FindElement(By.CssSelector("#cookies-submit > a"));
            kukis.Click();
            Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            IWebElement reklama = _driver.FindElement(By.CssSelector(".close-modal"));
            wait.Until(d => reklama.Displayed);
            reklama.Click();
        }

      
    }
}
