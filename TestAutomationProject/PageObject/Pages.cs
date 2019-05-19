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
        public SignInPage SignInBlock { get; }
        public CreateAccountPage CreateAccountPage { get; }
        public Pages(IWebDriver driver)
        {
            if (MainPage == null)
                MainPage = new MainPage(driver);
            if (SignInBlock == null)
                SignInBlock = new SignInPage(driver);
            if (CreateAccountPage == null)
                CreateAccountPage = new CreateAccountPage(driver);
        }
    }
}
