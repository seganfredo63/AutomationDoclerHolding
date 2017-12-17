using AutomationDoclerHolding.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationDoclerHolding.Pages
{
    public class FormResultPage : PageBase
    {
        public FormResultPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        private IWebElement Result
        {
            get
            {
                return webDriver.FindElement(By.Id("hello-text"));
            }
        }

        public void WaitUntilFormResultPageIsDisplayed()
        {
            int limit = 0;
            while (!Result.Displayed || limit == 20)
            {
                Thread.Sleep(500);
                limit++;
            }
        }

        public bool ValidateIfMessageWasCorrectlyDisplayed(String name)
        {
            string message = "Hello " + name + "!";
            if (Result.Text.Equals(message))
            {
                Logger.LogMessage("The message [ " + message + " ] was correctly displayed.");
                return true;
            }
            else
            {
                Logger.LogMessage("ERROR: The message [ " + message + " ] was NOT displayed correctly.");
                return false;
            }
        }
    }
}
