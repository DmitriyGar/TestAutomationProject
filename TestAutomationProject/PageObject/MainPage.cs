using OpenQA.Selenium;
using System.Linq;
using TestAutomationProject.Extensions;
using TestAutomationProject.Utilities;

namespace TestAutomationProject.PageObject
{
    class MainPage : BaseObjects
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        private readonly By _logOutButton = By.ClassName("logout");
        private readonly By _logInButton = By.XPath("//a[@class='login']");
        private readonly By _userName = By.XPath("//div[@class='header_user_info']/a/span");
        private readonly By _errorMsgSignIn = By.XPath("//div[@class='alert alert-danger']//li");
        private readonly By _errorMsgSignUp = By.XPath("//div[@id='create_account_error']/ol/li");
        private readonly By _contactUsButton = By.Id("contact-link");

        public IWebElement LogOutButton=>Driver.FindElements(_logOutButton).FirstOrDefault();
        public string UserName => Driver.GetTextElement(_userName);
        public string ErrorMsgLogin => Driver.GetTextElement(_errorMsgSignIn);
        public string ErrorMsgSignUp => Driver.GetTextElement(_errorMsgSignUp);
       

        public void NavigateToMainPage()
        {
            Driver.Navigate().GoToUrl(TestData.Url);
        }
        public void NavigateToSignInPage()
        {
            Driver.GetElement(_logInButton).Click();
            Driver.GetElement(_logInButton).Click();
        }
        public void LogOut()
        {
            if (LogOutButton != null)
            Driver.GetElement(_logOutButton).Click();
        }

    }
    }
