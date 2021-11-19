


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using VCSchool1023.Page;

namespace VCSchool1023.Test
{
    public class SeleniumInputTest : BaseTest
    {
       
        [Test]

        public void TestSeleniumInputFirstBlock()
        {
            _seleniumInputPage.NavigateToDefaultPage()
                .InsertText("Hi")
                .ClickShowMessageButton()
                .CheckResult("Hi");
        }

        [TestCase("2", "2", "4", TestName = "2 plius 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 plius 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a plius b = NaN")]
        public void TestSeleniumInputSecondBlock(string firstInput, string secondInput, string result)
        {
            _seleniumInputPage.NavigateToDefaultPage()
                .InsertBothsInput(firstInput, secondInput)
            .ClickGetTotalButton()
            .CheckSumResult(result);
        }

    }
}

