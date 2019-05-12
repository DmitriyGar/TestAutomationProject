using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProject.PageObject
{
    class SignInBlock : BaseObjects
    {
        public SignInBlock(IWebDriver driver):base(driver) { }
        private By _errorMsgSignIn = By.XPath("//div[@class='alert alert-danger']//li");
        private By _errorMsgSignUp = By.XPath("//div[@id='create_account_error']/ol/li");
        private By _userName = By.XPath("//div[@class='header_user_info']/a/span");
        private By _login = By.Id("email");
        private By _password = By.Id("passwd");
        private By _signinButton = By.Id("SubmitLogin");

        public string UserName => GetTextElement(_userName);
        public string ErrorMsgLogin => GetTextElement(_errorMsgSignIn);
        public string ErrorMsgSignUp => GetTextElement(_errorMsgSignUp);
        
        public void SignIn(string mail,string password)
        {
            Driver.FindElement(_login).SendKeys(mail);
            Driver.FindElement(_password).SendKeys(password);
            Driver.FindElement(_signinButton).Click();
        }
    }
}
