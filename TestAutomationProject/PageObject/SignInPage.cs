using OpenQA.Selenium;
using System;
using TestAutomationProject.Extensions;

namespace TestAutomationProject.PageObject
{
    class SignInPage : BaseObjects
    {
        public SignInPage(IWebDriver driver):base(driver) { }
        private readonly By _errorMsgSignIn = By.XPath("//div[@class='alert alert-danger']//li");
        private readonly By _errorMsgSignUp = By.XPath("//div[@id='create_account_error']/ol/li");
        private readonly By _userName = By.XPath("//div[@class='header_user_info']/a/span");
        private readonly By _login = By.Id("email");
        private readonly By _password = By.Id("passwd");
        private readonly By _signinButton = By.Id("SubmitLogin");
        private readonly By _forgotPasswordLink = By.XPath("//p[@class='lost_password form-group']");
        private readonly By _loginButton = By.ClassName("login");
        private By _createAccountBtn = By.Id("SubmitCreate");
        private By _emailField = By.Id("email_create");

        public string UserName => Driver.GetTextElement(_userName);
        public string ErrorMsgLogin => Driver.GetTextElement(_errorMsgSignIn);
        public string ErrorMsgSignUp => Driver.GetTextElement(_errorMsgSignUp);
        
        public void SignIn(string mail,string password)
        {
            Driver.GetElement(_login).SendKeys(mail);
            Driver.GetElement(_password).SendKeys(password);
            Driver.GetElement(_signinButton).Click();
        }
        public void OpenForgotPasswordPage()
        {
            Driver.GetElement(_forgotPasswordLink).Click();
        }

        public void SignUp(string email)
        {
            Driver.FindElement(_loginButton).Click();
            Driver.FindElement(_emailField).SendKeys(email);
            Driver.FindElement(_createAccountBtn).Click();
        }
        private string MakeNameWithDate(string name)  //TODO
        {
            string full_name="";
            DateTime date = new DateTime();
            //full_name=name+date.ToShortDateString("yyyy-mm-dd");
            return full_name;
        }
    }
}
