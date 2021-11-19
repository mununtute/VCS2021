

using NUnit.Framework;
using OpenQA.Selenium;

namespace VCSchool1023.Page
{
    public class SeleniumInputPage : BasePage
    {
        // private static IWebDriver Driver; reikia istrinti
        private const string PageAddress = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
        private IWebElement _inputField => Driver.FindElement(By.Id("user-message"));
        private IWebElement _button => Driver.FindElement(By.CssSelector("#get-input > button"));
        private IWebElement _result => Driver.FindElement(By.Id("display"));
        private IWebElement _firstInput => Driver.FindElement(By.Id("sum1"));
        private IWebElement _secondInput => Driver.FindElement(By.Id("sum2"));
        private IWebElement _getTotalButton => Driver.FindElement(By.CssSelector("#gettotal > button"));
        private IWebElement _resultFromPage => Driver.FindElement(By.Id("displayvalue"));
        public SeleniumInputPage(IWebDriver webdriver) : base(webdriver)
        { }

        public SeleniumInputPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public SeleniumInputPage InsertText(string text)
        {
            _inputField.Clear();
            _inputField.SendKeys(text);
            return this;
        }

        public SeleniumInputPage ClickShowMessageButton()
        {
            _button.Click();
            return this;
        }

        public SeleniumInputPage CheckResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, _result.Text, "Tekstas neatsirado");
            return this;
        }
        public SeleniumInputPage InsertFirstInput(string text)
        {
            _firstInput.Clear();
            _firstInput.SendKeys(text);
            return this;
        }
        public SeleniumInputPage InsertSecondInput(string text)
        {
            _secondInput.Clear();
            _secondInput.SendKeys(text);
            return this;
        }

        public SeleniumInputPage InsertBothsInput(string first, string second)
        {
            InsertFirstInput(first);
            InsertSecondInput(second);
            return this;
        }
        public SeleniumInputPage ClickGetTotalButton()
        {
            _getTotalButton.Click();
            return this;
        }
        public SeleniumInputPage CheckSumResult(string expectedResultSum)
        {
            Assert.AreEqual(expectedResultSum, _resultFromPage.Text, "Result is NOK");
            return this;
        }
        
    }
}
