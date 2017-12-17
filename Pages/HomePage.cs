using AutomationDoclerHolding.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDoclerHolding.Pages
{
    public class HomePage : PageBase
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {

        }

        private IWebElement WelcomeMessage
        {
            get
            {
                return webDriver.FindElement(By.TagName("h1"));
            }
        }

        private IWebElement SiteDescription
        {
            get
            {
                return webDriver.FindElement(By.TagName("p"));
            }
        }

        public bool ValidateWelcomeMessage()
        {
            if (WelcomeMessage.Text.Equals("Welcome to the Docler Holding QA Department"))
            {
                Logger.LogMessage("The Welcome message is 'Welcome to the Docler Holding QA Department' as it should be.");
                return true;
            }
            else
            {
                Logger.LogMessage("ERROR: The Welcome message is NOT 'Welcome to the Docler Holding QA Department'.");
                return false;
            }
        }

        public bool IsHomePageDisplayed()
        {
            if (WelcomeMessage.Displayed)
            {
                Logger.LogMessage("The Home Page was succesfully displayed.");
                return true;
            }
            else
            {
                Logger.LogMessage("ERROR: The Home Page wasn't displayed.");
                return false;
            }
        }

        public bool ValidateSiteDescription()
        {
            if (SiteDescription.Text.Equals("This site is dedicated to perform some exercises and demonstrate automated web testing."))
            {
                Logger.LogMessage("The Site Description is 'This site is dedicated to perform some exercises and demonstrate automated web testing.' as it should be.");
                return true;
            }
            else
            {
                Logger.LogMessage("ERROR: The Site Description is NOT 'This site is dedicated to perform some exercises and demonstrate automated web testing.'.");
                return false;
            }
        }
        
    }
}
