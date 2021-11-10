using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSchool1023.Page;
using static VCSchool1023.Page.SeleniumCheckBoxNamePage;

namespace VCSchool1023.Test
{
    public class SeleniumCheckBoxTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }

        [TestCase("Success - Check box is checked", TestName = "TestOneCheckBox")]
        public void TestOneCheckBox(string result)
        {
            SeleniumCheckBoxNamePage page = new SeleniumCheckBoxNamePage(_driver);
            page.ClickOneCheckBox();
            page.TestIfOneCheckBoxIsChecked(result);
        }

        [TestCase("Uncheck All", TestName = "TestAllCheckedBoxes")]
        public void TestAllFourCheckBoxes(string expectedValue)
        {
            SeleniumCheckBoxNamePage page = new SeleniumCheckBoxNamePage(_driver);
            page.ClickFirstCheckBox();
            page.SelectAllCheckBoxes();
            page.TestButtonValue(expectedValue);
        }

        [TestCase("Uncheck All", "0", TestName = "TestIfAllUnchecked")]
        public void TestIfUnchecked(string value, string expectedValue)
        {
            SeleniumCheckBoxNamePage page = new SeleniumCheckBoxNamePage(_driver);
            page.ClickButtonUncheckValue(value);
            page.TestIfAllCheckBoxesAreUnchecked(expectedValue);
        }

    }
}
    

