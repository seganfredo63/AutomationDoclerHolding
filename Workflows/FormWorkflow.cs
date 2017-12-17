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
    public class FormWorkflow : BaseWorkflow
    {
        private FormPage FormPage
        {
            get
            {
                return new FormPage(webDriver);
            }
        }
        public FormWorkflow(IWebDriver webDriver)
            : base(webDriver)
        {

        }

        public void ValidatePageTitle()
        {
            String expected = "UI Testing Site";
            FormPage.ClickForm();
            Logger.AssertEqual(expected, webDriver.Title);
            Assert.AreEqual(webDriver.Title, expected);
        }

        public void SubmitAName(String name)
        {
            FormPage.ClickForm();
            FormPage.InsertNameInput(name);
            FormPage.ClickSubmitButton();
        }

        public void ValidateIfCompanyLogoIsDisplayed()
        {
            FormPage.ClickForm();
            Assert.IsTrue(FormPage.IsLogoActive());
        }

        public void ValidateIfFormPageIsDisplayed()
        {
            FormPage.ClickForm();
            Assert.IsTrue(FormPage.IsFormPageDisplayed());
        }

        public void ValidateIfFormButtonIsChangedToActive()
        {
            FormPage.ClickForm();
            Assert.IsTrue(FormPage.IsFormButtonActive());
        }

        public void ValidateIfFormIsVisible()
        {
            FormPage.ClickForm();
            Assert.IsTrue(FormPage.IsFormDisplayed());
        }
    }
}
