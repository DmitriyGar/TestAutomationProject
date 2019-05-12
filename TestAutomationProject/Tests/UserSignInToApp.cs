using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            Thread.Sleep(2000);
            Assert.That(signInBlock.UserName,Is.EqualTo(TestData.PositiveUser.First_name+" "+TestData.PositiveUser.Last_name));
        }
        [Test]
        public void UserCanNotSignInWithIncorrectPassword()
        {
            mainPage.NavigateToSignInPage();
            signInBlock.SignIn(TestData.PositiveUser.Mail, TestData.NegativeUser.Password);
            Thread.Sleep(2000);
            Assert.That(mainPage.ErrorMsgLogin,Is.EqualTo("Authentication failed."));
        }
        [Test]
        public void UserCanNotSignInWithIncorrectLogin()
        {
            mainPage.NavigateToSignInPage();
            signInBlock.SignIn(TestData.NegativeUser.Mail, TestData.NegativeUser.Password);
            Thread.Sleep(2000);
            Assert.That(mainPage.ErrorMsgLogin, Is.EqualTo("Authentication failed."));
        }
        [TearDown]
        public void TierDown()
        {
            if (mainPage.LogOutButton != null) 
            { mainPage.LogOut(); }
        }
    }
}
