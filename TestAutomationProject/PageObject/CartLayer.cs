using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationProject.Extensions;

namespace TestAutomationProject.PageObject
{
    class CartLayer:BaseObjects
    {
        private By _textItems = By.XPath("//span[@class='ajax_cart_product_txt ']");
        private By _proceedAddingToCart=By.XPath("//a[@class='btn btn-default button button-medium']");

        public string GetTextAddedItemsToCart => Driver.GetTextElement(_textItems);

        public CartLayer(IWebDriver driver) : base(driver) { }

        public void ProceedToCheckout()
        {
            Driver.GetElement(_proceedAddingToCart).Click();
        }


    }
}
