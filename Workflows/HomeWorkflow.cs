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
    public class HomeWorkflow : BaseWorkflow
    {

        private HomePage HomePage
        {
            get
            { 
                return new HomePage(webDriver);
            }
        }
        public HomeWorkflow(IWebDriver webDriver)
            : base(webDriver)
        {

        }

        public void ValidatePageTitle()
        {
            String expected = "UI Testing Site";
            HomePage.ClickHome();
            Logger.AssertEqual(expected, webDriver.Title);
            Assert.AreEqual(webDriver.Title, expected);            
        }

        public void ValidateIfCompanyLogoIsDisplayed()
        {
            HomePage.ClickHome();
            Assert.IsTrue(HomePage.IsLogoActive());
        }

        public void ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_HomePage()
        {
            HomePage.ClickHome();
            Assert.IsTrue(HomePage.IsHomePageDisplayed());
        }

        public void ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_FormPage()
        {
            HomePage.ClickForm();
            HomePage.ClickHome();
            Assert.IsTrue(HomePage.IsHomePageDisplayed());
        }

        public void ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_ErrorPage()
        {
            HomePage.ClickError();
            HomePage.ClickHome();
            Assert.IsTrue(HomePage.IsHomePageDisplayed());
        }

        public void ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_FormResultPage()
        {
            HomePage.ClickHome();
            Assert.IsTrue(HomePage.IsHomePageDisplayed());
        }

        public void ValidateIfTheHomePageButtonIsClickedTheHomeButtonIsChangedToActive()
        {
            HomePage.ClickHome();
            Assert.IsTrue(HomePage.IsHomeButtonActive());
        }

        public void ValidateIfTheHomePageIsDisplayedWhenTheUITestingButtonIsClicked()
        {
            HomePage.ClickUITesting();
            Assert.IsTrue(HomePage.ValidateWelcomeMessage());
        }

        public void ValidateWelcomeText()
        {
            Assert.IsTrue(HomePage.ValidateWelcomeMessage());
        }

        public void ValidateSiteDescription()
        {
            Assert.IsTrue(HomePage.ValidateSiteDescription());
        }

    }
}
