using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSchool1023.Page
{
    public class GabrielePage
    {
        private static IWebDriver _driver;
        public IWebElement _singleCheckbox => _driver.FindElement(By.Id("isAgeSelected"));
        public IWebElement _singleResult => _driver.FindElement(By.Id("txtAge"));
        public IReadOnlyCollection<IWebElement> _multipleCheckboxList => _driver.FindElements(By.CssSelector(".cb1-element"));
        public IWebElement _button => _driver.FindElement(By.Id("check1"));
        public GabrielePage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }


        public GabrielePage CheckSingleCheckbox()
        {
            _singleCheckbox.Click();
            return this;
        }

        public GabrielePage SingleCheckboxResult(string expectedResult)
        {
            Assert.IsTrue(_singleResult.Text.Contains(expectedResult), "Result is not the same");
            return this;
        }

        public GabrielePage CheckMultipleCheckbox()
        {

            foreach (IWebElement element in _multipleCheckboxList)
            {
                element.Click();
            }

            return this;
        }
        public GabrielePage MultipleCheckboxResult()
        {
            _button.GetProperty("value");
            Assert.IsTrue(_button.GetProperty("value").Equals("Uncheck All"));

            _button.Click();
            _button.GetProperty("value");
            Assert.IsTrue(_button.GetProperty("value").Equals("Check All"));

            return this;
        }


    }
}
    

