using AutomationDoclerHolding.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDoclerHolding.Workflows
{
    public class BaseWorkflow
    {
        private PageBase PageBase
        {
            get
            {
                return new PageBase(webDriver);
            }
        }
        protected IWebDriver webDriver;

        public BaseWorkflow(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void ClickHomeButton()
        {
            PageBase.ClickHome();
        }

        public void ClickFormButton()
        {
            PageBase.ClickForm();
        }

        public void ClickErrorButton()
        {
            PageBase.ClickError();
        }

        public void ClickUITestingButton()
        {
            PageBase.ClickUITesting();
        }
    }
}
