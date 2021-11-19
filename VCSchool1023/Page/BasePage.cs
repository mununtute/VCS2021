

using OpenQA.Selenium;

namespace VCSchool1023.Page
{
    public class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public void CloseBrowser()
        {
           //Driver.Quit();
        }
    }
}
