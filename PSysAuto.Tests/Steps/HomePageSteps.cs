using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSysAuto.Tests.Common;
using TechTalk.SpecFlow;

namespace PSysAuto.Tests.Steps
{
    [Binding]
    public class HomePageSteps
    {
        [Given(@"Mobiles submenu is presented")]

        [Given(@"'(.*)' submenu under '(.*)' is presented")]
        public void GivenSubmenuUnderIsPresented(string subMenu, string mainMenu)
        {
            PSysWeb.HomePage.MoveToMenuItem(mainMenu)
                .MoveToMenuItem(subMenu);
        }

        [When(@"I select '(.*)' from menu")]
        public void WhenISelectFromMenu(string itemName)
        {
            PSysWeb.HomePage.MenuItem(itemName).Click();
        }

        [Then(@"I can add (.*) item to cart")]
        public void ThenICanAddItemToCart(int numberOfItems)
        {
            for(var i =0; i <numberOfItems; i++)
            {
                PSysWeb.HomePage.AddItemToCart();
            }
            var numberOfItemsInCart = PSysWeb.HomePage.GetNumberOfItemsInCart();
            Assert.AreEqual(numberOfItems, numberOfItemsInCart, "Some items missing from cart");
        }


    }
}
