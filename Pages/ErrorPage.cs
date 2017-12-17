using AutomationDoclerHolding.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDoclerHolding.Pages
{
    public class ErrorPage : PageBase
    {
        public ErrorPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        private IWebElement ErrorMessage
        {
            get
            {
                return webDriver.FindElement(By.TagName("h1"));
            }
        }

        public bool IsErrorMessageDisplayed()
        {
            if (ErrorMessage.Displayed && ErrorMessage.Text.Equals("404 Error: File not found :-("))
            {
                Logger.IsElementActive("Error Message", true);
                return true;
            }
            else
            {
                Logger.IsElementActive("Error Message", false);
                return false;
            }
        }
    }
}
