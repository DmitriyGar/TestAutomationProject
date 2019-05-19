using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationProject.Utilities;

namespace TestAutomationProject.Tests
{
    class UserCanSignUp : BaseTest
    {

            [SetUp]
            public void SetUp()
            {
                Pages.MainPage.NavigateToMainPage();
            }

            [Test]
            public void UserCanSignUpWithCorrectData()
            {
                Pages.MainPage.NavigateToSignInPage();
            Pages.SignInBlock.SignUp("");
               //ssert.That(Pages.SignInBlock.UserName, Is.EqualTo(TestData.PositiveUser.First_name + " " + TestData.PositiveUser.Last_name));
            }
           

            [TearDown]
            public void TierDown()
            {
                Pages.MainPage.LogOut();
            }
    }
}
