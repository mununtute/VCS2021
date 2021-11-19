

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace VCSchool1023.Page
{
    public class DropDownPage : BasePage
    {
        private const string PageAddress = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
        private const string ResultText = "Day selected :- ";
        private SelectElement DropDown => new SelectElement(Driver.FindElement(By.Id("select-demo")));
        private IWebElement ResultTextElement => Driver.FindElement(By.CssSelector(".selected-value"));
        private IWebElement FirstSelectedButton => Driver.FindElement(By.Id("printMe"));
        private IWebElement GetAllSelectedButton => Driver.FindElement(By.Id("printAll"));
        private SelectElement MultiDropDown => new SelectElement(Driver.FindElement(By.Id("multi-select")));
        private IWebElement ResultTextAllSelectedElement => Driver.FindElement(By.CssSelector(".getall-selected"));
        public DropDownPage(IWebDriver webdriver) : base(webdriver)
        {}

        public DropDownPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public DropDownPage SelectFromDropdownByText(string text)
        {
            DropDown.SelectByText(text);
            return this;
        }
        public DropDownPage SelectFromDropdownByValue(string text)
        {
            DropDown.SelectByValue(text);
            return this;
        }
        public DropDownPage VerifyResult(string selectedDay)
        {
            Assert.IsTrue(ResultTextElement.Text.Equals(ResultText + selectedDay), $"Result is wrong, not {selectedDay}");
            return this;
        }
        public DropDownPage SelectFromMultipleDropdownAndClickFirstButton(List <string> listOfStates)
        {
            MultiDropDown.DeselectAll();
            Actions action = new Actions(Driver);
            action.KeyDown(Keys.LeftControl);
            foreach (string state in listOfStates)
            {
                foreach (IWebElement option in MultiDropDown.Options)
                {
                    if (state.Equals(option.GetAttribute("value")))
                    {
                        action.Click(option);
                        break;
                    }
                }
            }
            action.KeyUp(Keys.LeftControl);
            action.Build().Perform();
            action.Click(FirstSelectedButton);
            action.Build().Perform();
            return this;
        }
        public DropDownPage ClickGetAllButton()
        {
            GetAllSelectedButton.Click();
            return this;
        }

        public DropDownPage CheckListedStates(List<string> selectedElements)
        {
            string result = ResultTextAllSelectedElement.Text;
            foreach (string selectedElement in selectedElements)
            {
                Assert.True(result.Contains(selectedElement),
                    $"Should be {selectedElement}, but was {result}");
            }
            return this;
        }
        public DropDownPage CheckFirstState(string selectedElement)
        {
            string result = ResultTextAllSelectedElement.Text;
            Assert.True(result.Contains(selectedElement),
                $"{selectedElement} is missing. {result}");
            return this;
        }

        public DropDownPage SelectFromMultipleDropDownByValue(List<string> listOfStates)
        {
            MultiDropDown.DeselectAll();
            foreach (IWebElement option in MultiDropDown.Options)
                if (listOfStates.Contains(option.GetAttribute("value")))
                {
                    ClickMultipleBox(option);
                }
            return this;
        }
        private void ClickMultipleBox(IWebElement element)
        {
            Actions actions = new Actions(Driver);
            actions.KeyDown(Keys.Control);
            actions.Click(element);
            actions.KeyUp(Keys.Control);
            actions.Build().Perform();
        }
        public DropDownPage ClickFirstSelectedButton()
        {
            FirstSelectedButton.Click();
            return this;
        }

        public DropDownPage ClickAllSelectedButton()
        {
            GetAllSelectedButton.Click();
            return this;
        }

    }
}

