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
    public class FormResultWorkflow : BaseWorkflow
    {
        private FormResultPage FormResultPage
        {
            get
            {
                return new FormResultPage(webDriver);
            }
        }
        public FormResultWorkflow(IWebDriver webDriver)
            : base(webDriver)
        {
            
        }

        public void ValidatePageTitle()
        {
            String expected = "UI Testing Site";
            FormResultPage.WaitUntilFormResultPageIsDisplayed();
            Logger.AssertEqual(expected, webDriver.Title);
            Assert.AreEqual(webDriver.Title, expected);
        }

        public void ValidateIfCompanyLogoIsDisplayed()
        {
            Assert.IsTrue(FormResultPage.IsLogoActive());
        }

        public void ValidateIfMessageWasCorrectlyDisplayed(String name)
        {
            Assert.IsTrue(FormResultPage.ValidateIfMessageWasCorrectlyDisplayed(name));
        }

    }
}
