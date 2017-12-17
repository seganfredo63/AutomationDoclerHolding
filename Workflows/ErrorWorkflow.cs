using AutomationDoclerHolding.Helpers;
using AutomationDoclerHolding.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDoclerHolding.Workflows
{
    public class ErrorWorkflow : BaseWorkflow
    {
        private ErrorPage ErrorPage
        {
            get
            {
                return new ErrorPage(webDriver);
            }
        }
        public ErrorWorkflow(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public void ValidatePageTitle()
        {
            String expected = "UI Testing Site";
            ErrorPage.ClickError();
            Logger.AssertEqual(expected, webDriver.Title);
            Assert.AreEqual(webDriver.Title, expected);
        }

        public void ValidateIfCompanyLogoIsDisplayed()
        {
            ErrorPage.ClickError();
            Assert.IsTrue(ErrorPage.IsLogoActive());
        }

        public void ValidateIfErrorMessageIsDisplayed()
        {
            ErrorPage.ClickError();
            Assert.IsTrue(ErrorPage.IsErrorMessageDisplayed());
        }

    }
}
