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
        private By _successMsgAfterAddingToCart = By.XPath("//div[@class='clearfix']//h2[i=contains(class,icon-ok)]");
        private By _proceedButton=By.XPath("//a[@title='Proceed to checkout']");

        public string GetTextAddedItemsToCart => Driver.GetTextElement(_successMsgAfterAddingToCart).Trim();

        public CartLayer(IWebDriver driver) : base(driver) { }

        public void ProceedToCheckout()
        {
            Driver.GetElement(_proceedButton).Click();
        }


    }
}
