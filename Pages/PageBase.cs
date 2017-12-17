using AutomationDoclerHolding.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDoclerHolding.Pages
{
    public class PageBase
    {
        protected IWebDriver webDriver;

        public PageBase(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }


        private IWebElement Home
        {
            get
            {
                return webDriver.FindElement(By.Id("home"));
            }
        }

        private IWebElement UITesting
        {
            get
            {
                return webDriver.FindElement(By.Id("site"));
            }
        }

        private IWebElement Form
        {
            get
            {
                return webDriver.FindElement(By.Id("form"));
            }
        }

        private IWebElement Error
        {
            get
            {
                return webDriver.FindElement(By.Id("error"));
            }
        }

        private IWebElement DoclerHoldingLogo
        {
            get
            {
                return webDriver.FindElement(By.Id("dh_logo"));
            }
        }

        public void ClickHome()
        {
            try
            {
                Home.Click();
                Logger.ClickedOn("Home Menu Button");
            }
            catch (Exception e)
            {
                Logger.LogMessage("Home Menu Button is unavailable.");
                Logger.LogException(e.Message);
                throw e;
            }
        }

        public void ClickForm()
        {
            try
            {
                Form.Click();
                Logger.ClickedOn("Form Menu Button");
            }
            catch (Exception e)
            {
                Logger.LogMessage("Form Menu Button is unavailable.");
                Logger.LogException(e.Message);
                throw e;
            }
        }

        public void ClickUITesting()
        {
            try
            {
                UITesting.Click();
                Logger.ClickedOn("UI Testing Button");
            }
            catch (Exception e)
            {
                Logger.LogMessage("UI Testing Button is unavailable.");
                Logger.LogException(e.Message);
                throw e;
            }

        }


        public void ClickError()
        {
            try
            {
                Error.Click();
                Logger.ClickedOn("Error Menu Button");
            }
            catch (Exception e)
            {
                Logger.LogMessage("Error Menu Button is unavailable.");
                Logger.LogException(e.Message);
                throw e;
            }

        }

        public bool IsLogoActive()
        {
            try
            {
                if (DoclerHoldingLogo.Displayed)
                {
                    Logger.IsElementActive("Docler Holding Logo", true);
                    return true;
                }
                else
                {
                    Logger.IsElementActive("Docler Holding Logo", false);
                    return false;
                }
            }
            catch(Exception e)
            {
                Logger.IsElementActive("Docler Holding Logo", false);
                Logger.LogException(e.Message);
                throw e;
            }

        }

        public bool IsHomeButtonActive()
        {
            IWebElement parentElement = Home.FindElement(By.XPath("./parent::*"));
            if (parentElement.GetAttribute("class").Equals("active"))
            {
                Logger.IsElementActive("Home Button", true);
                return true;
            }
            else
            {
                Logger.IsElementActive("Home Button", false);
                return false;
            }
        }

        public bool IsFormButtonActive()
        {
            IWebElement parentElement = Form.FindElement(By.XPath("./parent::*"));
            if (parentElement.GetAttribute("class").Equals("active"))
            {
                Logger.IsElementActive("Form Button", true);
                return true;
            }
            else
            {
                Logger.IsElementActive("Form Button", false);
                return false;
            }
        }
    }
}
