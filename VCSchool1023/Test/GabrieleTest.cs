using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSchool1023.Page;

namespace VCSchool1023.Test
{
    public class GabrieleTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void TestSingleCheckbox()
        {
            GabrielePage page = new GabrielePage(_driver);
            string expectedResult = "Success - Check box is checked";

            page.CheckSingleCheckbox().SingleCheckboxResult(expectedResult);
        }

        [Test]
        public void TestMultipleCheckbox()
        {
            GabrielePage page = new GabrielePage(_driver);
            page.CheckMultipleCheckbox().MultipleCheckboxResult();
        }

    }
}
    

