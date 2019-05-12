using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationProject.Utilities;

namespace TestAutomationProject.PageObject
{
    class MainPage : BaseObjects
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        private By _logOutButton = By.ClassName("logout");
        private By _logInButton = By.XPath("//a[@class='login']");
        private By _userName = By.XPath("//div[@class='header_user_info']/a/span");
        private By _errorMsgSignIn = By.XPath("//div[@class='alert alert-danger']//li");
        private By _errorMsgSignUp = By.XPath("//div[@id='create_account_error']/ol/li");
        private By _contactUsButton = By.Id("contact-link");

        public IWebElement LogOutButton=>GetElement(_logOutButton);
        public string UserName => GetTextElement(_userName);
        public string ErrorMsgLogin => GetTextElement(_errorMsgSignIn);
        public string ErrorMsgSignUp => GetTextElement(_errorMsgSignUp);
       

        public void NavigateToMainPage()
        {
            Driver.Navigate().GoToUrl(TestData.Url);
        }
        public void NavigateToSignInPage()
        {
            Driver.FindElement(_logInButton).Click();
        }
        public void LogOut()
        {
            Driver.FindElement(_logOutButton).Click();
        }

    }
    }
