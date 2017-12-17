using AutomationDoclerHolding.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDoclerHolding.Tests
{
    public class TestBase
    {
        protected IWebDriver webDriver;
        protected String TestCaseName;
        [TestInitialize]
        public void Setup()
        {
            webDriver = new ChromeDriver();
            webDriver.Url = "http://uitest.duodecadits.com/";
        }

        [TestCleanup]
        public void Cleanup()
        {
            Logger.CreateLogFile(TestCaseName);
            webDriver.Dispose();
        }
    }
}
