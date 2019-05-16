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
            mainPage.NavigateToMainPage();
        }
        [Test]
        public void UserCanSignIn()
        {
            mainPage.NavigateToSignInPage();
            signInBlock.SignIn(TestData.PositiveUser.Mail,TestData.PositiveUser.Password);
            Assert.That(signInBlock.UserName,Is.EqualTo(TestData.PositiveUser.First_name+" "+TestData.PositiveUser.Last_name));
        }
        [Test]
        public void UserCanNotSignInWithIncorrectPassword()
        {
            mainPage.NavigateToSignInPage();
            signInBlock.SignIn(TestData.PositiveUser.Mail, TestData.NegativeUser.Password);
            Assert.That(mainPage.ErrorMsgLogin,Is.EqualTo("Authentication failed."));
        }
        [Test]
        public void UserCanNotSignInWithIncorrectLogin()
        {
            mainPage.NavigateToSignInPage();
            signInBlock.SignIn(TestData.NegativeUser.Mail, TestData.NegativeUser.Password);
            Assert.That(mainPage.ErrorMsgLogin, Is.EqualTo("Authentication failed."));
        }

        [Test]
        public void UserCanNotSignInWithoutCreds()
        {
            mainPage.NavigateToSignInPage();
            signInBlock.SignIn("", "");
            Assert.That(mainPage.ErrorMsgLogin, Is.EqualTo("An email address required."));
        }

        [TearDown]
        public void TierDown()
        {
           mainPage.LogOut();
        }
    }
}
