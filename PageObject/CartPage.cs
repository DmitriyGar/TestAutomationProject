using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationProject.Extensions;

namespace TestAutomationProject.PageObject
{
    class CartPage: BaseObjects
    {
        public CartPage(IWebDriver driver) : base(driver) { }

        private By _priceOneProduct = By.XPath("//table[@id='cart_summary']/tbody/tr/td/span[@class='price']/span");
        private By _productName = By.XPath("//td[@class='cart_description']/p/a");
        private By _procceedButton = By.XPath("//p[@class='cart_navigation clearfix']/a[@title='Proceed to checkout']/span");
        private By _procceedAdressButton = By.XPath("//p[@class='cart_navigation clearfix']/button[@type='submit']/span");
        private By _checkBoxTermsConditions = By.Id("cgv");
        private By _payByCheckButton = By.XPath("//a[@class='cheque']");
        private By _confirmOrderButton = By.XPath("//p[@id='cart_navigation']//button[@type='submit']/span");
        private By _successPaymentMessage = By.XPath("//div[@id='center_column']/p[@class='alert alert-success']");
        private By _totalPrice = By.Id("total_price");
        private By _deliveryPrice = By.XPath("//div[@class='delivery_option_price']");
        private By _checkPaymentHeader = By.XPath("//h3[@class='page-subheading']");
        private By _successAfterPayment = By.XPath("//p[@class='alert alert-success']");

        public string PriceOneProduct => Driver.GetTextElement(_priceOneProduct);
        public string ProductName => Driver.GetTextElement(_productName);
        public string TotalPrice => Driver.GetTextElement(_totalPrice);
        public string SuccessPaymentMsg => Driver.GetTextElement(_successPaymentMessage);
        public string DeliveryPrice => Driver.GetTextElement(_deliveryPrice);
        public string CheckPaymentHeader => Driver.GetTextElement(_checkPaymentHeader);
        public string SuccessAfterPayment => Driver.GetTextElement(_successAfterPayment);

        public void ProccedToCheckOut()
        {
            Driver.GetElement(_procceedButton).Click();
        }
        public void ProccedAddressToCheckOut()
        {
            Driver.GetElement(_procceedAdressButton).Click();
        }

        public void AcceptTermsAndConditions()
        {
            Driver.GetElement(_checkBoxTermsConditions).Click();
        }
        public void ChoosePayByCheck()
        {
            Driver.GetElement(_payByCheckButton).Click();
        }
        public void ConfirmPaymentOfOrder()
        {
            Driver.GetElement(_confirmOrderButton).Click();
        }
    }
}
