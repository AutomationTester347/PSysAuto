using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace PSysAuto.Tests.Steps
{
    [Binding]
    public sealed class Hooks
    {
        private IWebDriver _driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(180);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.daraz.com.bd/");
            ScenarioContext.Current.Add("currentDriver", _driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver?.Quit();
        }
    }
}
