using OpenQA.Selenium;
using PSysAuto.Tests.Common;
using TechTalk.SpecFlow;

namespace PSysAuto.Tests.Pages
{
    public abstract class _BasePage
    {
        protected static IWebDriver driver => ScenarioContext.Current.Get<IWebDriver>("currentDriver");

    }
}
