using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationDoclerHolding.Tests;
using AutomationDoclerHolding.Workflows;

namespace AutomationDoclerHolding
{
    [TestClass]
    public class DoclerHoldingTest : TestBase
    {

        private HomeWorkflow HomeWorkflow
        {
            get 
            { 
                return new HomeWorkflow(webDriver); 
            }
        }

        private FormWorkflow FormWorkflow
        {
            get
            {
                return new FormWorkflow(webDriver);
            }
        }

        private ErrorWorkflow ErrorWorkflow
        {
            get
            {
                return new ErrorWorkflow(webDriver);
            }
        }

        private FormResultWorkflow FormResultWorkflow
        {
            get
            {
                return new FormResultWorkflow(webDriver);
            }
        }


        [TestMethod]
        [Description("This test validates that the title is 'UI Testing Site' on the Home page.")]
        public void TestCase_01_ValidatePageTitleOnTheHomePage()
        {
            TestCaseName = "TestCase_01";
            HomeWorkflow.ValidatePageTitle();
        }

        [TestMethod]
        [Description("This test validates that the title is 'UI Testing Site' on the Form page.")]
        public void TestCase_02_ValidatePageTitleOnTheFormPage()
        {
            TestCaseName = "TestCase_02";
            FormWorkflow.ValidatePageTitle();
        }

        [TestMethod]
        [Description("This test validates that the title is 'UI Testing Site' on the Error page.")]
        public void TestCase_03_ValidatePageTitleOnTheErrorPage()
        {
            TestCaseName = "TestCase_03";
            ErrorWorkflow.ValidatePageTitle();
        }

        [TestMethod]
        [Description("This test validates that the title is 'UI Testing Site' on the Form Result page.")]
        public void TestCase_04_ValidatePageTitleOnTheFormResultPage()
        {
            TestCaseName = "TestCase_04";
            FormWorkflow.SubmitAName("John");
            FormResultWorkflow.ValidatePageTitle();
        }

        [TestMethod]
        [Description("This test validates that the company logo is displayed on the Home page.")]
        public void TestCase_05_ValidateIfTheLogoIsDisplayedOnTheHomePage()
        {
            TestCaseName = "TestCase_05";
            HomeWorkflow.ValidateIfCompanyLogoIsDisplayed();
        }

        [TestMethod]
        [Description("This test validates that the company logo is displayed on the Form page.")]
        public void TestCase_06_ValidateIfTheLogoIsDisplayedOnTheFormPage()
        {
            TestCaseName = "TestCase_06";
            FormWorkflow.ValidateIfCompanyLogoIsDisplayed();
        }

        [TestMethod]
        [Description("This test validates that the company logo is displayed on the Error page.")]
        public void TestCase_07_ValidateIfTheLogoIsDisplayedOnTheErrorPage()
        {
            TestCaseName = "TestCase_07";
            ErrorWorkflow.ValidateIfCompanyLogoIsDisplayed();
        }

        [TestMethod]
        [Description("This test validates that the company logo is displayed on the Form Result page.")]
        public void TestCase_08_ValidateIfTheLogoIsDisplayedOnTheFormResultPage()
        {
            TestCaseName = "TestCase_08";
            FormWorkflow.SubmitAName("John");
            FormResultWorkflow.ValidateIfCompanyLogoIsDisplayed();
        }

        [TestMethod]
        [Description("This test validates that when the user clicks on the home button, when on the Home Page, he is redirected to the home page.")]
        public void TestCase_09_ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_HomePage()
        {
            TestCaseName = "TestCase_09";
            HomeWorkflow.ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_HomePage();
        }

        [TestMethod]
        [Description("This test validates that when the user clicks on the home button, when on the Form Page, he is redirected to the home page.")]
        public void TestCase_10_ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_FormPage()
        {
            TestCaseName = "TestCase_10";
            HomeWorkflow.ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_FormPage();
        }

        [TestMethod]
        [Description("This test validates that when the user clicks on the home button, when on the Error Page, he is redirected to the home page.")]
        public void TestCase_11_ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_ErrorPage()
        {
            TestCaseName = "TestCase_11";
            HomeWorkflow.ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_ErrorPage();
        }

        [TestMethod]
        [Description("This test validates that when the user clicks on the home button, when on the Form Result Page, he is redirected to the home page.")]
        public void TestCase_12_ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_FormResultPage()
        {
            TestCaseName = "TestCase_12";
            FormWorkflow.SubmitAName("John");
            HomeWorkflow.ValidateIfTheHomePageIsDisplayedWhenTheHomeButtonIsClicked_FormResultPage();
        }

        [TestMethod]
        [Description("This test validates that when the Home button is clicked on the Home Page, the home button is changed to active.")]
        public void TestCase_13_ValidateIfTheHomeButtonIsChangedToActive_HomePage()
        {
            TestCaseName = "TestCase_13";
            HomeWorkflow.ValidateIfTheHomePageButtonIsClickedTheHomeButtonIsChangedToActive();
        }

        [TestMethod]
        [Description("This test validates that when the Home button is clicked on the Form Page, the home button is changed to active.")]
        public void TestCase_14_ValidateIfTheHomeButtonIsChangedToActive_FormPage()
        {
            TestCaseName = "TestCase_14";
            HomeWorkflow.ClickFormButton();
            HomeWorkflow.ValidateIfTheHomePageButtonIsClickedTheHomeButtonIsChangedToActive();
        }

        [TestMethod]
        [Description("This test validates that when the Home button is clicked on the Error Page, the home button is changed to active.")]
        public void TestCase_15_ValidateIfTheHomeButtonIsChangedToActive_ErrorPage()
        {
            TestCaseName = "TestCase_15";
            HomeWorkflow.ClickErrorButton();
            HomeWorkflow.ValidateIfTheHomePageButtonIsClickedTheHomeButtonIsChangedToActive();
        }

        [TestMethod]
        [Description("This test validates that when the Home button is clicked on the Form Result Page, the home button is changed to active.")]
        public void TestCase_16_ValidateIfTheHomeButtonIsChangedToActive_FormResultPage()
        {
            TestCaseName = "TestCase_16";
            FormWorkflow.SubmitAName("John");
            HomeWorkflow.ValidateIfTheHomePageButtonIsClickedTheHomeButtonIsChangedToActive();
        }

        [TestMethod]
        [Description("This test validates that when the Home button is clicked on the Home Page, the home button is changed to active.")]
        public void TestCase_17_ValidateIfTheFormPageIsChangedToActive_HomePage()
        {
            TestCaseName = "TestCase_17";
            FormWorkflow.ValidateIfFormPageIsDisplayed();
        }

        [TestMethod]
        [Description("This test validates that when the Home button is clicked on the Form Page, the home button is changed to active.")]
        public void TestCase_18_ValidateIfTheFormPageIsChangedToActive_FormPage()
        {
            TestCaseName = "TestCase_18";
            HomeWorkflow.ClickFormButton();
            FormWorkflow.ValidateIfFormPageIsDisplayed();
        }


        [TestMethod]
        [Description("This test validates that when the Home button is clicked on the Error Page, the home button is changed to active.")]
        public void TestCase_19_ValidateIfTheFormPageIsChangedToActive_ErrorPage()
        {
            TestCaseName = "TestCase_19";
            HomeWorkflow.ClickErrorButton();
            FormWorkflow.ValidateIfFormPageIsDisplayed();
        }

        [TestMethod]
        [Description("This test validates that when the Home button is clicked on the Form Result Page, the home button is changed to active.")]
        public void TestCase_20_ValidateIfTheFormPageIsChangedToActive_FormResultPage()
        {
            TestCaseName = "TestCase_20";
            FormWorkflow.SubmitAName("Vinicius");
            FormWorkflow.ValidateIfFormPageIsDisplayed();
        }

        [TestMethod]
        [Description("This test validates that when the Form button is clicked on the Home Page, the Form button is changed to active.")]
        public void TestCase_21_ValidateIfTheFormButtonIsChangedToActive_HomePage()
        {
            TestCaseName = "TestCase_21";
            FormWorkflow.ValidateIfFormButtonIsChangedToActive();
        }

        [TestMethod]
        [Description("This test validates that when the Form button is clicked on the Form Page, the Form button is changed to active.")]
        public void TestCase_22_ValidateIfTheFormButtonIsChangedToActive_FormPage()
        {
            TestCaseName = "TestCase_22";
            HomeWorkflow.ClickFormButton();
            FormWorkflow.ValidateIfFormButtonIsChangedToActive();
        }

        [TestMethod]
        [Description("This test validates that when the Form button is clicked on the Error Page, the Form button is changed to active.")]
        public void TestCase_23_ValidateIfTheFormButtonIsChangedToActive_ErrorPage()
        {
            TestCaseName = "TestCase_23";
            HomeWorkflow.ClickErrorButton();
            FormWorkflow.ValidateIfFormButtonIsChangedToActive();
        }

        [TestMethod]
        [Description("This test validates that when the Form button is clicked on the Form Result Page, the Form button is changed to active.")]
        public void TestCase_24_ValidateIfTheFormButtonIsChangedToActive_FormResultPage()
        {
            TestCaseName = "TestCase_24";
            FormWorkflow.SubmitAName("John");
            FormWorkflow.ValidateIfFormButtonIsChangedToActive();
        }

        [TestMethod]
        [Description("This test validates that When the Error button is clicked on the Home Page, a 404 HTTP response code error is displayed.")]
        public void TestCase_25_ValidateIfErrorMessageWasDisplayed_HomePage()
        {
            TestCaseName = "TestCase_25";
            ErrorWorkflow.ValidateIfErrorMessageIsDisplayed();
        }

        [TestMethod]
        [Description("This test validates that When the Error button is clicked on the Form Page, a 404 HTTP response code error is displayed.")]
        public void TestCase_26_ValidateIfErrorMessageWasDisplayed_FormPage()
        {
            TestCaseName = "TestCase_26";
            HomeWorkflow.ClickFormButton();
            ErrorWorkflow.ValidateIfErrorMessageIsDisplayed();
        }

        [TestMethod]
        [Description("This test validates that When the Error button is clicked on the Error Page, a 404 HTTP response code error is displayed.")]
        public void TestCase_27_ValidateIfErrorMessageWasDisplayed_ErrorPage()
        {
            TestCaseName = "TestCase_27";
            HomeWorkflow.ClickErrorButton();
            ErrorWorkflow.ValidateIfErrorMessageIsDisplayed();
        }

        [TestMethod]
        [Description("This test validates that When the Error button is clicked on the Form Result Page, a 404 HTTP response code error is displayed.")]
        public void TestCase_28_ValidateIfErrorMessageWasDisplayed_FormResultPage()
        {
            TestCaseName = "TestCase_28";
            FormWorkflow.SubmitAName("John");
            ErrorWorkflow.ValidateIfErrorMessageIsDisplayed();
        }

        [TestMethod]
        [Description("This test validates that When the UI Testing button is clicked on the Form Page, the user is redirected to the home page")]
        public void TestCase_29_ValidateIfTheUserIsRedirectedToHomePageWhenUITestingIsClicked_HomePage()
        {
            TestCaseName = "TestCase_29";
            HomeWorkflow.ValidateIfTheHomePageIsDisplayedWhenTheUITestingButtonIsClicked();
        }

        [TestMethod]
        [Description("This test validates that When the UI Testing button is clicked on the Form Page, the user is redirected to the home page")]
        public void TestCase_30_ValidateIfTheUserIsRedirectedToHomePageWhenUITestingIsClicked_FormPage()
        {
            TestCaseName = "TestCase_30";
            HomeWorkflow.ClickFormButton();
            HomeWorkflow.ValidateIfTheHomePageIsDisplayedWhenTheUITestingButtonIsClicked();
        }

        [TestMethod]
        [Description("This test validates that When the UI Testing button is clicked on the Error Page, the user is redirected to the home page")]
        public void TestCase_31_ValidateIfTheUserIsRedirectedToHomePageWhenUITestingIsClicked_ErrorPage()
        {
            TestCaseName = "TestCase_31";
            HomeWorkflow.ClickFormButton();
            HomeWorkflow.ValidateIfTheHomePageIsDisplayedWhenTheUITestingButtonIsClicked();
        }

        [TestMethod]
        [Description("This test validates that When the UI Testing button is clicked on the Form Result Page, the user is redirected to the home page")]
        public void TestCase_32_ValidateIfTheUserIsRedirectedToHomePageWhenUITestingIsClicked_ErrorPage()
        {
            TestCaseName = "TestCase_32";
            FormWorkflow.SubmitAName("Kitti");
            HomeWorkflow.ValidateIfTheHomePageIsDisplayedWhenTheUITestingButtonIsClicked();
        }


        [TestMethod]
        [Description("This test validates that When the user is on the home page, a h1 tag is displayed with the message Welcome to the Docler Holding QA Department")]
        public void TestCase_33_ValidateWebSiteWelcomeMessage_ErrorPage()
        {
            TestCaseName = "TestCase_33";
            HomeWorkflow.ValidateWelcomeText();
        }

        [TestMethod]
        [Description("This test validates that When the user is on the home page, a p tag is displayed with the message 'This site is dedicated to perform some exercises and demonstrate automated web testing.'")]
        public void TestCase_34_ValidateWebSiteDescription_ErrorPage()
        {
            TestCaseName = "TestCase_34";
            HomeWorkflow.ValidateSiteDescription();
        }

        [TestMethod]
        [Description("This test validates that When the Form page is displayed, a form with an input box and a button should be displayed.		")]
        public void TestCase_35_ValidateIfAFormWithAnInputBoxAndAButtonIsDisplayed_ErrorPage()
        {
            TestCaseName = "TestCase_35";
            FormWorkflow.ValidateIfFormIsVisible();
        }

        [TestMethod]
        [Description("This test validates that When the Form page is displayed, a form with an input box and a button should be displayed.")]
        public void TestCase_36_ValidateIfAMessageSayingHelloJohnIsDisplayed_ErrorPage()
        {
            TestCaseName = "TestCase_36";
            String name = "John";
            FormWorkflow.SubmitAName(name);
            FormResultWorkflow.ValidateIfMessageWasCorrectlyDisplayed(name);
        }

        [TestMethod]
        [Description("This test validates that When the the user sends John on the Name Form, then a message saying 'Hello Sophia!' is displayed.")]
        public void TestCase_37_ValidateIfAMessageSayingHelloSophiaIsDisplayed_ErrorPage()
        {
            TestCaseName = "TestCase_37";
            String name = "Sophia";
            FormWorkflow.SubmitAName(name);
            FormResultWorkflow.ValidateIfMessageWasCorrectlyDisplayed(name);
        }

        [TestMethod]
        [Description("This test validates that When the the user sends John on the Name Form, then a message saying 'Hello Charlie!' is displayed.")]
        public void TestCase_38_ValidateIfAMessageSayingHelloCharlieIsDisplayed_ErrorPage()
        {
            TestCaseName = "TestCase_38";
            String name = "Charlie";
            FormWorkflow.SubmitAName(name);
            FormResultWorkflow.ValidateIfMessageWasCorrectlyDisplayed(name);
        }

        [TestMethod]
        [Description("This test validates that When the the user sends John on the Name Form, then a message saying 'Hello Emily!' is displayed.")]
        public void TestCase_39_ValidateIfAMessageSayingHelloEmilyIsDisplayed_ErrorPage()
        {
            TestCaseName = "TestCase_39";
            String name = "Emily";
            FormWorkflow.SubmitAName(name);
            FormResultWorkflow.ValidateIfMessageWasCorrectlyDisplayed(name);
        }
    }
}
