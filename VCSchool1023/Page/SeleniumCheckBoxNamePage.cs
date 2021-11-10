using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSchool1023.Page
{
    public class SeleniumCheckBoxNamePage : BasePage
    {  
        
            private static IWebDriver _driver;

            private IWebElement _oneCheckBox => _driver.FindElement(By.Id("isAgeSelected"));
            private IWebElement _text => _driver.FindElement(By.Id("txtAge"));
            private IWebElement _firstCheckbox => _driver.FindElement(By.Id("isAgeSelected"));
            private IReadOnlyCollection<IWebElement> _multipleCheckBoxList => _driver.FindElements(By.CssSelector(".cb1-element"));
            private IWebElement _button => _driver.FindElement(By.Id("check1"));

            public SeleniumCheckBoxNamePage(IWebDriver webdriver) : base(webdriver)
            { }

            public SeleniumCheckBoxNamePage ClickOneCheckBox()
            {
                _oneCheckBox.Click();
                return this;
            }
            public SeleniumCheckBoxNamePage TestIfOneCheckBoxIsChecked(string expectedResult)
            {

                Assert.IsTrue(_text.Text.Equals(expectedResult), $"Result is not the same, expected { expectedResult}, but was { _text.Text}");
                return this;
            }
            public SeleniumCheckBoxNamePage ClickFirstCheckBox()
            {
            if (!_firstCheckbox.Selected)
                _firstCheckbox.Click();
            return this;
        }
            public SeleniumCheckBoxNamePage SelectAllCheckBoxes()
            {
                foreach (IWebElement element in _multipleCheckBoxList)
                {
                    element.Click();
                }
                return this;
            }
            public SeleniumCheckBoxNamePage TestButtonValue(string expectedValue)
            {
                Assert.IsTrue(_button.GetProperty("value").Equals(expectedValue), $"The values are not the same");
                return this;
            }
            public SeleniumCheckBoxNamePage ClickButtonUncheckValue(string value)
            {
                if (_button.GetAttribute("value") == value)
                {
                    _button.Click();
                }
                return this;
            }
            public SeleniumCheckBoxNamePage TestIfAllCheckBoxesAreUnchecked(string expectedValue)
            {
                int counter = 0;
                foreach (IWebElement element in _multipleCheckBoxList)
                {
                    if (element.Selected)
                    {
                        counter++;
                    }
                }
                Assert.AreEqual(expectedValue, counter++, "Not all checkboxes are unchecked");
                return this;
            }


        }
    }


