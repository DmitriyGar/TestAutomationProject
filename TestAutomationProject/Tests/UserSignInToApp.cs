using Allure.Commons;
using NUnit.Allure.Attributes;
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

        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("UserCanSignIn")]
        [Test]
        public void UserCanSignIn()
        {
            Pages.MainPage.NavigateToSignInPage();
            Pages.SignInPage.SignIn(TestData.PositiveUser.Mail,TestData.PositiveUser.Password);
            Assert.That(Pages.SignInPage.UserName,Is.EqualTo(TestData.PositiveUser.First_name+" "+TestData.PositiveUser.Last_name));
        }

        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("UserCanNotSignInWithIncorrectPassword")]
        [Test]
        public void UserCanNotSignInWithIncorrectPassword()
        {
            Pages.MainPage.NavigateToSignInPage();
            Pages.SignInPage.SignIn(TestData.PositiveUser.Mail, TestData.NegativeUser.Password);
            Assert.That(Pages.MainPage.ErrorMsgLogin,Is.EqualTo("Authentication failed."));
        }
        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("UserCanNotSignInWithIncorrectLogin")]
        [Test]
        public void UserCanNotSignInWithIncorrectLogin()
        {
            Pages.MainPage.NavigateToSignInPage();
            Pages.SignInPage.SignIn(TestData.NegativeUser.Mail, TestData.NegativeUser.Password);
            Assert.That(Pages.MainPage.ErrorMsgLogin, Is.EqualTo("Authentication failed."));
        }

        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("UserCanNotSignInWithoutCreds")]
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
