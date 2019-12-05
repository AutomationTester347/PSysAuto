using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSysAuto.Tests.Common;
using TechTalk.SpecFlow;

namespace PSysAuto.Tests.Steps
{
    [Binding]
    public sealed class LoginPageSteps
    {
        string _email;
        string _passWord;

        [Given(@"Login page is presented")]
        public void GivenLoginPageIsPresented()
        {
            PSysWeb.HomePage.ClickOnLoginLink();
        }

        [When(@"I enter '(.*)' and '(.*)'")]
        public void WhenIEnterAnd(string email, string password)
        {
            _email = email;
            _passWord = password;
            PSysWeb.LoginPage.Login(email, password);
        }

        [Then(@"I get the expected '(.*)'")]
        public void ThenIGetTheExpected(string errorMessage)
        {
            if (string.IsNullOrEmpty(_email) && string.IsNullOrEmpty(_passWord))
            {
                Assert.AreEqual(errorMessage,
                    PSysWeb.LoginPage.GetErrorMessageForEmptyEmailfield().Trim(),
                    "Error message is not correct for email field");

                Assert.AreEqual(errorMessage,
                    PSysWeb.LoginPage.GetErrorMessageForEmptyPasswordField().Trim(),
                    "Error message is not correct for password field");
            }

            else if (string.IsNullOrEmpty(_email) && !string.IsNullOrEmpty(_passWord))
            {
                Assert.AreEqual(errorMessage,
                    PSysWeb.LoginPage.GetErrorMessageForEmptyEmailfield().Trim(),
                    "Error message is not correct for email field");

            }

            else if (!string.IsNullOrEmpty(_email) && string.IsNullOrEmpty(_passWord))
            {
                Assert.AreEqual(errorMessage,
                    PSysWeb.LoginPage.GetErrorMessageForEmptyPasswordField().Trim(),
                    "Error message is not correct for password field");

            }

            else if (!string.IsNullOrEmpty(_email) && !string.IsNullOrEmpty(_passWord))
            {
                Assert.AreEqual(errorMessage,
                    PSysWeb.LoginPage.GetErrorMessageForInvalidInputInBothField(),
                    "Error message is not correct for invalid inputs");

            }
        }

    }
}
