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
        string _productItem = "t-shirt";
        [SetUp]
        public void PreConditions()
        {
            Pages.MainPage.NavigateToMainPage();
            Pages.MainPage.NavigateToSignInPage();
            Pages.SignInPage.SignIn(TestData.PositiveUser.Mail, TestData.PositiveUser.Password);
        }
    
        [Test]
        public void LoggedInUserCanOrderProduct()
        {
            //Pages.SearchProductsBlock.SearchProducts(_productItem);
            Pages.MainPage.NavigateToMainPage();
            Pages.MainPage.OpenTshirtTopic();
            Pages.ProductItemFrame.OpenProductItem();
            Pages.ProductItemFrame.AddProductToCart();
            Thread.Sleep(3000);
         /*   Assert.That(Pages.CartLayer.GetTextAddedItemsToCart,Is.EqualTo(@"

                        There is 1 item in your cart.

                    "));*/
        }
    }
}
