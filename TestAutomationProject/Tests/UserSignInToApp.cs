using NUnit.Framework;
using TestAutomationProject.Utilities;

namespace TestAutomationProject.Tests
{
    [TestFixture]
    class UserSignInToApp : BaseTest
    {

        [SetUp]
        public void SetUp()
        {
            Pages.MainPage.NavigateToMainPage();
        }
        [Test]
        public void UserCanSignIn()
        {
            Pages.MainPage.NavigateToSignInPage();
            Pages.SignInPage.SignIn(TestData.PositiveUser.Mail,TestData.PositiveUser.Password);
            Assert.That(Pages.SignInPage.UserName,Is.EqualTo(TestData.PositiveUser.First_name+" "+TestData.PositiveUser.Last_name));
        }
        [Test]
        public void UserCanNotSignInWithIncorrectPassword()
        {
            Pages.MainPage.NavigateToSignInPage();
            Pages.SignInPage.SignIn(TestData.PositiveUser.Mail, TestData.NegativeUser.Password);
            Assert.That(Pages.MainPage.ErrorMsgLogin,Is.EqualTo("Authentication failed."));
        }
        [Test]
        public void UserCanNotSignInWithIncorrectLogin()
        {
            Pages.MainPage.NavigateToSignInPage();
            Pages.SignInPage.SignIn(TestData.NegativeUser.Mail, TestData.NegativeUser.Password);
            Assert.That(Pages.MainPage.ErrorMsgLogin, Is.EqualTo("Authentication failed."));
        }

        [Test]
        public void UserCanNotSignInWithoutCreds()
        {
            Pages.MainPage.NavigateToSignInPage();
            Pages.SignInPage.SignIn("", "");
            Assert.That(Pages.MainPage.ErrorMsgLogin, Is.EqualTo("An email address required."));
        }

        [TearDown]
        public void TierDown()
        {
           Pages.MainPage.LogOut();
        }
    }
}
