using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProject.PageObject
{
    class Pages
    {
        public MainPage MainPage { get; }
        public SignInPage SignInPage { get; }
        public CreateAccountPage CreateAccountPage { get; }
        public SearchProductsBlock SearchProductsBlock { get; }
        public ProductItemFrame ProductItemFrame { get; }
        public CartLayer CartLayer { get; }
        public Pages(IWebDriver driver)
        {
            if (MainPage == null)
                MainPage = new MainPage(driver);
            if (SignInPage == null)
                SignInPage = new SignInPage(driver);
            if (CreateAccountPage == null)
                CreateAccountPage = new CreateAccountPage(driver);
            if (SearchProductsBlock == null)
                SearchProductsBlock = new SearchProductsBlock(driver);
            if (ProductItemFrame == null)
                ProductItemFrame = new ProductItemFrame(driver);
            if (CartLayer == null)
                CartLayer = new CartLayer(driver);
        }
    }
}
