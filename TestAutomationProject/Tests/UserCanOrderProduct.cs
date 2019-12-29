using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestAutomationProject.PageObject;
using TestAutomationProject.Utilities;

namespace TestAutomationProject.Tests
{
    [TestFixture]
    class UserCanOrderProduct : BaseTest
    {
        private string _productItem = "t-shirt";
        private string _successAfterAddProductToCart = "Product successfully added to your shopping cart";
        private string _priceOneProduct = @"$16.51";
        private string _totalPrice = @"$35.02";
        private string _deliveryPrice = @"$2.00";
        private string _nameOfAddedProduct = "Faded Short Sleeve T-shirts";
        private string _checkPaymentHeader = "CHECK PAYMENT";
        private string _succesAfterPaymentMsg = "Your order on My Store is complete.";

        [SetUp]
        public void PreConditions()
        {
            Pages.MainPage.NavigateToMainPage();
            Pages.MainPage.NavigateToSignInPage();
            Pages.SignInPage.SignIn(TestData.PositiveUser.Mail, TestData.PositiveUser.Password);
        }

        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("OrderProduct")]
        [Test]
        public void LoggedInUserCanOrderProduct()
        {
            Pages.SearchProductsBlock.SearchProducts(_productItem);
            Pages.ProductItemFrame.OpenProductItem();
            Pages.ProductItemFrame.AddProductToCart();
            Assert.That(Pages.CartLayer.GetTextAddedItemsToCart,Is.EqualTo(_successAfterAddProductToCart),"Success adding to cart");
            Pages.CartLayer.ProceedToCheckout();
            Assert.That(Pages.CartPage.PriceOneProduct, Is.EqualTo(_priceOneProduct),"Checking price per one product");
            Assert.That(Pages.CartPage.ProductName, Is.EqualTo(_nameOfAddedProduct),"Checking name of product");
            Assert.That(Pages.CartPage.TotalPrice, Is.EqualTo(_totalPrice), "Checking total price");
            Pages.CartPage.ProccedToCheckOut();
            Pages.CartPage.ProccedAddressToCheckOut();
            Assert.That(Pages.CartPage.DeliveryPrice,Is.EqualTo(_deliveryPrice));
            Pages.CartPage.AcceptTermsAndConditions();
            Pages.CartPage.ProccedAddressToCheckOut();
            Pages.CartPage.ChoosePayByCheck();
            Assert.That(Pages.CartPage.CheckPaymentHeader, Is.EqualTo(_checkPaymentHeader));
            Pages.CartPage.ConfirmPaymentOfOrder();
            Assert.That(Pages.CartPage.SuccessAfterPayment, Is.EqualTo(_succesAfterPaymentMsg));
            //Thread.Sleep(5000);
        }
    }
}
