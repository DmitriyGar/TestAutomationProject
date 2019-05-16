using OpenQA.Selenium;
using TestAutomationProject.Extensions;

namespace TestAutomationProject.PageObject
{
    class SignInBlock : BaseObjects
    {
        public SignInBlock(IWebDriver driver):base(driver) { }
        private readonly By _errorMsgSignIn = By.XPath("//div[@class='alert alert-danger']//li");
        private readonly By _errorMsgSignUp = By.XPath("//div[@id='create_account_error']/ol/li");
        private readonly By _userName = By.XPath("//div[@class='header_user_info']/a/span");
        private readonly By _login = By.Id("email");
        private readonly By _password = By.Id("passwd");
        private readonly By _signinButton = By.Id("SubmitLogin");
        private readonly By _forgotPasswordLink = By.XPath("//p[@class='lost_password form-group']");

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
    }
}
