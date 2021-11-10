using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSchool1023.Page
{
    public class SeleniumInputPage : BasePage
    {
       // private static IWebDriver Driver; reikia istrinti

        private IWebElement _inputField => Driver.FindElement(By.Id("user-message"));
        private IWebElement _button => Driver.FindElement(By.CssSelector("#get-input > button"));
        private IWebElement _result => Driver.FindElement(By.Id("display"));
        private IWebElement _firstInput => Driver.FindElement(By.Id("sum1"));
        private IWebElement _secondInput => Driver.FindElement(By.Id("sum2"));
        private IWebElement _getTotalButton => Driver.FindElement(By.CssSelector("#gettotal > button"));
        private IWebElement _resultFromPage => Driver.FindElement(By.Id("displayvalue"));
        public SeleniumInputPage(IWebDriver webdriver) : base(webdriver)
        { }

        public void InsertText(string text)
        {
            _inputField.Clear();
            _inputField.SendKeys(text);
        }

        public void ClickShowMessageButton()
        {
            _button.Click();
        }

        public void CheckResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, _result.Text, "Tekstas neatsirado");
        }
        public void InsertFirstInput(string text)
        {
            _firstInput.Clear();
            _firstInput.SendKeys(text);
        }
        public void InsertSecondInput(string text)
        {
            _secondInput.Clear();
            _secondInput.SendKeys(text);
        }

        public void InsertBothsInput(string first, string second)
        {
            InsertFirstInput(first);
            InsertSecondInput(second);
        }
        public void ClickGetTotalButton()
        {
            _getTotalButton.Click();
        }
        public void CheckSumResult(string expectedResultSum)
        {
            Assert.AreEqual(expectedResultSum, _resultFromPage.Text, "Result is NOK");
        }
        
    }
}
