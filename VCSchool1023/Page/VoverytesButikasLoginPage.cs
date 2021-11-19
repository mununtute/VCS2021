

using NUnit.Framework;
using OpenQA.Selenium;

namespace VCSchool1023.Page
{
    public class VoverytesButikasLoginPage : BasePage
    {
        public const string PageAddressOpenLogin = "https://www.voverytesbutikelis.lt/account-login";
        public const string LoginErrorResultText = "Įspėjimas: El. paštas ir/arba slaptažodis nerasti sistemoje.";
        private IWebElement userEmail => Driver.FindElement(By.Id("input-email"));
        private IWebElement userPassword => Driver.FindElement(By.Id("input-password"));
        //private IWebElement loginButton => Driver.FindElement(By.CssSelector(".btn.btn-primary.button"));
        private IWebElement loginButton => Driver.FindElement(By.CssSelector("#content > div > div.col-sm-6.right > div > form > input"));
        private IWebElement loginResult => Driver.FindElement(By.CssSelector("#container > div.alert.alert-danger.warning"));
        private IWebElement newRegisterButton => Driver.FindElement(By.CssSelector("#column-right > div > div > ul > li:nth-child(2) > a"));
        public VoverytesButikasLoginPage(IWebDriver webdriver) : base(webdriver)
        {}

        public VoverytesButikasLoginPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressOpenLogin)
                Driver.Url = PageAddressOpenLogin;
            return this;
        }
        public VoverytesButikasLoginPage InsertEmail(string email)
        {
            userEmail.Clear();
            userEmail.SendKeys(email);
            return this;
        }
        public VoverytesButikasLoginPage InsertPassword(string password)
        {
            userPassword.Clear();
            userPassword.SendKeys(password);
            return this;
        }
        public VoverytesButikasLoginPage InsertEmailAndPassword(string email, string password)
        {
            InsertEmail(email);
            InsertPassword(password);
            return this;
        }
        public VoverytesButikasLoginPage ClickLoginButton()
        {
            loginButton.Click();
            return this;
        }
        //public VoverytesButikasLoginPage ClickNewRegisterButton()
      //  {
            //newRegisterButton.Click();
           // return this;
      //  }
        public VoverytesButikasLoginPage CheckLoginResult()
        {
            //Assert.AreEqual(expectedLoginResul, loginResult.Text, "No related message");
            Assert.AreEqual(LoginErrorResultText, loginResult.Text, "No related message");
            return this;
        }

    }
}
