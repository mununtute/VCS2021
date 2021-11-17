using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSchool1023.Drivers;
using VCSchool1023.Page;
using VCSchool1023.Tools;

namespace VCSchool1023.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static DropDownPage _dropDownPage;
        public static VartuTechnikaPage _vartuTechnikaPage;
        public static SebPage _sebPage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            _dropDownPage = new DropDownPage(driver);
            _vartuTechnikaPage = new VartuTechnikaPage(driver);
            _sebPage = new SebPage(driver);
        }

        [TearDown]

        public static void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreenshot(driver);
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            driver.Quit();
        }
    }
}
