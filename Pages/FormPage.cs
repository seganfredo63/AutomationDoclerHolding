using AutomationDoclerHolding.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDoclerHolding.Pages
{
    public class FormPage : PageBase
    {
        public FormPage(IWebDriver webDriver)
            : base(webDriver)
        {

        }

        private IWebElement NameInput
        {
            get
            {
                return webDriver.FindElement(By.Id("hello-input"));
            }
        }

        private IWebElement SubmitButton
        {
            get
            {
                return webDriver.FindElement(By.Id("hello-submit"));
            }
        }

        public void InsertNameInput(String value)
        {
            NameInput.SendKeys(value);
            Logger.LogMessage("Inserted [ " + value + " ] on the field [ Name Input ]");
        }

        public void ClickSubmitButton()
        {
            SubmitButton.Click();
            Logger.ClickedOn("Submit Button");
        }


        public bool IsFormDisplayed()
        {
            if (NameInput.Displayed && SubmitButton.Displayed)
            {
                Logger.IsElementActive("Form", true);
                return true;
            }
            else
            {
                Logger.IsElementActive("Form", false);
                return false;
            }
        }


        public bool IsFormPageDisplayed()
        {
            if (NameInput.Displayed)
            {
                Logger.IsElementActive("Form Page", true);
                return true;
            }
            else
            {
                Logger.IsElementActive("Form Page", false);
                return false;
            }
        }
    }
}
