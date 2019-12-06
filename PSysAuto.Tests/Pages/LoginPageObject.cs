using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace PSysAuto.Tests.Pages
{
    public class LoginPageObject : _BasePage
    {
        IWebElement EmailField => driver.FindElement(By.CssSelector(".mod-input-loginName input"));
        IWebElement PasswordField => driver.FindElement(By.CssSelector(".mod-input-password input"));
        IWebElement LoginButton => driver.FindElement(By.XPath("//button[text()='LOGIN']"));
        IWebElement ErrorModalForInvalidInput => driver.FindElement(By.CssSelector(".next-feedback-content"));

        public void FillupEmailField(string email)
        {
            EmailField.SendKeys(email);
        }

        public void FillupPasswordField(string email)
        {
            PasswordField.SendKeys(email);
        }

        public void Login(string email, string password)
        {
            EmailField.SendKeys(email);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }

        public string GetErrorMessageForEmptyEmailfield()
        {
            return EmailField.FindElement(By.XPath("../span")).Text;
        }

        public string GetErrorMessageForEmptyPasswordField()
        {
            return PasswordField.FindElement(By.XPath("../span")).Text;
        }

        public string GetErrorMessageForInvalidInputInBothField()
        {
            return ErrorModalForInvalidInput.Text;
        }
    }
}
