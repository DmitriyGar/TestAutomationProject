using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationProject.Extensions;

namespace TestAutomationProject.PageObject
{
    class ProductItemFrame : BaseObjects
    {
        private By _hoverOnItem = By.XPath("//div[@class='left-block']//a[@title='Faded Short Sleeve T-shirts']");
        private By _items = By.XPath("//div[@class='ac_results selassist-highlight']//ul");
        private By _addToCart = By.Id("add_to_cart");
        //private By _addToWhishList = By.XPath("//div[@class='box-cart-bottom']");
        private By _iframe = By.XPath("*//iframe[contains(@id,'fancybox-frame')]");
        private By _quickViewButton = By.XPath("//a[@class='quick-view']");
        private By _plusQtyProduct = By.XPath("//a[@class='btn btn-default button-plus product_quantity_up']");

        public ProductItemFrame(IWebDriver driver) : base(driver) { }

        public void OpenProductItem()
        {
            Actions hoverOnItem = new Actions(Driver);
            hoverOnItem.MoveToElement(Driver.GetElement(_hoverOnItem)).Perform();
            Driver.GetElement(_hoverOnItem).FindElement(_quickViewButton).Click();
        }
        public void AddProductToCart()
        {
            WaitWhileSwitchToFrame();
            Driver.GetElement(_plusQtyProduct).Click();
            Driver.GetElement(_addToCart).Click();
            //WaitWhileSwitchToDefaultFrame();
        }
        private void WaitWhileSwitchToFrame()
        {
            IWebElement frame = Driver.GetElement(_iframe);
            Driver.SwitchTo().Frame(frame);
        }

        private void WaitWhileSwitchToDefaultFrame()
        {
            Driver.SwitchTo().DefaultContent();
        }
    }
}
