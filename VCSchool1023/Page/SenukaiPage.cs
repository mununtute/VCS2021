using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSchool1023.Page
{
    public class SenukaiPage : BasePage
    {
        private const string PageAddress = "https://www.senukai.lt/";

        public SenukaiPage(IWebDriver webdriver) : base(webdriver)
        { }

        public SenukaiPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public SenukaiPage AcceptCookie()
        {
            Cookie myCookie = new Cookie("CookieConsent",
                "{stamp:%27HrfXET9bNa3cUan1VV7i8S1SymLHoOd0XBrynFq4y0dO4gzmXX+4KQ==%27%2Cnecessary:true%2Cpreferences:false%2Cstatistics:false%2Cmarketing:false%2Cver:1%2Cutc:1637340040391%2Cregion:%27lt%27}",
                "www.senukai.lt", "/",
                DateTime.Now.AddDays(2));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
            return this;
        }

    }
}
