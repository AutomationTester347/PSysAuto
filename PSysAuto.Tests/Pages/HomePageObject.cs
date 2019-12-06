using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace PSysAuto.Tests.Pages
{
   public class HomePageObject : _BasePage
    {
        IWebElement LoginLink => driver.FindElement(By.CssSelector("#anonLogin"));
        IWebElement NavigationMenu => driver.FindElement(By.CssSelector(".lzd-site-nav-menu-dropdown"));
        IWebElement AddToCartButton => driver.FindElement(By.CssSelector(".ant-btn-lg"));
        IWebElement NumberOfItemsInCart => driver.FindElement(By.CssSelector("#topActionCartNumber"));
        IWebElement ModalCloseButton => driver.FindElement(By.CssSelector(".ant-modal-close"));
        IWebElement ProductItem => driver.FindElement(By.CssSelector("div[data-qa-locator='product-item']"));
        public LoginPageObject ClickOnLoginLink()
        {
            LoginLink.Click();
            return new LoginPageObject();
        }

        public IWebElement MenuItem(string itemName)
        {
            return NavigationMenu.FindElement(By.XPath($".//span[text()= '{itemName}']"));
        }

        public HomePageObject MoveToMenuItem(string itemName)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(MenuItem(itemName)).Build().Perform();
            return new HomePageObject();
        }

        public void AddItemToCart()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(ProductItem)
                .MoveToElement(AddToCartButton)
                .Click().Build().Perform();
            
            ModalCloseButton.Click();

        }

        public int GetNumberOfItemsInCart()
        {
            return string.IsNullOrEmpty(NumberOfItemsInCart.Text) ?
                0 : int.Parse(NumberOfItemsInCart.Text);
        }
    }
}
