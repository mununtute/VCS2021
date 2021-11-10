using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSchool1023.Page
{
   public class CheckboxDemoPage : BasePage
    {
        private IWebElement _singleCheckbox => Driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement _Text => Driver.FindElement(By.Id("txtAge"));
        private IReadOnlyCollection<IWebElement> MultipleCheckboxList => Driver.FindElements(By.CssSelector(".cb1-element"));
        private IWebElement _Button => Driver.FindElement(By.Id("check1"));

        public CheckboxDemoPage(IWebDriver webdriver) : base(webdriver)
        {
            //Driver.Url = "https://demo.seleniumeasy.com/basic-checkbox-demo.html";
        }
        public CheckboxDemoPage CheckSingleCheckbox()
        {
            if (!_singleCheckbox.Selected)
                _singleCheckbox.Click();
            return this;
        }

        public CheckboxDemoPage CheckResult()
        {
            Assert.IsTrue(_Text.Text.Equals("Success - Check box is checked"));
            return this;
        }


        private void UncheckFirstBlockCheckbox()
        {
            if (_singleCheckbox.Selected)
                _singleCheckbox.Click();
        }

        public CheckboxDemoPage CheckAllCheckboxes()
        {
            UncheckFirstBlockCheckbox();
            foreach (IWebElement element in MultipleCheckboxList)
            {
                if (!element.Selected)
                    element.Click();
            }
            return this;
        }

        public CheckboxDemoPage CheckButtonValue(string value)
        {
            //GetWait().Until(ExpectedConditions.TextToBePresentInElement(Button, "Uncheck All"));
            //Assert.IsTrue(Button.GetAttribute("value").Equals(value), "Second is wrong");
            return this;
        }

        public CheckboxDemoPage ClickButton()
        {
            _Button.Click();
            return this;
        }

        public CheckboxDemoPage VerifyThatAllCheckboxesAreUnchecked()
        {
            foreach (IWebElement element in MultipleCheckboxList)
            {
                Assert.False(element.Selected, "Checkbox is still checked");
                //Assert.IsTrue(!element.Selected, "Checkbox is still checked");
                //Assert.That(!element.Selected, "Checkbox is still checked");
                //Assert.That(!element.Selected, "Checkbox is still checked");
            }
            return this;
        }
    }
}
    

